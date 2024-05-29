using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Wybierz plik";
            ofd.Filter = "Rich Text Format (.rtf)|*.rtf| Text Files(.txt)|*.txt";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                int filterIndex = ofd.FilterIndex;
                RichTextBoxStreamType st = RichTextBoxStreamType.RichText;
                if (filterIndex == 2)
                {
                    st = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.LoadFile(ofd.FileName, st);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "Zapisz plik";
            ofd.Filter = "Rich Text Format (.rtf)|*.rtf| Text Files(.txt)|*.txt";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                int filterIndex = ofd.FilterIndex;
                RichTextBoxStreamType st = RichTextBoxStreamType.RichText;
                if (filterIndex == 2)
                {
                    st = RichTextBoxStreamType.PlainText;
                }
                richTextBox1.LoadFile(ofd.FileName, st);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font selectFont = richTextBox1.SelectionFont;
            
            if (selectFont != null)
            {
                Font boldFont;
                if (selectFont.Style == FontStyle.Bold)
                {
                    boldFont = new Font(selectFont, FontStyle.Regular);

                }
                else
                {
                    boldFont = new Font(selectFont, FontStyle.Bold);
                }
                richTextBox1.SelectionFont = boldFont;

            }
        }

        private void btnItlic_Click(object sender, EventArgs e)
        {
            Font selectFont = richTextBox1.SelectionFont;

            if (selectFont != null)
            {
                Font italicFont;
                if (selectFont.Style == FontStyle.Italic)
                {
                    italicFont = new Font(selectFont, FontStyle.Regular);

                }
                else
                {
                    italicFont = new Font(selectFont, FontStyle.Italic);
                }
                richTextBox1.SelectionFont = italicFont;

            }
        }

        private void btnUnderLine_Click(object sender, EventArgs e)
        {
            Font selectFont = richTextBox1.SelectionFont;

            if (selectFont != null)
            {
                Font underline;
                if (selectFont.Style == FontStyle.Underline)
                {
                    underline = new Font(selectFont, FontStyle.Regular);

                }
                else
                {
                    underline = new Font(selectFont, FontStyle.Underline);
                }
                richTextBox1.SelectionFont = underline;

            }
        }
    }
}