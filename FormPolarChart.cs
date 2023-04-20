using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionModeling
{
    public partial class FormPolarChart : Form
    {
        public FormPolarChart()
        {
            InitializeComponent();
        }
        public void DrawGraphic(double[] fi, double[] w, double t_end, double delta)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            int i = 0;
            for (double t = delta; t < t_end - delta; t += delta)
            {
                chart1.Series[0].Points.AddXY(Math.Cos(t), Math.Sin(fi[i]));
                chart1.Series[1].Points.AddXY(Math.Cos(t), Math.Sin(w[i]));
                i++;
            }
        }
    }
}
