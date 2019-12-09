namespace Project_4
{
    partial class SignUpUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.address = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Email1 = new System.Windows.Forms.TextBox();
            this.username1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.messagefullo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullolabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Kodikos1 = new System.Windows.Forms.TextBox();
            this.Kodikos2 = new System.Windows.Forms.TextBox();
            this.Epitheto = new System.Windows.Forms.TextBox();
            this.Onoma = new System.Windows.Forms.TextBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonBox = new System.Windows.Forms.GroupBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.radioButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dobPicker);
            this.panel2.Controls.Add(this.radioButtonBox);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Email1);
            this.panel2.Controls.Add(this.username1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.messagefullo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fullolabel);
            this.panel2.Controls.Add(this.messageLabel);
            this.panel2.Controls.Add(this.Register);
            this.panel2.Controls.Add(this.Kodikos1);
            this.panel2.Controls.Add(this.Kodikos2);
            this.panel2.Controls.Add(this.Epitheto);
            this.panel2.Controls.Add(this.Onoma);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 605);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // address
            // 
            this.address.AutoCompleteCustomSource.AddRange(new string[] {
            "Αθήνα",
            "Θεσσαλονίκη",
            "Πάτρα",
            "Ηράκλειο",
            "Λάρισα",
            "Βόλος",
            "Ιωάννινα",
            "Τρίκαλα",
            "Χαλκίδα",
            "Σέρρες",
            "Αλεξανδρούπολη\t",
            "Ξάνθη",
            "Κατερίνη",
            "Αγρίνιο",
            "Καλαμάτα",
            "Καβάλα",
            "Χανιά",
            "Λαμία",
            "Κομοτηνή",
            "Ρόδος",
            "Δράμα",
            "Βέροια",
            "Κοζάνη",
            "Καρδίτσα",
            "Ρέθυμνο",
            "Πτολεμαΐδα",
            "Τρίπολη",
            "Κόρινθος",
            "Γέρακας",
            "Γιαννιτσά",
            "Μυτιλήνη",
            "Χίος",
            "Σαλαμίνα",
            "Ελευσίνα",
            "Κέρκυρα",
            "Πύργος",
            "Μέγαρα",
            "Κιλκίς",
            "Θήβα",
            "Άργος",
            "Άρτα",
            "Κως",
            "Πρέβεζα",
            "Σπάρτη",
            "Νάουσα",
            "Ορεστιάδα",
            "Έδεσσα",
            "Φλώρινα",
            "Θέρμη",
            "Αλεξάνδρεια\t",
            "Ναύπλιο",
            "Ναύπακτος\t",
            "Καστοριά",
            "Γρεβενά",
            "Άγιος Νικόλαος",
            "Ερμούπολη",
            "Χρυσούπολη"});
            this.address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.address.ForeColor = System.Drawing.Color.Gray;
            this.address.Location = new System.Drawing.Point(224, 225);
            this.address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(355, 23);
            this.address.TabIndex = 30;
            this.address.Text = "Περιοχή";
            this.address.MouseClick += new System.Windows.Forms.MouseEventHandler(this.address_MouseClick);
            this.address.Leave += new System.EventHandler(this.address_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 51);
            this.panel1.TabIndex = 29;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(246, 12);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(339, 25);
            this.Title.TabIndex = 15;
            this.Title.Text = "Δημιουργήστε Nέο Λογαριασμό";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Email1
            // 
            this.Email1.ForeColor = System.Drawing.Color.Gray;
            this.Email1.Location = new System.Drawing.Point(224, 145);
            this.Email1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(356, 23);
            this.Email1.TabIndex = 28;
            this.Email1.Text = "Email";
            this.Email1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Email1_MouseClick);
            this.Email1.Leave += new System.EventHandler(this.Email1_Leave);
            // 
            // username1
            // 
            this.username1.ForeColor = System.Drawing.Color.Gray;
            this.username1.Location = new System.Drawing.Point(224, 118);
            this.username1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(356, 23);
            this.username1.TabIndex = 27;
            this.username1.Text = "Username";
            this.username1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username1_MouseClick);
            this.username1.Leave += new System.EventHandler(this.username1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.groupBox1.Location = new System.Drawing.Point(222, 368);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(354, 110);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eνδιαφέρομαι για:";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox6.Location = new System.Drawing.Point(206, 55);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(95, 21);
            this.checkBox6.TabIndex = 32;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox5.Location = new System.Drawing.Point(4, 84);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 21);
            this.checkBox5.TabIndex = 31;
            this.checkBox5.Text = "Σινεμά";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox4.Location = new System.Drawing.Point(105, 58);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 21);
            this.checkBox4.TabIndex = 30;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox3.Location = new System.Drawing.Point(105, 28);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(180, 21);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "Θεατρικές Παραστάσεις";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox2.Location = new System.Drawing.Point(4, 58);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 21);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(2, 28);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Μουσική";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // messagefullo
            // 
            this.messagefullo.AutoSize = true;
            this.messagefullo.Location = new System.Drawing.Point(135, 265);
            this.messagefullo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messagefullo.Name = "messagefullo";
            this.messagefullo.Size = new System.Drawing.Size(0, 17);
            this.messagefullo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(220, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ημερομηνίά γέννησης";
            // 
            // fullolabel
            // 
            this.fullolabel.AutoSize = true;
            this.fullolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.fullolabel.Location = new System.Drawing.Point(220, 249);
            this.fullolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullolabel.Name = "fullolabel";
            this.fullolabel.Size = new System.Drawing.Size(49, 17);
            this.fullolabel.TabIndex = 18;
            this.fullolabel.Text = "Φύλλο";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.messageLabel.Location = new System.Drawing.Point(220, 63);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(98, 16);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.Text = "message label";
            this.messageLabel.Visible = false;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Register.Location = new System.Drawing.Point(311, 516);
            this.Register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(142, 41);
            this.Register.TabIndex = 10;
            this.Register.Text = "Eγγραφή";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Kodikos1
            // 
            this.Kodikos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Kodikos1.ForeColor = System.Drawing.Color.Gray;
            this.Kodikos1.Location = new System.Drawing.Point(224, 171);
            this.Kodikos1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Kodikos1.Name = "Kodikos1";
            this.Kodikos1.Size = new System.Drawing.Size(355, 23);
            this.Kodikos1.TabIndex = 8;
            this.Kodikos1.Text = "Κωδικός";
            this.Kodikos1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Kodikos1_MouseClick);
            this.Kodikos1.Leave += new System.EventHandler(this.Kodikos1_Leave);
            // 
            // Kodikos2
            // 
            this.Kodikos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Kodikos2.ForeColor = System.Drawing.Color.Gray;
            this.Kodikos2.Location = new System.Drawing.Point(224, 198);
            this.Kodikos2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Kodikos2.Name = "Kodikos2";
            this.Kodikos2.Size = new System.Drawing.Size(355, 23);
            this.Kodikos2.TabIndex = 9;
            this.Kodikos2.Text = "Επαλήθευση Κωδικού";
            this.Kodikos2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Kodikos2_MouseClick);
            this.Kodikos2.Leave += new System.EventHandler(this.Kodikos2_Leave);
            // 
            // Epitheto
            // 
            this.Epitheto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Epitheto.ForeColor = System.Drawing.Color.Gray;
            this.Epitheto.Location = new System.Drawing.Point(404, 91);
            this.Epitheto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Epitheto.Name = "Epitheto";
            this.Epitheto.Size = new System.Drawing.Size(176, 23);
            this.Epitheto.TabIndex = 6;
            this.Epitheto.Text = "Επώνυμο";
            this.Epitheto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Epitheto_MouseClick);
            this.Epitheto.Leave += new System.EventHandler(this.Epitheto_Leave);
            // 
            // Onoma
            // 
            this.Onoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Onoma.ForeColor = System.Drawing.Color.DimGray;
            this.Onoma.Location = new System.Drawing.Point(224, 91);
            this.Onoma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Onoma.Name = "Onoma";
            this.Onoma.Size = new System.Drawing.Size(176, 23);
            this.Onoma.TabIndex = 5;
            this.Onoma.Text = "Όνομα";
            this.Onoma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Onoma_MouseClick);
            this.Onoma.Leave += new System.EventHandler(this.Onoma_Leave);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(6, 10);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(56, 21);
            this.maleRadioButton.TabIndex = 31;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(66, 10);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(72, 21);
            this.femaleRadioButton.TabIndex = 32;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonBox
            // 
            this.radioButtonBox.Controls.Add(this.femaleRadioButton);
            this.radioButtonBox.Controls.Add(this.maleRadioButton);
            this.radioButtonBox.Location = new System.Drawing.Point(224, 269);
            this.radioButtonBox.Name = "radioButtonBox";
            this.radioButtonBox.Size = new System.Drawing.Size(144, 37);
            this.radioButtonBox.TabIndex = 34;
            this.radioButtonBox.TabStop = false;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(224, 329);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 23);
            this.dobPicker.TabIndex = 35;
            // 
            // SignUpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUpUser";
            this.Size = new System.Drawing.Size(848, 605);
            this.Load += new System.EventHandler(this.SignUpUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.radioButtonBox.ResumeLayout(false);
            this.radioButtonBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label messagefullo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullolabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Kodikos1;
        private System.Windows.Forms.TextBox Kodikos2;
        private System.Windows.Forms.TextBox Epitheto;
        private System.Windows.Forms.TextBox Onoma;
        private System.Windows.Forms.TextBox Email1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.GroupBox radioButtonBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
    }
}
