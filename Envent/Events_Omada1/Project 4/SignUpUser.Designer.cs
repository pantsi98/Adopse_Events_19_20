﻿namespace Project_4
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
            this.ConferenceCB = new System.Windows.Forms.CheckBox();
            this.CinemaCB = new System.Windows.Forms.CheckBox();
            this.SportsCB = new System.Windows.Forms.CheckBox();
            this.TheaterCB = new System.Windows.Forms.CheckBox();
            this.FstivalCB = new System.Windows.Forms.CheckBox();
            this.MusicCB = new System.Windows.Forms.CheckBox();
            this.messagefullo = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fullolabel = new System.Windows.Forms.Label();
            this.Andras = new System.Windows.Forms.CheckBox();
            this.Gynaika = new System.Windows.Forms.CheckBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Kodikos1 = new System.Windows.Forms.TextBox();
            this.Kodikos2 = new System.Windows.Forms.TextBox();
            this.Epitheto = new System.Windows.Forms.TextBox();
            this.Onoma = new System.Windows.Forms.TextBox();
            this.EducationalCB = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Email1);
            this.panel2.Controls.Add(this.username1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.messagefullo);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.domainUpDown1);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fullolabel);
            this.panel2.Controls.Add(this.Andras);
            this.panel2.Controls.Add(this.Gynaika);
            this.panel2.Controls.Add(this.messageLabel);
            this.panel2.Controls.Add(this.Register);
            this.panel2.Controls.Add(this.Kodikos1);
            this.panel2.Controls.Add(this.Kodikos2);
            this.panel2.Controls.Add(this.Epitheto);
            this.panel2.Controls.Add(this.Onoma);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 745);
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
            this.address.Location = new System.Drawing.Point(298, 277);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(472, 27);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 63);
            this.panel1.TabIndex = 29;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(328, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(424, 31);
            this.Title.TabIndex = 15;
            this.Title.Text = "Δημιουργήστε Nέο Λογαριασμό";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Email1
            // 
            this.Email1.ForeColor = System.Drawing.Color.Gray;
            this.Email1.Location = new System.Drawing.Point(298, 178);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(473, 27);
            this.Email1.TabIndex = 28;
            this.Email1.Text = "Email";
            this.Email1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Email1_MouseClick);
            this.Email1.Leave += new System.EventHandler(this.Email1_Leave);
            // 
            // username1
            // 
            this.username1.ForeColor = System.Drawing.Color.Gray;
            this.username1.Location = new System.Drawing.Point(298, 145);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(473, 27);
            this.username1.TabIndex = 27;
            this.username1.Text = "Username";
            this.username1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username1_MouseClick);
            this.username1.Leave += new System.EventHandler(this.username1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EducationalCB);
            this.groupBox1.Controls.Add(this.ConferenceCB);
            this.groupBox1.Controls.Add(this.CinemaCB);
            this.groupBox1.Controls.Add(this.SportsCB);
            this.groupBox1.Controls.Add(this.TheaterCB);
            this.groupBox1.Controls.Add(this.FstivalCB);
            this.groupBox1.Controls.Add(this.MusicCB);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.groupBox1.Location = new System.Drawing.Point(296, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 177);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eνδιαφέρομαι για:";
            // 
            // ConferenceCB
            // 
            this.ConferenceCB.AutoSize = true;
            this.ConferenceCB.ForeColor = System.Drawing.Color.DimGray;
            this.ConferenceCB.Location = new System.Drawing.Point(370, 35);
            this.ConferenceCB.Name = "ConferenceCB";
            this.ConferenceCB.Size = new System.Drawing.Size(105, 26);
            this.ConferenceCB.TabIndex = 32;
            this.ConferenceCB.Text = "Συνέδρια";
            this.ConferenceCB.UseVisualStyleBackColor = true;
            // 
            // CinemaCB
            // 
            this.CinemaCB.AutoSize = true;
            this.CinemaCB.ForeColor = System.Drawing.Color.DimGray;
            this.CinemaCB.Location = new System.Drawing.Point(371, 84);
            this.CinemaCB.Name = "CinemaCB";
            this.CinemaCB.Size = new System.Drawing.Size(85, 26);
            this.CinemaCB.TabIndex = 31;
            this.CinemaCB.Text = "Σινεμά";
            this.CinemaCB.UseVisualStyleBackColor = true;
            // 
            // SportsCB
            // 
            this.SportsCB.AutoSize = true;
            this.SportsCB.ForeColor = System.Drawing.Color.DimGray;
            this.SportsCB.Location = new System.Drawing.Point(6, 84);
            this.SportsCB.Name = "SportsCB";
            this.SportsCB.Size = new System.Drawing.Size(214, 26);
            this.SportsCB.TabIndex = 30;
            this.SportsCB.Text = "Αθλητικές Εκδηλώσεις";
            this.SportsCB.UseVisualStyleBackColor = true;
            // 
            // TheaterCB
            // 
            this.TheaterCB.AutoSize = true;
            this.TheaterCB.ForeColor = System.Drawing.Color.DimGray;
            this.TheaterCB.Location = new System.Drawing.Point(6, 35);
            this.TheaterCB.Name = "TheaterCB";
            this.TheaterCB.Size = new System.Drawing.Size(226, 26);
            this.TheaterCB.TabIndex = 29;
            this.TheaterCB.Text = "Θεατρικές Παραστάσεις";
            this.TheaterCB.UseVisualStyleBackColor = true;
            // 
            // FstivalCB
            // 
            this.FstivalCB.AutoSize = true;
            this.FstivalCB.ForeColor = System.Drawing.Color.DimGray;
            this.FstivalCB.Location = new System.Drawing.Point(242, 84);
            this.FstivalCB.Name = "FstivalCB";
            this.FstivalCB.Size = new System.Drawing.Size(109, 26);
            this.FstivalCB.TabIndex = 28;
            this.FstivalCB.Text = "Φεστιβάλ";
            this.FstivalCB.UseVisualStyleBackColor = true;
            // 
            // MusicCB
            // 
            this.MusicCB.AutoSize = true;
            this.MusicCB.ForeColor = System.Drawing.Color.DimGray;
            this.MusicCB.Location = new System.Drawing.Point(242, 35);
            this.MusicCB.Name = "MusicCB";
            this.MusicCB.Size = new System.Drawing.Size(99, 26);
            this.MusicCB.TabIndex = 27;
            this.MusicCB.Text = "Μουσική";
            this.MusicCB.UseVisualStyleBackColor = true;
            // 
            // messagefullo
            // 
            this.messagefullo.AutoSize = true;
            this.messagefullo.Location = new System.Drawing.Point(180, 326);
            this.messagefullo.Name = "messagefullo";
            this.messagefullo.Size = new System.Drawing.Size(0, 22);
            this.messagefullo.TabIndex = 23;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(481, 382);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            19910,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 27);
            this.numericUpDown2.TabIndex = 22;
            this.numericUpDown2.Value = new decimal(new int[] {
            1994,
            0,
            0,
            0});
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Ιαν");
            this.domainUpDown1.Items.Add("Φεβ");
            this.domainUpDown1.Items.Add("Μάρ");
            this.domainUpDown1.Items.Add("Απρ");
            this.domainUpDown1.Items.Add("Μάι");
            this.domainUpDown1.Items.Add("Ιούν");
            this.domainUpDown1.Items.Add("Ιούλ");
            this.domainUpDown1.Items.Add("Αύγ");
            this.domainUpDown1.Items.Add("Σεπ");
            this.domainUpDown1.Items.Add("Οκτ");
            this.domainUpDown1.Items.Add("Νοέμ");
            this.domainUpDown1.Items.Add("Δεκ");
            this.domainUpDown1.Location = new System.Drawing.Point(361, 382);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 27);
            this.domainUpDown1.TabIndex = 21;
            this.domainUpDown1.Text = "Μήνας";
            this.domainUpDown1.Click += new System.EventHandler(this.domainUpDown1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 382);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 27);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(294, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ημερομηνίά γέννησης";
            // 
            // fullolabel
            // 
            this.fullolabel.AutoSize = true;
            this.fullolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.fullolabel.Location = new System.Drawing.Point(294, 307);
            this.fullolabel.Name = "fullolabel";
            this.fullolabel.Size = new System.Drawing.Size(64, 22);
            this.fullolabel.TabIndex = 18;
            this.fullolabel.Text = "Φύλλο";
            // 
            // Andras
            // 
            this.Andras.AutoSize = true;
            this.Andras.ForeColor = System.Drawing.Color.DimGray;
            this.Andras.Location = new System.Drawing.Point(415, 328);
            this.Andras.Name = "Andras";
            this.Andras.Size = new System.Drawing.Size(93, 26);
            this.Andras.TabIndex = 17;
            this.Andras.Text = "Άνδρας";
            this.Andras.UseVisualStyleBackColor = true;
            this.Andras.CheckedChanged += new System.EventHandler(this.Andras_CheckedChanged);
            this.Andras.Click += new System.EventHandler(this.Andras_Click);
            // 
            // Gynaika
            // 
            this.Gynaika.AutoSize = true;
            this.Gynaika.ForeColor = System.Drawing.Color.DimGray;
            this.Gynaika.Location = new System.Drawing.Point(298, 328);
            this.Gynaika.Name = "Gynaika";
            this.Gynaika.Size = new System.Drawing.Size(95, 26);
            this.Gynaika.TabIndex = 16;
            this.Gynaika.Text = "Γυναίκα";
            this.Gynaika.UseVisualStyleBackColor = true;
            this.Gynaika.CheckedChanged += new System.EventHandler(this.Gynaika_CheckedChanged);
            this.Gynaika.Click += new System.EventHandler(this.Gynaika_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.messageLabel.Location = new System.Drawing.Point(294, 77);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(111, 20);
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
            this.Register.Location = new System.Drawing.Point(415, 612);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(189, 51);
            this.Register.TabIndex = 10;
            this.Register.Text = "Eγγραφή";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Kodikos1
            // 
            this.Kodikos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Kodikos1.ForeColor = System.Drawing.Color.Gray;
            this.Kodikos1.Location = new System.Drawing.Point(298, 211);
            this.Kodikos1.Name = "Kodikos1";
            this.Kodikos1.Size = new System.Drawing.Size(472, 27);
            this.Kodikos1.TabIndex = 8;
            this.Kodikos1.Text = "Κωδικός";
            this.Kodikos1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Kodikos1_MouseClick);
            this.Kodikos1.Leave += new System.EventHandler(this.Kodikos1_Leave);
            // 
            // Kodikos2
            // 
            this.Kodikos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Kodikos2.ForeColor = System.Drawing.Color.Gray;
            this.Kodikos2.Location = new System.Drawing.Point(298, 244);
            this.Kodikos2.Name = "Kodikos2";
            this.Kodikos2.Size = new System.Drawing.Size(472, 27);
            this.Kodikos2.TabIndex = 9;
            this.Kodikos2.Text = "Επαλήθευση Κωδικού";
            this.Kodikos2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Kodikos2_MouseClick);
            this.Kodikos2.Leave += new System.EventHandler(this.Kodikos2_Leave);
            // 
            // Epitheto
            // 
            this.Epitheto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Epitheto.ForeColor = System.Drawing.Color.Gray;
            this.Epitheto.Location = new System.Drawing.Point(538, 112);
            this.Epitheto.Name = "Epitheto";
            this.Epitheto.Size = new System.Drawing.Size(233, 27);
            this.Epitheto.TabIndex = 6;
            this.Epitheto.Text = "Επώνυμο";
            this.Epitheto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Epitheto_MouseClick);
            this.Epitheto.Leave += new System.EventHandler(this.Epitheto_Leave);
            // 
            // Onoma
            // 
            this.Onoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Onoma.ForeColor = System.Drawing.Color.DimGray;
            this.Onoma.Location = new System.Drawing.Point(298, 112);
            this.Onoma.Name = "Onoma";
            this.Onoma.Size = new System.Drawing.Size(233, 27);
            this.Onoma.TabIndex = 5;
            this.Onoma.Text = "Όνομα";
            this.Onoma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Onoma_MouseClick);
            this.Onoma.Leave += new System.EventHandler(this.Onoma_Leave);
            // 
            // EducationalCB
            // 
            this.EducationalCB.AutoSize = true;
            this.EducationalCB.ForeColor = System.Drawing.Color.DimGray;
            this.EducationalCB.Location = new System.Drawing.Point(6, 133);
            this.EducationalCB.Name = "EducationalCB";
            this.EducationalCB.Size = new System.Drawing.Size(226, 26);
            this.EducationalCB.TabIndex = 34;
            this.EducationalCB.Text = "Επιμορφωτικά Σεμινάρια";
            this.EducationalCB.UseVisualStyleBackColor = true;
            // 
            // SignUpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "SignUpUser";
            this.Size = new System.Drawing.Size(1130, 745);
            this.Load += new System.EventHandler(this.SignUpUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ConferenceCB;
        private System.Windows.Forms.CheckBox CinemaCB;
        private System.Windows.Forms.CheckBox SportsCB;
        private System.Windows.Forms.CheckBox TheaterCB;
        private System.Windows.Forms.CheckBox FstivalCB;
        private System.Windows.Forms.CheckBox MusicCB;
        private System.Windows.Forms.Label messagefullo;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullolabel;
        private System.Windows.Forms.CheckBox Andras;
        private System.Windows.Forms.CheckBox Gynaika;
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
        private System.Windows.Forms.CheckBox EducationalCB;
    }
}
