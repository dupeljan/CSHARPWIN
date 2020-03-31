using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab08 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void моеДействиеToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Пункт меню");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            textBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e) {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            textBox1.SelectAll();
        }

        private void моеДействиеToolStripMenuItem_MouseEnter(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Будет выведено сообщение";
        }

        private void моеДействиеToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void выходToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void выходToolStripMenuItem_MouseEnter(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Произойдет выход из приложения";
        }

        private void cutToolStripMenuItem_MouseEnter(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Будет вырезан выделенный текст";
        }

        private void cutToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void copyToolStripMenuItem_MouseEnter(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Будет скопирован выделенныф текст";
        }

        private void copyToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void pastToolStripMenuItem_MouseEnter(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Вставится текст из буфера";
        }

        private void pastToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void selectAllToolStripMenuItem_MouseEnter(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "Выделение всего текста поля";
        }

        private void selectAllToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) {
            comboBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) {
            listBox1.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Text = "";
            if (listBox1.Items.Count > 0) listBox1.SetSelected(0, true);
        }

        private void button3_Click(object sender, EventArgs e) {
            comboBox1.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            if (listBox1.Items.Count > 0) listBox1.SetSelected(0, true);
        }
    }
}
