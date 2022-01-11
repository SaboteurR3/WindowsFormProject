using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class ImageSlider : Form
    {
        public ImageSlider()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            imageNumber++;
            if (imageNumber == 7)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);                    
        }
        private void LoadPreviouseImage()
        {
            imageNumber--;
            if (imageNumber < 1)
            {
                imageNumber = 6;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);          
        }
        private void ImageSliderTimer_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            int v = (trackBar1.Maximum - trackBar1.Value) + 5;
            ImageSliderTimer.Interval = v;
        }
        private void PreviouseClick_Click(object sender, EventArgs e)
        {
            LoadPreviouseImage();
        }
        private void NextClick_Click_Click(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }
    }
}