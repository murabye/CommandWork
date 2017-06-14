using System;
using System.CodeDom;
using System.Drawing;
using System.Windows.Forms;
using CommandWork.Properties;

namespace CommandWork
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public static int Index; // выбранное задание
        public static bool IsAmerican; // переменная для формата даты
        public static string[] Date = new string[6], Date2 = new string[6]; // основная дата и дата для промежутка
        public static string Months, Days;

        public static string Data, Data2; 

        public FormMain()
        {
            InitializeComponent();
            entry1_1.TextChanged += MaskedTextBoxLength2;
            entry2_1.TextChanged += MaskedTextBoxLength2;
            year1.TextChanged += MaskedTextBoxLength4;
            hour1.TextChanged += MaskedTextBoxLength2;
            minutes1.TextChanged += MaskedTextBoxLength2;
            seconds1.TextChanged += MaskedTextBoxLength2;
            entry1_2.TextChanged += MaskedTextBoxLength2;
            entry2_2.TextChanged += MaskedTextBoxLength2;
            year2.TextChanged += MaskedTextBoxLength4;
            hour2.TextChanged += MaskedTextBoxLength2;
            minutes2.TextChanged += MaskedTextBoxLength2;
            seconds2.TextChanged += MaskedTextBoxLength2;
        }

        #region RadioButtonClick

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
            // действия при клике на "Российский формат"
        {
            Clear(); // очистка всех ранее введенных в поля данных
            IsAmerican = false;
            action.Enabled = true; // доступен выбор действий
            label4.Text = Resources.Form_radioButton1_CheckedChanged__; // в ресурсах точка
            label10.Text = label5.Text = label9.Text = label4.Text; // разделитель - точка
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
            // действия при клике на "Американский формат"
        {
            Clear(); // очистка всех ранее введенных в поля данных
            IsAmerican = true;
            action.Enabled = true; // доступен выбор действий
            label4.Text = Resources.Form_radioButton2_CheckedChanged__; // в ресурсах тире
            label10.Text = label5.Text = label9.Text = label4.Text; // разделитель - тире
        }

        #endregion

        #region ComboboxClick

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // выбор выполняемого задания
        {
            Clear();
            Index = action.SelectedIndex; // индекс выбранного задания
            if (Index != -1) // если выбрано хоть что-то
            {
                entry1_1.Enabled = true; // доступен ввод даты 1
                entry2_1.Enabled = year1.Enabled = hour1.Enabled =
                    minutes1.Enabled = seconds1.Enabled = entry1_1.Enabled;
                doAction.Enabled = false; // недоступна кнопка перевода
            }
            switch (Index)
            {
                case 0:
                case 1:
                    entry1_2.Enabled = false; // недоступен ввод даты 2
                    entry2_2.Enabled = year2.Enabled = hour2.Enabled =
                        minutes2.Enabled = seconds2.Enabled = entry1_2.Enabled;
                    months1.Enabled = true; // доступен ввод месяцев
                    days1.Enabled = false; // недоступен ввод дней
                    break;
                case 2:
                case 3:
                    entry1_2.Enabled = false; // недоступен ввод даты 2
                    entry2_2.Enabled = year2.Enabled = hour2.Enabled =
                        minutes2.Enabled = seconds2.Enabled = entry1_2.Enabled;
                    months1.Enabled = false; // недоступен ввод месяцев
                    days1.Enabled = true; // доступен ввод дней
                    break;
                case 4:
                    entry1_2.Enabled = true; // доступен ввод даты 2
                    entry2_2.Enabled = year2.Enabled = hour2.Enabled =
                        minutes2.Enabled = seconds2.Enabled = entry1_2.Enabled;
                    months1.Enabled = false; // недоступен ввод месяцев
                    days1.Enabled = false; // недоступен ввод дней
                    break;
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
            CheckFull();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            CheckFull();
        }

        private void CheckFull()
        {
            switch (Index)
            {
                case 0:
                case 1:
                    if (entry1_1.MaskFull && entry2_1.MaskFull && year1.MaskFull &&
                        hour1.MaskFull && minutes1.MaskFull && seconds1.MaskFull &&
                        months1.TextLength != 0) Check(IsAmerican);
                    break;
                case 2:
                case 3:
                    if (entry1_1.MaskFull && entry2_1.MaskFull && year1.MaskFull &&
                        hour1.MaskFull && minutes1.MaskFull && seconds1.MaskFull &&
                        days1.TextLength != 0) Check(IsAmerican);
                    break;
                case 4:
                    if (entry1_1.MaskFull && entry2_1.MaskFull && year1.MaskFull &&
                        hour1.MaskFull && minutes1.MaskFull && seconds1.MaskFull &&
                        entry1_2.MaskFull && entry2_2.MaskFull && year2.MaskFull &&
                        hour2.MaskFull && minutes2.MaskFull && seconds2.MaskFull)
                        Check(IsAmerican);
                    break;
            }
        }

        private void Boomcheck(MaskedTextBox mtb, int lenght) // проверка длины ввода
        {
            var value = mtb.Text.Trim('_');
            if (value.Length < lenght && value.Length != 0)
            {
                mtb.BackColor = Color.LightCoral;
                toolTip1.ToolTipTitle = "Слишком короткий ввод";
                toolTip1.Show("Введите больше символов", mtb, 100, 15, 1000);
            }
            else if (value.Length == lenght)
                mtb.BackColor = Color.White;
        }

        private void MaskedTextBoxLength2(object sender, EventArgs e)
        {
            var thisMtb = (MaskedTextBox) sender;
            Boomcheck(thisMtb, 2);
        }

        private void MaskedTextBoxLength4(object sender, EventArgs e)
        {
            var thisMtb = (MaskedTextBox)sender;
            Boomcheck(thisMtb, 4);
        }

        private void maskedTextBox_Click(object sender, EventArgs e)
        {
            var thismtb = (MaskedTextBox) sender;
            thismtb.Clear();
        }

        #endregion

        #region Other

        public void Clear()
        {
            entry1_1.Clear();
            entry2_1.Clear();
            year1.Clear();
            hour1.Clear();
            minutes1.Clear();
            seconds1.Clear();
            entry1_2.Clear();
            entry2_2.Clear();
            year2.Clear();
            hour2.Clear();
            minutes2.Clear();
            seconds2.Clear();
            months1.Clear();
            days1.Clear();
        }

        public bool Check(bool isAmerican) // проверка корректности ввода
        {
            if (!isAmerican)
            {
                Date[0] = entry1_1.Text;
                Date[1] = entry2_1.Text;
            }
            else
            {
                Date[1] = entry1_1.Text;
                Date[0] = entry2_1.Text;
            }
            Date[2] = year1.Text;
            Date[3] = hour1.Text;
            Date[4] = minutes1.Text;
            Date[5] = seconds1.Text;

            if (!isAmerican)
                Data = Date[0] + "." + Date[1] + "." + Date[2] + "." + Date[3] + "." + Date[4] + "." + Date[5];
            else Data = Date[0] + "-" + Date[1] + "-" + Date[2] + "-" + Date[3] + "-" + Date[4] + "-" + Date[5];

            switch (Index)
            {
                case 0:
                case 1:
                    Months = months1.Text; // для прибавления или вычитания месяцев
                    doAction.Enabled = Calc.CheckMonths(Months) && Calc.CheckDate(Date);
                    return doAction.Enabled;
                case 2:
                case 3:
                    Days = days1.Text; // для прибавления или вычитания дней
                    doAction.Enabled = Calc.CheckDays(Days) && Calc.CheckDate(Date);
                    return doAction.Enabled;
                default: // для вычитания дат
                    if (!isAmerican)
                    {
                        Date2[0] = entry1_2.Text;
                        Date2[1] = entry2_2.Text;
                    }
                    else
                    {
                        Date2[1] = entry1_2.Text;
                        Date2[2] = entry2_2.Text;
                    }
                    Date2[2] = year2.Text;
                    Date2[3] = hour2.Text;
                    Date2[4] = minutes2.Text;
                    Date2[5] = seconds2.Text;

                    if (!isAmerican)
                        Data2 = Date2[0] + "." + Date2[1] + "." + Date2[2] + "." + Date2[3] + "." + Date2[4] + "." + Date2[5];
                    else Data2 = Date2[0] + "-" + Date2[1] + "-" + Date2[2] + "-" + Date2[3] + "-" + Date2[4] + "-" + Date2[5];

                    doAction.Enabled = Calc.CheckDate(Date2) && Calc.CheckDate(Date);
                    return doAction.Enabled;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAns f2 = new FormAns(IsAmerican);
            f2.Owner = this;
            f2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormProto pr = new FormProto();
            pr.ShowDialog();
        }

        #endregion
    }
}
