namespace MotionModeling
{
    partial class FormStart
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
            this.buttonPendulum = new System.Windows.Forms.Button();
            this.buttonProjectile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBullet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPendulum
            // 
            this.buttonPendulum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPendulum.Location = new System.Drawing.Point(29, 72);
            this.buttonPendulum.Name = "buttonPendulum";
            this.buttonPendulum.Size = new System.Drawing.Size(148, 75);
            this.buttonPendulum.TabIndex = 1;
            this.buttonPendulum.Text = "Маятник";
            this.buttonPendulum.UseVisualStyleBackColor = true;
            this.buttonPendulum.Click += new System.EventHandler(this.buttoPendulum_Click);
            // 
            // buttonProjectile
            // 
            this.buttonProjectile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProjectile.Location = new System.Drawing.Point(211, 72);
            this.buttonProjectile.Name = "buttonProjectile";
            this.buttonProjectile.Size = new System.Drawing.Size(148, 75);
            this.buttonProjectile.TabIndex = 2;
            this.buttonProjectile.Text = "Тело";
            this.buttonProjectile.UseVisualStyleBackColor = true;
            this.buttonProjectile.Click += new System.EventHandler(this.buttonProjectile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Модели";
            // 
            // buttonBullet
            // 
            this.buttonBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBullet.Location = new System.Drawing.Point(404, 72);
            this.buttonBullet.Name = "buttonBullet";
            this.buttonBullet.Size = new System.Drawing.Size(148, 75);
            this.buttonBullet.TabIndex = 4;
            this.buttonBullet.Text = "Снаряд";
            this.buttonBullet.UseVisualStyleBackColor = true;
            this.buttonBullet.Click += new System.EventHandler(this.buttonBullet_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 181);
            this.Controls.Add(this.buttonBullet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProjectile);
            this.Controls.Add(this.buttonPendulum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStart";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPendulum;
        private System.Windows.Forms.Button buttonProjectile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBullet;
    }
}