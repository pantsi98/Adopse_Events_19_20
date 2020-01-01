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
            this.since_dateTimePicker.Location = new System.Drawing.Point(230, 36);
            this.since_dateTimePicker.Name = "since_dateTimePicker";
            this.since_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.since_dateTimePicker.TabIndex = 1;
            // 
            // until_dateTimePicker2
            // 
            this.until_dateTimePicker2.Location = new System.Drawing.Point(463, 35);
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
            "FootBall",
            "BasketBall"});
            this.categoryBox.Location = new System.Drawing.Point(70, 38);
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
            this.cityBox.Location = new System.Drawing.Point(695, 33);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 6;
            // 
            // Advanced_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.until_dateTimePicker2);
            this.Controls.Add(this.since_dateTimePicker);
            this.Name = "Advanced_Search";
            this.Size = new System.Drawing.Size(1001, 596);
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
    }
}
