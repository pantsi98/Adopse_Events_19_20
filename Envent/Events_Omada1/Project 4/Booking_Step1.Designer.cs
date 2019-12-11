namespace Project_4
{
    partial class Booking_Step1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.enventDbDataSet = new Project_4.enventDbDataSet();
            this.playTableAdapter1 = new Project_4.enventDbDataSetTableAdapters.playTableAdapter();
            this.show_availability = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enventDataSet = new Project_4.enventDataSet();
            this.enventDbDataSet1 = new Project_4.enventDbDataSet1();
            this.enventDbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventDb_title_date = new Project_4.eventDb_title_date();
            this.eventDbtitledateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playTableAdapter = new Project_4.enventDataSetTableAdapters.playTableAdapter();
            this.enventDataSet1 = new Project_4.enventDataSet();
            this.playBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.enventDataSet2 = new Project_4.enventDataSet();
            this.enventDataSet3 = new Project_4.enventDataSet();
            this.playBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Book = new System.Windows.Forms.Button();
            this.available_hours_dates = new System.Windows.Forms.Label();
            this.Booking_Steps = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDb_title_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDbtitledateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.available_hours_dates);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 54);
            this.panel1.TabIndex = 0;
            // 
            // playBindingSource3
            // 
            this.playBindingSource3.DataMember = "play";
            this.playBindingSource3.DataSource = this.enventDbDataSet;
            // 
            // enventDbDataSet
            // 
            this.enventDbDataSet.DataSetName = "enventDbDataSet";
            this.enventDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playTableAdapter1
            // 
            this.playTableAdapter1.ClearBeforeFill = true;
            // 
            // show_availability
            // 
            this.show_availability.Location = new System.Drawing.Point(323, 82);
            this.show_availability.Name = "show_availability";
            this.show_availability.Size = new System.Drawing.Size(223, 35);
            this.show_availability.TabIndex = 1;
            this.show_availability.Text = "Δείξε μου μέρες και ώρες";
            this.show_availability.UseVisualStyleBackColor = true;
            this.show_availability.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(323, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(223, 351);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // eventidDataGridViewTextBoxColumn
            // 
            this.eventidDataGridViewTextBoxColumn.DataPropertyName = "event_id";
            this.eventidDataGridViewTextBoxColumn.FillWeight = 120F;
            this.eventidDataGridViewTextBoxColumn.HeaderText = "event_id";
            this.eventidDataGridViewTextBoxColumn.Name = "eventidDataGridViewTextBoxColumn";
            this.eventidDataGridViewTextBoxColumn.Visible = false;
            this.eventidDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Ημερομηνία";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 160;
            // 
            // playBindingSource
            // 
            this.playBindingSource.DataMember = "play";
            this.playBindingSource.DataSource = this.enventDataSet;
            // 
            // enventDataSet
            // 
            this.enventDataSet.DataSetName = "enventDataSet";
            this.enventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enventDbDataSet1
            // 
            this.enventDbDataSet1.DataSetName = "enventDbDataSet1";
            this.enventDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enventDbDataSet1BindingSource
            // 
            this.enventDbDataSet1BindingSource.DataSource = this.enventDbDataSet1;
            this.enventDbDataSet1BindingSource.Position = 0;
            // 
            // eventDb_title_date
            // 
            this.eventDb_title_date.DataSetName = "eventDb_title_date";
            this.eventDb_title_date.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventDbtitledateBindingSource
            // 
            this.eventDbtitledateBindingSource.DataSource = this.eventDb_title_date;
            this.eventDbtitledateBindingSource.Position = 0;
            // 
            // playTableAdapter
            // 
            this.playTableAdapter.ClearBeforeFill = true;
            // 
            // enventDataSet1
            // 
            this.enventDataSet1.DataSetName = "enventDataSet";
            this.enventDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playBindingSource1
            // 
            this.playBindingSource1.DataMember = "play";
            this.playBindingSource1.DataSource = this.enventDataSet1;
            // 
            // enventDataSet2
            // 
            this.enventDataSet2.DataSetName = "enventDataSet";
            this.enventDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enventDataSet3
            // 
            this.enventDataSet3.DataSetName = "enventDataSet";
            this.enventDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playBindingSource2
            // 
            this.playBindingSource2.DataMember = "play";
            this.playBindingSource2.DataSource = this.enventDataSet3;
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(323, 503);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(223, 31);
            this.Book.TabIndex = 3;
            this.Book.Text = "Επιλογή Θέσεων";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // available_hours_dates
            // 
            this.available_hours_dates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.available_hours_dates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_hours_dates.ForeColor = System.Drawing.Color.White;
            this.available_hours_dates.Location = new System.Drawing.Point(0, 0);
            this.available_hours_dates.Name = "available_hours_dates";
            this.available_hours_dates.Size = new System.Drawing.Size(868, 54);
            this.available_hours_dates.TabIndex = 4;
            this.available_hours_dates.Text = "Διαθέσιμες μέρες και ώρες";
            this.available_hours_dates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Booking_Steps
            // 
            this.Booking_Steps.Location = new System.Drawing.Point(0, 0);
            this.Booking_Steps.Name = "Booking_Steps";
            this.Booking_Steps.Size = new System.Drawing.Size(868, 605);
            this.Booking_Steps.TabIndex = 4;
            // 
            // Booking_Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Book);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.show_availability);
            this.Controls.Add(this.Booking_Steps);
            this.Name = "Booking_Step1";
            this.Size = new System.Drawing.Size(868, 605);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDb_title_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDbtitledateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource playBindingSource;
        private enventDataSet enventDataSet;
        private enventDataSetTableAdapters.playTableAdapter playTableAdapter;
        private System.Windows.Forms.BindingSource playBindingSource1;
        private enventDataSet enventDataSet1;
        private enventDataSet enventDataSet2;
        private System.Windows.Forms.BindingSource playBindingSource2;
        private enventDataSet enventDataSet3;
        private System.Windows.Forms.BindingSource playBindingSource3;
        private enventDbDataSet enventDbDataSet;
        private enventDbDataSetTableAdapters.playTableAdapter playTableAdapter1;
        private System.Windows.Forms.Button show_availability;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private enventDbDataSet1 enventDbDataSet1;
        private System.Windows.Forms.BindingSource enventDbDataSet1BindingSource;
        private eventDb_title_date eventDb_title_date;
        private System.Windows.Forms.BindingSource eventDbtitledateBindingSource;
        private System.Windows.Forms.Label available_hours_dates;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Panel Booking_Steps;
    }
}
