namespace Project_4
{
    partial class Resetpassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resetparcode = new System.Windows.Forms.TextBox();
            this.ChangePassBtn = new System.Windows.Forms.Button();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 63);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(386, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Βρείτε το λογαριασμό σας";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(293, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Γράψτε τον κωδικό ασφαλείας.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(29, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 1);
            this.panel2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Είσάγεται τον κωδικό που έχετε λάβει στο email σας.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Στείλαμε τον κωδικό σας εδώ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "email@gmail.com";
            // 
            // resetparcode
            // 
            this.resetparcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resetparcode.ForeColor = System.Drawing.Color.Gray;
            this.resetparcode.Location = new System.Drawing.Point(29, 95);
            this.resetparcode.Name = "resetparcode";
            this.resetparcode.Size = new System.Drawing.Size(334, 28);
            this.resetparcode.TabIndex = 40;
            this.resetparcode.Text = "Κωδικός επαναφοράς";
            this.resetparcode.Click += new System.EventHandler(this.resetparcode_Click);
            this.resetparcode.TextChanged += new System.EventHandler(this.resetparcode_TextChanged);
            this.resetparcode.Leave += new System.EventHandler(this.resetparcode_Leave);
            // 
            // ChangePassBtn
            // 
            this.ChangePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.ChangePassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ChangePassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangePassBtn.Location = new System.Drawing.Point(562, 220);
            this.ChangePassBtn.Name = "ChangePassBtn";
            this.ChangePassBtn.Size = new System.Drawing.Size(216, 44);
            this.ChangePassBtn.TabIndex = 41;
            this.ChangePassBtn.Text = "Αποθήκευση αλλαγών";
            this.ChangePassBtn.UseVisualStyleBackColor = false;
            this.ChangePassBtn.Click += new System.EventHandler(this.ChangePassBtn_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NewPassword.ForeColor = System.Drawing.Color.Gray;
            this.NewPassword.Location = new System.Drawing.Point(29, 220);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(334, 28);
            this.NewPassword.TabIndex = 43;
            this.NewPassword.Text = "Νέος κωδικός ";
            this.NewPassword.Click += new System.EventHandler(this.NewPassword_Click);
            this.NewPassword.Leave += new System.EventHandler(this.NewPassword_Leave);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 34);
            this.label6.TabIndex = 44;
            this.label6.Text = "Δημιουργήστε ένα νέο κωδικό πρόσβασης με τουλάχιστον 8 χαρακτήρες, ένα κεφαλαίο γ" +
    "ράμμα, ένα μικρό και έναν αριθμό .";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.ForeColor = System.Drawing.Color.Red;
            this.passwordlabel.Location = new System.Drawing.Point(253, 98);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(626, 17);
            this.passwordlabel.TabIndex = 45;
            this.passwordlabel.Text = "Ο κωδικός πρέπει να περιέχει τουλάχιστον 8 χαρακτήρες , κεφαλαιο και μικρό γράμμα" +
    " και νούμερο.";
            this.passwordlabel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.ChangePassBtn);
            this.panel3.Controls.Add(this.NewPassword);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.resetparcode);
            this.panel3.Location = new System.Drawing.Point(135, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 451);
            this.panel3.TabIndex = 46;
            this.panel3.MouseHover += new System.EventHandler(this.panel3_MouseHover);
            // 
            // Resetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.panel1);
            this.Name = "Resetpassword";
            this.Size = new System.Drawing.Size(1130, 703);
            this.Load += new System.EventHandler(this.Resetpassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resetparcode;
        private System.Windows.Forms.Button ChangePassBtn;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Panel panel3;
    }
}
