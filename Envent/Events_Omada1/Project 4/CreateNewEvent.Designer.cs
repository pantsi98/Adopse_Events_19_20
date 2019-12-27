namespace Project_4
{
    partial class CreateNewEvent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titlos = new System.Windows.Forms.TextBox();
            this.perigrafi = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.topothesia = new System.Windows.Forms.ComboBox();
            this.katigoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.Addplay = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.durationhour = new System.Windows.Forms.NumericUpDown();
            this.durationmin = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Timemin = new System.Windows.Forms.NumericUpDown();
            this.timehour = new System.Windows.Forms.NumericUpDown();
            this.kanonikoticket = new System.Windows.Forms.NumericUpDown();
            this.meiomenoticket = new System.Windows.Forms.NumericUpDown();
            this.createEvent = new System.Windows.Forms.Button();
            this.createplaypanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timehour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanonikoticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meiomenoticket)).BeginInit();
            this.createplaypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1414, 61);
            this.panel1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(448, -9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 79);
            this.label2.TabIndex = 1;
            this.label2.Text = "Δημιουργία Νέου Event";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(60, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Τίτλος:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Τοποθεσία:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Eικόνα:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(60, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Διάρκεια:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(60, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Περιγραφή:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(60, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Κατηγορία:";
            // 
            // titlos
            // 
            this.titlos.Location = new System.Drawing.Point(206, 121);
            this.titlos.Margin = new System.Windows.Forms.Padding(4);
            this.titlos.Name = "titlos";
            this.titlos.Size = new System.Drawing.Size(350, 27);
            this.titlos.TabIndex = 48;
            // 
            // perigrafi
            // 
            this.perigrafi.Location = new System.Drawing.Point(206, 217);
            this.perigrafi.Margin = new System.Windows.Forms.Padding(4);
            this.perigrafi.Name = "perigrafi";
            this.perigrafi.Size = new System.Drawing.Size(350, 27);
            this.perigrafi.TabIndex = 50;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(206, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(572, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 54;
            this.button1.Text = "Εισαγώγη εικόνας";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // topothesia
            // 
            this.topothesia.FormattingEnabled = true;
            this.topothesia.Location = new System.Drawing.Point(207, 55);
            this.topothesia.Name = "topothesia";
            this.topothesia.Size = new System.Drawing.Size(314, 28);
            this.topothesia.TabIndex = 55;
            // 
            // katigoria
            // 
            this.katigoria.AutoCompleteCustomSource.AddRange(new string[] {
            "Μουσική"});
            this.katigoria.FormattingEnabled = true;
            this.katigoria.Items.AddRange(new object[] {
            "Music",
            "Theater",
            "Conference",
            "Festivals",
            "Sports",
            "Educational",
            "Informing",
            "Soccer",
            "Basketball",
            "Cinema"});
            this.katigoria.Location = new System.Drawing.Point(206, 167);
            this.katigoria.Name = "katigoria";
            this.katigoria.Size = new System.Drawing.Size(350, 28);
            this.katigoria.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Ημερομηνία:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(314, 27);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 258);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 292);
            this.listView1.TabIndex = 59;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Δημιουργία Νέας Παράστασης";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Addplay
            // 
            this.Addplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.Addplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Addplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addplay.Location = new System.Drawing.Point(179, 197);
            this.Addplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addplay.Name = "Addplay";
            this.Addplay.Size = new System.Drawing.Size(265, 34);
            this.Addplay.TabIndex = 61;
            this.Addplay.Text = "Προσθήκη Πάραστασης";
            this.Addplay.UseVisualStyleBackColor = false;
            this.Addplay.Click += new System.EventHandler(this.AddPlay_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "Ώρα:";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Savebtn.Location = new System.Drawing.Point(1069, 670);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(241, 48);
            this.Savebtn.TabIndex = 66;
            this.Savebtn.Text = "Αποθήκευση";
            this.Savebtn.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 551);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Τιμή εισητηρίων:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 551);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "μειωμένο";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 551);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 69;
            this.label13.Text = "κανονικό";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(538, 558);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "€";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(353, 558);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 20);
            this.label15.TabIndex = 73;
            this.label15.Text = "€";
            // 
            // durationhour
            // 
            this.durationhour.Location = new System.Drawing.Point(289, 261);
            this.durationhour.Name = "durationhour";
            this.durationhour.Size = new System.Drawing.Size(54, 27);
            this.durationhour.TabIndex = 76;
            // 
            // durationmin
            // 
            this.durationmin.Location = new System.Drawing.Point(480, 263);
            this.durationmin.Name = "durationmin";
            this.durationmin.Size = new System.Drawing.Size(54, 27);
            this.durationmin.TabIndex = 77;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(237, 263);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 78;
            this.label16.Text = "ώρες";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(421, 263);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 79;
            this.label17.Text = "λεπτά";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(392, 149);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 83;
            this.label18.Text = "λεπτά";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(225, 149);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 20);
            this.label19.TabIndex = 82;
            this.label19.Text = "ώρα";
            // 
            // Timemin
            // 
            this.Timemin.Location = new System.Drawing.Point(451, 147);
            this.Timemin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Timemin.Name = "Timemin";
            this.Timemin.Size = new System.Drawing.Size(54, 27);
            this.Timemin.TabIndex = 81;
            // 
            // timehour
            // 
            this.timehour.Location = new System.Drawing.Point(282, 147);
            this.timehour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timehour.Name = "timehour";
            this.timehour.Size = new System.Drawing.Size(54, 27);
            this.timehour.TabIndex = 80;
            // 
            // kanonikoticket
            // 
            this.kanonikoticket.Location = new System.Drawing.Point(292, 551);
            this.kanonikoticket.Name = "kanonikoticket";
            this.kanonikoticket.Size = new System.Drawing.Size(54, 27);
            this.kanonikoticket.TabIndex = 84;
            // 
            // meiomenoticket
            // 
            this.meiomenoticket.Location = new System.Drawing.Point(480, 551);
            this.meiomenoticket.Name = "meiomenoticket";
            this.meiomenoticket.Size = new System.Drawing.Size(54, 27);
            this.meiomenoticket.TabIndex = 85;
            // 
            // createEvent
            // 
            this.createEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(233)))));
            this.createEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createEvent.Location = new System.Drawing.Point(227, 623);
            this.createEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createEvent.Name = "createEvent";
            this.createEvent.Size = new System.Drawing.Size(223, 47);
            this.createEvent.TabIndex = 86;
            this.createEvent.Text = "Δημιουργία Event";
            this.createEvent.UseVisualStyleBackColor = false;
            this.createEvent.Click += new System.EventHandler(this.createEvent_Click);
            // 
            // createplaypanel
            // 
            this.createplaypanel.Controls.Add(this.Addplay);
            this.createplaypanel.Controls.Add(this.label3);
            this.createplaypanel.Controls.Add(this.topothesia);
            this.createplaypanel.Controls.Add(this.label8);
            this.createplaypanel.Controls.Add(this.label18);
            this.createplaypanel.Controls.Add(this.dateTimePicker1);
            this.createplaypanel.Controls.Add(this.label19);
            this.createplaypanel.Controls.Add(this.listView1);
            this.createplaypanel.Controls.Add(this.Timemin);
            this.createplaypanel.Controls.Add(this.label9);
            this.createplaypanel.Controls.Add(this.timehour);
            this.createplaypanel.Controls.Add(this.label10);
            this.createplaypanel.Location = new System.Drawing.Point(707, 66);
            this.createplaypanel.Name = "createplaypanel";
            this.createplaypanel.Size = new System.Drawing.Size(641, 592);
            this.createplaypanel.TabIndex = 87;
            this.createplaypanel.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 66);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(185, 20);
            this.label20.TabIndex = 88;
            this.label20.Text = "Δημιουργία Νέου Event";
            // 
            // CreateNewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.createplaypanel);
            this.Controls.Add(this.createEvent);
            this.Controls.Add(this.meiomenoticket);
            this.Controls.Add(this.kanonikoticket);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.durationmin);
            this.Controls.Add(this.durationhour);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.katigoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.perigrafi);
            this.Controls.Add(this.titlos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateNewEvent";
            this.Size = new System.Drawing.Size(1363, 736);
            this.Load += new System.EventHandler(this.CreateNewEvent_Load);
            this.MouseHover += new System.EventHandler(this.CreateNewEvent_MouseHover);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timehour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanonikoticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meiomenoticket)).EndInit();
            this.createplaypanel.ResumeLayout(false);
            this.createplaypanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titlos;
        private System.Windows.Forms.TextBox perigrafi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox topothesia;
        private System.Windows.Forms.ComboBox katigoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Addplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown durationhour;
        private System.Windows.Forms.NumericUpDown durationmin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown Timemin;
        private System.Windows.Forms.NumericUpDown timehour;
        private System.Windows.Forms.NumericUpDown kanonikoticket;
        private System.Windows.Forms.NumericUpDown meiomenoticket;
        private System.Windows.Forms.Button createEvent;
        private System.Windows.Forms.Panel createplaypanel;
        private System.Windows.Forms.Label label20;
    }
}
