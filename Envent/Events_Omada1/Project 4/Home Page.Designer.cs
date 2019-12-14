namespace Project_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homepagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.sideBarPanel = new Project_4.GradientSideBarPanel();
            this.sportsSubMenu = new System.Windows.Forms.Panel();
            this.basketBtn = new System.Windows.Forms.Button();
            this.footballBtn = new System.Windows.Forms.Button();
            this.sportsBtn = new System.Windows.Forms.Button();
            this.festivalsBtn = new System.Windows.Forms.Button();
            this.conferenceSubMenu = new System.Windows.Forms.Panel();
            this.newsButton = new System.Windows.Forms.Button();
            this.educationBtn = new System.Windows.Forms.Button();
            this.conferencesBtn = new System.Windows.Forms.Button();
            this.theaterBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.homepagePanel.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.sportsSubMenu.SuspendLayout();
            this.conferenceSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepagePanel
            // 
            this.homepagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.homepagePanel.Controls.Add(this.panel2);
            this.homepagePanel.Controls.Add(this.textBox1);
            this.homepagePanel.Controls.Add(this.button8);
            this.homepagePanel.Controls.Add(this.button7);
            this.homepagePanel.Location = new System.Drawing.Point(0, 0);
            this.homepagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homepagePanel.Name = "homepagePanel";
            this.homepagePanel.Size = new System.Drawing.Size(1520, 61);
            this.homepagePanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(28, -21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 82);
            this.panel2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(467, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MinimumSize = new System.Drawing.Size(376, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 44);
            this.textBox1.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(1223, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 61);
            this.button8.TabIndex = 1;
            this.button8.Text = "LOGIN";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(1349, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 61);
            this.button7.TabIndex = 0;
            this.button7.Text = "SIGNUP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(319, 65);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1190, 763);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.sideBarPanel.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.sideBarPanel.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.sideBarPanel.Controls.Add(this.sportsSubMenu);
            this.sideBarPanel.Controls.Add(this.sportsBtn);
            this.sideBarPanel.Controls.Add(this.festivalsBtn);
            this.sideBarPanel.Controls.Add(this.conferenceSubMenu);
            this.sideBarPanel.Controls.Add(this.conferencesBtn);
            this.sideBarPanel.Controls.Add(this.theaterBtn);
            this.sideBarPanel.Controls.Add(this.musicBtn);
            this.sideBarPanel.Controls.Add(this.menuBtn);
            this.sideBarPanel.Location = new System.Drawing.Point(-1, 61);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(300, 778);
            this.sideBarPanel.TabIndex = 1;
            this.sideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // sportsSubMenu
            // 
            this.sportsSubMenu.Controls.Add(this.basketBtn);
            this.sportsSubMenu.Controls.Add(this.footballBtn);
            this.sportsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.sportsSubMenu.Location = new System.Drawing.Point(0, 446);
            this.sportsSubMenu.Name = "sportsSubMenu";
            this.sportsSubMenu.Size = new System.Drawing.Size(300, 80);
            this.sportsSubMenu.TabIndex = 10;
            // 
            // basketBtn
            // 
            this.basketBtn.BackColor = System.Drawing.Color.Transparent;
            this.basketBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.basketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.basketBtn.Location = new System.Drawing.Point(0, 40);
            this.basketBtn.Name = "basketBtn";
            this.basketBtn.Size = new System.Drawing.Size(300, 40);
            this.basketBtn.TabIndex = 1;
            this.basketBtn.Text = "Basket";
            this.basketBtn.UseVisualStyleBackColor = false;
            // 
            // footballBtn
            // 
            this.footballBtn.BackColor = System.Drawing.Color.Transparent;
            this.footballBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.footballBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.footballBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.footballBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.footballBtn.Location = new System.Drawing.Point(0, 0);
            this.footballBtn.Name = "footballBtn";
            this.footballBtn.Size = new System.Drawing.Size(300, 40);
            this.footballBtn.TabIndex = 0;
            this.footballBtn.Text = "Ποδόσφαιρο";
            this.footballBtn.UseVisualStyleBackColor = false;
            // 
            // sportsBtn
            // 
            this.sportsBtn.BackColor = System.Drawing.Color.Transparent;
            this.sportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sportsBtn.ForeColor = System.Drawing.Color.White;
            this.sportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("sportsBtn.Image")));
            this.sportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sportsBtn.Location = new System.Drawing.Point(0, 385);
            this.sportsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sportsBtn.Name = "sportsBtn";
            this.sportsBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sportsBtn.Size = new System.Drawing.Size(300, 61);
            this.sportsBtn.TabIndex = 9;
            this.sportsBtn.Text = "Αθλήματα";
            this.sportsBtn.UseVisualStyleBackColor = false;
            this.sportsBtn.Click += new System.EventHandler(this.sportsBtn_Click);
            this.sportsBtn.MouseEnter += new System.EventHandler(this.sportsBtn_MouseEnter);
            // 
            // festivalsBtn
            // 
            this.festivalsBtn.BackColor = System.Drawing.Color.Transparent;
            this.festivalsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.festivalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.festivalsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.festivalsBtn.ForeColor = System.Drawing.Color.White;
            this.festivalsBtn.Image = ((System.Drawing.Image)(resources.GetObject("festivalsBtn.Image")));
            this.festivalsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.festivalsBtn.Location = new System.Drawing.Point(0, 324);
            this.festivalsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.festivalsBtn.Name = "festivalsBtn";
            this.festivalsBtn.Size = new System.Drawing.Size(300, 61);
            this.festivalsBtn.TabIndex = 8;
            this.festivalsBtn.Text = "Festivals";
            this.festivalsBtn.UseVisualStyleBackColor = false;
            // 
            // conferenceSubMenu
            // 
            this.conferenceSubMenu.BackColor = System.Drawing.SystemColors.Control;
            this.conferenceSubMenu.Controls.Add(this.newsButton);
            this.conferenceSubMenu.Controls.Add(this.educationBtn);
            this.conferenceSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.conferenceSubMenu.Location = new System.Drawing.Point(0, 244);
            this.conferenceSubMenu.Name = "conferenceSubMenu";
            this.conferenceSubMenu.Size = new System.Drawing.Size(300, 80);
            this.conferenceSubMenu.TabIndex = 7;
            // 
            // newsButton
            // 
            this.newsButton.BackColor = System.Drawing.Color.Transparent;
            this.newsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newsButton.Location = new System.Drawing.Point(0, 40);
            this.newsButton.Name = "newsButton";
            this.newsButton.Size = new System.Drawing.Size(300, 40);
            this.newsButton.TabIndex = 2;
            this.newsButton.Text = "Ενημερωτικά";
            this.newsButton.UseVisualStyleBackColor = false;
            this.newsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // educationBtn
            // 
            this.educationBtn.BackColor = System.Drawing.Color.Transparent;
            this.educationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.educationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.educationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.educationBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.educationBtn.Location = new System.Drawing.Point(0, 0);
            this.educationBtn.Name = "educationBtn";
            this.educationBtn.Size = new System.Drawing.Size(300, 40);
            this.educationBtn.TabIndex = 0;
            this.educationBtn.Text = "Εκπαίδευση";
            this.educationBtn.UseVisualStyleBackColor = false;
            this.educationBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // conferencesBtn
            // 
            this.conferencesBtn.BackColor = System.Drawing.Color.Transparent;
            this.conferencesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.conferencesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.conferencesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.conferencesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.conferencesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.conferencesBtn.Image = ((System.Drawing.Image)(resources.GetObject("conferencesBtn.Image")));
            this.conferencesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conferencesBtn.Location = new System.Drawing.Point(0, 183);
            this.conferencesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.conferencesBtn.Name = "conferencesBtn";
            this.conferencesBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.conferencesBtn.Size = new System.Drawing.Size(300, 61);
            this.conferencesBtn.TabIndex = 4;
            this.conferencesBtn.Text = "Συνέδρια";
            this.conferencesBtn.UseVisualStyleBackColor = false;
            this.conferencesBtn.MouseEnter += new System.EventHandler(this.conferencesBtn_MouseEnter);
            // 
            // theaterBtn
            // 
            this.theaterBtn.BackColor = System.Drawing.Color.Transparent;
            this.theaterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.theaterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.theaterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.theaterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.theaterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.theaterBtn.Image = ((System.Drawing.Image)(resources.GetObject("theaterBtn.Image")));
            this.theaterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.theaterBtn.Location = new System.Drawing.Point(0, 122);
            this.theaterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.theaterBtn.Name = "theaterBtn";
            this.theaterBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.theaterBtn.Size = new System.Drawing.Size(300, 61);
            this.theaterBtn.TabIndex = 2;
            this.theaterBtn.Text = "Θέατρο";
            this.theaterBtn.UseVisualStyleBackColor = false;
            // 
            // musicBtn
            // 
            this.musicBtn.BackColor = System.Drawing.Color.Transparent;
            this.musicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.musicBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.musicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.musicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.musicBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.musicBtn.Image = ((System.Drawing.Image)(resources.GetObject("musicBtn.Image")));
            this.musicBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musicBtn.Location = new System.Drawing.Point(0, 61);
            this.musicBtn.Margin = new System.Windows.Forms.Padding(2);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.musicBtn.Size = new System.Drawing.Size(300, 61);
            this.musicBtn.TabIndex = 1;
            this.musicBtn.Text = "Μουσική";
            this.musicBtn.UseVisualStyleBackColor = false;
            this.musicBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.menuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Location = new System.Drawing.Point(0, 0);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.menuBtn.Size = new System.Drawing.Size(300, 61);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1520, 839);
            this.Controls.Add(this.homepagePanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.homepagePanel.ResumeLayout(false);
            this.homepagePanel.PerformLayout();
            this.sideBarPanel.ResumeLayout(false);
            this.sportsSubMenu.ResumeLayout(false);
            this.conferenceSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientSideBarPanel sideBarPanel;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel homepagePanel;
        private System.Windows.Forms.Button theaterBtn;
        private System.Windows.Forms.Button conferencesBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel conferenceSubMenu;
        private System.Windows.Forms.Button festivalsBtn;
        private System.Windows.Forms.Button sportsBtn;
        private System.Windows.Forms.Button educationBtn;
        private System.Windows.Forms.Button newsButton;
        private System.Windows.Forms.Panel sportsSubMenu;
        private System.Windows.Forms.Button basketBtn;
        private System.Windows.Forms.Button footballBtn;
        private System.Windows.Forms.Button musicBtn;
    }
}

