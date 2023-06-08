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


namespace MotionModeling
{
    public partial class FormPendulum : Form
    {
        FormRectangularChart formRec = new FormRectangularChart();
        FormPolarChart formPol = new FormPolarChart();

        public FormPendulum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model();
        }

        private void Model()
        {
            double v0 = Convert.ToDouble(textBoxVelocity.Text);
            double r0 = Convert.ToDouble(textBoxRadius.Text);
            double t_end = Convert.ToDouble(textBoxTimeEnd.Text);
            double delta = Convert.ToDouble(textBoxDelta.Text);
            const double g = 9.82;

            double[] w = new double[(int)(t_end / delta)];
            double[] fi = new double[(int)(t_end / delta)];

            fi[0] = 0;
            w[0] = v0 / Math.Sqrt(g * r0);

            int i = 1;

                    for (double t = delta; t < t_end - delta; t += delta)
                    {
                        w[i] = w[i - 1] - delta * Math.Sin(fi[i - 1] * Math.PI / 180) * 180 / Math.PI;
                        fi[i] = fi[i - 1] + delta * w[i];
                        i++;    
                    }       
       
            formRec.DrawGraphic(fi, w, t_end, delta);
            formRec.Show();

            formPol.DrawGraphic(fi, w, t_end, delta);
            formPol.Show();

        }
    }
}
