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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.sideBarPanel = new Project_4.GradientSideBarPanel();
            this.sportsBtn = new System.Windows.Forms.Button();
            this.festivalsBtn = new System.Windows.Forms.Button();
            this.educationBtn = new System.Windows.Forms.Button();
            this.danceBtn = new System.Windows.Forms.Button();
            this.theaterBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.homepagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepagePanel
            // 
            this.homepagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.homepagePanel.Controls.Add(this.MainPanel);
            this.homepagePanel.Controls.Add(this.logo);
            this.homepagePanel.Controls.Add(this.textBox1);
            this.homepagePanel.Controls.Add(this.button8);
            this.homepagePanel.Controls.Add(this.button7);
            this.homepagePanel.Location = new System.Drawing.Point(0, 0);
            this.homepagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homepagePanel.Name = "homepagePanel";
            this.homepagePanel.Size = new System.Drawing.Size(1520, 61);
            this.homepagePanel.TabIndex = 2;
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
            this.MainPanel.Location = new System.Drawing.Point(64, 59);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1456, 778);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.logo.Location = new System.Drawing.Point(25, -19);
            this.logo.Name = "pictureBox1";
            this.logo.Size = new System.Drawing.Size(271, 80);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.sideBarPanel.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.sideBarPanel.Controls.Add(this.sportsBtn);
            this.sideBarPanel.Controls.Add(this.festivalsBtn);
            this.sideBarPanel.Controls.Add(this.educationBtn);
            this.sideBarPanel.Controls.Add(this.danceBtn);
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
            // sportsBtn
            // 
            this.sportsBtn.BackColor = System.Drawing.Color.Transparent;
            this.sportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sportsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sportsBtn.Image = ((System.Drawing.Image)(resources.GetObject("sportsBtn.Image")));
            this.sportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sportsBtn.Location = new System.Drawing.Point(0, 384);
            this.sportsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sportsBtn.Name = "sportsBtn";
            this.sportsBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.sportsBtn.Size = new System.Drawing.Size(300, 64);
            this.sportsBtn.TabIndex = 6;
            this.sportsBtn.Text = "Αθλήματα";
            this.sportsBtn.UseVisualStyleBackColor = false;
            // 
            // festivalsBtn
            // 
            this.festivalsBtn.BackColor = System.Drawing.Color.Transparent;
            this.festivalsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.festivalsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.festivalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.festivalsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.festivalsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.festivalsBtn.Image = ((System.Drawing.Image)(resources.GetObject("festivalsBtn.Image")));
            this.festivalsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.festivalsBtn.Location = new System.Drawing.Point(0, 320);
            this.festivalsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.festivalsBtn.Name = "festivalsBtn";
            this.festivalsBtn.Size = new System.Drawing.Size(300, 64);
            this.festivalsBtn.TabIndex = 5;
            this.festivalsBtn.Text = "Festivals";
            this.festivalsBtn.UseVisualStyleBackColor = false;
            this.festivalsBtn.Click += new System.EventHandler(this.festivalsBtn_Click);
            // 
            // educationBtn
            // 
            this.educationBtn.BackColor = System.Drawing.Color.Transparent;
            this.educationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.educationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.educationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.educationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.educationBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.educationBtn.Image = ((System.Drawing.Image)(resources.GetObject("educationBtn.Image")));
            this.educationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.educationBtn.Location = new System.Drawing.Point(0, 256);
            this.educationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.educationBtn.Name = "educationBtn";
            this.educationBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.educationBtn.Size = new System.Drawing.Size(300, 64);
            this.educationBtn.TabIndex = 4;
            this.educationBtn.Text = "Εκπαίδευση";
            this.educationBtn.UseVisualStyleBackColor = false;
            // 
            // danceBtn
            // 
            this.danceBtn.BackColor = System.Drawing.Color.Transparent;
            this.danceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.danceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.danceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.danceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.danceBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.danceBtn.Image = ((System.Drawing.Image)(resources.GetObject("danceBtn.Image")));
            this.danceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.danceBtn.Location = new System.Drawing.Point(0, 192);
            this.danceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.danceBtn.Name = "danceBtn";
            this.danceBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.danceBtn.Size = new System.Drawing.Size(300, 64);
            this.danceBtn.TabIndex = 3;
            this.danceBtn.Text = "Χορός";
            this.danceBtn.UseVisualStyleBackColor = false;
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
            this.theaterBtn.Location = new System.Drawing.Point(0, 128);
            this.theaterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.theaterBtn.Name = "theaterBtn";
            this.theaterBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.theaterBtn.Size = new System.Drawing.Size(300, 64);
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
            this.musicBtn.Location = new System.Drawing.Point(0, 64);
            this.musicBtn.Margin = new System.Windows.Forms.Padding(2);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.musicBtn.Size = new System.Drawing.Size(300, 64);
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
            this.menuBtn.Size = new System.Drawing.Size(300, 64);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1520, 839);
            this.Controls.Add(this.homepagePanel);
            this.Controls.Add(this.sideBarPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Envent";
            this.Text = "Envent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.homepagePanel.ResumeLayout(false);
            this.homepagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.sideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientSideBarPanel sideBarPanel;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel homepagePanel;
        private System.Windows.Forms.Button theaterBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button festivalsBtn;
        private System.Windows.Forms.Button educationBtn;
        private System.Windows.Forms.Button danceBtn;
        private System.Windows.Forms.Button sportsBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox logo;
    }
}

