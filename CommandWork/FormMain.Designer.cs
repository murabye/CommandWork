namespace CommandWork
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.doAction = new System.Windows.Forms.Button();
            this.days1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.months1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.entry1_2 = new System.Windows.Forms.MaskedTextBox();
            this.entry2_2 = new System.Windows.Forms.MaskedTextBox();
            this.year2 = new System.Windows.Forms.MaskedTextBox();
            this.hour2 = new System.Windows.Forms.MaskedTextBox();
            this.minutes2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.seconds2 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seconds1 = new System.Windows.Forms.MaskedTextBox();
            this.minutes1 = new System.Windows.Forms.MaskedTextBox();
            this.hour1 = new System.Windows.Forms.MaskedTextBox();
            this.year1 = new System.Windows.Forms.MaskedTextBox();
            this.entry2_1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entry1_1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // doAction
            // 
            this.doAction.Enabled = false;
            this.doAction.Location = new System.Drawing.Point(210, 207);
            this.doAction.Name = "doAction";
            this.doAction.Size = new System.Drawing.Size(75, 23);
            this.doAction.TabIndex = 103;
            this.doAction.Text = "Посчитать";
            this.doAction.UseVisualStyleBackColor = true;
            this.doAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // days1
            // 
            this.days1.Enabled = false;
            this.days1.Location = new System.Drawing.Point(195, 181);
            this.days1.MaxLength = 30000000;
            this.days1.Name = "days1";
            this.days1.Size = new System.Drawing.Size(63, 20);
            this.days1.TabIndex = 102;
            this.days1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.days1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(158, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 101;
            this.label16.Text = "Дни:";
            // 
            // months1
            // 
            this.months1.Enabled = false;
            this.months1.Location = new System.Drawing.Point(69, 181);
            this.months1.MaxLength = 30000000;
            this.months1.Name = "months1";
            this.months1.Size = new System.Drawing.Size(63, 20);
            this.months1.TabIndex = 100;
            this.months1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.months1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 99;
            this.label15.Text = "Месяцы:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "Введите месяцы/дни:";
            // 
            // action
            // 
            this.action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action.Enabled = false;
            this.action.FormattingEnabled = true;
            this.action.Items.AddRange(new object[] {
            "Вычитание даты и месяцев",
            "Сложение даты и месяцев",
            "Вычитание даты и дней",
            "Сложение даты и дней",
            "Вычитание дат"});
            this.action.Location = new System.Drawing.Point(15, 66);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(260, 21);
            this.action.TabIndex = 110;
            this.action.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 96;
            this.label13.Text = "Выберите действие:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "2.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = ".";
            // 
            // entry1_2
            // 
            this.entry1_2.Enabled = false;
            this.entry1_2.Location = new System.Drawing.Point(28, 140);
            this.entry1_2.Mask = "00";
            this.entry1_2.Name = "entry1_2";
            this.entry1_2.Size = new System.Drawing.Size(21, 20);
            this.entry1_2.TabIndex = 86;
            this.entry1_2.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.entry1_2.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // entry2_2
            // 
            this.entry2_2.Enabled = false;
            this.entry2_2.Location = new System.Drawing.Point(71, 140);
            this.entry2_2.Mask = "00";
            this.entry2_2.Name = "entry2_2";
            this.entry2_2.Size = new System.Drawing.Size(21, 20);
            this.entry2_2.TabIndex = 87;
            this.entry2_2.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.entry2_2.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // year2
            // 
            this.year2.Enabled = false;
            this.year2.Location = new System.Drawing.Point(114, 140);
            this.year2.Mask = "0000";
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(28, 20);
            this.year2.TabIndex = 88;
            this.year2.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.year2.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // hour2
            // 
            this.hour2.Enabled = false;
            this.hour2.Location = new System.Drawing.Point(168, 140);
            this.hour2.Mask = "00";
            this.hour2.Name = "hour2";
            this.hour2.Size = new System.Drawing.Size(21, 20);
            this.hour2.TabIndex = 89;
            this.hour2.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.hour2.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // minutes2
            // 
            this.minutes2.Enabled = false;
            this.minutes2.Location = new System.Drawing.Point(211, 140);
            this.minutes2.Mask = "00";
            this.minutes2.Name = "minutes2";
            this.minutes2.Size = new System.Drawing.Size(21, 20);
            this.minutes2.TabIndex = 90;
            this.minutes2.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.minutes2.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = ":";
            // 
            // seconds2
            // 
            this.seconds2.Enabled = false;
            this.seconds2.Location = new System.Drawing.Point(254, 140);
            this.seconds2.Mask = "00";
            this.seconds2.Name = "seconds2";
            this.seconds2.Size = new System.Drawing.Size(21, 20);
            this.seconds2.TabIndex = 91;
            this.seconds2.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.seconds2.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = ":";
            // 
            // seconds1
            // 
            this.seconds1.Enabled = false;
            this.seconds1.Location = new System.Drawing.Point(254, 107);
            this.seconds1.Mask = "00";
            this.seconds1.Name = "seconds1";
            this.seconds1.Size = new System.Drawing.Size(21, 20);
            this.seconds1.TabIndex = 82;
            this.seconds1.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.seconds1.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // minutes1
            // 
            this.minutes1.Enabled = false;
            this.minutes1.Location = new System.Drawing.Point(211, 107);
            this.minutes1.Mask = "00";
            this.minutes1.Name = "minutes1";
            this.minutes1.Size = new System.Drawing.Size(21, 20);
            this.minutes1.TabIndex = 81;
            this.minutes1.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.minutes1.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // hour1
            // 
            this.hour1.Enabled = false;
            this.hour1.Location = new System.Drawing.Point(168, 107);
            this.hour1.Mask = "00";
            this.hour1.Name = "hour1";
            this.hour1.Size = new System.Drawing.Size(21, 20);
            this.hour1.TabIndex = 80;
            this.hour1.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.hour1.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // year1
            // 
            this.year1.Enabled = false;
            this.year1.Location = new System.Drawing.Point(114, 107);
            this.year1.Mask = "0000";
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(28, 20);
            this.year1.TabIndex = 79;
            this.year1.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.year1.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // entry2_1
            // 
            this.entry2_1.Enabled = false;
            this.entry2_1.Location = new System.Drawing.Point(71, 107);
            this.entry2_1.Mask = "00";
            this.entry2_1.Name = "entry2_1";
            this.entry2_1.Size = new System.Drawing.Size(21, 20);
            this.entry2_1.TabIndex = 78;
            this.entry2_1.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.entry2_1.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = ".";
            // 
            // entry1_1
            // 
            this.entry1_1.Enabled = false;
            this.entry1_1.Location = new System.Drawing.Point(28, 107);
            this.entry1_1.Mask = "00";
            this.entry1_1.Name = "entry1_1";
            this.entry1_1.Size = new System.Drawing.Size(21, 20);
            this.entry1_1.TabIndex = 75;
            this.entry1_1.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.entry1_1.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Введите даты:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 17);
            this.radioButton2.TabIndex = 72;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Американский";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 71;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Российский";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Выберите формат даты:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 234);
            this.Controls.Add(this.doAction);
            this.Controls.Add(this.days1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.months1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.action);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.entry1_2);
            this.Controls.Add(this.entry2_2);
            this.Controls.Add(this.year2);
            this.Controls.Add(this.hour2);
            this.Controls.Add(this.minutes2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.seconds2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seconds1);
            this.Controls.Add(this.minutes1);
            this.Controls.Add(this.hour1);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.entry2_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entry1_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "FormMain";
            this.Text = "Калькулятор дат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doAction;
        private System.Windows.Forms.TextBox days1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox months1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox action;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox entry1_2;
        private System.Windows.Forms.MaskedTextBox entry2_2;
        private System.Windows.Forms.MaskedTextBox year2;
        private System.Windows.Forms.MaskedTextBox hour2;
        private System.Windows.Forms.MaskedTextBox minutes2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox seconds2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox seconds1;
        private System.Windows.Forms.MaskedTextBox minutes1;
        private System.Windows.Forms.MaskedTextBox hour1;
        private System.Windows.Forms.MaskedTextBox year1;
        private System.Windows.Forms.MaskedTextBox entry2_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox entry1_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

