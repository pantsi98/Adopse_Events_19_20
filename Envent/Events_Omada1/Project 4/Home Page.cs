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
using Project_4.App_Code;
using Project_4.App_Code.StaticMethods;
using Project_4.User_Classes;

namespace Project_4
{
    public partial class Form1 : Form
    {
        public List<string> btntxtList = new List<string>() {"Αθλήματα", "Festivals","Συνέδρια", "Θέατρο","Μουσική","Menu"};
        public int index = 0;
        SearchCategoriesControl sccsearch = new SearchCategoriesControl();
        SearchCategoriesControl sccmusic = new SearchCategoriesControl(1);
        SearchCategoriesControl scctheater = new SearchCategoriesControl(2);
        SearchCategoriesControl sccconferences = new SearchCategoriesControl(3);
        SearchCategoriesControl scceducation = new SearchCategoriesControl(6);
        SearchCategoriesControl sccinforming = new SearchCategoriesControl(7);
        SearchCategoriesControl sccfestivals = new SearchCategoriesControl(4);
        SearchCategoriesControl sccsports = new SearchCategoriesControl(5);
        SearchCategoriesControl sccsoccer = new SearchCategoriesControl(8);
        SearchCategoriesControl sccbasket = new SearchCategoriesControl(9);
        SearchCategoriesControl scccinema = new SearchCategoriesControl(10);
        HomeMain hm1 = new HomeMain();
        HomeMain hm2 = new HomeMain();
        public Form1()
        {
            InitializeComponent();
            conferenceSubMenu.BackColor = Color.FromArgb(193, 200, 228);
            sportsSubMenu.BackColor = Color.FromArgb(193, 200, 228);
            hideSubmenus();
        }

        private void hideSubmenus()
        {
            conferenceSubMenu.Visible = false;
            sportsSubMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            HomeMain hm = new HomeMain();
            MainPanel.Controls.Add(hm);
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
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(scceducation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void festivalsBtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void educationBtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccinforming);
        }

        private void sportsBtn_Click(object sender, EventArgs e)
        {

        }
        private void conferencesBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sideBarPanel.Width == 300)
            {
                conferenceSubMenu.Visible = true;
                sportsSubMenu.Visible = false;
            }
        }

        private void sportsBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sideBarPanel.Width == 300)
            {
                sportsSubMenu.Visible = true;
                conferenceSubMenu.Visible = false;
            }
        }

        private void cCircularButton1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccsoccer);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccbasket);
        }
    }
}
