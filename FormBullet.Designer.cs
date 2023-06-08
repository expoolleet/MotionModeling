namespace MotionModeling
{
    partial class FormBullet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxFindOptimalAngle = new System.Windows.Forms.CheckBox();
            this.groupBoxDistance = new System.Windows.Forms.GroupBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxCD = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.groupBoxAngle = new System.Windows.Forms.GroupBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.chartRectangular = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBoxDistance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBoxAngle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRectangular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxFindOptimalAngle);
            this.groupBox5.Controls.Add(this.groupBoxDistance);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBoxAngle);
            this.groupBox5.Controls.Add(this.buttonShow);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(582, 188);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Рассчет траектории запущенного снаряда ";
            // 
            // checkBoxFindOptimalAngle
            // 
            this.checkBoxFindOptimalAngle.AutoSize = true;
            this.checkBoxFindOptimalAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFindOptimalAngle.Location = new System.Drawing.Point(18, 97);
            this.checkBoxFindOptimalAngle.Name = "checkBoxFindOptimalAngle";
            this.checkBoxFindOptimalAngle.Size = new System.Drawing.Size(213, 19);
            this.checkBoxFindOptimalAngle.TabIndex = 8;
            this.checkBoxFindOptimalAngle.Text = "Нахождение оптимального угла";
            this.checkBoxFindOptimalAngle.UseVisualStyleBackColor = true;
            this.checkBoxFindOptimalAngle.Click += new System.EventHandler(this.checkBoxFindOptimalAngle_Click);
            // 
            // groupBoxDistance
            // 
            this.groupBoxDistance.Controls.Add(this.textBoxDistance);
            this.groupBoxDistance.Enabled = false;
            this.groupBoxDistance.Location = new System.Drawing.Point(12, 120);
            this.groupBoxDistance.Name = "groupBoxDistance";
            this.groupBoxDistance.Size = new System.Drawing.Size(219, 63);
            this.groupBoxDistance.TabIndex = 10;
            this.groupBoxDistance.TabStop = false;
            this.groupBoxDistance.Text = "Необходимая дистанция";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(6, 30);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(159, 24);
            this.textBoxDistance.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDelta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(499, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шаг";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelta.Location = new System.Drawing.Point(6, 19);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(55, 26);
            this.textBoxDelta.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxCD);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox10.Location = new System.Drawing.Point(380, 35);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(113, 56);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Обтикаемость";
            // 
            // textBoxCD
            // 
            this.textBoxCD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCD.Location = new System.Drawing.Point(6, 19);
            this.textBoxCD.Name = "textBoxCD";
            this.textBoxCD.Size = new System.Drawing.Size(90, 26);
            this.textBoxCD.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxDiameter);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.Location = new System.Drawing.Point(276, 35);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(98, 56);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Диаметр(м)";
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDiameter.Location = new System.Drawing.Point(6, 19);
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.Size = new System.Drawing.Size(75, 26);
            this.textBoxDiameter.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxMass);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(186, 35);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(84, 56);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Масса";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMass.Location = new System.Drawing.Point(6, 19);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(61, 26);
            this.textBoxMass.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxVelocity);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(96, 35);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(84, 56);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Скорость";
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVelocity.Location = new System.Drawing.Point(6, 19);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(61, 26);
            this.textBoxVelocity.TabIndex = 1;
            // 
            // groupBoxAngle
            // 
            this.groupBoxAngle.Controls.Add(this.textBoxAngle);
            this.groupBoxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAngle.Location = new System.Drawing.Point(6, 35);
            this.groupBoxAngle.Name = "groupBoxAngle";
            this.groupBoxAngle.Size = new System.Drawing.Size(84, 56);
            this.groupBoxAngle.TabIndex = 2;
            this.groupBoxAngle.TabStop = false;
            this.groupBoxAngle.Text = "Угол";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAngle.Location = new System.Drawing.Point(6, 19);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(61, 26);
            this.textBoxAngle.TabIndex = 1;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow.Location = new System.Drawing.Point(374, 97);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(202, 77);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // chartRectangular
            // 
            this.chartRectangular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartRectangular.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea3.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.chartRectangular.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRectangular.Legends.Add(legend3);
            this.chartRectangular.Location = new System.Drawing.Point(12, 206);
            this.chartRectangular.Name = "chartRectangular";
            this.chartRectangular.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "bullet";
            series3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series3.ShadowOffset = -2;
            this.chartRectangular.Series.Add(series3);
            this.chartRectangular.Size = new System.Drawing.Size(582, 385);
            this.chartRectangular.TabIndex = 7;
            this.chartRectangular.Text = "chart1";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeight.Location = new System.Drawing.Point(298, 605);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(102, 15);
            this.labelHeight.TabIndex = 9;
            this.labelHeight.Text = "Высота полета: ";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(21, 605);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(122, 15);
            this.labelLength.TabIndex = 8;
            this.labelLength.Text = "Дистанция полета: ";
            // 
            // FormBullet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 643);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.chartRectangular);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBullet";
            this.Text = "Снаряд";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxDistance.ResumeLayout(false);
            this.groupBoxDistance.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBoxAngle.ResumeLayout(false);
            this.groupBoxAngle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRectangular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxCD;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.GroupBox groupBoxAngle;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Button buttonShow;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chartRectangular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.CheckBox checkBoxFindOptimalAngle;
        private System.Windows.Forms.GroupBox groupBoxDistance;
        private System.Windows.Forms.TextBox textBoxDistance;
    }
}