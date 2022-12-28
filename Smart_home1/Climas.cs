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
    public partial class Climas : Form
    {
        public Climas()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aicha\source\repos\Smart-Home1\Smart Home\Images\cordinator_on.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aicha\source\repos\Smart-Home1\Smart Home\Images\cordinator_off.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Refresh();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            Home form2 = new Home();
            form2.Show();
            this.Hide();
        }
    }
}
