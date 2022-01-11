using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Contact : Form
    {
        Dictionary<TextBox, Label> TextBox_Label_Pair;
        private readonly Color defaultcolor;
        public Contact()
        {
            InitializeComponent();
            TextBox_Label_Pair = new Dictionary<TextBox, Label>
            {
                [NametextBox] = Namelabel,
                [emailtextBox] = emaillabel,
                [TextBox] = TextLabel
            };
            defaultcolor = NametextBox.ForeColor;
        }
        bool ChackEmail()
        {
            bool email = emailtextBox.Text.Contains("@");
            incorrectEmaillabel.Visible = !email;
            return email;
        }
        private bool ValidPair(KeyValuePair<TextBox, Label> pair)
        {
            var textbox = pair.Key;
            var label = pair.Value;
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                label.ForeColor = Color.Maroon;
                return false;
            }
            else
            {
                label.ForeColor = defaultcolor;
                return true;
            }
        }
        private bool ValidateUser()
        {
            bool valid = true;
            foreach (var item in TextBox_Label_Pair)
            {
                valid = ValidPair(item) && valid;
            }
            return valid;
        }
        private void TextBoxChanged(object sender, EventArgs e)
        {
            var pair = TextBox_Label_Pair.FirstOrDefault(p => p.Key.Equals(sender));
            ValidPair(pair);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Contact.ActiveForm.Dispose();
        }
        private void registrationButton_Click_1(object sender, EventArgs e)
        {
            if (ValidateUser() && ChackEmail())
            {
                MessageBox.Show("Your information has been submitted successfully");       
                StreamWriter send = new StreamWriter(Application.StartupPath + "\\SavedInfo\\" + "Clients.txt");
                send.WriteLine(Namelabel.Text + ": " + NametextBox.Text);
                send.WriteLine(emaillabel.Text + ": " + emailtextBox.Text);
                send.WriteLine(TextLabel.Text + ": " + TextBox.Text); 
                send.Close();
                Contact.ActiveForm.Dispose();
            }
        }
    }
}