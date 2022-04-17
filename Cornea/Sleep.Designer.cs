namespace Cornea
{
    partial class Sleep
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
            this.components = new System.ComponentModel.Container();
            this.display2 = new System.Windows.Forms.TextBox();
            this.display1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessSlider = new System.Windows.Forms.TrackBar();
            this.nightlightSlider = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wakeMin = new System.Windows.Forms.TextBox();
            this.bedMin = new System.Windows.Forms.TextBox();
            this.wakeHour = new System.Windows.Forms.TextBox();
            this.bedHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightlightSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // display2
            // 
            this.display2.ForeColor = System.Drawing.Color.Turquoise;
            this.display2.Location = new System.Drawing.Point(418, 71);
            this.display2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.display2.Multiline = true;
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(35, 18);
            this.display2.TabIndex = 32;
            this.display2.Text = "0";
            this.display2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.display2.TextChanged += new System.EventHandler(this.brightnessSlider_ValueChanged);
            // 
            // display1
            // 
            this.display1.ForeColor = System.Drawing.Color.Turquoise;
            this.display1.Location = new System.Drawing.Point(419, 11);
            this.display1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.display1.Multiline = true;
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(35, 18);
            this.display1.TabIndex = 33;
            this.display1.Text = "0";
            this.display1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.display1.TextChanged += new System.EventHandler(this.nightlightSlider_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sleep Brightness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sleep Light";
            // 
            // brightnessSlider
            // 
            this.brightnessSlider.Location = new System.Drawing.Point(154, 70);
            this.brightnessSlider.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.brightnessSlider.Maximum = 100;
            this.brightnessSlider.Minimum = 20;
            this.brightnessSlider.Name = "brightnessSlider";
            this.brightnessSlider.Size = new System.Drawing.Size(260, 45);
            this.brightnessSlider.TabIndex = 28;
            this.brightnessSlider.Value = 20;
            this.brightnessSlider.Scroll += new System.EventHandler(this.brightnessSlider_ValueChanged);
            // 
            // nightlightSlider
            // 
            this.nightlightSlider.Location = new System.Drawing.Point(155, 10);
            this.nightlightSlider.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nightlightSlider.Maximum = 100;
            this.nightlightSlider.Minimum = 20;
            this.nightlightSlider.Name = "nightlightSlider";
            this.nightlightSlider.Size = new System.Drawing.Size(260, 45);
            this.nightlightSlider.TabIndex = 29;
            this.nightlightSlider.Value = 20;
            this.nightlightSlider.Scroll += new System.EventHandler(this.nightlightSlider_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Navy;
            this.checkBox1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.checkBox1.Location = new System.Drawing.Point(287, 202);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "OFF";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.TextChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sleep Light";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Bed Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Wake Time";
            // 
            // wakeMin
            // 
            this.wakeMin.Location = new System.Drawing.Point(381, 150);
            this.wakeMin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.wakeMin.Multiline = true;
            this.wakeMin.Name = "wakeMin";
            this.wakeMin.Size = new System.Drawing.Size(52, 18);
            this.wakeMin.TabIndex = 36;
            this.wakeMin.Text = "00";
            this.wakeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wakeMin.TextChanged += new System.EventHandler(this.wakeMin_TextChanged);
            // 
            // bedMin
            // 
            this.bedMin.Location = new System.Drawing.Point(381, 119);
            this.bedMin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bedMin.Multiline = true;
            this.bedMin.Name = "bedMin";
            this.bedMin.Size = new System.Drawing.Size(52, 18);
            this.bedMin.TabIndex = 37;
            this.bedMin.Text = "00";
            this.bedMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bedMin.TextChanged += new System.EventHandler(this.bedMin_TextChanged);
            // 
            // wakeHour
            // 
            this.wakeHour.Location = new System.Drawing.Point(223, 151);
            this.wakeHour.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.wakeHour.Multiline = true;
            this.wakeHour.Name = "wakeHour";
            this.wakeHour.Size = new System.Drawing.Size(52, 18);
            this.wakeHour.TabIndex = 36;
            this.wakeHour.Text = "6";
            this.wakeHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wakeHour.TextChanged += new System.EventHandler(this.wakeHour_TextChanged);
            // 
            // bedHour
            // 
            this.bedHour.Location = new System.Drawing.Point(223, 119);
            this.bedHour.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bedHour.Multiline = true;
            this.bedHour.Name = "bedHour";
            this.bedHour.Size = new System.Drawing.Size(52, 18);
            this.bedHour.TabIndex = 37;
            this.bedHour.Text = "10";
            this.bedHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bedHour.TextChanged += new System.EventHandler(this.bedHour_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hour :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Hour :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Minutes :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Minutes :";
            // 
            // Sleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(465, 268);
            this.Controls.Add(this.bedHour);
            this.Controls.Add(this.bedMin);
            this.Controls.Add(this.wakeHour);
            this.Controls.Add(this.wakeMin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brightnessSlider);
            this.Controls.Add(this.nightlightSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Sleep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sleep";
            this.Load += new System.EventHandler(this.Sleep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightlightSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display2;
        private System.Windows.Forms.TextBox display1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar brightnessSlider;
        private System.Windows.Forms.TrackBar nightlightSlider;
        protected System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wakeMin;
        private System.Windows.Forms.TextBox bedMin;
        private System.Windows.Forms.TextBox wakeHour;
        private System.Windows.Forms.TextBox bedHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}