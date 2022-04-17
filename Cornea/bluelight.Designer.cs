namespace Cornea
{
    partial class bluelight
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.display2 = new System.Windows.Forms.TextBox();
            this.display1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nightslider = new System.Windows.Forms.TrackBar();
            this.dayslider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nightslider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayslider)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Navy;
            this.checkBox1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.checkBox1.Location = new System.Drawing.Point(319, 242);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 20);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "OFF";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.TextChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // display2
            // 
            this.display2.ForeColor = System.Drawing.Color.Turquoise;
            this.display2.Location = new System.Drawing.Point(549, 146);
            this.display2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display2.Multiline = true;
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(45, 22);
            this.display2.TabIndex = 26;
            this.display2.Text = "0";
            this.display2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.display2.TextChanged += new System.EventHandler(this.nightslider_ValueChanged);
            // 
            // display1
            // 
            this.display1.ForeColor = System.Drawing.Color.Turquoise;
            this.display1.Location = new System.Drawing.Point(549, 66);
            this.display1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display1.Multiline = true;
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(45, 22);
            this.display1.TabIndex = 27;
            this.display1.Text = "0";
            this.display1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.display1.TextChanged += new System.EventHandler(this.dayslider_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Manual Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Night Light";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Day Light";
            // 
            // nightslider
            // 
            this.nightslider.Location = new System.Drawing.Point(187, 145);
            this.nightslider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nightslider.Maximum = 100;
            this.nightslider.Name = "nightslider";
            this.nightslider.Size = new System.Drawing.Size(347, 56);
            this.nightslider.TabIndex = 21;
            this.nightslider.Value = 20;
            this.nightslider.Scroll += new System.EventHandler(this.nightslider_ValueChanged);
            // 
            // dayslider
            // 
            this.dayslider.Location = new System.Drawing.Point(187, 66);
            this.dayslider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayslider.Maximum = 100;
            this.dayslider.Name = "dayslider";
            this.dayslider.Size = new System.Drawing.Size(347, 56);
            this.dayslider.TabIndex = 22;
            this.dayslider.Value = 20;
            this.dayslider.Scroll += new System.EventHandler(this.dayslider_ValueChanged);
            // 
            // bluelight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(620, 330);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nightslider);
            this.Controls.Add(this.dayslider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bluelight";
            this.Text = "bluelight";
            this.Load += new System.EventHandler(this.bluelight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nightslider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayslider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox display2;
        private System.Windows.Forms.TextBox display1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar nightslider;
        private System.Windows.Forms.TrackBar dayslider;
    }
}