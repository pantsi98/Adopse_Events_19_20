namespace Project_4
{
    partial class LogIn
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
            this.LogInpanel = new System.Windows.Forms.Panel();
            this.msglabel = new System.Windows.Forms.Label();
            this.messagelabel = new System.Windows.Forms.Label();
            this.loginfail = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Syndesi = new System.Windows.Forms.Button();
            this.PasswordLog = new System.Windows.Forms.TextBox();
            this.UsernameLog = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogInpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInpanel
            // 
            this.LogInpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogInpanel.Controls.Add(this.msglabel);
            this.LogInpanel.Controls.Add(this.messagelabel);
            this.LogInpanel.Controls.Add(this.loginfail);
            this.LogInpanel.Controls.Add(this.linkLabel1);
            this.LogInpanel.Controls.Add(this.Syndesi);
            this.LogInpanel.Controls.Add(this.PasswordLog);
            this.LogInpanel.Controls.Add(this.UsernameLog);
            this.LogInpanel.Location = new System.Drawing.Point(0, 0);
            this.LogInpanel.Name = "LogInpanel";
            this.LogInpanel.Size = new System.Drawing.Size(1130, 745);
            this.LogInpanel.TabIndex = 0;
            this.LogInpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogInpanel_Paint);
            this.LogInpanel.MouseHover += new System.EventHandler(this.LogInpanel_MouseHover);
            // 
            // msglabel
            // 
            this.msglabel.AutoSize = true;
            this.msglabel.Location = new System.Drawing.Point(540, 104);
            this.msglabel.Name = "msglabel";
            this.msglabel.Size = new System.Drawing.Size(0, 17);
            this.msglabel.TabIndex = 7;
            // 
            // messagelabel
            // 
            this.messagelabel.AutoSize = true;
            this.messagelabel.Location = new System.Drawing.Point(255, 647);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(0, 17);
            this.messagelabel.TabIndex = 6;
            // 
            // loginfail
            // 
            this.loginfail.AutoSize = true;
            this.loginfail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginfail.ForeColor = System.Drawing.Color.Red;
            this.loginfail.Location = new System.Drawing.Point(254, 129);
            this.loginfail.Name = "loginfail";
            this.loginfail.Size = new System.Drawing.Size(637, 20);
            this.loginfail.TabIndex = 5;
            this.loginfail.Text = "Ο κωδικός πρόσβασης ή το Email που καταχωρήσατε είναι λάθος. Ξαναπροσπαθήστε.";
            this.loginfail.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(537, 471);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ξεχάσατε το λογαριασμό σας;";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Syndesi
            // 
            this.Syndesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.Syndesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Syndesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Syndesi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Syndesi.Location = new System.Drawing.Point(475, 344);
            this.Syndesi.Name = "Syndesi";
            this.Syndesi.Size = new System.Drawing.Size(180, 46);
            this.Syndesi.TabIndex = 3;
            this.Syndesi.Text = "Σύνδεση";
            this.Syndesi.UseVisualStyleBackColor = false;
            this.Syndesi.Click += new System.EventHandler(this.Syndesi_Click);
            // 
            // PasswordLog
            // 
            this.PasswordLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordLog.ForeColor = System.Drawing.Color.Gray;
            this.PasswordLog.Location = new System.Drawing.Point(388, 255);
            this.PasswordLog.Name = "PasswordLog";
            this.PasswordLog.Size = new System.Drawing.Size(345, 34);
            this.PasswordLog.TabIndex = 1;
            this.PasswordLog.Text = "Κωδικός";
          
            this.PasswordLog.Enter += new System.EventHandler(this.PasswordLog_Enter);
            this.PasswordLog.Leave += new System.EventHandler(this.PasswordLog_Leave);
            // 
            // UsernameLog
            // 
            this.UsernameLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UsernameLog.ForeColor = System.Drawing.Color.Gray;
            this.UsernameLog.Location = new System.Drawing.Point(388, 189);
            this.UsernameLog.Name = "UsernameLog";
            this.UsernameLog.Size = new System.Drawing.Size(345, 34);
            this.UsernameLog.TabIndex = 0;
            this.UsernameLog.Text = "Username";
            this.UsernameLog.Click += new System.EventHandler(this.UsernameLog_Click);
            this.UsernameLog.TextChanged += new System.EventHandler(this.UsernameLog_TextChanged);
            this.UsernameLog.Leave += new System.EventHandler(this.UsernameLog_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(505, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 31);
            this.label.TabIndex = 2;
            this.label.Text = "Είσοδος";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 63);
            this.panel1.TabIndex = 31;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogInpanel);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(1130, 745);
            this.Load += new System.EventHandler(this.LogIn_Load_1);
            this.LogInpanel.ResumeLayout(false);
            this.LogInpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogInpanel;
        private System.Windows.Forms.TextBox PasswordLog;
        private System.Windows.Forms.TextBox UsernameLog;
        private System.Windows.Forms.Button Syndesi;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginfail;
        private System.Windows.Forms.Label messagelabel;
        private System.Windows.Forms.Label msglabel;
    }
}
