using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MotionModeling
{
    public partial class FormProjectile : Form
    {
        private double g = 9.81;
        private double p_g = -9.81;
        private double c_d = 0.47; // Коэффициент обтикаемости тела(шара)
        private double pi = Math.PI;
        private double e = Math.E;
        private double density = 1.2; // Плотность воздуха


        public FormProjectile()
        {
            InitializeComponent();

            textBoxAngle.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxMass.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxVelocity.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);
            textBoxDelta.KeyPress += new KeyPressEventHandler(FormStart.OnKeyPressed);

            chartRectangular.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chartRectangular.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {

                var angle = Convert.ToDouble(textBoxAngle.Text);
                var velocity = Convert.ToDouble(textBoxVelocity.Text);
                var mass = Convert.ToDouble(textBoxMass.Text);
                var dt = Convert.ToDouble(textBoxDelta.Text);

                var (xSym, ySym, distanceSym, heightSym) = FindProjectileTrajectorySymbolical(mass, velocity, angle, dt);
                labelLengthSym.Text = $"Дистанция полета(Символьно): {Math.Round(distanceSym, 3)}";
                labelHeightSym.Text = $"Высота полета(Символьно): {Math.Round(heightSym, 3)}";

                var (xNum, yNum, distanceNum, heightNum) = FindProjectileTrajectoryNumerical(mass, velocity, angle, dt);
                labelLengthNum.Text = $"Дистанция полета(Численно): {Math.Round(distanceNum, 3)}";
                labelHeightNum.Text = $"Высота полета(Численно): {Math.Round(heightNum, 3)}";

                DrawPlot(xSym, ySym, xSym, ySym);
            }
            catch { }
        }

        private void DrawPlot(List<double> xSym, List<double> ySym, List<double> xNum, List<double> yNum)
        {
            chartRectangular.Series[0].Points.Clear();
            chartRectangular.Series[1].Points.Clear();

            int length = xSym.Count;

            for (int i = 0; i < length; i++)
            {
                chartRectangular.Series[0].Points.AddXY(xSym[i], ySym[i]);
                chartRectangular.Series[1].Points.AddXY(xNum[i], yNum[i]);
            }
        }

        private (List<double>, List<double>, double, double) FindProjectileTrajectorySymbolical(double mass, double v0, double angle, double dt)
        {
            var vt = g * mass / c_d;
            double t = 0;
            int i = 0;
            var xList = new List<double>() { 0 };
            var yList = new List<double>() { 0 };
            double distance;
            double height;

            if (checkBoxFriction.Checked)
            {
                while (yList[i] >= 0)
                {
                    i++;
                    xList.Add(vt * v0 * Math.Cos(angle * pi / 180) * (1 - Math.Pow(e, p_g * t / vt)) / g);
                    yList.Add(vt * (v0 * Math.Sin(angle * pi / 180) + vt) * (1 - Math.Pow(e, p_g * t / vt)) / g - mass * g * t / c_d);
                    t += dt;
                }
                yList[i] = 0;
                distance = xList[i];
                height = yList.Max();
            }
            else
            {
                var l = (Math.Pow(v0, 2) * Math.Sin(2 * angle * pi / 180) / (g * mass));
                for (double x = dt; x < l; x+=dt)
                {
                    i++;
                    xList.Add(x);
                    yList.Add(x * Math.Tan(angle * pi / 180) - (g * mass * Math.Pow(x, 2) / (2 * Math.Pow(v0, 2) * Math.Pow(Math.Cos(angle * pi / 180), 2))));
                }
                yList[i] = 0;
                distance = xList[i];
                height = yList.Max();
            }
            return (xList, yList, distance, height);
        }

        private (List<double>, List<double>, double, double) FindProjectileTrajectoryNumerical(double mass, double v0, double angle, double dt)
        {
            var k = density * c_d / 2;
            int t = 0;
            int i = 0;
            var xList = new List<double>() { 0 };
            var yList = new List<double>() { 0 };
            var vxList = new List<double>() { v0 * Math.Cos(angle * pi / 180) };
            var vyList = new List<double>() { v0 * Math.Sin(angle * pi / 180) };

            double distance, height, ax, ay;
     
            if (checkBoxFriction.Checked)
            {
                ax = -k * vxList[0] / mass;
                ay = p_g - k * vyList[0] / mass;
            }
            else
            {
                ay = p_g * mass;
                ax = 0;
            }

            double x, y, vx, vy;
            while (yList[i] >= 0)
            {
                x = xList[i] + vxList[i] * dt;
                y = yList[i] + vyList[i] * dt;
                vx = vxList[i] + ax * dt;
                vy = vyList[i] + ay * dt;
                xList.Add(x);
                yList.Add(y);
                vxList.Add(vx);
                vyList.Add(vy);
                i++;
            }
            distance = xList[i];
            height = yList.Max();

            return (xList, yList, distance, height);
        }
    }
}
