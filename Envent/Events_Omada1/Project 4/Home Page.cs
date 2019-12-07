using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string cs = @"server=35.228.3.69;userid=root;password=l7heDyE6lxs7CN7o;database=enventDb";

          var con = new MySqlConnection(cs);
          con.Open();

            var stm = "SELECT * FROM category";
            var cmd = new MySqlCommand(stm, con);

            string version = cmd.ExecuteScalar().ToString();
            label1.Text = version;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            SignUpstep1 su = new SignUpstep1();
            MainPanel.Controls.Add(su);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            LogIn su = new LogIn();
            MainPanel.Controls.Add(su);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
