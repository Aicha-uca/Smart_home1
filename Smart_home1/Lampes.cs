using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_home1
{
    public partial class lampes : Form
    {
        public lampes()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aicha\source\repos\Smart-Home1\Smart Home\Images\light_off.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Refresh();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aicha\source\repos\Smart-Home1\Smart Home\Images\light_on.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Refresh();
        }
    }
}
