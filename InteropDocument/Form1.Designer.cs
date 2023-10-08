namespace InteropDocument
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.surnameManBox = new System.Windows.Forms.TextBox();
            this.docWriteBut = new System.Windows.Forms.Button();
            this.birhdayMan = new System.Windows.Forms.DateTimePicker();
            this.nameManBox = new System.Windows.Forms.TextBox();
            this.patronymicManBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CitizenshipManBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.residenceManBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.basesBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.courtDate = new System.Windows.Forms.DateTimePicker();
            this.certificateDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.certificateNum = new System.Windows.Forms.NumericUpDown();
            this.issuedDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.issuedBox = new System.Windows.Forms.TextBox();
            this.newSurnameBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.residenceWomanBox = new System.Windows.Forms.TextBox();
            this.surnameWomanBox = new System.Windows.Forms.TextBox();
            this.birhdayWoman = new System.Windows.Forms.DateTimePicker();
            this.nameWomanBox = new System.Windows.Forms.TextBox();
            this.patronymicWomanBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.CitizenshipWomanBox = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.marriageBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // surnameManBox
            // 
            this.surnameManBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameManBox.Location = new System.Drawing.Point(110, 44);
            this.surnameManBox.MaxLength = 25;
            this.surnameManBox.Name = "surnameManBox";
            this.surnameManBox.ShortcutsEnabled = false;
            this.surnameManBox.Size = new System.Drawing.Size(103, 27);
            this.surnameManBox.TabIndex = 1;
            this.surnameManBox.Text = "Озеров";
            this.surnameManBox.WordWrap = false;
            this.surnameManBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusChars_KeyPress);
            // 
            // docWriteBut
            // 
            this.docWriteBut.BackColor = System.Drawing.Color.White;
            this.docWriteBut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.docWriteBut.ForeColor = System.Drawing.Color.Black;
            this.docWriteBut.Location = new System.Drawing.Point(12, 802);
            this.docWriteBut.Name = "docWriteBut";
            this.docWriteBut.Size = new System.Drawing.Size(1308, 53);
            this.docWriteBut.TabIndex = 2;
            this.docWriteBut.Text = "Записать документ";
            this.docWriteBut.UseVisualStyleBackColor = false;
            this.docWriteBut.Click += new System.EventHandler(this.docWriteBut_Click);
            // 
            // birhdayMan
            // 
            this.birhdayMan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birhdayMan.Location = new System.Drawing.Point(157, 147);
            this.birhdayMan.Name = "birhdayMan";
            this.birhdayMan.Size = new System.Drawing.Size(190, 27);
            this.birhdayMan.TabIndex = 3;
            this.birhdayMan.Value = new System.DateTime(2023, 4, 22, 23, 5, 43, 0);
            // 
            // nameManBox
            // 
            this.nameManBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameManBox.Location = new System.Drawing.Point(287, 44);
            this.nameManBox.MaxLength = 25;
            this.nameManBox.Name = "nameManBox";
            this.nameManBox.ShortcutsEnabled = false;
            this.nameManBox.Size = new System.Drawing.Size(103, 27);
            this.nameManBox.TabIndex = 4;
            this.nameManBox.Text = "Ростислав";
            this.nameManBox.WordWrap = false;
            this.nameManBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusChars_KeyPress);
            // 
            // patronymicManBox
            // 
            this.patronymicManBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicManBox.Location = new System.Drawing.Point(515, 44);
            this.patronymicManBox.MaxLength = 25;
            this.patronymicManBox.Name = "patronymicManBox";
            this.patronymicManBox.ShortcutsEnabled = false;
            this.patronymicManBox.Size = new System.Drawing.Size(103, 27);
            this.patronymicManBox.TabIndex = 5;
            this.patronymicManBox.Text = "Николаевич";
            this.patronymicManBox.WordWrap = false;
            this.patronymicManBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusChars_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(420, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // CitizenshipManBox
            // 
            this.CitizenshipManBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CitizenshipManBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitizenshipManBox.FormattingEnabled = true;
            this.CitizenshipManBox.Items.AddRange(new object[] {
            "гражданин России",
            "гражданин Украины",
            "гражданин Казахстана",
            "гражданин Азербайджана",
            "гражданин Армении",
            "гражданин Белоруссии",
            "гражданин Болгарии",
            "гражданин Великобритании",
            "гражданин Венгрии",
            "гражданин Вьетнама",
            "гражданин Германии",
            "гражданин Греции",
            "гражданин Грузии",
            "гражданин Дании",
            "гражданин Египта",
            "гражданин Израиля",
            "гражданин Испании",
            "гражданин Италии",
            "гражданин Киргизии",
            "гражданин КНР",
            "гражданин Латвии",
            "гражданин Литвы",
            "гражданин Молдавии",
            "гражданин Польши",
            "гражданин Португалии",
            "гражданин Румынии",
            "гражданин Сербии",
            "гражданин Словакии",
            "гражданин Словении",
            "гражданин США",
            "гражданин Таджикистана",
            "гражданин Таиланда",
            "гражданин Туркмении",
            "гражданин Турции",
            "гражданин Узбекистана",
            "гражданин Франции",
            "гражданин Черногории",
            "гражданин Чехии",
            "гражданин Швеции",
            "гражданин Эстонии"});
            this.CitizenshipManBox.Location = new System.Drawing.Point(149, 108);
            this.CitizenshipManBox.Name = "CitizenshipManBox";
            this.CitizenshipManBox.Size = new System.Drawing.Size(317, 27);
            this.CitizenshipManBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Гражданство";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата рождения";
            // 
            // residenceManBox
            // 
            this.residenceManBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.residenceManBox.Location = new System.Drawing.Point(16, 237);
            this.residenceManBox.MaxLength = 250;
            this.residenceManBox.Name = "residenceManBox";
            this.residenceManBox.ShortcutsEnabled = false;
            this.residenceManBox.Size = new System.Drawing.Size(602, 27);
            this.residenceManBox.TabIndex = 11;
            this.residenceManBox.Text = "г. Москва ул. Каскадная д. 20 кор. 3\r\n";
            this.residenceManBox.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Место рождения";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label13.Location = new System.Drawing.Point(359, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 22);
            this.label13.TabIndex = 36;
            this.label13.Text = "Место регистрации";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label14.Location = new System.Drawing.Point(12, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 22);
            this.label14.TabIndex = 34;
            this.label14.Text = "Номер свидетельства";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label15.Location = new System.Drawing.Point(517, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 22);
            this.label15.TabIndex = 33;
            this.label15.Text = "и составлено";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label16.Location = new System.Drawing.Point(12, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 22);
            this.label16.TabIndex = 31;
            this.label16.Text = "Основание действительно от";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label17.Location = new System.Drawing.Point(407, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 22);
            this.label17.TabIndex = 30;
            this.label17.Text = "На основании";
            // 
            // basesBox
            // 
            this.basesBox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.basesBox.Location = new System.Drawing.Point(561, 109);
            this.basesBox.MaxLength = 350;
            this.basesBox.Multiline = true;
            this.basesBox.Name = "basesBox";
            this.basesBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.basesBox.ShortcutsEnabled = false;
            this.basesBox.Size = new System.Drawing.Size(717, 65);
            this.basesBox.TabIndex = 28;
            this.basesBox.Text = "решения суда о расторжении брака: мировой судья 229 судебного участка Сергиево-По" +
    "садского судебного района Московской";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label18.Location = new System.Drawing.Point(12, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 22);
            this.label18.TabIndex = 25;
            this.label18.Text = "Брак прекращен";
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.endDate.Location = new System.Drawing.Point(175, 105);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(190, 27);
            this.endDate.TabIndex = 37;
            this.endDate.Value = new System.DateTime(2023, 4, 22, 23, 5, 43, 0);
            // 
            // courtDate
            // 
            this.courtDate.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.courtDate.Location = new System.Drawing.Point(308, 216);
            this.courtDate.Name = "courtDate";
            this.courtDate.Size = new System.Drawing.Size(190, 27);
            this.courtDate.TabIndex = 38;
            this.courtDate.Value = new System.DateTime(2023, 4, 22, 23, 5, 43, 0);
            // 
            // certificateDate
            // 
            this.certificateDate.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.certificateDate.Location = new System.Drawing.Point(660, 216);
            this.certificateDate.Name = "certificateDate";
            this.certificateDate.Size = new System.Drawing.Size(190, 27);
            this.certificateDate.TabIndex = 39;
            this.certificateDate.Value = new System.DateTime(2023, 4, 22, 23, 5, 43, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label20.Location = new System.Drawing.Point(966, 468);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 22);
            this.label20.TabIndex = 41;
            this.label20.Text = "Дата выдачи";
            // 
            // certificateNum
            // 
            this.certificateNum.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.certificateNum.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.certificateNum.Location = new System.Drawing.Point(227, 42);
            this.certificateNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.certificateNum.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.certificateNum.Name = "certificateNum";
            this.certificateNum.Size = new System.Drawing.Size(100, 27);
            this.certificateNum.TabIndex = 42;
            this.certificateNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.certificateNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusChars_KeyPress);
            // 
            // issuedDate
            // 
            this.issuedDate.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.issuedDate.Location = new System.Drawing.Point(1088, 464);
            this.issuedDate.Name = "issuedDate";
            this.issuedDate.Size = new System.Drawing.Size(190, 27);
            this.issuedDate.TabIndex = 44;
            this.issuedDate.Value = new System.DateTime(2023, 4, 22, 23, 5, 43, 0);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label21.Location = new System.Drawing.Point(754, 423);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(192, 22);
            this.label21.TabIndex = 45;
            this.label21.Text = "Сертификат выдал(а)";
            // 
            // issuedBox
            // 
            this.issuedBox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.issuedBox.Location = new System.Drawing.Point(961, 422);
            this.issuedBox.Name = "issuedBox";
            this.issuedBox.ShortcutsEnabled = false;
            this.issuedBox.Size = new System.Drawing.Size(317, 27);
            this.issuedBox.TabIndex = 46;
            this.issuedBox.Text = "Пяткина Галина Сергеевна";
            this.issuedBox.WordWrap = false;
            this.issuedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusSpaceChars_KeyPress);
            // 
            // newSurnameBox
            // 
            this.newSurnameBox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.newSurnameBox.Location = new System.Drawing.Point(170, 295);
            this.newSurnameBox.MaxLength = 25;
            this.newSurnameBox.Name = "newSurnameBox";
            this.newSurnameBox.ShortcutsEnabled = false;
            this.newSurnameBox.Size = new System.Drawing.Size(100, 27);
            this.newSurnameBox.TabIndex = 48;
            this.newSurnameBox.Text = "Озёров";
            this.newSurnameBox.WordWrap = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label22.Location = new System.Drawing.Point(14, 296);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 22);
            this.label22.TabIndex = 47;
            this.label22.Text = "Новая фамилия";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.residenceManBox);
            this.groupBox1.Controls.Add(this.surnameManBox);
            this.groupBox1.Controls.Add(this.birhdayMan);
            this.groupBox1.Controls.Add(this.nameManBox);
            this.groupBox1.Controls.Add(this.patronymicManBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CitizenshipManBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(636, 277);
            this.groupBox1.MinimumSize = new System.Drawing.Size(636, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 277);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения о муже";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.residenceWomanBox);
            this.groupBox2.Controls.Add(this.surnameWomanBox);
            this.groupBox2.Controls.Add(this.birhdayWoman);
            this.groupBox2.Controls.Add(this.nameWomanBox);
            this.groupBox2.Controls.Add(this.patronymicWomanBox);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.CitizenshipWomanBox);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(685, 12);
            this.groupBox2.MaximumSize = new System.Drawing.Size(636, 277);
            this.groupBox2.MinimumSize = new System.Drawing.Size(636, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 277);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сведения о жене";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(12, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 22);
            this.label23.TabIndex = 0;
            this.label23.Text = "Фамилия";
            // 
            // residenceWomanBox
            // 
            this.residenceWomanBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.residenceWomanBox.Location = new System.Drawing.Point(16, 237);
            this.residenceWomanBox.MaxLength = 250;
            this.residenceWomanBox.Name = "residenceWomanBox";
            this.residenceWomanBox.ShortcutsEnabled = false;
            this.residenceWomanBox.Size = new System.Drawing.Size(602, 27);
            this.residenceWomanBox.TabIndex = 11;
            this.residenceWomanBox.Text = "г. Москва ул. Каскадная д. 20 кор. 2\r\n";
            this.residenceWomanBox.WordWrap = false;
            // 
            // surnameWomanBox
            // 
            this.surnameWomanBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameWomanBox.Location = new System.Drawing.Point(110, 44);
            this.surnameWomanBox.MaxLength = 25;
            this.surnameWomanBox.Name = "surnameWomanBox";
            this.surnameWomanBox.ShortcutsEnabled = false;
            this.surnameWomanBox.Size = new System.Drawing.Size(103, 27);
            this.surnameWomanBox.TabIndex = 1;
            this.surnameWomanBox.Text = "Озерова";
            this.surnameWomanBox.WordWrap = false;
            this.surnameWomanBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusChars_KeyPress);
            // 
            // birhdayWoman
            // 
            this.birhdayWoman.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birhdayWoman.Location = new System.Drawing.Point(157, 147);
            this.birhdayWoman.Name = "birhdayWoman";
            this.birhdayWoman.Size = new System.Drawing.Size(190, 27);
            this.birhdayWoman.TabIndex = 3;
            this.birhdayWoman.Value = new System.DateTime(2023, 4, 22, 23, 5, 43, 0);
            // 
            // nameWomanBox
            // 
            this.nameWomanBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameWomanBox.Location = new System.Drawing.Point(287, 44);
            this.nameWomanBox.MaxLength = 25;
            this.nameWomanBox.Name = "nameWomanBox";
            this.nameWomanBox.ShortcutsEnabled = false;
            this.nameWomanBox.Size = new System.Drawing.Size(103, 27);
            this.nameWomanBox.TabIndex = 4;
            this.nameWomanBox.Text = "Ростислава";
            this.nameWomanBox.WordWrap = false;
            this.nameWomanBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusChars_KeyPress);
            // 
            // patronymicWomanBox
            // 
            this.patronymicWomanBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicWomanBox.Location = new System.Drawing.Point(515, 44);
            this.patronymicWomanBox.MaxLength = 25;
            this.patronymicWomanBox.Name = "patronymicWomanBox";
            this.patronymicWomanBox.ShortcutsEnabled = false;
            this.patronymicWomanBox.Size = new System.Drawing.Size(103, 27);
            this.patronymicWomanBox.TabIndex = 5;
            this.patronymicWomanBox.Text = "Николаевна";
            this.patronymicWomanBox.WordWrap = false;
            this.patronymicWomanBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rusChars_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(235, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 22);
            this.label24.TabIndex = 6;
            this.label24.Text = "Имя";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(420, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 22);
            this.label25.TabIndex = 7;
            this.label25.Text = "Отчество";
            // 
            // CitizenshipWomanBox
            // 
            this.CitizenshipWomanBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CitizenshipWomanBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitizenshipWomanBox.FormattingEnabled = true;
            this.CitizenshipWomanBox.Items.AddRange(new object[] {
            "гражданка России",
            "гражданка Украины",
            "гражданка Казахстана",
            "гражданка Азербайджана",
            "гражданка Армении",
            "гражданка Белоруссии",
            "гражданка Болгарии",
            "гражданка Великобритании",
            "гражданка Венгрии",
            "гражданка Вьетнама",
            "гражданка Германии",
            "гражданка Греции",
            "гражданка Грузии",
            "гражданка Дании",
            "гражданка Египта",
            "гражданка Израиля",
            "гражданка Испании",
            "гражданка Италии",
            "гражданка Киргизии",
            "гражданка КНР",
            "гражданка Латвии",
            "гражданка Литвы",
            "гражданка Молдавии",
            "гражданка Польши",
            "гражданка Португалии",
            "гражданка Румынии",
            "гражданка Сербии",
            "гражданка Словакии",
            "гражданка Словении",
            "гражданка США",
            "гражданка Таджикистана",
            "гражданка Таиланда",
            "гражданка Туркмении",
            "гражданка Турции",
            "гражданка Узбекистана",
            "гражданка Франции",
            "гражданка Черногории",
            "гражданка Чехии",
            "гражданка Швеции",
            "гражданка Эстонии"});
            this.CitizenshipWomanBox.Location = new System.Drawing.Point(149, 108);
            this.CitizenshipWomanBox.Name = "CitizenshipWomanBox";
            this.CitizenshipWomanBox.Size = new System.Drawing.Size(317, 27);
            this.CitizenshipWomanBox.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(12, 108);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 22);
            this.label26.TabIndex = 9;
            this.label26.Text = "Гражданство";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(12, 151);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(139, 22);
            this.label27.TabIndex = 10;
            this.label27.Text = "Дата рождения";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(12, 208);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(153, 22);
            this.label28.TabIndex = 12;
            this.label28.Text = "Место рождения";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.marriageBox);
            this.groupBox3.Controls.Add(this.certificateDate);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.basesBox);
            this.groupBox3.Controls.Add(this.newSurnameBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.issuedBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.issuedDate);
            this.groupBox3.Controls.Add(this.endDate);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.certificateNum);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.courtDate);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(13, 295);
            this.groupBox3.MaximumSize = new System.Drawing.Size(1307, 501);
            this.groupBox3.MinimumSize = new System.Drawing.Size(1307, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1307, 501);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сведения о свидетельстве";
            // 
            // marriageBox
            // 
            this.marriageBox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.marriageBox.Location = new System.Drawing.Point(561, 300);
            this.marriageBox.MaxLength = 350;
            this.marriageBox.Multiline = true;
            this.marriageBox.Name = "marriageBox";
            this.marriageBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.marriageBox.ShortcutsEnabled = false;
            this.marriageBox.Size = new System.Drawing.Size(717, 65);
            this.marriageBox.TabIndex = 49;
            this.marriageBox.Text = "Сергиево-Посадского управление ЗАГС главного управления ЗАГС Московской области\r\n" +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1338, 863);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.docWriteBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ПО для заполнения данных в свидетельство о расторжении брака";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certificateNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameManBox;
        private System.Windows.Forms.Button docWriteBut;
        private System.Windows.Forms.DateTimePicker birhdayMan;
        private System.Windows.Forms.TextBox nameManBox;
        private System.Windows.Forms.TextBox patronymicManBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CitizenshipManBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox residenceManBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox basesBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker courtDate;
        private System.Windows.Forms.DateTimePicker certificateDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown certificateNum;
        private System.Windows.Forms.DateTimePicker issuedDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox issuedBox;
        private System.Windows.Forms.TextBox newSurnameBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox residenceWomanBox;
        private System.Windows.Forms.TextBox surnameWomanBox;
        private System.Windows.Forms.DateTimePicker birhdayWoman;
        private System.Windows.Forms.TextBox nameWomanBox;
        private System.Windows.Forms.TextBox patronymicWomanBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox CitizenshipWomanBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox marriageBox;
    }
}

