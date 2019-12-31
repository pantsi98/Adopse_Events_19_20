namespace Project_4
{
    partial class BookingStep2
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
            this.booking_panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.PlayTitle_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.booking_panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // booking_panel2
            // 
            this.booking_panel2.Controls.Add(this.next_button);
            this.booking_panel2.Controls.Add(this.label2);
            this.booking_panel2.Controls.Add(this.label4);
            this.booking_panel2.Controls.Add(this.PlayTitle_label);
            this.booking_panel2.Controls.Add(this.label3);
            this.booking_panel2.Controls.Add(this.name_label);
            this.booking_panel2.Controls.Add(this.date_label);
            this.booking_panel2.Controls.Add(this.panel1);
            this.booking_panel2.Location = new System.Drawing.Point(0, 0);
            this.booking_panel2.Name = "booking_panel2";
            this.booking_panel2.Size = new System.Drawing.Size(680, 570);
            this.booking_panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Επιβεβαίωση Κράτησης";
            // 
            // date_label
            // 
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(158, 86);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(132, 23);
            this.date_label.TabIndex = 2;
            this.date_label.Text = "Ονοματεπώνυμο :\r\n";
            // 
            // name_label
            // 
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(296, 86);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(132, 23);
            this.name_label.TabIndex = 3;
            // 
            // PlayTitle_label
            // 
            this.PlayTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayTitle_label.Location = new System.Drawing.Point(296, 109);
            this.PlayTitle_label.Name = "PlayTitle_label";
            this.PlayTitle_label.Size = new System.Drawing.Size(132, 23);
            this.PlayTitle_label.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Τίτλος Παράστασης : \r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ημερομηνία Παράστασης : ";
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(511, 512);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(151, 43);
            this.next_button.TabIndex = 10;
            this.next_button.Text = "Ολοκλήρωση Κράτησης";
            this.next_button.UseVisualStyleBackColor = true;
            // 
            // BookingStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.booking_panel2);
            this.Name = "BookingStep2";
            this.Size = new System.Drawing.Size(680, 570);
            this.booking_panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel booking_panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayTitle_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button next_button;
    }
}
