using System.Collections.Generic;
using System.Windows.Forms;

namespace RichTextBoxExNameSpace
{
    public class RichTextBoxEx : RichTextBox
    {
        List<UndoBuf> undoBufs = new List<UndoBuf>();
        List<UndoBuf> redoBufs = new List<UndoBuf>();

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;

            int i = (int)e.KeyChar;
            if (i < 0x20 || i > 0x80)
                return;

            var str = e.KeyChar.ToString();
            SelectedText = str;

            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                Back();
                return;
            }
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                Delete();
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                BreakLine();
                return;
            }
            if (e.KeyCode == Keys.X)
            {
                e.Handled = true;
                Cut();
                return;
            }
            if (e.KeyCode == Keys.C)
            {
                e.Handled = true;
                Copy();
                return;
            }
            if ((e.KeyCode == Keys.V && e.Modifiers == Keys.Control) || (e.KeyCode == Keys.Insert && e.Modifiers == Keys.Shift))
            {
                e.Handled = true;
                Paste();
                return;
            }
            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                Undo();
                return;
            }
            if (e.KeyCode == Keys.Y && e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                Redo();
                return;
            }

            if (e.KeyCode == Keys.Tab)
            {
                SelectedText = "\t";
                return;
            }
        }

        bool IsNextLineBreak()
        {
            if (SelectionLength != 0)
                return false;

            string s = Text;
            if (SelectionStart + 2 > TextLength)
                return false;

            string s2 = s.Substring(SelectionStart, 2);
            if (s2 == "\r\n")
                return true;
            else
                return false;
        }

        bool IsBeforeLineBreak()
        {
            string s = Text;
            if (SelectionStart - 2 < 0)
                return false;

            string s2 = s.Substring(SelectionStart - 2, 2);
            if (s2 == "\r\n")
                return true;
            else
                return false;
        }

        void Back()
        {
            if (SelectionLength > 0)
            {
                SelectedText = "";
            }
            else
            {
                if (SelectionStart != 0)
                {
                    if (IsBeforeLineBreak())
                    {
                        SelectionStart -= 2;
                        SelectionLength = 2;
                        SelectedText = "";
                    }
                    else
                    {
                        SelectionStart--;
                        SelectionLength = 1;
                        SelectedText = "";
                    }
                }
            }
        }
        void Delete()
        {
            if (SelectionLength > 0)
            {
                SelectedText = "";
            }
            else
            {

                if (SelectionStart != TextLength)
                {
                    if (IsNextLineBreak())
                    {
                        SelectionLength = 2;
                        SelectedText = "";
                    }
                    else
                    {
                        SelectionLength = 1;
                        SelectedText = "";
                    }
                }
            }
        }

        void BreakLine()
        {
            SelectedText = "\r\n";
        }

        new string SelectedText
        {
            get
            {
                return base.SelectedText;
            }
            set
            {
                UndoBuf buf = new UndoBuf();
                buf.DeleteStart = SelectionStart;
                buf.DeleteLength = SelectionLength;
                buf.DeleteString = SelectedText;

                buf.InsertStart = SelectionStart;
                buf.InsertLength = value.Length;
                buf.InsertString = value;

                redoBufs.Clear();
                undoBufs.Insert(0, buf);

                base.SelectedText = value;
            }
        }

        new string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                undoBufs.Clear();
                redoBufs.Clear();
                base.Text = value;
            }
        }

        new void Undo()
        {
            if (undoBufs.Count == 0)
                return;

            UndoBuf buf = undoBufs[0];
            undoBufs.RemoveAt(0);
            SelectionStart = buf.InsertStart;
            SelectionLength = buf.InsertLength;
            base.SelectedText = "";
            SelectionStart = buf.DeleteStart;
            SelectionLength = 0;
            base.SelectedText = buf.DeleteString;

            redoBufs.Insert(0, buf);
        }

        void Redo()
        {
            if (redoBufs.Count == 0)
                return;

            UndoBuf buf = redoBufs[0];
            redoBufs.RemoveAt(0);
            SelectionStart = buf.DeleteStart;
            SelectionLength = buf.DeleteLength;
            base.SelectedText = "";
            SelectionStart = buf.InsertStart;
            SelectionLength = 0;
            base.SelectedText = buf.InsertString;

            undoBufs.Insert(0, buf);
        }

        new void Cut()
        {
            if (SelectedText == "") return;
            Clipboard.SetText(SelectedText);
            SelectedText = "";
        }

        new void Paste()
        {
            string str = Clipboard.GetText();
            SelectedText = str;
        }
    }

    public class UndoBuf
    {
        internal int DeleteStart { get; set; } = 0;
        internal int DeleteLength { get; set; } = 0;
        internal string DeleteString { get; set; } = "";

        internal int InsertStart { get; set; } = 0;
        internal int InsertLength { get; set; } = 0;
        internal string InsertString { get; set; } = "";
    }
}