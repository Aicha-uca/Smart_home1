using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smart_home1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ComboBox_Load();
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
            Climas c = new Climas();
            c.Show();
            this.Hide();
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

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            
        }
    


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TV_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
           
                
        }
        private void ComboBox_Load()
        {
            List<Zone> list;
            list = new List<Zone>();
            try
            {
                string sql = "datasource=localhost;port=3306;username=root;password=;database=smart8home";
                MySqlConnection conn = new MySqlConnection(sql);

                string selectQuery = "SELECT * FROM zone";
                conn.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Zone(Int32.Parse(reader.GetString("id")), reader.GetString("libelle")));
                    comboBox1.Items.Add(reader.GetString("libelle"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lampe_Click(object sender, EventArgs e)
        {
            lampes l = new lampes();
            l.Show();
            this.Hide();
        }
    }
    }

