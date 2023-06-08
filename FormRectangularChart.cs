using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionModeling
{
    public partial class FormRectangularChart : Form
    {
        public FormRectangularChart()
        {
            InitializeComponent();
           // CopyControl(new FormPolarChart().chartPolar, chartRectangular);
        }
        public void DrawGraphic(double[] fi, double[] w, double t_end, double delta)
        {
            chartRectangular.Series[0].Points.Clear();
            chartRectangular.Series[1].Points.Clear();

            int i = 0;
            for (double t = delta; t < t_end - delta; t += delta)
            {
                chartRectangular.Series[0].Points.AddXY(t, fi[i]);
                chartRectangular.Series[1].Points.AddXY(t, w[i]);
                i++;
            }
        }
        private void CopyControl(Control sourceControl, Control targetControl)
        {
            if (sourceControl.GetType() != targetControl.GetType())
            {
                throw new Exception("Incorrect control types");
            }

            foreach (var sourceProperty in sourceControl.GetType().GetProperties())
            {
                object newValue = sourceProperty.GetValue(sourceControl, null);

                MethodInfo mi = sourceProperty.GetSetMethod(true);

                if (mi != null)
                {
                    sourceProperty.SetValue(targetControl, newValue, null);
                }
            }
        }
    }
}
