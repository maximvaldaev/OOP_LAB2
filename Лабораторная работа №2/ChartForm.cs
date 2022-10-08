using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Лабораторная_работа__2
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            chart1.Parent = this;
            chart1.Dock = DockStyle.Fill;
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("Math functions"));
                        
            Series seriesOfPointSinus = new Series("Sinus");
            Series seriesOfPointCosin = new Series("Cosin");

            //Создаем и настраиваем набор точек для рисования графика, в том
            //не забыв указать имя области на которой хотим отобразить этот
            //набор точек
            seriesOfPointSinus.ChartType = SeriesChartType.Line;
            seriesOfPointCosin.ChartType = SeriesChartType.Line;
            seriesOfPointSinus.ChartArea = "Math functions";
            seriesOfPointCosin.ChartArea = "Math functions";

            for (double x = -6; x <= 6; x += 0.1)
            {
                seriesOfPointSinus.Points.AddXY(x, Math.Sin(x));
                seriesOfPointCosin.Points.AddXY(x, Math.Cos(x));
            }

            //Добавляем созданный набор точек в Chart
            chart1.Series.Add(seriesOfPointSinus);
            chart1.Series.Add(seriesOfPointCosin);
        }
    }
}
