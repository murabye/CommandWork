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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox12 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(210, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 103;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(195, 181);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 102;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(69, 181);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 100;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Вычитание даты и временного интервала",
            "Сложение даты и временного интервала",
            "Вычитание дат"});
            this.comboBox1.Location = new System.Drawing.Point(15, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 97;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // maskedTextBox7
            // 
            this.maskedTextBox7.Enabled = false;
            this.maskedTextBox7.Location = new System.Drawing.Point(28, 140);
            this.maskedTextBox7.Mask = "00";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox7.TabIndex = 93;
            this.maskedTextBox7.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox7.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Enabled = false;
            this.maskedTextBox8.Location = new System.Drawing.Point(71, 140);
            this.maskedTextBox8.Mask = "00";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox8.TabIndex = 92;
            this.maskedTextBox8.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox8.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Enabled = false;
            this.maskedTextBox9.Location = new System.Drawing.Point(114, 140);
            this.maskedTextBox9.Mask = "00";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox9.TabIndex = 91;
            this.maskedTextBox9.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox9.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Enabled = false;
            this.maskedTextBox10.Location = new System.Drawing.Point(168, 140);
            this.maskedTextBox10.Mask = "00";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox10.TabIndex = 90;
            this.maskedTextBox10.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox10.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.Enabled = false;
            this.maskedTextBox11.Location = new System.Drawing.Point(211, 140);
            this.maskedTextBox11.Mask = "00";
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox11.TabIndex = 89;
            this.maskedTextBox11.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox11.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
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
            // maskedTextBox12
            // 
            this.maskedTextBox12.Enabled = false;
            this.maskedTextBox12.Location = new System.Drawing.Point(254, 140);
            this.maskedTextBox12.Mask = "00";
            this.maskedTextBox12.Name = "maskedTextBox12";
            this.maskedTextBox12.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox12.TabIndex = 86;
            this.maskedTextBox12.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox12.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
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
            // maskedTextBox6
            // 
            this.maskedTextBox6.Enabled = false;
            this.maskedTextBox6.Location = new System.Drawing.Point(254, 107);
            this.maskedTextBox6.Mask = "00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox6.TabIndex = 82;
            this.maskedTextBox6.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox6.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Enabled = false;
            this.maskedTextBox5.Location = new System.Drawing.Point(211, 107);
            this.maskedTextBox5.Mask = "00";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox5.TabIndex = 81;
            this.maskedTextBox5.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox5.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Enabled = false;
            this.maskedTextBox4.Location = new System.Drawing.Point(168, 107);
            this.maskedTextBox4.Mask = "00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox4.TabIndex = 80;
            this.maskedTextBox4.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox4.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Enabled = false;
            this.maskedTextBox3.Location = new System.Drawing.Point(114, 107);
            this.maskedTextBox3.Mask = "00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox3.TabIndex = 79;
            this.maskedTextBox3.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox3.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(71, 107);
            this.maskedTextBox2.Mask = "00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox2.TabIndex = 78;
            this.maskedTextBox2.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox2.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(28, 107);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(21, 20);
            this.maskedTextBox1.TabIndex = 75;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox_Click);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.maskedTextBox10);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maskedTextBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Калькулятор дат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

