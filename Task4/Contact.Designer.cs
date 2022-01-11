
namespace Task4
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.incorrectEmaillabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(88, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 53);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(88, 135);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(533, 23);
            this.NametextBox.TabIndex = 2;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(88, 194);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(533, 23);
            this.emailtextBox.TabIndex = 2;
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Teal;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.ForeColor = System.Drawing.Color.Honeydew;
            this.registrationButton.Location = new System.Drawing.Point(88, 329);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(533, 42);
            this.registrationButton.TabIndex = 5;
            this.registrationButton.Text = "Submit";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click_1);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Namelabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Namelabel.Location = new System.Drawing.Point(88, 111);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(53, 21);
            this.Namelabel.TabIndex = 6;
            this.Namelabel.Text = "Name";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.emaillabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.emaillabel.Location = new System.Drawing.Point(88, 170);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(49, 21);
            this.emaillabel.TabIndex = 6;
            this.emaillabel.Text = "Email";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TextLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextLabel.Location = new System.Drawing.Point(88, 229);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(38, 21);
            this.TextLabel.TabIndex = 6;
            this.TextLabel.Text = "Text";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(88, 253);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(533, 57);
            this.TextBox.TabIndex = 7;
            // 
            // incorrectEmaillabel
            // 
            this.incorrectEmaillabel.AutoSize = true;
            this.incorrectEmaillabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.incorrectEmaillabel.ForeColor = System.Drawing.Color.Maroon;
            this.incorrectEmaillabel.Location = new System.Drawing.Point(178, 170);
            this.incorrectEmaillabel.Name = "incorrectEmaillabel";
            this.incorrectEmaillabel.Size = new System.Drawing.Size(123, 21);
            this.incorrectEmaillabel.TabIndex = 8;
            this.incorrectEmaillabel.Text = "incorrect format";
            this.incorrectEmaillabel.Visible = false;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.incorrectEmaillabel);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label incorrectEmaillabel;
    }
}