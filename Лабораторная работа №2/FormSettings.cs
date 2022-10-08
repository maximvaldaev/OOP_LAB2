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

namespace Лабораторная_работа__2
{
    public partial class FormSettings : Form
    {
        
        public FormSettings()
        {
            InitializeComponent();
            timePicker1.Format = DateTimePickerFormat.Time;
            timePicker1.ShowUpDown = true;
            datePicker1.Format = DateTimePickerFormat.Custom;
            this.panel1.MouseClick += new MouseEventHandler(this.panel1_Click);
            tabControl1.Parent = this;
            tabControl1.Size = this.Size;
        }

       

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();          
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message ="Вы хотите сохранить настройки?";
            const string caption = "Сохранение";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //TimeSpan timespan = timePicker1.Value.TimeOfDay;
                //String time = timespan.ToString(@"hh\:mm\:ss");

                String res = "Целое число:" + numericUpDown1.Value + "\r\n" +
                    "Ввод целого числа десятков:" + numericUpDown2.Value + "\r\n" +
                    "Время:" + timePicker1.Value.TimeOfDay.ToString(@"hh\:mm\:ss") + "\r\n" +
                    "Дата:" + datePicker1.Value.Date.ToString(@"dd\:MM\:yyyy") + "\r\n" +
                    "Альтернатива:" + radioButtons() + "\r\n" +
                    "Параметр 1:" + checkBox1.Checked + "\r\n" +
                    "Параметр 2:" + checkBox2.Checked + "\r\n" +
                    "Параметр 3:" + checkBox3.Checked + "\r\n" +
                    "Параметр 4:" + checkBox4.Checked + "\r\n" +
                    "Цвет:RGB A=" + panel1.BackColor.A + " G=" + panel1.BackColor.G + " B=" + panel1.BackColor.B;
                writeToFile(res);                
                this.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void writeToFile (String text)
        {
            saveFileDialog1.Filter = "Текстовый файл | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    //Write a line of text
                    sw.WriteLine(text);
                    //Close the file
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }

        public String radioButtons()
        {
            foreach (Control control in groupBox1.Controls)
            {
                // Проверка на принадлежность элемента управления к классу RadioButton:
                if (control.GetType() == typeof(System.Windows.Forms.RadioButton))
                {
                    // Создание отдельного (именованного) объекта класса RadioButton:
                    RadioButton rbControl = (RadioButton)control;
                    // Вывод сообщения, содержащего текст выбранного элемента:
                    if (rbControl.Checked)
                    {
                      return rbControl.Text;                        
                    }
                }
            }//foreach
            return "Альтернатива не выбрана!";
        }
    }
}
