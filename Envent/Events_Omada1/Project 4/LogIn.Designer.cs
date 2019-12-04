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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Syndesi = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.PasswordLog = new System.Windows.Forms.TextBox();
            this.EmailLog = new System.Windows.Forms.TextBox();
            this.LogInpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInpanel
            // 
            this.LogInpanel.Controls.Add(this.linkLabel1);
            this.LogInpanel.Controls.Add(this.Syndesi);
            this.LogInpanel.Controls.Add(this.label);
            this.LogInpanel.Controls.Add(this.PasswordLog);
            this.LogInpanel.Controls.Add(this.EmailLog);
            this.LogInpanel.Location = new System.Drawing.Point(3, 3);
            this.LogInpanel.Name = "LogInpanel";
            this.LogInpanel.Size = new System.Drawing.Size(869, 604);
            this.LogInpanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 437);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ξεχάσατε το λογαριασμό σας;";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Syndesi
            // 
            this.Syndesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Syndesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Syndesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.Syndesi.Location = new System.Drawing.Point(242, 327);
            this.Syndesi.Name = "Syndesi";
            this.Syndesi.Size = new System.Drawing.Size(180, 46);
            this.Syndesi.TabIndex = 3;
            this.Syndesi.Text = "Σύνδεση";
            this.Syndesi.UseVisualStyleBackColor = true;
            this.Syndesi.Click += new System.EventHandler(this.Syndesi_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.label.Location = new System.Drawing.Point(269, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 31);
            this.label.TabIndex = 2;
            this.label.Text = "Είσοδος";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // PasswordLog
            // 
            this.PasswordLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PasswordLog.ForeColor = System.Drawing.Color.Gray;
            this.PasswordLog.Location = new System.Drawing.Point(171, 251);
            this.PasswordLog.Name = "PasswordLog";
            this.PasswordLog.Size = new System.Drawing.Size(345, 34);
            this.PasswordLog.TabIndex = 1;
            this.PasswordLog.Text = "Κωδικός";
            this.PasswordLog.Click += new System.EventHandler(this.PasswordLog_Click);
            this.PasswordLog.TextChanged += new System.EventHandler(this.PasswordLog_TextChanged);
            this.PasswordLog.Leave += new System.EventHandler(this.PasswordLog_Leave);
            // 
            // EmailLog
            // 
            this.EmailLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailLog.ForeColor = System.Drawing.Color.Gray;
            this.EmailLog.Location = new System.Drawing.Point(171, 195);
            this.EmailLog.Name = "EmailLog";
            this.EmailLog.Size = new System.Drawing.Size(345, 34);
            this.EmailLog.TabIndex = 0;
            this.EmailLog.Text = "Email";
            this.EmailLog.Click += new System.EventHandler(this.EmailLog_Click);
            this.EmailLog.Leave += new System.EventHandler(this.EmailLog_Leave);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogInpanel);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(872, 607);
            this.LogInpanel.ResumeLayout(false);
            this.LogInpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogInpanel;
        private System.Windows.Forms.TextBox PasswordLog;
        private System.Windows.Forms.TextBox EmailLog;
        private System.Windows.Forms.Button Syndesi;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
