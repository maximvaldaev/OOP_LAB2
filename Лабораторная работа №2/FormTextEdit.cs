using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__2
{
    public partial class FormTextEdit : Form
    {
        String copyText;
        public FormTextEdit()
        {
            InitializeComponent();
        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
            //richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 26, richTextBox1.SelectionFont.Style);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyText = richTextBox1.SelectedText;
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = copyText;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = String.Empty;
        }
    }
}
