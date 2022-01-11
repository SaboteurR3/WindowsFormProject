
namespace Task4
{
    partial class ImageSlider
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageSlider));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageSliderTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SlideShowSpeed = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.NextClick_Click = new System.Windows.Forms.Button();
            this.PreviouseClick = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ImageSliderTimer
            // 
            this.ImageSliderTimer.Enabled = true;
            this.ImageSliderTimer.Interval = 7000;
            this.ImageSliderTimer.Tick += new System.EventHandler(this.ImageSliderTimer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(-1, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(-1, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "Contact us";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SlideShowSpeed
            // 
            this.SlideShowSpeed.AutoSize = true;
            this.SlideShowSpeed.BackColor = System.Drawing.Color.Teal;
            this.SlideShowSpeed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SlideShowSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SlideShowSpeed.Location = new System.Drawing.Point(36, 306);
            this.SlideShowSpeed.Name = "SlideShowSpeed";
            this.SlideShowSpeed.Size = new System.Drawing.Size(154, 25);
            this.SlideShowSpeed.TabIndex = 10;
            this.SlideShowSpeed.Text = "ImageSliderSpeed";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(-1, 361);
            this.trackBar1.Maximum = 7000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(215, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "MyProject";
            // 
            // Panel
            // 
            this.Panel.AccessibleName = "Panel";
            this.Panel.Controls.Add(this.NextClick_Click);
            this.Panel.Controls.Add(this.PreviouseClick);
            this.Panel.Controls.Add(this.pictureBox1);
            this.Panel.Location = new System.Drawing.Point(220, -1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(799, 495);
            this.Panel.TabIndex = 2;
            // 
            // NextClick_Click
            // 
            this.NextClick_Click.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NextClick_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextClick_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextClick_Click.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NextClick_Click.Image = ((System.Drawing.Image)(resources.GetObject("NextClick_Click.Image")));
            this.NextClick_Click.Location = new System.Drawing.Point(768, 218);
            this.NextClick_Click.Name = "NextClick_Click";
            this.NextClick_Click.Size = new System.Drawing.Size(31, 52);
            this.NextClick_Click.TabIndex = 2;
            this.NextClick_Click.UseVisualStyleBackColor = false;
            this.NextClick_Click.Click += new System.EventHandler(this.NextClick_Click_Click);
            // 
            // PreviouseClick
            // 
            this.PreviouseClick.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PreviouseClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviouseClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviouseClick.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PreviouseClick.Image = ((System.Drawing.Image)(resources.GetObject("PreviouseClick.Image")));
            this.PreviouseClick.Location = new System.Drawing.Point(0, 218);
            this.PreviouseClick.Name = "PreviouseClick";
            this.PreviouseClick.Size = new System.Drawing.Size(31, 52);
            this.PreviouseClick.TabIndex = 1;
            this.PreviouseClick.UseVisualStyleBackColor = false;
            this.PreviouseClick.Click += new System.EventHandler(this.PreviouseClick_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 428);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(86, 428);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(158, 428);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // ImageSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1019, 494);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SlideShowSpeed);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1039, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1039, 537);
            this.Name = "ImageSlider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageSlider";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer ImageSliderTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label SlideShowSpeed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button PreviouseClick;
        private System.Windows.Forms.Button NextClick_Click;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

