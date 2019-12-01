namespace Project_4
{
    partial class UserRegister
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
            this.eggrafi_label = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.lname_text = new System.Windows.Forms.TextBox();
            this.complete_registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eggrafi_label
            // 
            this.eggrafi_label.AutoSize = true;
            this.eggrafi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggrafi_label.Location = new System.Drawing.Point(250, 20);
            this.eggrafi_label.Name = "eggrafi_label";
            this.eggrafi_label.Size = new System.Drawing.Size(70, 20);
            this.eggrafi_label.TabIndex = 0;
            this.eggrafi_label.Text = "Εγγραφή";
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(165, 62);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(76, 20);
            this.fname.TabIndex = 1;
            this.fname.Text = "Όνομα:";
            this.fname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(165, 91);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(76, 20);
            this.lname.TabIndex = 2;
            this.lname.Text = "Επώνυμο:";
            // 
            // fname_text
            // 
            this.fname_text.Location = new System.Drawing.Point(254, 62);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(120, 20);
            this.fname_text.TabIndex = 3;
            // 
            // lname_text
            // 
            this.lname_text.Location = new System.Drawing.Point(254, 93);
            this.lname_text.Name = "lname_text";
            this.lname_text.Size = new System.Drawing.Size(120, 20);
            this.lname_text.TabIndex = 4;
            this.lname_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // complete_registration
            // 
            this.complete_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complete_registration.Location = new System.Drawing.Point(254, 406);
            this.complete_registration.Name = "complete_registration";
            this.complete_registration.Size = new System.Drawing.Size(120, 42);
            this.complete_registration.TabIndex = 5;
            this.complete_registration.Text = "Ολοκλήρωση Εγγραφής";
            this.complete_registration.UseVisualStyleBackColor = true;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 493);
            this.Controls.Add(this.complete_registration);
            this.Controls.Add(this.lname_text);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.eggrafi_label);
            this.Name = "UserRegister";
            this.Text = "UserRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eggrafi_label;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox fname_text;
        private System.Windows.Forms.TextBox lname_text;
        private System.Windows.Forms.Button complete_registration;
    }
}