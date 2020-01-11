namespace Project_4
{
    partial class SignUpstep1
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
            this.label2 = new System.Windows.Forms.Label();
            this.UserButon = new System.Windows.Forms.Button();
            this.EventManagerButton = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRegister.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(355, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eγγραφή ως:";
            // 
            // UserButon
            // 
            this.UserButon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.UserButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.UserButon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserButon.Location = new System.Drawing.Point(337, 139);
            this.UserButon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserButon.Name = "UserButon";
            this.UserButon.Size = new System.Drawing.Size(177, 67);
            this.UserButon.TabIndex = 2;
            this.UserButon.Text = "Χρήστης";
            this.UserButon.UseVisualStyleBackColor = false;
            this.UserButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventManagerButton
            // 
            this.EventManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.EventManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.EventManagerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EventManagerButton.Location = new System.Drawing.Point(337, 249);
            this.EventManagerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventManagerButton.Name = "EventManagerButton";
            this.EventManagerButton.Size = new System.Drawing.Size(178, 67);
            this.EventManagerButton.TabIndex = 3;
            this.EventManagerButton.Text = "Event Manager";
            this.EventManagerButton.UseVisualStyleBackColor = false;
            this.EventManagerButton.Click += new System.EventHandler(this.EventManagerButton_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.Controls.Add(this.panel1);
            this.panelRegister.Controls.Add(this.UserButon);
            this.panelRegister.Controls.Add(this.EventManagerButton);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(848, 675);
            this.panelRegister.TabIndex = 4;
            this.panelRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegister_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 51);
            this.panel1.TabIndex = 30;
            // 
            // SignUpstep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelRegister);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUpstep1";
            this.Size = new System.Drawing.Size(1233, 784);
            this.panelRegister.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserButon;
        private System.Windows.Forms.Button EventManagerButton;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panel1;
    }
}
