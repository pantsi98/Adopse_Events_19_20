using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        HomeMain hm = new HomeMain();
        
        public Form1()
        {
            InitializeComponent();
            conferenceSubMenu.BackColor = Color.FromArgb(193, 200, 228);
            sportsSubMenu.BackColor = Color.FromArgb(193, 200, 228);
            hideSubmenus();
            MainPanel.Controls.Clear();
            HomeMain su = new HomeMain();
            MainPanel.Controls.Add(su);
            cCircularButton1.Visible = false;
        }

        private void Splash_Animation()
        {
            Splash_Animation sa = new Splash_Animation();
            sa.SetDesktopLocation(500, 500);
            Application.Run(new Splash_Animation());
        }

        private void hideSubmenus()
        {
            conferenceSubMenu.Visible = false;
            sportsSubMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(hm);
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
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
            if (button8.Text == "LOGIN")
            {
                MainPanel.Controls.Clear();
                LogIn su = new LogIn();
                MainPanel.Controls.Add(su);
            }
            else if (button8.Text == "LOGOUT")
            {
                InstanceOfUser.LogOut();
                button8.Text = "LOGIN";
                button7.Visible = true;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(hm);
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void festivalsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccfestivals);
        }

        private void educationBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(scceducation);
        }

        private void sportsBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccsports);
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
            User x = InstanceOfUser.GetUser();
            if (x is Project_4.App_Code.NormalUser) {
                MainPanel.Controls.Clear();
                ProfileControl su = new ProfileControl();
                MainPanel.Controls.Add(su); }
            else
            {
                MainPanel.Controls.Clear();
                ProfileEventManager su = new ProfileEventManager();
                MainPanel.Controls.Add(su);

            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(hm);

            }
            else if (!string.IsNullOrEmpty(searchTextBox.Text) && MainPanel.Controls.Count == 0)
            {

                foreach (Control item in sccsearch.Controls)
                {
                    System.Diagnostics.Trace.WriteLine(item.GetType().ToString());
                }

                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(sccsearch);
            }
            else if (!string.IsNullOrEmpty(searchTextBox.Text) && MainPanel.Controls.Count > 0)
            {
                foreach (Control item in sccsearch.Controls)
                {
                    if (item.GetType() == typeof(Label))
                    {
                        item.Text = searchTextBox.Text;
                    }
                }
                sccsearch.tileLabel1.Text = searchTextBox.Text;

                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(sccsearch);
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void searchTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new HomeMain());

            }
            else if (!string.IsNullOrEmpty(searchTextBox.Text) && MainPanel.Controls.Count == 0)
            {
                
                foreach (Control item in sccsearch.Controls)
                {
                    System.Diagnostics.Trace.WriteLine(item.GetType().ToString());
                }

                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(sccsearch);
            }
            else if (!string.IsNullOrEmpty(searchTextBox.Text) && MainPanel.Controls.Count > 0)
            {
                foreach (Control item in sccsearch.Controls)
                {
                    if (item.GetType() == typeof(Label))
                    {
                        item.Text = searchTextBox.Text;
                    }
                }
                sccsearch.tileLabel1.Text = searchTextBox.Text;

                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(sccsearch);
            }
        }

        private void newsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccinforming);
        }

        private void musicBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccmusic);
        }

        private void theaterBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(scctheater);
        }

        private void conferencesBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccconferences);
        }

        private void footballBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccsoccer);
        }

        private void basketBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(sccbasket);
        }

        private void cinemaBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(scccinema);
        }
    }
}
