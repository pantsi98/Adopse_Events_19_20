namespace Project_4
{
    partial class BookingStep1
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
            this.components = new System.ComponentModel.Container();
            this.booking_panel1 = new System.Windows.Forms.Panel();
            this.next_button = new System.Windows.Forms.Button();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.reducedTicketsCounter = new System.Windows.Forms.NumericUpDown();
            this.normalTicketsCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.date_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.play_title = new System.Windows.Forms.Label();
            this.enventDataSet = new Project_4.enventDataSet();
            this.playBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playTableAdapter = new Project_4.enventDataSetTableAdapters.playTableAdapter();
            this.playBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labeledTableAdapter1 = new Project_4.enventDataSetTableAdapters.labeledTableAdapter();
            this.booking_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reducedTicketsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalTicketsCounter)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // booking_panel1
            // 
            this.booking_panel1.Controls.Add(this.next_button);
            this.booking_panel1.Controls.Add(this.paymentComboBox);
            this.booking_panel1.Controls.Add(this.reducedTicketsCounter);
            this.booking_panel1.Controls.Add(this.normalTicketsCounter);
            this.booking_panel1.Controls.Add(this.label4);
            this.booking_panel1.Controls.Add(this.label3);
            this.booking_panel1.Controls.Add(this.label1);
            this.booking_panel1.Controls.Add(this.dateComboBox);
            this.booking_panel1.Controls.Add(this.date_label);
            this.booking_panel1.Controls.Add(this.panel1);
            this.booking_panel1.Location = new System.Drawing.Point(0, 0);
            this.booking_panel1.Name = "booking_panel1";
            this.booking_panel1.Size = new System.Drawing.Size(1233, 784);
            this.booking_panel1.TabIndex = 0;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(506, 506);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(151, 43);
            this.next_button.TabIndex = 9;
            this.next_button.Text = "Επόμενο";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Στο ταμείο",
            "Με κάρτα"});
            this.paymentComboBox.Location = new System.Drawing.Point(319, 178);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(121, 21);
            this.paymentComboBox.TabIndex = 8;
            // 
            // reducedTicketsCounter
            // 
            this.reducedTicketsCounter.Location = new System.Drawing.Point(319, 151);
            this.reducedTicketsCounter.Name = "reducedTicketsCounter";
            this.reducedTicketsCounter.Size = new System.Drawing.Size(37, 20);
            this.reducedTicketsCounter.TabIndex = 7;
            // 
            // normalTicketsCounter
            // 
            this.normalTicketsCounter.Location = new System.Drawing.Point(319, 125);
            this.normalTicketsCounter.Name = "normalTicketsCounter";
            this.normalTicketsCounter.Size = new System.Drawing.Size(37, 20);
            this.normalTicketsCounter.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Τρόπος Πληρωμής";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Μειωμένα Εισιτήρια";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Κανονικά Εισιτήρια";
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(319, 97);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(121, 21);
            this.dateComboBox.TabIndex = 2;
            // 
            // date_label
            // 
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.Location = new System.Drawing.Point(31, 96);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(289, 23);
            this.date_label.TabIndex = 1;
            this.date_label.Text = "Επιλέξτε την ημερμονηία που επιθυμείτε";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.play_title);
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(-84, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 51);
            this.panel2.TabIndex = 31;
            // 
            // play_title
            // 
            this.play_title.AutoSize = true;
            this.play_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.play_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.play_title.Location = new System.Drawing.Point(323, 12);
            this.play_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.play_title.Name = "play_title";
            this.play_title.Size = new System.Drawing.Size(219, 25);
            this.play_title.TabIndex = 1;
            this.play_title.Text = "Τίτλος Παράστασης";
            // 
            // enventDataSet
            // 
            this.enventDataSet.DataSetName = "enventDataSet";
            this.enventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playBindingSource
            // 
            this.playBindingSource.DataMember = "play";
            this.playBindingSource.DataSource = this.enventDataSet;
            // 
            // playTableAdapter
            // 
            this.playTableAdapter.ClearBeforeFill = true;
            // 
            // playBindingSource1
            // 
            this.playBindingSource1.DataMember = "play";
            this.playBindingSource1.DataSource = this.enventDataSet;
            // 
            // labeledTableAdapter1
            // 
            this.labeledTableAdapter1.ClearBeforeFill = true;
            // 
            // BookingStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.booking_panel1);
            this.Name = "BookingStep1";
            this.Size = new System.Drawing.Size(1233, 784);
            this.booking_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reducedTicketsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalTicketsCounter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel booking_panel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label play_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.BindingSource playBindingSource1;
        private enventDataSet enventDataSet;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.BindingSource playBindingSource;
        private enventDataSetTableAdapters.playTableAdapter playTableAdapter;
        private enventDataSetTableAdapters.labeledTableAdapter labeledTableAdapter1;
        private System.Windows.Forms.NumericUpDown reducedTicketsCounter;
        private System.Windows.Forms.NumericUpDown normalTicketsCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.ComboBox paymentComboBox;
    }
}
