namespace KobaEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Editor = new System.Windows.Forms.TabControl();
            this.Start = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.FindOrReplacePanel = new System.Windows.Forms.Panel();
            this.ReplaceAllButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.EraseButton = new System.Windows.Forms.Button();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FileTree = new System.Windows.Forms.TreeView();
            this.NewFile = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.NewFolder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.newTextMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPowershellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTabToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTabToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.newFileOrFolderName = new System.Windows.Forms.TextBox();
            this.Rename = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.OpenPowershell = new System.Windows.Forms.Button();
            this.WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.AiTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MoveTabToRight = new System.Windows.Forms.Button();
            this.MoveTabToLeft = new System.Windows.Forms.Button();
            this.TabErase = new System.Windows.Forms.Button();
            this.Editor.SuspendLayout();
            this.Start.SuspendLayout();
            this.FindOrReplacePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.Controls.Add(this.Start);
            this.Editor.Location = new System.Drawing.Point(13, 16);
            this.Editor.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Editor.Name = "Editor";
            this.Editor.SelectedIndex = 0;
            this.Editor.Size = new System.Drawing.Size(1119, 1197);
            this.Editor.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Controls.Add(this.label1);
            this.Start.Location = new System.Drawing.Point(8, 39);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(3);
            this.Start.Size = new System.Drawing.Size(1103, 1150);
            this.Start.TabIndex = 0;
            this.Start.Text = "StartPage";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 394);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koba Editor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindOrReplacePanel
            // 
            this.FindOrReplacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FindOrReplacePanel.Controls.Add(this.ReplaceAllButton);
            this.FindOrReplacePanel.Controls.Add(this.ReplaceButton);
            this.FindOrReplacePanel.Controls.Add(this.FindButton);
            this.FindOrReplacePanel.Controls.Add(this.EraseButton);
            this.FindOrReplacePanel.Controls.Add(this.ReplaceTextBox);
            this.FindOrReplacePanel.Controls.Add(this.FindTextBox);
            this.FindOrReplacePanel.Location = new System.Drawing.Point(1252, 42);
            this.FindOrReplacePanel.Name = "FindOrReplacePanel";
            this.FindOrReplacePanel.Size = new System.Drawing.Size(222, 113);
            this.FindOrReplacePanel.TabIndex = 1;
            this.FindOrReplacePanel.Visible = false;
            // 
            // ReplaceAllButton
            // 
            this.ReplaceAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReplaceAllButton.BackgroundImage")));
            this.ReplaceAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReplaceAllButton.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReplaceAllButton.Location = new System.Drawing.Point(146, 78);
            this.ReplaceAllButton.Name = "ReplaceAllButton";
            this.ReplaceAllButton.Size = new System.Drawing.Size(31, 31);
            this.ReplaceAllButton.TabIndex = 15;
            this.ReplaceAllButton.UseCompatibleTextRendering = true;
            this.ReplaceAllButton.UseVisualStyleBackColor = true;
            this.ReplaceAllButton.Click += new System.EventHandler(this.ReplaceAllButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReplaceButton.BackgroundImage")));
            this.ReplaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReplaceButton.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReplaceButton.Location = new System.Drawing.Point(183, 78);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(31, 31);
            this.ReplaceButton.TabIndex = 14;
            this.ReplaceButton.UseCompatibleTextRendering = true;
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindButton.BackgroundImage")));
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindButton.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FindButton.Location = new System.Drawing.Point(183, 41);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(31, 31);
            this.FindButton.TabIndex = 13;
            this.FindButton.UseCompatibleTextRendering = true;
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // EraseButton
            // 
            this.EraseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EraseButton.BackgroundImage")));
            this.EraseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EraseButton.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EraseButton.Location = new System.Drawing.Point(183, 2);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(31, 31);
            this.EraseButton.TabIndex = 12;
            this.EraseButton.UseCompatibleTextRendering = true;
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Location = new System.Drawing.Point(4, 41);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(173, 31);
            this.ReplaceTextBox.TabIndex = 1;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(4, 4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(173, 31);
            this.FindTextBox.TabIndex = 0;
            // 
            // FileTree
            // 
            this.FileTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FileTree.BackColor = System.Drawing.SystemColors.Control;
            this.FileTree.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTree.ForeColor = System.Drawing.Color.Black;
            this.FileTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FileTree.Location = new System.Drawing.Point(12, 104);
            this.FileTree.Name = "FileTree";
            this.FileTree.Size = new System.Drawing.Size(453, 1148);
            this.FileTree.TabIndex = 1;
            // 
            // NewFile
            // 
            this.NewFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewFile.BackgroundImage")));
            this.NewFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewFile.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewFile.Location = new System.Drawing.Point(293, 165);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(50, 50);
            this.NewFile.TabIndex = 2;
            this.NewFile.UseCompatibleTextRendering = true;
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // NewFolder
            // 
            this.NewFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewFolder.BackgroundImage")));
            this.NewFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewFolder.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewFolder.Location = new System.Drawing.Point(349, 165);
            this.NewFolder.Name = "NewFolder";
            this.NewFolder.Size = new System.Drawing.Size(50, 50);
            this.NewFolder.TabIndex = 3;
            this.NewFolder.UseCompatibleTextRendering = true;
            this.NewFolder.UseVisualStyleBackColor = true;
            this.NewFolder.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2305, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.newTextMemoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(406, 44);
            this.openFolderToolStripMenuItem.Text = "Open Folder...";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(406, 44);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(403, 6);
            // 
            // newTextMemoToolStripMenuItem
            // 
            this.newTextMemoToolStripMenuItem.Name = "newTextMemoToolStripMenuItem";
            this.newTextMemoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTextMemoToolStripMenuItem.Size = new System.Drawing.Size(406, 44);
            this.newTextMemoToolStripMenuItem.Text = "New Text Memo";
            this.newTextMemoToolStripMenuItem.Click += new System.EventHandler(this.newTextMemoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(403, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(406, 44);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(406, 44);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(403, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(406, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem5,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.editToolStripMenuItem.Text = "Edit(&E)";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(348, 44);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(348, 44);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(345, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(348, 44);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(348, 44);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(348, 44);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(345, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(348, 44);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(348, 44);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.viewToolStripMenuItem.Text = "View(&V)";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(315, 44);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPowershellToolStripMenuItem,
            this.toolStripMenuItem6,
            this.eraseToolStripMenuItem,
            this.moveTabToLeftToolStripMenuItem,
            this.moveTabToRightToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(157, 36);
            this.windowToolStripMenuItem.Text = "Window(&W)";
            // 
            // openPowershellToolStripMenuItem
            // 
            this.openPowershellToolStripMenuItem.Name = "openPowershellToolStripMenuItem";
            this.openPowershellToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Space)));
            this.openPowershellToolStripMenuItem.Size = new System.Drawing.Size(456, 44);
            this.openPowershellToolStripMenuItem.Text = "Powershell";
            this.openPowershellToolStripMenuItem.Click += new System.EventHandler(this.openPowershellToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(453, 6);
            // 
            // eraseToolStripMenuItem
            // 
            this.eraseToolStripMenuItem.Name = "eraseToolStripMenuItem";
            this.eraseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.eraseToolStripMenuItem.Size = new System.Drawing.Size(456, 44);
            this.eraseToolStripMenuItem.Text = "Erase This Tab";
            this.eraseToolStripMenuItem.Click += new System.EventHandler(this.eraseToolStripMenuItem_Click);
            // 
            // moveTabToLeftToolStripMenuItem
            // 
            this.moveTabToLeftToolStripMenuItem.Name = "moveTabToLeftToolStripMenuItem";
            this.moveTabToLeftToolStripMenuItem.Size = new System.Drawing.Size(456, 44);
            this.moveTabToLeftToolStripMenuItem.Text = "Move Tab To Left";
            this.moveTabToLeftToolStripMenuItem.Click += new System.EventHandler(this.moveTabToLeftToolStripMenuItem_Click);
            // 
            // moveTabToRightToolStripMenuItem
            // 
            this.moveTabToRightToolStripMenuItem.Name = "moveTabToRightToolStripMenuItem";
            this.moveTabToRightToolStripMenuItem.Size = new System.Drawing.Size(456, 44);
            this.moveTabToRightToolStripMenuItem.Text = "Move Tab To Right";
            this.moveTabToRightToolStripMenuItem.Click += new System.EventHandler(this.moveTabToRightToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.helpToolStripMenuItem.Text = "Help(&H)";
            // 
            // newFileOrFolderName
            // 
            this.newFileOrFolderName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFileOrFolderName.Location = new System.Drawing.Point(294, 123);
            this.newFileOrFolderName.Name = "newFileOrFolderName";
            this.newFileOrFolderName.Size = new System.Drawing.Size(161, 36);
            this.newFileOrFolderName.TabIndex = 6;
            // 
            // Rename
            // 
            this.Rename.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rename.BackgroundImage")));
            this.Rename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rename.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rename.Location = new System.Drawing.Point(405, 165);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(50, 50);
            this.Rename.TabIndex = 7;
            this.Rename.UseCompatibleTextRendering = true;
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delete.Location = new System.Drawing.Point(405, 221);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(50, 50);
            this.Delete.TabIndex = 8;
            this.Delete.UseCompatibleTextRendering = true;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // OpenPowershell
            // 
            this.OpenPowershell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenPowershell.BackgroundImage")));
            this.OpenPowershell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenPowershell.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpenPowershell.Location = new System.Drawing.Point(349, 221);
            this.OpenPowershell.Name = "OpenPowershell";
            this.OpenPowershell.Size = new System.Drawing.Size(50, 50);
            this.OpenPowershell.TabIndex = 9;
            this.OpenPowershell.UseCompatibleTextRendering = true;
            this.OpenPowershell.UseVisualStyleBackColor = true;
            this.OpenPowershell.Click += new System.EventHandler(this.OpenPowershell_Click);
            // 
            // WebView
            // 
            this.WebView.AllowExternalDrop = true;
            this.WebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebView.CreationProperties = null;
            this.WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebView.Location = new System.Drawing.Point(3, 53);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(649, 518);
            this.WebView.TabIndex = 10;
            this.WebView.ZoomFactor = 1D;
            this.WebView.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WebView_CoreWebView2InitializationCompleted);
            // 
            // AiTextBox
            // 
            this.AiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AiTextBox.Location = new System.Drawing.Point(3, 4);
            this.AiTextBox.Multiline = true;
            this.AiTextBox.Name = "AiTextBox";
            this.AiTextBox.Size = new System.Drawing.Size(647, 609);
            this.AiTextBox.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(17, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SearchTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.WebView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AiTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(653, 1189);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 10;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(647, 44);
            this.SearchTextBox.TabIndex = 11;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(471, 44);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MoveTabToRight);
            this.splitContainer2.Panel1.Controls.Add(this.MoveTabToLeft);
            this.splitContainer2.Panel1.Controls.Add(this.TabErase);
            this.splitContainer2.Panel1.Controls.Add(this.Editor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1821, 1217);
            this.splitContainer2.SplitterDistance = 1134;
            this.splitContainer2.TabIndex = 11;
            // 
            // MoveTabToRight
            // 
            this.MoveTabToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveTabToRight.BackColor = System.Drawing.SystemColors.Control;
            this.MoveTabToRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveTabToRight.BackgroundImage")));
            this.MoveTabToRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveTabToRight.FlatAppearance.BorderSize = 0;
            this.MoveTabToRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MoveTabToRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MoveTabToRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveTabToRight.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MoveTabToRight.Location = new System.Drawing.Point(1027, -1);
            this.MoveTabToRight.Name = "MoveTabToRight";
            this.MoveTabToRight.Size = new System.Drawing.Size(31, 31);
            this.MoveTabToRight.TabIndex = 19;
            this.MoveTabToRight.UseCompatibleTextRendering = true;
            this.MoveTabToRight.UseVisualStyleBackColor = false;
            this.MoveTabToRight.Click += new System.EventHandler(this.MoveTabToRight_Click);
            // 
            // MoveTabToLeft
            // 
            this.MoveTabToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveTabToLeft.BackColor = System.Drawing.SystemColors.Control;
            this.MoveTabToLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoveTabToLeft.BackgroundImage")));
            this.MoveTabToLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoveTabToLeft.FlatAppearance.BorderSize = 0;
            this.MoveTabToLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MoveTabToLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MoveTabToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveTabToLeft.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MoveTabToLeft.Location = new System.Drawing.Point(1064, -2);
            this.MoveTabToLeft.Name = "MoveTabToLeft";
            this.MoveTabToLeft.Size = new System.Drawing.Size(31, 31);
            this.MoveTabToLeft.TabIndex = 18;
            this.MoveTabToLeft.UseCompatibleTextRendering = true;
            this.MoveTabToLeft.UseVisualStyleBackColor = false;
            this.MoveTabToLeft.Click += new System.EventHandler(this.MoveTabToLeft_Click);
            // 
            // TabErase
            // 
            this.TabErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabErase.BackColor = System.Drawing.SystemColors.Control;
            this.TabErase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabErase.BackgroundImage")));
            this.TabErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TabErase.FlatAppearance.BorderSize = 0;
            this.TabErase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TabErase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TabErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabErase.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TabErase.Location = new System.Drawing.Point(1101, -2);
            this.TabErase.Name = "TabErase";
            this.TabErase.Size = new System.Drawing.Size(31, 31);
            this.TabErase.TabIndex = 17;
            this.TabErase.UseCompatibleTextRendering = true;
            this.TabErase.UseVisualStyleBackColor = false;
            this.TabErase.Click += new System.EventHandler(this.TabErase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2305, 1262);
            this.Controls.Add(this.FindOrReplacePanel);
            this.Controls.Add(this.OpenPowershell);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.newFileOrFolderName);
            this.Controls.Add(this.NewFolder);
            this.Controls.Add(this.NewFile);
            this.Controls.Add(this.FileTree);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Editor.ResumeLayout(false);
            this.Start.ResumeLayout(false);
            this.FindOrReplacePanel.ResumeLayout(false);
            this.FindOrReplacePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Editor;
        private System.Windows.Forms.TreeView FileTree;
        private System.Windows.Forms.TabPage Start;
        private System.Windows.Forms.Button NewFile;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button NewFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog OpenFolderDialog;
        private System.Windows.Forms.TextBox newFileOrFolderName;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newTextMemoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.Button OpenPowershell;
        private System.Windows.Forms.ToolStripMenuItem openPowershellToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
        private System.Windows.Forms.TextBox AiTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Panel FindOrReplacePanel;
        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button ReplaceAllButton;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.Button TabErase;
        private System.Windows.Forms.Button MoveTabToLeft;
        private System.Windows.Forms.Button MoveTabToRight;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem eraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveTabToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveTabToRightToolStripMenuItem;
    }
}

