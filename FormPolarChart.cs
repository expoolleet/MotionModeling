using System.Windows.Forms;

namespace MotionModeling
{
    public partial class FormPolarChart : Form
    {
        public FormPolarChart()
        {
            InitializeComponent();

            chartPolar.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chartPolar.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
        }
        public void DrawGraphic(double[] fi, double[] w, double t_end, double delta) 
        {
            chartPolar.Series[0].Points.Clear();
            chartPolar.Series[1].Points.Clear();

                int i = 0;
            for (double t = 0; t < t_end - delta; t += delta)
            {
                chartPolar.Series[0].Points.AddXY(fi[i], w[i]);
                i++;
            }
        }   
    }
}
