using RichTextBoxWithLineNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;
using System.Text.Json;
using UndoRedo;
using KobaEditor.Properties;
using System.Resources;
using GeminiChat;
using Markdig;

namespace KobaEditor
{
    public partial class Form1 : Form
    {
        #region Fields

        string selectedPath = "";
        string rootPath = "";

        List<string> paths = new List<string>() { "" };

        List<FindStringLoc> findLocations = new List<FindStringLoc>();

        ChatBot chatBot;

        Settings settings = new Settings();

        #endregion

        #region Declarations

        struct FindStringLoc
        {
            public FindStringLoc(int loc, int len)
            {
                location = loc;
                length = len;
            }

            public int location;
            public int length;
        }

        #endregion

        #region Initialize

        public Form1()
        {
            InitializeComponent();
            InitializeAsync();

            string settingsFile = File.ReadAllText(@"..\..\settings.json");
            settings = JsonSerializer.Deserialize<Settings>(settingsFile);

            chatBot = new ChatBot();
        }

        ~Form1()
        {

        }

        async void InitializeAsync()
        {
            try
            {
                await WebView.EnsureCoreWebView2Async(null);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("WebView2ランタイムがインストールされていない可能性があります。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileTree.AfterSelect += FileTree_AfterSelect;
        }

        #endregion

        #region ButtonsOnFileTree

        private void NewFile_Click(object sender, EventArgs e)
        {
            if (selectedPath != string.Empty)
                using (FileStream file = File.Create(selectedPath + "\\" + newFileOrFolderName.Text)) ;

            UpdateTree(rootPath);
        }

        private void NewFolder_Click(object sender, EventArgs e)
        {
            if (selectedPath != string.Empty)
                Directory.CreateDirectory(selectedPath + "\\" + newFileOrFolderName.Text);

            UpdateTree(rootPath);
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (FileTree.SelectedNode == null) return;

            string filePath = GetFullPath(FileTree.SelectedNode);
            string newFilePath = String.Join("\\", filePath.Split('\\').Take(filePath.Split('\\').Length - 1))
                + "\\" + newFileOrFolderName.Text;

            Console.WriteLine($"{filePath} rename: {newFilePath}");
            RenameFileOrFolder(filePath, newFilePath);

            UpdateTree(rootPath);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (FileTree.SelectedNode == null) return;

            string filePath = GetFullPath(FileTree.SelectedNode);
            DeleteFileOrFolder(filePath);

            UpdateTree(rootPath);
        }

        private void OpenPowershell_Click(object sender, EventArgs e)
        {
            OpenPowershellWithPath(selectedPath);
        }

        #endregion

        #region Menubar

        #region File
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                filePath = openFileDialog.FileName;
            else return;

            string fileName = filePath.Split('\\').Last();

            CreateNewTab(fileName, filePath);
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            DialogResult result = OpenFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
                folderPath = OpenFolderDialog.SelectedPath;
            else return;

            rootPath = folderPath;

            UpdateTree(folderPath);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"paths.length:{paths.Count} SelectedIndex:{Editor.SelectedIndex}");
            string filePath = paths[Editor.SelectedIndex];

            if(filePath == "") return;

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                RichTextBoxLN richTextBoxLN = (RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0];
                sw.WriteLine(richTextBoxLN.richTextBox.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = Editor.SelectedTab.Text;
            saveFileDialog.InitialDirectory = paths[Editor.SelectedIndex];
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.Title = "Save As";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    RichTextBoxLN richTextBoxLN = (RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0];
                    sw.WriteLine(richTextBoxLN.richTextBox.Text);
                }
            }
        }

        private void newTextMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTab("MEMO", string.Empty);
        }

        #endregion

        #region Window

        private void openPowershellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPowershellWithPath(selectedPath);
        }

        private void eraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EraseTab();
        }

        private void moveTabToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveTabToTheLeft();
        }

        private void moveTabToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveTabToTheRight();
        }

        #endregion

        #region Edit

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0]).richTextBox.Undo();
            } catch { }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0]).richTextBox.Redo();
            } catch { }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0]).richTextBox.Copy();
            } catch { }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0]).richTextBox.Cut();
            } catch { }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0]).richTextBox.Paste();
            } catch { }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindOrReplacePanel.Visible = true;
            ReplaceTextBox.Enabled = false;
            ReplaceButton.Enabled = false;
            ReplaceAllButton.Enabled = false;

            findLocations.Clear();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindOrReplacePanel.Visible = true;
            ReplaceTextBox.Enabled = true;
            ReplaceButton.Enabled = true;
            ReplaceAllButton.Enabled = true;

            findLocations.Clear();
        }

        #endregion

        #region View

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #endregion

        #region TabManageControls

        private void TabErase_Click(object sender, EventArgs e)
        {
            EraseTab();
        }

        private void MoveTabToLeft_Click(object sender, EventArgs e)
        {
            MoveTabToTheLeft();
        }

        private void MoveTabToRight_Click(object sender, EventArgs e)
        {
            MoveTabToTheRight();
        }

        #endregion

        #region FindAndReplaceControls

        private void EraseButton_Click(object sender, EventArgs e)
        {
            FindOrReplacePanel.Visible = false;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (findLocations.Count == 0)
                AddFindLocations();
            if (findLocations.Count == 0) return;

            RichTextBoxLN textBox = (RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0];
            textBox.richTextBox.Select();
            textBox.richTextBox.SelectionStart = findLocations[0].location;
            textBox.richTextBox.SelectionLength = findLocations[0].length;
            findLocations.RemoveAt(0);
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (findLocations.Count == 0)
                AddFindLocations();
            if (findLocations.Count == 0) return;

            string replaceText = ReplaceTextBox.Text;

            RichTextBoxLN textBox = (RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0];
            textBox.richTextBox.Select();
            textBox.richTextBox.SelectionStart = findLocations[0].location;
            textBox.richTextBox.SelectionLength = findLocations[0].length;
            textBox.richTextBox.SelectedText = replaceText;
            findLocations.RemoveAt(0);
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            if (findLocations.Count == 0)
                AddFindLocations();

            string replaceText = ReplaceTextBox.Text;

            RichTextBoxLN textBox = (RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0];
            foreach(FindStringLoc findStringLoc in findLocations)
            {
                textBox.richTextBox.Select();
                textBox.richTextBox.SelectionStart = findStringLoc.location;
                textBox.richTextBox.SelectionLength = findStringLoc.length;
                textBox.richTextBox.SelectedText = replaceText;
            }
            findLocations.Clear();
        }

        #endregion

        #region OtherEvents

        private void FileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string fullPath = GetFullPath(e.Node);

            selectedPath = fullPath;

            if (e.Node.Nodes.Count == 0)
            {
                try
                {
                    CreateNewTab(e.Node.Text, fullPath);
                }
                catch { }

                return;
            }
        }

        //検索機能
        private void WebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            WebView.CoreWebView2.Navigate(settings.StartURL);
            WebView.ZoomFactor = 0.5;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WebView.CoreWebView2.Navigate($"{settings.SearchURL}{SearchTextBox.Text}");
            }
        }

        //AIchat機能
        private async void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string text = MessageBox.Text;
                string res = await chatBot.SendMessageAsync(text);
                string messages = $"<p style=\"text-align: right;\"><font color=\"gray\">{text}</font></p>\n\n{res}\n\n";
                string messagesOfHTML = Markdown.ToHtml(messages);

                ChatBoxBrow.DocumentText += messagesOfHTML;
                MessageBox.Text = "";
            }
        }

        private void ClearChat_Click(object sender, EventArgs e)
        {
            ChatBoxBrow.DocumentText = "";
            chatBot.Clear();
        }

        #endregion

        #region functions

        private void UpdateTree(string folderPath)
        {
            TreeNode tn = new TreeNode(folderPath);

            FileTree.Nodes.Clear();
            FileTree.Nodes.Add(tn);
            PopulateTreeNode(tn, folderPath);
        }

        private void PopulateTreeNode(TreeNode node, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode childNode = new TreeNode(Path.GetFileName(dir));
                    node.Nodes.Add(childNode);
                    PopulateTreeNode(childNode, dir);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode childNode = new TreeNode(Path.GetFileName(file), 1, 1);
                    node.Nodes.Add(childNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // アクセス権限がない場合は無視
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

        private void CreateNewTab(string name, string path)
        {
            paths.Add(path);

            TabPage newPage = new TabPage(name);

            string content = (path == string.Empty) ? "" : File.ReadAllText(path);
            RichTextBoxLN textBox = new RichTextBoxLN();
            textBox.richTextBox.Text = content;
            textBox.Location = new Point(0, 0);
            textBox.Size = new Size(Editor.Width, Editor.Height);
            textBox.richTextBox.Multiline = true;
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Name = "textBox";

            newPage.Controls.Add(textBox);
            Editor.TabPages.Add(newPage);
        }

        private string GetFullPath(TreeNode node)
        {
            if (node == null) return string.Empty;

            string path = node.Text;
            TreeNode parent = node.Parent;

            while (parent != null)
            {
                path = Path.Combine(parent.Text, path);
                parent = parent.Parent;
            }

            return path;
        }

        private static void RenameFileOrFolder(string sourceFilePath, string outputFilePath)
        {
            var fileInfo = new FileInfo(sourceFilePath);

            try
            {
                if (fileInfo.Attributes.HasFlag(FileAttributes.Directory))
                {
                    RenameDirectory(sourceFilePath, outputFilePath);
                }
                else
                {
                    fileInfo.MoveTo(outputFilePath);
                }
            }
            catch (System.IO.IOException message)
            {
                System.Windows.Forms.MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void RenameDirectory(string sourceFilePath, string outputFilePath)
        {
            if ((String.Compare(sourceFilePath, outputFilePath, true) == 0))
            {
                var tempPath = GetSafeTempName(outputFilePath);

                Directory.Move(sourceFilePath, tempPath);
                Directory.Move(tempPath, outputFilePath);
            }
            else
            {
                Directory.Move(sourceFilePath, outputFilePath);
            }
        }

        private static string GetSafeTempName(string outputFilePath)
        {
            outputFilePath += "_";
            while (File.Exists(outputFilePath))
            {
                outputFilePath += "_";
            }
            return outputFilePath;
        }

        private void DeleteFileOrFolder(string path)
        {
            var fileInfo = new FileInfo(path);

            if(fileInfo.Attributes.HasFlag(FileAttributes.Directory))
            {
                Directory.Delete(path, true);
            }
            else
            {
                File.Delete(path);
            }
        }

        private void OpenPowershellWithPath(string path)
        {
            string command = $"cd '{path}'";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -NoExit -Command \"{command}\"",
                UseShellExecute = true,
                CreateNoWindow = false
            };

            try
            {
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddFindLocations()
        {
            string code = ((RichTextBoxLN)Editor.TabPages[Editor.SelectedIndex].Controls.Find("textBox", false)[0]).richTextBox.Text;
            string findStr = FindTextBox.Text;

            findLocations.AddRange(FindStringIndices(code, findStr).ToList());
        }

        private FindStringLoc[] FindStringIndices(string target, string find)
        {
            List<FindStringLoc> index_list = new List<FindStringLoc>();

            if (string.IsNullOrEmpty(target) == true) return index_list.ToArray();

            if (string.IsNullOrEmpty(find) == true) return index_list.ToArray();

            int index = 0;
            while ((index = target.IndexOf(find, index)) >= 0)
            {
                index_list.Add(new FindStringLoc(index, find.Length));

                index++;
            }

            return index_list.ToArray();
        }

        private void EraseTab()
        {
            if (Editor.TabCount == 0) return;

            Editor.TabPages.RemoveAt(Editor.SelectedIndex);
        }
        private void MoveTabToTheLeft()
        {
            if (Editor.TabCount == 0 || Editor.SelectedIndex == 0) return;

            TabPage tmp = Editor.TabPages[Editor.SelectedIndex];
            Editor.TabPages[Editor.SelectedIndex] = Editor.TabPages[Editor.SelectedIndex - 1];
            Editor.TabPages[Editor.SelectedIndex - 1] = tmp;
        }

        private void MoveTabToTheRight()
        {
            if (Editor.TabCount == 0 || Editor.SelectedIndex == Editor.TabCount - 1) return;

            TabPage tmp = Editor.TabPages[Editor.SelectedIndex];
            Editor.TabPages[Editor.SelectedIndex] = Editor.TabPages[Editor.SelectedIndex + 1];
            Editor.TabPages[Editor.SelectedIndex + 1] = tmp;
        }

        #endregion
    }
}
