namespace Project_4
{
    partial class ProfileEventManager
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
            this.createnewevent = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.updateprofil = new System.Windows.Forms.Button();
            this.empanel = new System.Windows.Forms.Panel();
            this.circularPicture1 = new Project_4.App_Code.circularPicture();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // createnewevent
            // 
            this.createnewevent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.createnewevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createnewevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createnewevent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createnewevent.Location = new System.Drawing.Point(655, 80);
            this.createnewevent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createnewevent.Name = "createnewevent";
            this.createnewevent.Size = new System.Drawing.Size(311, 50);
            this.createnewevent.TabIndex = 54;
            this.createnewevent.Text = "Δημιουργία Νέου Event";
            this.createnewevent.UseVisualStyleBackColor = false;
            this.createnewevent.Click += new System.EventHandler(this.createnewevent_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.history.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.history.Location = new System.Drawing.Point(54, 132);
            this.history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(311, 50);
            this.history.TabIndex = 53;
            this.history.Text = "Ιστορικό των Event";
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // updateprofil
            // 
            this.updateprofil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.updateprofil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateprofil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.updateprofil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateprofil.Location = new System.Drawing.Point(54, 79);
            this.updateprofil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateprofil.Name = "updateprofil";
            this.updateprofil.Size = new System.Drawing.Size(311, 50);
            this.updateprofil.TabIndex = 52;
            this.updateprofil.Text = "Επεξεργασία";
            this.updateprofil.UseVisualStyleBackColor = false;
            // 
            // empanel
            // 
            this.empanel.Location = new System.Drawing.Point(54, 221);
            this.empanel.Name = "empanel";
            this.empanel.Size = new System.Drawing.Size(1011, 472);
            this.empanel.TabIndex = 55;
            // 
            // circularPicture1
            // 
            this.circularPicture1.BackColor = System.Drawing.Color.Transparent;
            this.circularPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circularPicture1.Image = global::Project_4.Properties.Resources.userProfile;
            this.circularPicture1.Location = new System.Drawing.Point(432, 8);
            this.circularPicture1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(150, 150);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture1.TabIndex = 51;
            this.circularPicture1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(655, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 50);
            this.button1.TabIndex = 56;
            this.button1.Text = "Επεξεργασία Event";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ProfileEventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empanel);
            this.Controls.Add(this.createnewevent);
            this.Controls.Add(this.history);
            this.Controls.Add(this.updateprofil);
            this.Controls.Add(this.circularPicture1);
            this.Name = "ProfileEventManager";
            this.Size = new System.Drawing.Size(1120, 729);
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createnewevent;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button updateprofil;
        private App_Code.circularPicture circularPicture1;
        private System.Windows.Forms.Panel empanel;
        private System.Windows.Forms.Button button1;
    }
}
