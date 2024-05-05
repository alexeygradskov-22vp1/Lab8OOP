namespace Lab7OOp
{
    partial class MainForm
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
            this.quantityArgs = new System.Windows.Forms.GroupBox();
            this.allArgsRB = new System.Windows.Forms.RadioButton();
            this.twoArgsRb = new System.Windows.Forms.RadioButton();
            this.oneArgRB = new System.Windows.Forms.RadioButton();
            this.withoutArgsRB = new System.Windows.Forms.RadioButton();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.QuantLb = new System.Windows.Forms.Label();
            this.phoneLb = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.addressLb = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.squareLb = new System.Windows.Forms.Label();
            this.squareTB = new System.Windows.Forms.TextBox();
            this.avgNumbLb = new System.Windows.Forms.Label();
            this.avgNumberTb = new System.Windows.Forms.TextBox();
            this.rateLb = new System.Windows.Forms.Label();
            this.rateTB = new System.Windows.Forms.TextBox();
            this.selectLibCB = new System.Windows.Forms.ComboBox();
            this.panelForChoice = new System.Windows.Forms.Panel();
            this.panelForUpdate = new System.Windows.Forms.Panel();
            this.rateUpdLb = new System.Windows.Forms.Label();
            this.rateUpdTB = new System.Windows.Forms.TextBox();
            this.avgNumberUpdLb = new System.Windows.Forms.Label();
            this.avgNumberUpdTb = new System.Windows.Forms.TextBox();
            this.squareUpdLb = new System.Windows.Forms.Label();
            this.squareUpdTb = new System.Windows.Forms.TextBox();
            this.addressUpdLb = new System.Windows.Forms.Label();
            this.addressUpdTB = new System.Windows.Forms.TextBox();
            this.phoneUpdLb = new System.Windows.Forms.Label();
            this.phoneUpdTB = new System.Windows.Forms.TextBox();
            this.quantityUpdLb = new System.Windows.Forms.Label();
            this.quantityUpdTb = new System.Windows.Forms.TextBox();
            this.name2Lb = new System.Windows.Forms.Label();
            this.nameUpdTb = new System.Windows.Forms.TextBox();
            this.saveLibBtn = new System.Windows.Forms.Button();
            this.AddLibBtn = new System.Windows.Forms.Button();
            this.printDataBtn = new System.Windows.Forms.Button();
            this.objectCounterLabel = new System.Windows.Forms.Label();
            this.rateOutCB = new System.Windows.Forms.CheckBox();
            this.avgNumberOutCB = new System.Windows.Forms.CheckBox();
            this.squareOutCB = new System.Windows.Forms.CheckBox();
            this.addressOutCB = new System.Windows.Forms.CheckBox();
            this.phoneOutCB = new System.Windows.Forms.CheckBox();
            this.quantityOutCB = new System.Windows.Forms.CheckBox();
            this.nameOutCB = new System.Windows.Forms.CheckBox();
            this.calculate = new System.Windows.Forms.Button();
            this.quantityArgs.SuspendLayout();
            this.panelForUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // quantityArgs
            // 
            this.quantityArgs.Controls.Add(this.allArgsRB);
            this.quantityArgs.Controls.Add(this.twoArgsRb);
            this.quantityArgs.Controls.Add(this.oneArgRB);
            this.quantityArgs.Controls.Add(this.withoutArgsRB);
            this.quantityArgs.Location = new System.Drawing.Point(12, 12);
            this.quantityArgs.Name = "quantityArgs";
            this.quantityArgs.Size = new System.Drawing.Size(265, 72);
            this.quantityArgs.TabIndex = 1;
            this.quantityArgs.TabStop = false;
            // 
            // allArgsRB
            // 
            this.allArgsRB.AutoSize = true;
            this.allArgsRB.Location = new System.Drawing.Point(146, 47);
            this.allArgsRB.Name = "allArgsRB";
            this.allArgsRB.Size = new System.Drawing.Size(126, 20);
            this.allArgsRB.TabIndex = 3;
            this.allArgsRB.Text = "Все аргументы";
            this.allArgsRB.UseVisualStyleBackColor = true;
            this.allArgsRB.CheckedChanged += new System.EventHandler(this.allArgsRB_CheckedChanged);
            // 
            // twoArgsRb
            // 
            this.twoArgsRb.AutoSize = true;
            this.twoArgsRb.Location = new System.Drawing.Point(146, 21);
            this.twoArgsRb.Name = "twoArgsRb";
            this.twoArgsRb.Size = new System.Drawing.Size(108, 20);
            this.twoArgsRb.TabIndex = 2;
            this.twoArgsRb.Text = "2 аргумента";
            this.twoArgsRb.UseVisualStyleBackColor = true;
            this.twoArgsRb.CheckedChanged += new System.EventHandler(this.twoArgsRb_CheckedChanged);
            // 
            // oneArgRB
            // 
            this.oneArgRB.AutoSize = true;
            this.oneArgRB.Location = new System.Drawing.Point(6, 47);
            this.oneArgRB.Name = "oneArgRB";
            this.oneArgRB.Size = new System.Drawing.Size(100, 20);
            this.oneArgRB.TabIndex = 1;
            this.oneArgRB.Text = "1 аргумент";
            this.oneArgRB.UseVisualStyleBackColor = true;
            this.oneArgRB.CheckedChanged += new System.EventHandler(this.oneArgRB_CheckedChanged);
            // 
            // withoutArgsRB
            // 
            this.withoutArgsRB.AutoSize = true;
            this.withoutArgsRB.Location = new System.Drawing.Point(6, 21);
            this.withoutArgsRB.Name = "withoutArgsRB";
            this.withoutArgsRB.Size = new System.Drawing.Size(134, 20);
            this.withoutArgsRB.TabIndex = 0;
            this.withoutArgsRB.Text = "Без аргументов";
            this.withoutArgsRB.UseVisualStyleBackColor = true;
            this.withoutArgsRB.CheckedChanged += new System.EventHandler(this.withoutArgsRB_CheckedChanged);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(12, 117);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(265, 22);
            this.NameTb.TabIndex = 2;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(9, 98);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(106, 16);
            this.nameLb.TabIndex = 3;
            this.nameLb.Text = "Наименование";
            // 
            // quantityTb
            // 
            this.quantityTb.Location = new System.Drawing.Point(12, 160);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(265, 22);
            this.quantityTb.TabIndex = 4;
            // 
            // QuantLb
            // 
            this.QuantLb.AutoSize = true;
            this.QuantLb.Location = new System.Drawing.Point(12, 142);
            this.QuantLb.Name = "QuantLb";
            this.QuantLb.Size = new System.Drawing.Size(142, 16);
            this.QuantLb.TabIndex = 5;
            this.QuantLb.Text = "Библиотечный фонд";
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.Location = new System.Drawing.Point(12, 185);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(119, 16);
            this.phoneLb.TabIndex = 7;
            this.phoneLb.Text = "Номер телефона";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(12, 203);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(265, 22);
            this.phoneTB.TabIndex = 6;
            // 
            // addressLb
            // 
            this.addressLb.AutoSize = true;
            this.addressLb.Location = new System.Drawing.Point(12, 228);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(47, 16);
            this.addressLb.TabIndex = 9;
            this.addressLb.Text = "Адрес";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(12, 246);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(265, 22);
            this.addressTB.TabIndex = 8;
            // 
            // squareLb
            // 
            this.squareLb.AutoSize = true;
            this.squareLb.Location = new System.Drawing.Point(12, 271);
            this.squareLb.Name = "squareLb";
            this.squareLb.Size = new System.Drawing.Size(65, 16);
            this.squareLb.TabIndex = 11;
            this.squareLb.Text = "Площадь";
            // 
            // squareTB
            // 
            this.squareTB.Location = new System.Drawing.Point(12, 289);
            this.squareTB.Name = "squareTB";
            this.squareTB.Size = new System.Drawing.Size(79, 22);
            this.squareTB.TabIndex = 10;
            // 
            // avgNumbLb
            // 
            this.avgNumbLb.AutoSize = true;
            this.avgNumbLb.Location = new System.Drawing.Point(94, 271);
            this.avgNumbLb.Name = "avgNumbLb";
            this.avgNumbLb.Size = new System.Drawing.Size(78, 16);
            this.avgNumbLb.TabIndex = 13;
            this.avgNumbLb.Text = "Кол. посет.";
            // 
            // avgNumberTb
            // 
            this.avgNumberTb.Location = new System.Drawing.Point(97, 289);
            this.avgNumberTb.Name = "avgNumberTb";
            this.avgNumberTb.Size = new System.Drawing.Size(79, 22);
            this.avgNumberTb.TabIndex = 12;
            // 
            // rateLb
            // 
            this.rateLb.AutoSize = true;
            this.rateLb.Location = new System.Drawing.Point(179, 271);
            this.rateLb.Name = "rateLb";
            this.rateLb.Size = new System.Drawing.Size(61, 16);
            this.rateLb.TabIndex = 15;
            this.rateLb.Text = "Рейтинг";
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(182, 289);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(79, 22);
            this.rateTB.TabIndex = 14;
            // 
            // selectLibCB
            // 
            this.selectLibCB.FormattingEnabled = true;
            this.selectLibCB.Location = new System.Drawing.Point(562, 13);
            this.selectLibCB.Name = "selectLibCB";
            this.selectLibCB.Size = new System.Drawing.Size(226, 24);
            this.selectLibCB.TabIndex = 16;
            this.selectLibCB.Text = "Не выбрано";
            this.selectLibCB.SelectedIndexChanged += new System.EventHandler(this.selectLibCB_SelectedIndexChanged);
            // 
            // panelForChoice
            // 
            this.panelForChoice.Location = new System.Drawing.Point(3, 12);
            this.panelForChoice.Name = "panel1";
            this.panelForChoice.Size = new System.Drawing.Size(290, 317);
            this.panelForChoice.TabIndex = 31;
            // 
            // panelForUpdate
            // 
            this.panelForUpdate.Controls.Add(this.rateUpdLb);
            this.panelForUpdate.Controls.Add(this.rateUpdTB);
            this.panelForUpdate.Controls.Add(this.avgNumberUpdLb);
            this.panelForUpdate.Controls.Add(this.avgNumberUpdTb);
            this.panelForUpdate.Controls.Add(this.squareUpdLb);
            this.panelForUpdate.Controls.Add(this.squareUpdTb);
            this.panelForUpdate.Controls.Add(this.addressUpdLb);
            this.panelForUpdate.Controls.Add(this.addressUpdTB);
            this.panelForUpdate.Controls.Add(this.phoneUpdLb);
            this.panelForUpdate.Controls.Add(this.phoneUpdTB);
            this.panelForUpdate.Controls.Add(this.quantityUpdLb);
            this.panelForUpdate.Controls.Add(this.quantityUpdTb);
            this.panelForUpdate.Controls.Add(this.name2Lb);
            this.panelForUpdate.Controls.Add(this.nameUpdTb);
            this.panelForUpdate.Location = new System.Drawing.Point(299, 43);
            this.panelForUpdate.Name = "panel2";
            this.panelForUpdate.Size = new System.Drawing.Size(290, 270);
            this.panelForUpdate.TabIndex = 32;
            // 
            // rateUpdLb
            // 
            this.rateUpdLb.AutoSize = true;
            this.rateUpdLb.Location = new System.Drawing.Point(173, 198);
            this.rateUpdLb.Name = "rateUpdLb";
            this.rateUpdLb.Size = new System.Drawing.Size(61, 16);
            this.rateUpdLb.TabIndex = 44;
            this.rateUpdLb.Text = "Рейтинг";
            // 
            // rateUpdTB
            // 
            this.rateUpdTB.Location = new System.Drawing.Point(176, 216);
            this.rateUpdTB.Name = "rateUpdTB";
            this.rateUpdTB.Size = new System.Drawing.Size(79, 22);
            this.rateUpdTB.TabIndex = 43;
            // 
            // avgNumberUpdLb
            // 
            this.avgNumberUpdLb.AutoSize = true;
            this.avgNumberUpdLb.Location = new System.Drawing.Point(88, 198);
            this.avgNumberUpdLb.Name = "avgNumberUpdLb";
            this.avgNumberUpdLb.Size = new System.Drawing.Size(78, 16);
            this.avgNumberUpdLb.TabIndex = 42;
            this.avgNumberUpdLb.Text = "Кол. посет.";
            // 
            // avgNumberUpdTb
            // 
            this.avgNumberUpdTb.Location = new System.Drawing.Point(91, 216);
            this.avgNumberUpdTb.Name = "avgNumberUpdTb";
            this.avgNumberUpdTb.Size = new System.Drawing.Size(79, 22);
            this.avgNumberUpdTb.TabIndex = 41;
            // 
            // squareUpdLb
            // 
            this.squareUpdLb.AutoSize = true;
            this.squareUpdLb.Location = new System.Drawing.Point(6, 198);
            this.squareUpdLb.Name = "squareUpdLb";
            this.squareUpdLb.Size = new System.Drawing.Size(65, 16);
            this.squareUpdLb.TabIndex = 40;
            this.squareUpdLb.Text = "Площадь";
            // 
            // squareUpdTb
            // 
            this.squareUpdTb.Location = new System.Drawing.Point(6, 216);
            this.squareUpdTb.Name = "squareUpdTb";
            this.squareUpdTb.Size = new System.Drawing.Size(79, 22);
            this.squareUpdTb.TabIndex = 39;
            // 
            // addressUpdLb
            // 
            this.addressUpdLb.AutoSize = true;
            this.addressUpdLb.Location = new System.Drawing.Point(6, 155);
            this.addressUpdLb.Name = "addressUpdLb";
            this.addressUpdLb.Size = new System.Drawing.Size(47, 16);
            this.addressUpdLb.TabIndex = 38;
            this.addressUpdLb.Text = "Адрес";
            // 
            // addressUpdTB
            // 
            this.addressUpdTB.Location = new System.Drawing.Point(6, 173);
            this.addressUpdTB.Name = "addressUpdTB";
            this.addressUpdTB.Size = new System.Drawing.Size(265, 22);
            this.addressUpdTB.TabIndex = 37;
            // 
            // phoneUpdLb
            // 
            this.phoneUpdLb.AutoSize = true;
            this.phoneUpdLb.Location = new System.Drawing.Point(6, 112);
            this.phoneUpdLb.Name = "phoneUpdLb";
            this.phoneUpdLb.Size = new System.Drawing.Size(119, 16);
            this.phoneUpdLb.TabIndex = 36;
            this.phoneUpdLb.Text = "Номер телефона";
            // 
            // phoneUpdTB
            // 
            this.phoneUpdTB.Location = new System.Drawing.Point(6, 130);
            this.phoneUpdTB.Name = "phoneUpdTB";
            this.phoneUpdTB.Size = new System.Drawing.Size(265, 22);
            this.phoneUpdTB.TabIndex = 35;
            // 
            // quantityUpdLb
            // 
            this.quantityUpdLb.AutoSize = true;
            this.quantityUpdLb.Location = new System.Drawing.Point(6, 69);
            this.quantityUpdLb.Name = "quantityUpdLb";
            this.quantityUpdLb.Size = new System.Drawing.Size(142, 16);
            this.quantityUpdLb.TabIndex = 34;
            this.quantityUpdLb.Text = "Библиотечный фонд";
            // 
            // quantityUpdTb
            // 
            this.quantityUpdTb.Location = new System.Drawing.Point(6, 87);
            this.quantityUpdTb.Name = "quantityUpdTb";
            this.quantityUpdTb.Size = new System.Drawing.Size(265, 22);
            this.quantityUpdTb.TabIndex = 33;
            // 
            // name2Lb
            // 
            this.name2Lb.AutoSize = true;
            this.name2Lb.Location = new System.Drawing.Point(3, 25);
            this.name2Lb.Name = "name2Lb";
            this.name2Lb.Size = new System.Drawing.Size(106, 16);
            this.name2Lb.TabIndex = 32;
            this.name2Lb.Text = "Наименование";
            // 
            // nameUpdTb
            // 
            this.nameUpdTb.Location = new System.Drawing.Point(6, 44);
            this.nameUpdTb.Name = "nameUpdTb";
            this.nameUpdTb.Size = new System.Drawing.Size(265, 22);
            this.nameUpdTb.TabIndex = 31;
            // 
            // saveLibBtn
            // 
            this.saveLibBtn.Location = new System.Drawing.Point(385, 373);
            this.saveLibBtn.Name = "saveLibBtn";
            this.saveLibBtn.Size = new System.Drawing.Size(152, 23);
            this.saveLibBtn.TabIndex = 33;
            this.saveLibBtn.Text = "Сохранить";
            this.saveLibBtn.UseVisualStyleBackColor = true;
            this.saveLibBtn.Click += new System.EventHandler(this.saveLibBtn_Click);
            // 
            // AddLibBtn
            // 
            this.AddLibBtn.Location = new System.Drawing.Point(55, 373);
            this.AddLibBtn.Name = "AddLibBtn";
            this.AddLibBtn.Size = new System.Drawing.Size(152, 23);
            this.AddLibBtn.TabIndex = 34;
            this.AddLibBtn.Text = "Добавить библ.";
            this.AddLibBtn.UseVisualStyleBackColor = true;
            this.AddLibBtn.Click += new System.EventHandler(this.AddLibBtn_Click);
            // 
            // printDataBtn
            // 
            this.printDataBtn.Location = new System.Drawing.Point(616, 373);
            this.printDataBtn.Name = "printDataBtn";
            this.printDataBtn.Size = new System.Drawing.Size(152, 23);
            this.printDataBtn.TabIndex = 35;
            this.printDataBtn.Text = "Вывести";
            this.printDataBtn.UseVisualStyleBackColor = true;
            this.printDataBtn.Click += new System.EventHandler(this.printDataBtn_Click);
            // 
            // objectCounterLabel
            // 
            this.objectCounterLabel.AutoSize = true;
            this.objectCounterLabel.Location = new System.Drawing.Point(613, 27);
            this.objectCounterLabel.Name = "objectCounterLabel";
            this.objectCounterLabel.Size = new System.Drawing.Size(0, 16);
            this.objectCounterLabel.TabIndex = 49;
            // 
            // rateOutCB
            // 
            this.rateOutCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rateOutCB.AutoSize = true;
            this.rateOutCB.Location = new System.Drawing.Point(616, 321);
            this.rateOutCB.Name = "rateOutCB";
            this.rateOutCB.Size = new System.Drawing.Size(83, 20);
            this.rateOutCB.TabIndex = 48;
            this.rateOutCB.Text = "Рейтинг";
            this.rateOutCB.UseVisualStyleBackColor = true;
            // 
            // avgNumberOutCB
            // 
            this.avgNumberOutCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avgNumberOutCB.AutoSize = true;
            this.avgNumberOutCB.Location = new System.Drawing.Point(616, 277);
            this.avgNumberOutCB.Name = "avgNumberOutCB";
            this.avgNumberOutCB.Size = new System.Drawing.Size(216, 20);
            this.avgNumberOutCB.TabIndex = 47;
            this.avgNumberOutCB.Text = "Среднее число посетителей";
            this.avgNumberOutCB.UseVisualStyleBackColor = true;
            // 
            // squareOutCB
            // 
            this.squareOutCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareOutCB.AutoSize = true;
            this.squareOutCB.Location = new System.Drawing.Point(616, 233);
            this.squareOutCB.Name = "squareOutCB";
            this.squareOutCB.Size = new System.Drawing.Size(87, 20);
            this.squareOutCB.TabIndex = 46;
            this.squareOutCB.Text = "Площадь";
            this.squareOutCB.UseVisualStyleBackColor = true;
            // 
            // addressOutCB
            // 
            this.addressOutCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressOutCB.AutoSize = true;
            this.addressOutCB.Location = new System.Drawing.Point(616, 192);
            this.addressOutCB.Name = "addressOutCB";
            this.addressOutCB.Size = new System.Drawing.Size(69, 20);
            this.addressOutCB.TabIndex = 45;
            this.addressOutCB.Text = "Адрес";
            this.addressOutCB.UseVisualStyleBackColor = true;
            // 
            // phoneOutCB
            // 
            this.phoneOutCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneOutCB.AutoSize = true;
            this.phoneOutCB.Location = new System.Drawing.Point(616, 151);
            this.phoneOutCB.Name = "phoneOutCB";
            this.phoneOutCB.Size = new System.Drawing.Size(141, 20);
            this.phoneOutCB.TabIndex = 44;
            this.phoneOutCB.Text = "Номер телефона";
            this.phoneOutCB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.phoneOutCB.UseVisualStyleBackColor = true;
            // 
            // quantityOutCB
            // 
            this.quantityOutCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityOutCB.AutoSize = true;
            this.quantityOutCB.Location = new System.Drawing.Point(616, 101);
            this.quantityOutCB.Name = "quantityOutCB";
            this.quantityOutCB.Size = new System.Drawing.Size(164, 20);
            this.quantityOutCB.TabIndex = 43;
            this.quantityOutCB.Text = "Библиотечный фонд";
            this.quantityOutCB.UseVisualStyleBackColor = true;
            // 
            // nameOutCB
            // 
            this.nameOutCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameOutCB.AutoSize = true;
            this.nameOutCB.Location = new System.Drawing.Point(616, 59);
            this.nameOutCB.Name = "nameOutCB";
            this.nameOutCB.Size = new System.Drawing.Size(95, 20);
            this.nameOutCB.TabIndex = 42;
            this.nameOutCB.Text = "Название";
            this.nameOutCB.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(616, 402);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(147, 36);
            this.calculate.TabIndex = 50;
            this.calculate.Text = "Произвести замер";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.objectCounterLabel);
            this.Controls.Add(this.rateOutCB);
            this.Controls.Add(this.avgNumberOutCB);
            this.Controls.Add(this.squareOutCB);
            this.Controls.Add(this.addressOutCB);
            this.Controls.Add(this.phoneOutCB);
            this.Controls.Add(this.quantityOutCB);
            this.Controls.Add(this.nameOutCB);
            this.Controls.Add(this.printDataBtn);
            this.Controls.Add(this.AddLibBtn);
            this.Controls.Add(this.saveLibBtn);
            this.Controls.Add(this.panelForUpdate);
            this.Controls.Add(this.selectLibCB);
            this.Controls.Add(this.rateLb);
            this.Controls.Add(this.rateTB);
            this.Controls.Add(this.avgNumbLb);
            this.Controls.Add(this.avgNumberTb);
            this.Controls.Add(this.squareLb);
            this.Controls.Add(this.squareTB);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.phoneLb);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.QuantLb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.quantityArgs);
            this.Controls.Add(this.panelForChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.quantityArgs.ResumeLayout(false);
            this.quantityArgs.PerformLayout();
            this.panelForUpdate.ResumeLayout(false);
            this.panelForUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox quantityArgs;
        private System.Windows.Forms.RadioButton withoutArgsRB;
        private System.Windows.Forms.RadioButton allArgsRB;
        private System.Windows.Forms.RadioButton twoArgsRb;
        private System.Windows.Forms.RadioButton oneArgRB;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Label QuantLb;
        private System.Windows.Forms.Label phoneLb;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label addressLb;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label squareLb;
        private System.Windows.Forms.TextBox squareTB;
        private System.Windows.Forms.Label avgNumbLb;
        private System.Windows.Forms.TextBox avgNumberTb;
        private System.Windows.Forms.Label rateLb;
        private System.Windows.Forms.TextBox rateTB;
        private System.Windows.Forms.ComboBox selectLibCB;
        private System.Windows.Forms.Panel panelForChoice;
        private System.Windows.Forms.Panel panelForUpdate;
        private System.Windows.Forms.Label rateUpdLb;
        private System.Windows.Forms.TextBox rateUpdTB;
        private System.Windows.Forms.Label avgNumberUpdLb;
        private System.Windows.Forms.TextBox avgNumberUpdTb;
        private System.Windows.Forms.Label squareUpdLb;
        private System.Windows.Forms.TextBox squareUpdTb;
        private System.Windows.Forms.Label addressUpdLb;
        private System.Windows.Forms.TextBox addressUpdTB;
        private System.Windows.Forms.Label phoneUpdLb;
        private System.Windows.Forms.TextBox phoneUpdTB;
        private System.Windows.Forms.Label quantityUpdLb;
        private System.Windows.Forms.TextBox quantityUpdTb;
        private System.Windows.Forms.Label name2Lb;
        private System.Windows.Forms.TextBox nameUpdTb;
        private System.Windows.Forms.Button saveLibBtn;
        private System.Windows.Forms.Button AddLibBtn;
        private System.Windows.Forms.Button printDataBtn;
        private System.Windows.Forms.Label objectCounterLabel;
        private System.Windows.Forms.CheckBox rateOutCB;
        private System.Windows.Forms.CheckBox avgNumberOutCB;
        private System.Windows.Forms.CheckBox squareOutCB;
        private System.Windows.Forms.CheckBox addressOutCB;
        private System.Windows.Forms.CheckBox phoneOutCB;
        private System.Windows.Forms.CheckBox quantityOutCB;
        private System.Windows.Forms.CheckBox nameOutCB;
        private System.Windows.Forms.Button calculate;
    }
}

