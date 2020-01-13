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
            this.total_Price = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reducedTickets_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.normalTickets_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayTitle_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.booking_panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // booking_panel2
            // 
            this.booking_panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.booking_panel2.Controls.Add(this.total_Price);
            this.booking_panel2.Controls.Add(this.label9);
            this.booking_panel2.Controls.Add(this.reducedTickets_Label);
            this.booking_panel2.Controls.Add(this.label7);
            this.booking_panel2.Controls.Add(this.normalTickets_Label);
            this.booking_panel2.Controls.Add(this.label5);
            this.booking_panel2.Controls.Add(this.next_button);
            this.booking_panel2.Controls.Add(this.date_label);
            this.booking_panel2.Controls.Add(this.label4);
            this.booking_panel2.Controls.Add(this.PlayTitle_label);
            this.booking_panel2.Controls.Add(this.label3);
            this.booking_panel2.Controls.Add(this.name_label);
            this.booking_panel2.Controls.Add(this.name);
            this.booking_panel2.Controls.Add(this.panel1);
            this.booking_panel2.Location = new System.Drawing.Point(0, 0);
            this.booking_panel2.Name = "booking_panel2";
            this.booking_panel2.Size = new System.Drawing.Size(1233, 784);
            this.booking_panel2.TabIndex = 0;
            // 
            // total_Price
            // 
            this.total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Price.Location = new System.Drawing.Point(508, 271);
            this.total_Price.Name = "total_Price";
            this.total_Price.Size = new System.Drawing.Size(43, 23);
            this.total_Price.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(380, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Σύνολο (σε €) : ";
            // 
            // reducedTickets_Label
            // 
            this.reducedTickets_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reducedTickets_Label.Location = new System.Drawing.Point(500, 379);
            this.reducedTickets_Label.Name = "reducedTickets_Label";
            this.reducedTickets_Label.Size = new System.Drawing.Size(26, 23);
            this.reducedTickets_Label.TabIndex = 14;
            this.reducedTickets_Label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Μειωμένα Εισιτήρια ";
            // 
            // normalTickets_Label
            // 
            this.normalTickets_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalTickets_Label.Location = new System.Drawing.Point(500, 353);
            this.normalTickets_Label.Name = "normalTickets_Label";
            this.normalTickets_Label.Size = new System.Drawing.Size(26, 23);
            this.normalTickets_Label.TabIndex = 12;
            this.normalTickets_Label.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Κανονικά Εισιτήρια  ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(548, 535);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(151, 43);
            this.next_button.TabIndex = 10;
            this.next_button.Text = "Ολοκλήρωση Κράτησης";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // date_label
            // 
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(500, 319);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(365, 23);
            this.date_label.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ημερομηνία Παράστασης : ";
            // 
            // PlayTitle_label
            // 
            this.PlayTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayTitle_label.Location = new System.Drawing.Point(500, 286);
            this.PlayTitle_label.Name = "PlayTitle_label";
            this.PlayTitle_label.Size = new System.Drawing.Size(365, 23);
            this.PlayTitle_label.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Τίτλος Παράστασης : \r\n";
            // 
            // name_label
            // 
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(500, 248);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(365, 23);
            this.name_label.TabIndex = 3;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(362, 248);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 23);
            this.name.TabIndex = 2;
            this.name.Text = "Ονοματεπώνυμο :\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(498, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Επιβεβαίωση Κράτησης";
            // 
            // BookingStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.booking_panel2);
            this.Name = "BookingStep2";
            this.Size = new System.Drawing.Size(1233, 784);
            this.booking_panel2.ResumeLayout(false);
            this.booking_panel2.PerformLayout();
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
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label total_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label reducedTickets_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label normalTickets_Label;
        private System.Windows.Forms.Label label5;
    }
}
