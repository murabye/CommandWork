using System;
using System.Drawing;
using System.Windows.Forms;
using CommandWork.Properties;

namespace CommandWork
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private bool _ok, _ok2, _ok01, _ok02, _ok03, _ok04, _ok05, _ok06, _ok07, _ok08, _ok09, _ok10, _ok11, _ok12;
        public int index; // выбранное задание
        public bool isAmerican; // переменная для формата даты
        public static string[] date, date2; // основная дата и дата для промежутка
        public string months, days;

        public FormMain()
        {
            InitializeComponent();
            maskedTextBox1.TextChanged += maskedTextBox1_tc1;
            maskedTextBox2.TextChanged += maskedTextBox2_tc1;
            maskedTextBox3.TextChanged += maskedTextBox3_tc1;
            maskedTextBox4.TextChanged += maskedTextBox4_tc1;
            maskedTextBox5.TextChanged += maskedTextBox5_tc1;
            maskedTextBox6.TextChanged += maskedTextBox6_tc1;
            maskedTextBox7.TextChanged += maskedTextBox7_tc1;
            maskedTextBox8.TextChanged += maskedTextBox8_tc1;
            maskedTextBox9.TextChanged += maskedTextBox9_tc1;
            maskedTextBox10.TextChanged += maskedTextBox10_tc1;
            maskedTextBox11.TextChanged += maskedTextBox11_tc1;
            maskedTextBox12.TextChanged += maskedTextBox12_tc1;
        }

        #region ButtonClick

        public static void Push(Date ans)
        {
            
        }

        public static void Push(TimeInterval ans)
        {
            
        }

        public static void Push(string exception)
        {
            
        }

        #endregion

        #region RadioButtonClick

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // действия при клике на "Российский формат"
        {
            Clear();
            isAmerican = false;
            comboBox1.Enabled = true; // доступен выбор действий
            label4.Text = Resources.Form_radioButton1_CheckedChanged__; // в ресурсах точка
            label10.Text = label5.Text = label9.Text = label4.Text; // разделитель - точка
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // действия при клике на "Американский формат"
        {
            Clear();
            isAmerican = true;
            comboBox1.Enabled = true; // доступен выбор действий
            label4.Text = Resources.Form_radioButton2_CheckedChanged__; // в ресурсах тире
            label10.Text = label5.Text = label9.Text = label4.Text; // разделитель - тире
        }

        #endregion

        #region ComboboxClick

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // выбор выполняемого задания
        {
            Clear();
            index = comboBox1.SelectedIndex;
            if (index != -1) // если выбрано хоть что-то
            {
                maskedTextBox1.Enabled = true; // доступен ввод даты 1
                maskedTextBox2.Enabled = maskedTextBox3.Enabled = maskedTextBox4.Enabled =
                    maskedTextBox5.Enabled = maskedTextBox6.Enabled = maskedTextBox1.Enabled;
            }
            if (index == 0) // выбран перевод даты
            {
                maskedTextBox7.Enabled = false; // недоступен ввод даты 2
                maskedTextBox8.Enabled = maskedTextBox9.Enabled = maskedTextBox10.Enabled =
                maskedTextBox11.Enabled = maskedTextBox12.Enabled = maskedTextBox7.Enabled;
                button1.Enabled = true; // доступна кнопка перевода
                textBox1.Enabled = false; // недоступен ввод месяцев
                textBox2.Enabled = false; // недоступен ввод дней
            }
            else if (index == 1 || index == 2) // для прибавления или вычитания месяцев/дней
            {
                maskedTextBox7.Enabled = false; // недоступен ввод даты 2
                maskedTextBox8.Enabled = maskedTextBox9.Enabled = maskedTextBox10.Enabled =
                maskedTextBox11.Enabled = maskedTextBox12.Enabled = maskedTextBox7.Enabled;
                button1.Enabled = false; // недоступна кнопка перевода
                textBox1.Enabled = true; // доступен ввод месяцев
                textBox2.Enabled = true; // доступен ввод дней
            }
            else if (index != -1 && index != 0 && index != 1 && index != 2) // для запросов
            {
                maskedTextBox7.Enabled = true; // доступен ввод даты 2
                maskedTextBox8.Enabled = maskedTextBox9.Enabled = maskedTextBox10.Enabled =
                maskedTextBox11.Enabled = maskedTextBox12.Enabled = maskedTextBox7.Enabled;
                button1.Enabled = false; // недоступна кнопка перевода
                textBox1.Enabled = false; // недоступен ввод месяцев
                textBox2.Enabled = false; // недоступен ввод дней
            }
        }

        #endregion

        #region TextChanged

        private void textBox_KeyPress(object sender, KeyPressEventArgs e) // проверка вводимых символов для месяцев/дней
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8) // разрешен ввод только цифр
                e.Handled = true;
        }

        private void maskedTextBox_TextChanged(object sender, EventArgs e) // проверка наличия ввода в maskedtextbox
        {
            _ok = _ok01 && _ok02 && _ok03 && _ok04 && _ok05;
            _ok2 = _ok06 && _ok07 && _ok08 && _ok09 && _ok10 && _ok11 && _ok12;
            if (index == 1 || index == 2) // для прибавления или вычитания месяцев/дней
            {
                button1.Enabled = _ok;
            }
            else if (index != 0 && index != 1 && index != 2) // для запросов
            {
                button1.Enabled = _ok && _ok2;
            }
        }

        private void Boomcheck(MaskedTextBox ppp, ref bool kok) // проверка длины ввода
        {
            var value = ppp.Text.Trim('_');
            if (value.Length < 2 && value.Length != 0)
            {
                kok = false;
                ppp.BackColor = Color.LightCoral;
                toolTip1.ToolTipTitle = "Слишком короткий ввод";
                toolTip1.Show("Введите больше символов", ppp, 100, 15, 1000);
            }
            else if (value.Length == 0) kok = false;
            else
            {
                kok = true;
                ppp.BackColor = Color.White;
            }
            _ok = _ok01 && _ok02 && _ok03 && _ok04 && _ok05 && _ok06 && _ok07 && _ok08 && _ok09 && _ok10 && _ok11 && _ok12;
            button1.Enabled = _ok;
        }

        private void maskedTextBox1_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox1, ref _ok01);
        }

        private void maskedTextBox2_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox2, ref _ok02);
        }

        private void maskedTextBox3_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox3, ref _ok03);
        }

        private void maskedTextBox4_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox4, ref _ok04);
        }

        private void maskedTextBox5_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox5, ref _ok05);
        }

        private void maskedTextBox6_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox6, ref _ok06);
        }

        private void maskedTextBox7_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox7, ref _ok07);
        }

        private void maskedTextBox8_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox8, ref _ok08);
        }

        private void maskedTextBox9_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox9, ref _ok09);
        }

        private void maskedTextBox10_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox10, ref _ok10);
        }

        private void maskedTextBox11_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox11, ref _ok11);
        }

        private void maskedTextBox12_tc1(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox12, ref _ok12);
        }

        private void maskedTextBox_Click(object sender, EventArgs e)
        {
            var thismtb = (MaskedTextBox)sender;
            thismtb.Clear();
            button1.Enabled = _ok;
        }

        #endregion

        public void Clear()
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            maskedTextBox7.Clear();
            maskedTextBox8.Clear();
            maskedTextBox9.Clear();
            maskedTextBox10.Clear();
            maskedTextBox11.Clear();
            maskedTextBox12.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        public void Check(bool isAmerican) // проверка корректности ввода
        {
            bool ok, ok2; // показатели корректности ввода 
            date = new string[6];
            if (!isAmerican)
            {
                date[0] = maskedTextBox1.Text;
                date[1] = maskedTextBox2.Text;
            }
            else
            {
                date[1] = maskedTextBox1.Text;
                date[2] = maskedTextBox2.Text;
            }
            date[2] = maskedTextBox3.Text;
            date[3] = maskedTextBox4.Text;
            date[4] = maskedTextBox5.Text;
            date[5] = maskedTextBox6.Text;
            ok = Calc.CheckDate(date, isAmerican);
            button1.Enabled = ok && index == 0; // если дата верна - кнопка доступна
            switch (index)
            {
                case 1:
                    months = textBox1.Text; // для прибавления или вычитания месяцев
                    ok = Calc.CheckMonthsDates(months);
                    button1.Enabled = ok;
                    break;
                case 2:
                    days = textBox2.Text; // для прибавления или вычитания дней
                    ok = Calc.CheckMonthsDates(days);
                    button1.Enabled = ok;
                    break;
                default:
                    if (index != 0 && index != 1 && index != 2) // для запросов
                    {
                        if (!isAmerican)
                        {
                            date2[0] = maskedTextBox7.Text;
                            date2[1] = maskedTextBox8.Text;
                        }
                        else
                        {
                            date2[1] = maskedTextBox7.Text;
                            date2[2] = maskedTextBox8.Text;
                        }
                        date2[2] = maskedTextBox9.Text;
                        date2[3] = maskedTextBox10.Text;
                        date2[4] = maskedTextBox11.Text;
                        date2[5] = maskedTextBox12.Text;
                    }
                    ok2 = Calc.CheckDate(date2, isAmerican);
                    button1.Enabled = ok2 && ok;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
