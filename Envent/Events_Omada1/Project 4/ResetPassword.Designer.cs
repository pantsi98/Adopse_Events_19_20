namespace Project_4
{
    partial class ResetPassword
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
            this.new_pass_label = new System.Windows.Forms.Label();
            this.ver_new_pass = new System.Windows.Forms.Label();
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.txtResetPassVer = new System.Windows.Forms.TextBox();
            this.button_reset_pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_pass_label
            // 
            this.new_pass_label.AutoSize = true;
            this.new_pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass_label.Location = new System.Drawing.Point(109, 139);
            this.new_pass_label.Name = "new_pass_label";
            this.new_pass_label.Size = new System.Drawing.Size(108, 20);
            this.new_pass_label.TabIndex = 0;
            this.new_pass_label.Text = "Νέος Κωδικός";
            // 
            // ver_new_pass
            // 
            this.ver_new_pass.AutoSize = true;
            this.ver_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_new_pass.Location = new System.Drawing.Point(109, 179);
            this.ver_new_pass.Name = "ver_new_pass";
            this.ver_new_pass.Size = new System.Drawing.Size(202, 20);
            this.ver_new_pass.TabIndex = 1;
            this.ver_new_pass.Text = "Επιβεβαίωση Νέου Κωδικού";
            // 
            // txtResetPass
            // 
            this.txtResetPass.Location = new System.Drawing.Point(339, 139);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.Size = new System.Drawing.Size(169, 20);
            this.txtResetPass.TabIndex = 2;
            // 
            // txtResetPassVer
            // 
            this.txtResetPassVer.Location = new System.Drawing.Point(339, 179);
            this.txtResetPassVer.Name = "txtResetPassVer";
            this.txtResetPassVer.Size = new System.Drawing.Size(169, 20);
            this.txtResetPassVer.TabIndex = 3;
            // 
            // button_reset_pass
            // 
            this.button_reset_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset_pass.Location = new System.Drawing.Point(234, 233);
            this.button_reset_pass.Name = "button_reset_pass";
            this.button_reset_pass.Size = new System.Drawing.Size(139, 41);
            this.button_reset_pass.TabIndex = 4;
            this.button_reset_pass.Text = "Επαναφορά";
            this.button_reset_pass.UseVisualStyleBackColor = true;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_reset_pass);
            this.Controls.Add(this.txtResetPassVer);
            this.Controls.Add(this.txtResetPass);
            this.Controls.Add(this.ver_new_pass);
            this.Controls.Add(this.new_pass_label);
            this.Name = "ResetPassword";
            this.Size = new System.Drawing.Size(630, 513);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label new_pass_label;
        private System.Windows.Forms.Label ver_new_pass;
        private System.Windows.Forms.TextBox txtResetPass;
        private System.Windows.Forms.TextBox txtResetPassVer;
        private System.Windows.Forms.Button button_reset_pass;
    }
}
