namespace Project_4
{
    partial class ForgetPassword
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
            this.ForgotPaspanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.EmailForgot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ForgotPaspanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForgotPaspanel
            // 
            this.ForgotPaspanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForgotPaspanel.Controls.Add(this.panel1);
            this.ForgotPaspanel.Controls.Add(this.button1);
            this.ForgotPaspanel.Controls.Add(this.EmailForgot);
            this.ForgotPaspanel.Controls.Add(this.label1);
            this.ForgotPaspanel.Location = new System.Drawing.Point(0, 0);
            this.ForgotPaspanel.Name = "ForgotPaspanel";
            this.ForgotPaspanel.Size = new System.Drawing.Size(1130, 745);
            this.ForgotPaspanel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(471, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Αποστολή";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailForgot
            // 
            this.EmailForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailForgot.ForeColor = System.Drawing.Color.Gray;
            this.EmailForgot.Location = new System.Drawing.Point(392, 190);
            this.EmailForgot.Name = "EmailForgot";
            this.EmailForgot.Size = new System.Drawing.Size(347, 30);
            this.EmailForgot.TabIndex = 3;
            this.EmailForgot.Text = "Email";
            this.EmailForgot.Click += new System.EventHandler(this.EmailForgot_Click);
            this.EmailForgot.TextChanged += new System.EventHandler(this.EmailForgot_TextChanged);
            this.EmailForgot.Leave += new System.EventHandler(this.EmailForgot_Leave);
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
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(234, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Συμπληρώστε το email να λάβετε τον κωδικό για να επαναφέρετε τον λογαργιασμό σας." +
    "";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 63);
            this.panel1.TabIndex = 30;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ForgotPaspanel);
            this.Name = "ForgetPassword";
            this.Size = new System.Drawing.Size(1130, 745);
            this.ForgotPaspanel.ResumeLayout(false);
            this.ForgotPaspanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ForgotPaspanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EmailForgot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
