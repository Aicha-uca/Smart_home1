using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Smart_home1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        MySqlConnection conx = new MySqlConnection("SERVER=localhost; DATABASE=smart_home; UID=root; PASSWORD=");


        public void Login()
        {
            String query = "SELECT * from login where username= '" + txt_username.Text + "' and password='" + txt_password.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(query, conx);
            DataTable dataTable = new DataTable();
            cmd.CommandTimeout = 60;
            MySqlDataReader reader;
            try {
                conx.Open();
                reader = cmd.ExecuteReader();
                if(reader.HasRows){
                    while (reader.Read())
                    {
                                          }
                Home form2 = new Home();
                form2.Show();
                this.Hide();
                }
                else
                {
                  MessageBox.Show("Invalid login details", "Error");
                }
                conx.Close();
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            }
        




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
