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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void работаСИзображениямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {       
                FormWorkWithImage formWorkWithImage = new FormWorkWithImage(openFileDialog1.FileName); 
                formWorkWithImage.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void текстовыйРедакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTextEdit formTextEdit = new FormTextEdit();
            formTextEdit.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
        }

        private void построениеГрафиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            chartForm.Show();
        }
    }
}
