namespace Cornea
{
    partial class Form1
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
            this.pause = new System.Windows.Forms.Button();
            this.advanced = new System.Windows.Forms.Button();
            this.simple = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.simple_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dropdown_mode = new System.Windows.Forms.Panel();
            this.sleep = new System.Windows.Forms.Button();
            this.dark = new System.Windows.Forms.Button();
            this.gaming = new System.Windows.Forms.Button();
            this.reading = new System.Windows.Forms.Button();
            this.healthy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.simple_panel.SuspendLayout();
            this.dropdown_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.advanced);
            this.panel1.Controls.Add(this.simple);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 617);
            this.panel1.TabIndex = 0;
            // 
            // pause
            // 
            this.pause.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Location = new System.Drawing.Point(0, 550);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(228, 67);
            this.pause.TabIndex = 1;
            this.pause.Text = "PAUSE";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // advanced
            // 
            this.advanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.advanced.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.advanced.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.advanced.Location = new System.Drawing.Point(0, 218);
            this.advanced.Name = "advanced";
            this.advanced.Size = new System.Drawing.Size(228, 67);
            this.advanced.TabIndex = 1;
            this.advanced.Text = "ADVANCED";
            this.advanced.UseVisualStyleBackColor = true;
            this.advanced.Click += new System.EventHandler(this.advanced_Click);
            // 
            // simple
            // 
            this.simple.Dock = System.Windows.Forms.DockStyle.Top;
            this.simple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.simple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.simple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simple.Location = new System.Drawing.Point(0, 151);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(228, 67);
            this.simple.TabIndex = 1;
            this.simple.Text = "SIMPLE";
            this.simple.UseVisualStyleBackColor = true;
            this.simple.Click += new System.EventHandler(this.simple_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 151);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cornea.Properties.Resources.icon3;
            this.pictureBox1.Location = new System.Drawing.Point(84, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(867, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "-";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cornea";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(935, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 43);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // simple_panel
            // 
            this.simple_panel.Controls.Add(this.label1);
            this.simple_panel.Controls.Add(this.dropdown_mode);
            this.simple_panel.Controls.Add(this.button1);
            this.simple_panel.Location = new System.Drawing.Point(228, 148);
            this.simple_panel.Name = "simple_panel";
            this.simple_panel.Size = new System.Drawing.Size(777, 469);
            this.simple_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mode";
            // 
            // dropdown_mode
            // 
            this.dropdown_mode.Controls.Add(this.sleep);
            this.dropdown_mode.Controls.Add(this.dark);
            this.dropdown_mode.Controls.Add(this.gaming);
            this.dropdown_mode.Controls.Add(this.reading);
            this.dropdown_mode.Controls.Add(this.healthy);
            this.dropdown_mode.Location = new System.Drawing.Point(268, 177);
            this.dropdown_mode.Name = "dropdown_mode";
            this.dropdown_mode.Size = new System.Drawing.Size(400, 221);
            this.dropdown_mode.TabIndex = 1;
            // 
            // sleep
            // 
            this.sleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sleep.Dock = System.Windows.Forms.DockStyle.Top;
            this.sleep.Location = new System.Drawing.Point(0, 172);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(400, 43);
            this.sleep.TabIndex = 0;
            this.sleep.Text = "Sleep";
            this.sleep.UseVisualStyleBackColor = false;
            this.sleep.Click += new System.EventHandler(this.sleep_Click);
            // 
            // dark
            // 
            this.dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dark.Dock = System.Windows.Forms.DockStyle.Top;
            this.dark.Location = new System.Drawing.Point(0, 129);
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(400, 43);
            this.dark.TabIndex = 0;
            this.dark.Text = "Dark movie";
            this.dark.UseVisualStyleBackColor = false;
            this.dark.Click += new System.EventHandler(this.dark_Click);
            // 
            // gaming
            // 
            this.gaming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gaming.Dock = System.Windows.Forms.DockStyle.Top;
            this.gaming.Location = new System.Drawing.Point(0, 86);
            this.gaming.Name = "gaming";
            this.gaming.Size = new System.Drawing.Size(400, 43);
            this.gaming.TabIndex = 0;
            this.gaming.Text = "Gaming";
            this.gaming.UseVisualStyleBackColor = false;
            this.gaming.Click += new System.EventHandler(this.gaming_Click);
            // 
            // reading
            // 
            this.reading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.reading.Dock = System.Windows.Forms.DockStyle.Top;
            this.reading.Location = new System.Drawing.Point(0, 43);
            this.reading.Name = "reading";
            this.reading.Size = new System.Drawing.Size(400, 43);
            this.reading.TabIndex = 0;
            this.reading.Text = "Reading";
            this.reading.UseVisualStyleBackColor = false;
            this.reading.Click += new System.EventHandler(this.reading_Click);
            // 
            // healthy
            // 
            this.healthy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.healthy.Dock = System.Windows.Forms.DockStyle.Top;
            this.healthy.Location = new System.Drawing.Point(0, 0);
            this.healthy.Name = "healthy";
            this.healthy.Size = new System.Drawing.Size(400, 43);
            this.healthy.TabIndex = 0;
            this.healthy.Text = "Healthy";
            this.healthy.UseVisualStyleBackColor = false;
            this.healthy.Click += new System.EventHandler(this.healthy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose a mode..";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Location = new System.Drawing.Point(825, 73);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(76, 28);
            this.display.TabIndex = 3;
            this.display.Text = "Simple";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1005, 617);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.simple_panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.simple_panel.ResumeLayout(false);
            this.simple_panel.PerformLayout();
            this.dropdown_mode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button advanced;
        private System.Windows.Forms.Button simple;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel simple_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dropdown_mode;
        private System.Windows.Forms.Button sleep;
        private System.Windows.Forms.Button dark;
        private System.Windows.Forms.Button gaming;
        private System.Windows.Forms.Button reading;
        private System.Windows.Forms.Button healthy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label display;
    }
}

