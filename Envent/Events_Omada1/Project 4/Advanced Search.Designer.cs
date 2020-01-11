namespace Project_4
{
    partial class Advanced_Search
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
            this.enventDataSet = new Project_4.enventDataSet();
            this.enventDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project_4.enventDataSetTableAdapters.categoryTableAdapter();
            this.since_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.until_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.filters_label = new System.Windows.Forms.Label();
            this.since_label = new System.Windows.Forms.Label();
            this.until_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // enventDataSet
            // 
            this.enventDataSet.DataSetName = "enventDataSet";
            this.enventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enventDataSetBindingSource
            // 
            this.enventDataSetBindingSource.DataSource = this.enventDataSet;
            this.enventDataSetBindingSource.Position = 0;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.enventDataSetBindingSource;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // since_dateTimePicker
            // 
            this.since_dateTimePicker.Location = new System.Drawing.Point(261, 78);
            this.since_dateTimePicker.Name = "since_dateTimePicker";
            this.since_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.since_dateTimePicker.TabIndex = 1;
            // 
            // until_dateTimePicker2
            // 
            this.until_dateTimePicker2.Location = new System.Drawing.Point(262, 128);
            this.until_dateTimePicker2.Name = "until_dateTimePicker2";
            this.until_dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.until_dateTimePicker2.TabIndex = 2;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            this.categoryBindingSource1.DataSource = this.enventDataSet;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Theater",
            "Music",
            "Conference",
            "Festival",
            "Soccer",
            "Basketball"});
            this.categoryBox.Location = new System.Drawing.Point(262, 178);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 21);
            this.categoryBox.TabIndex = 5;
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Athens",
            "Rethymno",
            "Thessaloniki",
            "Patra",
            "Rhodes",
            "Volos",
            "Agrinio",
            "Larisa",
            "Lamia",
            "Tripli"});
            this.cityBox.Location = new System.Drawing.Point(262, 228);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 6;
            // 
            // filters_label
            // 
            this.filters_label.AutoSize = true;
            this.filters_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filters_label.Location = new System.Drawing.Point(0, 10);
            this.filters_label.Name = "filters_label";
            this.filters_label.Size = new System.Drawing.Size(236, 29);
            this.filters_label.TabIndex = 7;
            this.filters_label.Text = "Φίλτρα Αναζήτησης";
            // 
            // since_label
            // 
            this.since_label.AutoSize = true;
            this.since_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.since_label.Location = new System.Drawing.Point(95, 78);
            this.since_label.Name = "since_label";
            this.since_label.Size = new System.Drawing.Size(161, 20);
            this.since_label.TabIndex = 8;
            this.since_label.Text = "Ημερομηνία Έναρξης";
            // 
            // until_label
            // 
            this.until_label.AutoSize = true;
            this.until_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.until_label.Location = new System.Drawing.Point(95, 128);
            this.until_label.Name = "until_label";
            this.until_label.Size = new System.Drawing.Size(145, 20);
            this.until_label.TabIndex = 9;
            this.until_label.Text = "Ημερομηνία Λήξης";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.category_label.Location = new System.Drawing.Point(95, 179);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(84, 20);
            this.category_label.TabIndex = 10;
            this.category_label.Text = "Κατηγορία";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.city_label.Location = new System.Drawing.Point(95, 229);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(48, 20);
            this.city_label.TabIndex = 11;
            this.city_label.Text = "Πόλη";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Press Enter To Search";
            // 
            // Advanced_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.until_label);
            this.Controls.Add(this.since_label);
            this.Controls.Add(this.filters_label);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.until_dateTimePicker2);
            this.Controls.Add(this.since_dateTimePicker);
            this.Location = new System.Drawing.Point(150, 0);
            this.Name = "Advanced_Search";
            this.Size = new System.Drawing.Size(550, 302);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Advanced_Search_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enventDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource enventDataSetBindingSource;
        private enventDataSet enventDataSet;
        private enventDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DateTimePicker since_dateTimePicker;
        private System.Windows.Forms.DateTimePicker until_dateTimePicker2;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label filters_label;
        private System.Windows.Forms.Label since_label;
        private System.Windows.Forms.Label until_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label city_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
