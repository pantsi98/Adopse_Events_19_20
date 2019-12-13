namespace Project_4
{
    partial class ProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.circularPicture1 = new Project_4.App_Code.circularPicture();
            this.circularPicture2 = new Project_4.App_Code.circularPicture();
            this.circularPicture3 = new Project_4.App_Code.circularPicture();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserButon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 63);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Προφίλ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularPicture1
            // 
            this.circularPicture1.BackColor = System.Drawing.Color.Transparent;
            this.circularPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circularPicture1.Image = global::Project_4.Properties.Resources.userProfile;
            this.circularPicture1.Location = new System.Drawing.Point(491, 26);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(150, 150);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture1.TabIndex = 32;
            this.circularPicture1.TabStop = false;
            // 
            // circularPicture2
            // 
            this.circularPicture2.BackColor = System.Drawing.Color.Transparent;
            this.circularPicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circularPicture2.Image = global::Project_4.Properties.Resources.facebook;
            this.circularPicture2.Location = new System.Drawing.Point(9, 682);
            this.circularPicture2.Name = "circularPicture2";
            this.circularPicture2.Size = new System.Drawing.Size(50, 50);
            this.circularPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture2.TabIndex = 33;
            this.circularPicture2.TabStop = false;
            // 
            // circularPicture3
            // 
            this.circularPicture3.BackColor = System.Drawing.Color.Transparent;
            this.circularPicture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circularPicture3.Image = global::Project_4.Properties.Resources.gmail;
            this.circularPicture3.Location = new System.Drawing.Point(65, 682);
            this.circularPicture3.Name = "circularPicture3";
            this.circularPicture3.Size = new System.Drawing.Size(80, 50);
            this.circularPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture3.TabIndex = 34;
            this.circularPicture3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(200, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 1);
            this.panel2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(489, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "UserName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserButon
            // 
            this.UserButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.UserButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.UserButon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserButon.Location = new System.Drawing.Point(200, 109);
            this.UserButon.Name = "UserButon";
            this.UserButon.Size = new System.Drawing.Size(202, 50);
            this.UserButon.TabIndex = 37;
            this.UserButon.Text = "Επεξεργασία";
            this.UserButon.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(748, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 50);
            this.button2.TabIndex = 39;
            this.button2.Text = "Ιστορικό";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.circularPicture3);
            this.Controls.Add(this.circularPicture2);
            this.Controls.Add(this.circularPicture1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1131, 745);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private App_Code.circularPicture circularPicture1;
        private App_Code.circularPicture circularPicture2;
        private App_Code.circularPicture circularPicture3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserButon;
        private System.Windows.Forms.Button button2;
    }
}
