using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab08 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                // если выбрали текст
                if (openFileDialog1.FilterIndex == 1)
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                // если выбрали текст
                if (openFileDialog1.FilterIndex == 1)
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                // если выбрали текст
                if (saveFileDialog1.FilterIndex == 1)
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                // если выбрали текст
                if (saveFileDialog1.FilterIndex == 1)
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Вы уверены ?", "Вопрос",
                 MessageBoxButtons.YesNo
                 , MessageBoxIcon.Question
                 , MessageBoxDefaultButton.Button2
                 )
                != DialogResult.Yes
                ) {
                e.Cancel = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }
    }
}
