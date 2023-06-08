using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotionModeling
{
    public partial class FormBullet : Form
    {
        private double g = 9.81;
        private double p_g = -9.81;
        private double pi = Math.PI;
        private double e = Math.E;
        private double density = 1.2; // Плотность воздуха

        public FormBullet()
        {
            InitializeComponent();
            textBoxAngle.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxMass.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxVelocity.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxDiameter.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxCD.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxDelta.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);

            chartRectangular.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chartRectangular.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
        }

        private void DrawPlot(List<double> x, List<double> y)
        {
            chartRectangular.Series[0].Points.Clear();

            int length = x.Count;

            for (int i = 0; i < length; i++)
            {
                chartRectangular.Series[0].Points.AddXY(x[i], y[i]);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                var velocity = Convert.ToDouble(textBoxVelocity.Text);
                var mass = Convert.ToDouble(textBoxMass.Text);
                var delta = Convert.ToDouble(textBoxDelta.Text);
                var diameter = Convert.ToDouble(textBoxDiameter.Text);
                var c_d = Convert.ToDouble(textBoxCD.Text);
                double angle = 0;
                double optimal_distance = 0;
                if (checkBoxFindOptimalAngle.Checked)
                {
                    (angle, optimal_distance) = FindOptimalLaunchAngle(mass, diameter, velocity, c_d, Convert.ToDouble(textBoxDistance.Text));
                    textBoxAngle.Text = angle.ToString();
                    labelDistance.Text = $": {optimal_distance}";
                }
                else
                {
                    angle = Convert.ToDouble(textBoxAngle.Text);
                }

                var (x, y, distance, height) = FindBulletTrajectory(mass, diameter, velocity, c_d, angle, delta);
                labelLength.Text = $"Дистанция полета: {Math.Round(distance, 3)}";
                labelHeight.Text = $"Высота полета: {Math.Round(height, 3)}";
                DrawPlot(x, y);
            }
            catch { }

        }

        private (List<double>, List<double>, double, double) FindBulletTrajectory(double m, double d, double v0, double c_d, double a, double dt)
        {
            var area = (pi * Math.Pow(d / 2, 2));
            var drag_coefficient = 0.5 * density * c_d * area;

            var vx = v0 * Math.Cos(a * pi / 180);
            var vy = v0 * Math.Sin(a * pi / 180);
            double t = 0;

            var xList = new List<double>() { 0 };
            var yList = new List<double>() { 0 };
            var ay = p_g;
            int i = 0;
            while (yList[i] >= 0)
            {
                i++;
                var drag_force = drag_coefficient * Math.Pow(vx, 2);
                var ax = -drag_force / m;

                xList.Add(vx * t);
                yList.Add(vy * t);
                vx += ax * dt;
                vy += ay * dt;

                t += dt;
            }
            double distance = xList[i];
            double height = yList.Max();

            return (xList, yList, distance, height);
        }

        private (double, double) FindOptimalLaunchAngle(double m, double d, double v0, double c_d, double target_distance)
        {
            var min_angle = 0;
            var max_angle = 90;
            int step = 1;
            double max_distance = 0;
            double optimal_angle = 0;
            for (int angle = min_angle; angle <= max_angle; angle += step)
            {
                var (x, _, _, _) = FindBulletTrajectory(m, d, v0, c_d, angle, Convert.ToDouble(textBoxDelta.Text));
                var distance = Math.Abs(x[angle] - target_distance);

                if (distance < Math.Abs(max_distance - target_distance))
                {
                    max_distance = x[angle];
                    optimal_angle = angle;
                }
            }
            return (optimal_angle, max_distance);
        }

        private void checkBoxFindOptimalAngle_Click(object sender, EventArgs e)
        {
            if (checkBoxFindOptimalAngle.Checked)
            {
                groupBoxDistance.Enabled = true;
                groupBoxAngle.Enabled = false;
            }
            else
            {
                groupBoxDistance.Enabled = false;
                groupBoxAngle.Enabled = true;
            }
        }
    }
}
