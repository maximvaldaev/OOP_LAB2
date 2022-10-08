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
    public partial class FormWorkWithImage : Form
    {
        public FormWorkWithImage(String fileName)
        {
            InitializeComponent();
            try
            {
                pictureBox1.Image = Image.FromFile(fileName);
               
            }
            catch
            {
                MessageBox.Show("Невозможно открыть файл");
            }
            this.pictureBox1.MouseMove += new MouseEventHandler(this.pictureBox1_MouseMove);
            pathFile.Text = fileName;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseX.Text = Convert.ToString(Cursor.Position.X);
            posMouseY.Text = Convert.ToString(Cursor.Position.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        



    }
}
