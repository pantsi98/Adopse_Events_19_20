namespace Project_4
{
    partial class Profile
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
            this.cCircularButton1 = new Project_4.App_Code.CCircularButton();
            this.cCircularButton2 = new Project_4.App_Code.CCircularButton();
            this.cCircularButton3 = new Project_4.App_Code.CCircularButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 51);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Προφίλ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cCircularButton1
            // 
            this.cCircularButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cCircularButton1.BackColor = System.Drawing.Color.Transparent;
            this.cCircularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cCircularButton1.ForeColor = System.Drawing.Color.Transparent;
            this.cCircularButton1.Image = global::Project_4.Properties.Resources.profileIcon;
            this.cCircularButton1.Location = new System.Drawing.Point(724, 15);
            this.cCircularButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cCircularButton1.Name = "cCircularButton1";
            this.cCircularButton1.Size = new System.Drawing.Size(112, 122);
            this.cCircularButton1.TabIndex = 32;
            this.cCircularButton1.UseVisualStyleBackColor = false;
            // 
            // cCircularButton2
            // 
            this.cCircularButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cCircularButton2.BackColor = System.Drawing.Color.Transparent;
            this.cCircularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cCircularButton2.ForeColor = System.Drawing.Color.Transparent;
            this.cCircularButton2.Image = global::Project_4.Properties.Resources.facebookIcon;
            this.cCircularButton2.Location = new System.Drawing.Point(42, 566);
            this.cCircularButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cCircularButton2.Name = "cCircularButton2";
            this.cCircularButton2.Size = new System.Drawing.Size(34, 37);
            this.cCircularButton2.TabIndex = 33;
            this.cCircularButton2.UseVisualStyleBackColor = false;
            // 
            // cCircularButton3
            // 
            this.cCircularButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cCircularButton3.BackColor = System.Drawing.Color.Transparent;
            this.cCircularButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cCircularButton3.ForeColor = System.Drawing.Color.Transparent;
            this.cCircularButton3.Image = global::Project_4.Properties.Resources.gmailIcon;
            this.cCircularButton3.Location = new System.Drawing.Point(4, 566);
            this.cCircularButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cCircularButton3.Name = "cCircularButton3";
            this.cCircularButton3.Size = new System.Drawing.Size(34, 37);
            this.cCircularButton3.TabIndex = 34;
            this.cCircularButton3.UseVisualStyleBackColor = false;
            this.cCircularButton3.Click += new System.EventHandler(this.cCircularButton3_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cCircularButton3);
            this.Controls.Add(this.cCircularButton2);
            this.Controls.Add(this.cCircularButton1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(848, 605);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private App_Code.CCircularButton cCircularButton1;
        private App_Code.CCircularButton cCircularButton2;
        private App_Code.CCircularButton cCircularButton3;
    }
}
