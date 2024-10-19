using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UndoRedo;
using RichTextBoxExNameSpace;

namespace RichTextBoxWithLineNumber
{
    public partial class RichTextBoxLN : UserControl
    {
        private string nowCode;

        public RichTextBoxEx richTextBox;
        private Panel lineNumberPanel;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        const int EM_GETFIRSTVISIBLELINE = 0x00CE;

        public int LeftMargin { get; set; } = 50;

        public RichTextBoxLN()
        {
            InitializeComponent();
            SetupControls();
        }

        private void SetupControls()
        {
            lineNumberPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = LeftMargin,
                BackColor = Color.LightGray
            };
            lineNumberPanel.Paint += LineNumberPanel_Paint;

            richTextBox = new RichTextBoxEx
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.None,
                Font = new Font("Consolas", 10F, FontStyle.Regular),
                WordWrap = false,
                ScrollBars = RichTextBoxScrollBars.Both
            };

            richTextBox.VScroll += RichTextBox_VScroll;
            richTextBox.TextChanged += RichTextBox_TextChanged;
            richTextBox.Resize += RichTextBox_Resize;

            this.Controls.Add(richTextBox);
            this.Controls.Add(lineNumberPanel);
        }

        private void LineNumberPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawLineNumbers(e.Graphics);
        }

        private void DrawLineNumbers(Graphics g)
        {
            if (richTextBox == null) return;

            int firstVisibleLine = (int)SendMessage(richTextBox.Handle, EM_GETFIRSTVISIBLELINE, IntPtr.Zero, IntPtr.Zero);
            int visibleLines = richTextBox.Height / richTextBox.Font.Height;

            using (SolidBrush brush = new SolidBrush(Color.Gray))
            {
                for (int i = firstVisibleLine; i < firstVisibleLine + visibleLines + 1; i++)
                {
                    int charIndex = richTextBox.GetFirstCharIndexFromLine(i);
                    if (charIndex == -1) break;

                    Point pos = richTextBox.GetPositionFromCharIndex(charIndex);
                    string lineNumber = (i + 1).ToString();
                    SizeF size = g.MeasureString(lineNumber, richTextBox.Font);
                    g.DrawString(lineNumber, richTextBox.Font, brush,
                        new PointF(LeftMargin - size.Width - 5, pos.Y));
                }
            }
        }

        private void RichTextBox_VScroll(object sender, EventArgs e)
        {
            lineNumberPanel.Invalidate();
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            lineNumberPanel.Invalidate();
        }

        private void RichTextBox_Resize(object sender, EventArgs e)
        {
            lineNumberPanel.Invalidate();
        }

        private void RichTextBoxLN_Load(object sender, EventArgs e)
        {

        }
    }
}