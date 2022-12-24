using Guna.UI2.WinForms;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pictureBox2.AllowDrop = true;
            pictureBox1.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            bathroomlabel.Visible = false;
            kitchenlabel.Visible = false;
            bedroomlabel.Visible = false;
            balconylabel.Visible = false;
            bathroom2label.Visible = false;
            livinglabel.Visible = false;

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            
            
        }

        private void clima_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void guna2PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((Guna2PictureBox)sender).DoDragDrop(((Guna2PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            bathroomlabel.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;    
            }
        }

        private void pictureBox2_DragLeave(object sender, EventArgs e)
        {
            bathroomlabel.Visible = false;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            bathroomlabel.Visible = true;
            Image getPicture = (Bitmap) e.Data.GetData(DataFormats.Bitmap);
            pictureBox2.Image = getPicture;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            livinglabel.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox1_DragLeave(object sender, EventArgs e)
        {
            livinglabel.Visible = false;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            livinglabel.Visible = true;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox1.Image = getPicture;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.DoDragDrop(pictureBox6.Image, DragDropEffects.Copy);
        }

        private void pictureBox6_DragEnter(object sender, DragEventArgs e)
        {
            balconylabel.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox6_DragLeave(object sender, EventArgs e)
        {
            balconylabel.Visible = false;
        }

        private void pictureBox6_DragDrop(object sender, DragEventArgs e)
        {
            balconylabel.Visible = true;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox6.Image = getPicture;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.DoDragDrop(pictureBox5.Image, DragDropEffects.Copy);
        }

        private void pictureBox5_DragEnter(object sender, DragEventArgs e)
        {
            bedroomlabel.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox5_DragLeave(object sender, EventArgs e)
        {
            bedroomlabel.Visible = false;
        }

        private void pictureBox5_DragDrop(object sender, DragEventArgs e)
        {
            bedroomlabel.Visible = true;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox5.Image = getPicture;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.DoDragDrop(pictureBox3.Image, DragDropEffects.Copy);
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            bathroom2label.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox3_DragLeave(object sender, EventArgs e)
        {
            bathroom2label.Visible = false;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            bathroom2label.Visible = true;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox3.Image = getPicture;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.DoDragDrop(pictureBox4.Image, DragDropEffects.Copy);
        }

        private void pictureBox4_DragEnter(object sender, DragEventArgs e)
        {
            kitchenlabel.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox4_DragLeave(object sender, EventArgs e)
        {
            kitchenlabel.Visible = false;
        }

        private void pictureBox4_DragDrop(object sender, DragEventArgs e)
        {
            kitchenlabel.Visible = true;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox4.Image = getPicture;
        }

        
    }
}
