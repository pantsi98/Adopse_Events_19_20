namespace Project_4
{
    partial class BookingStep2Card
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
            this.bookingStep2Card_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bookingStep2Card_panel
            // 
            this.bookingStep2Card_panel.Location = new System.Drawing.Point(0, 0);
            this.bookingStep2Card_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookingStep2Card_panel.Name = "bookingStep2Card_panel";
            this.bookingStep2Card_panel.Size = new System.Drawing.Size(1233, 784);
            this.bookingStep2Card_panel.TabIndex = 0;
            this.bookingStep2Card_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bookingStep2Card_panel_Paint);
            // 
            // BookingStep2Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingStep2Card_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingStep2Card";
            this.Size = new System.Drawing.Size(1233, 784);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookingStep2Card_panel;
    }
}
