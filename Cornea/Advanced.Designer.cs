namespace Cornea
{
    partial class Advanced
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Button();
            this.bluelight = new System.Windows.Forms.Button();
            this.brightness = new System.Windows.Forms.Button();
            this.sleep = new System.Windows.Forms.Button();
            this.adv_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.timer);
            this.panel1.Controls.Add(this.bluelight);
            this.panel1.Controls.Add(this.brightness);
            this.panel1.Controls.Add(this.sleep);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 79);
            this.panel1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Dock = System.Windows.Forms.DockStyle.Left;
            this.timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.timer.Location = new System.Drawing.Point(468, 0);
            this.timer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(152, 79);
            this.timer.TabIndex = 3;
            this.timer.Text = "Timer";
            this.timer.UseVisualStyleBackColor = true;
            this.timer.Click += new System.EventHandler(this.timer_Click);
            // 
            // bluelight
            // 
            this.bluelight.Dock = System.Windows.Forms.DockStyle.Left;
            this.bluelight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluelight.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluelight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.bluelight.Location = new System.Drawing.Point(312, 0);
            this.bluelight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bluelight.Name = "bluelight";
            this.bluelight.Size = new System.Drawing.Size(156, 79);
            this.bluelight.TabIndex = 2;
            this.bluelight.Text = "Blue light";
            this.bluelight.UseVisualStyleBackColor = true;
            this.bluelight.Click += new System.EventHandler(this.bluelight_Click);
            // 
            // brightness
            // 
            this.brightness.Dock = System.Windows.Forms.DockStyle.Left;
            this.brightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brightness.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.brightness.Location = new System.Drawing.Point(156, 0);
            this.brightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(156, 79);
            this.brightness.TabIndex = 1;
            this.brightness.Text = "Brightness";
            this.brightness.UseVisualStyleBackColor = true;
            this.brightness.Click += new System.EventHandler(this.brightness_Click);
            // 
            // sleep
            // 
            this.sleep.Dock = System.Windows.Forms.DockStyle.Left;
            this.sleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sleep.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.sleep.Location = new System.Drawing.Point(0, 0);
            this.sleep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(156, 79);
            this.sleep.TabIndex = 0;
            this.sleep.Text = "Sleep";
            this.sleep.UseVisualStyleBackColor = true;
            this.sleep.Click += new System.EventHandler(this.sleep_Click);
            // 
            // adv_panel
            // 
            this.adv_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adv_panel.Location = new System.Drawing.Point(0, 80);
            this.adv_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adv_panel.Name = "adv_panel";
            this.adv_panel.Size = new System.Drawing.Size(620, 330);
            this.adv_panel.TabIndex = 1;
            // 
            // Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(620, 410);
            this.Controls.Add(this.adv_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Advanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Advanced";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel adv_panel;
        private System.Windows.Forms.Button timer;
        private System.Windows.Forms.Button bluelight;
        private System.Windows.Forms.Button brightness;
        private System.Windows.Forms.Button sleep;
    }
}