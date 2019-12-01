namespace Project_4
{
    partial class RegisterPopUp
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
            this.eggrafi_os_label = new System.Windows.Forms.Label();
            this.simple_user = new System.Windows.Forms.Button();
            this.event_manager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eggrafi_os_label
            // 
            this.eggrafi_os_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggrafi_os_label.Location = new System.Drawing.Point(107, 19);
            this.eggrafi_os_label.Name = "eggrafi_os_label";
            this.eggrafi_os_label.Size = new System.Drawing.Size(100, 23);
            this.eggrafi_os_label.TabIndex = 0;
            this.eggrafi_os_label.Text = "Εγγραφή ως";
            // 
            // simple_user
            // 
            this.simple_user.Location = new System.Drawing.Point(44, 57);
            this.simple_user.Name = "simple_user";
            this.simple_user.Size = new System.Drawing.Size(90, 30);
            this.simple_user.TabIndex = 1;
            this.simple_user.Text = "Χρήστης";
            this.simple_user.UseVisualStyleBackColor = true;
            // 
            // event_manager
            // 
            this.event_manager.Location = new System.Drawing.Point(192, 57);
            this.event_manager.Name = "event_manager";
            this.event_manager.Size = new System.Drawing.Size(90, 30);
            this.event_manager.TabIndex = 2;
            this.event_manager.Text = "Event Manager";
            this.event_manager.UseVisualStyleBackColor = true;
            // 
            // RegisterPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 133);
            this.Controls.Add(this.event_manager);
            this.Controls.Add(this.simple_user);
            this.Controls.Add(this.eggrafi_os_label);
            this.Name = "RegisterPopUp";
            this.Text = "RegisterPopUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label eggrafi_os_label;
        private System.Windows.Forms.Button simple_user;
        private System.Windows.Forms.Button event_manager;
    }
}