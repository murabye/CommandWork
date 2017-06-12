using System;
using System.Drawing;
using System.Windows.Forms;
using CommandWork.Properties;

namespace CommandWork
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public int Index; // выбранное задание
        public bool IsAmerican; // переменная для формата даты
        public static string[] Date, Date2; // основная дата и дата для промежутка
        public string Months, Days;

        public FormMain()
        {
            InitializeComponent();
            maskedTextBox1.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox2.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox3.TextChanged += MaskedTextBoxLenght4;
            maskedTextBox4.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox5.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox6.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox7.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox8.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox9.TextChanged += MaskedTextBoxLenght4;
            maskedTextBox10.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox11.TextChanged += MaskedTextBoxLenght2;
            maskedTextBox12.TextChanged += MaskedTextBoxLenght2;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
            // действия при клике на "Российский формат"
        {
            Clear(); // очистка всех ранее введенных в поля данных
            IsAmerican = false;
            comboBox1.Enabled = true; // доступен выбор действий
            label4.Text = Resources.Form_radioButton1_CheckedChanged__; // в ресурсах точка
            label10.Text = label5.Text = label9.Text = label4.Text; // разделитель - точка
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
            // действия при клике на "Американский формат"
        {
            Clear(); // очистка всех ранее введенных в поля данных
            IsAmerican = true;
            comboBox1.Enabled = true; // доступен выбор действий
            label4.Text = Resources.Form_radioButton2_CheckedChanged__; // в ресурсах тире
            label10.Text = label5.Text = label9.Text = label4.Text; // разделитель - тире
        }

        #endregion

        #region ComboboxClick

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // выбор выполняемого задания
        {
            Clear();
            Index = comboBox1.SelectedIndex; // индекс выбранного задания
            if (Index != -1) // если выбрано хоть что-то
            {
                maskedTextBox1.Enabled = true; // доступен ввод даты 1
                maskedTextBox2.Enabled = maskedTextBox3.Enabled = maskedTextBox4.Enabled =
                    maskedTextBox5.Enabled = maskedTextBox6.Enabled = maskedTextBox1.Enabled;
                button1.Enabled = false; // недоступна кнопка перевода
            }
            switch (Index)
            {
                case 0:
                case 1:
                    maskedTextBox7.Enabled = false; // недоступен ввод даты 2
                    maskedTextBox8.Enabled = maskedTextBox9.Enabled = maskedTextBox10.Enabled =
                        maskedTextBox11.Enabled = maskedTextBox12.Enabled = maskedTextBox7.Enabled;
                    textBox1.Enabled = true; // доступен ввод месяцев
                    textBox2.Enabled = false; // недоступен ввод дней
                    break;
                case 2:
                case 3:
                    maskedTextBox7.Enabled = false; // недоступен ввод даты 2
                    maskedTextBox8.Enabled = maskedTextBox9.Enabled = maskedTextBox10.Enabled =
                        maskedTextBox11.Enabled = maskedTextBox12.Enabled = maskedTextBox7.Enabled;
                    textBox1.Enabled = false; // недоступен ввод месяцев
                    textBox2.Enabled = true; // доступен ввод дней
                    break;
                case 4:
                    maskedTextBox7.Enabled = true; // доступен ввод даты 2
                    maskedTextBox8.Enabled = maskedTextBox9.Enabled = maskedTextBox10.Enabled =
                        maskedTextBox11.Enabled = maskedTextBox12.Enabled = maskedTextBox7.Enabled;
                    textBox1.Enabled = false; // недоступен ввод месяцев
                    textBox2.Enabled = false; // недоступен ввод дней
                    break;
            }
        }

        #endregion

        #region TextChanged

        private void textBox_KeyPress(object sender, KeyPressEventArgs e) // проверка вводимых символов для месяцев/дней
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8) // разрешен ввод только цифр
                e.Handled = true;
            Check(IsAmerican);
        }

        private void maskedTextBox_TextChanged(object sender, EventArgs e) // проверка наличия ввода в maskedtextbox
        {
            switch (Index)
            {
                case 0:
                case 1:
                    if (maskedTextBox1.MaskFull && maskedTextBox2.MaskFull && maskedTextBox3.MaskFull &&
                        maskedTextBox4.MaskFull && maskedTextBox5.MaskFull && maskedTextBox6.MaskFull &&
                        textBox1.TextLength != 0) Check(IsAmerican);
                    break;
                case 2:
                case 3:
                    if (maskedTextBox1.MaskFull && maskedTextBox2.MaskFull && maskedTextBox3.MaskFull &&
                        maskedTextBox4.MaskFull && maskedTextBox5.MaskFull && maskedTextBox6.MaskFull &&
                        textBox2.TextLength != 0) Check(IsAmerican);
                    break;
                case 4:
                    if (maskedTextBox1.MaskFull && maskedTextBox2.MaskFull && maskedTextBox3.MaskFull &&
                        maskedTextBox4.MaskFull && maskedTextBox5.MaskFull && maskedTextBox6.MaskFull &&
                        maskedTextBox7.MaskFull && maskedTextBox8.MaskFull && maskedTextBox9.MaskFull &&
                        maskedTextBox10.MaskFull && maskedTextBox11.MaskFull && maskedTextBox12.MaskFull)
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

        private void MaskedTextBoxLenght2(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox1, 2);
        }

        private void MaskedTextBoxLenght4(object sender, EventArgs e)
        {
            Boomcheck(maskedTextBox1, 4);
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

        public bool Check(bool isAmerican) // проверка корректности ввода
        {
            Date = new string[6];
            if (!isAmerican)
            {
                Date[0] = maskedTextBox1.Text;
                Date[1] = maskedTextBox2.Text;
            }
            else
            {
                Date[1] = maskedTextBox1.Text;
                Date[0] = maskedTextBox2.Text;
            }
            Date[2] = maskedTextBox3.Text;
            Date[3] = maskedTextBox4.Text;
            Date[4] = maskedTextBox5.Text;
            Date[5] = maskedTextBox6.Text;
            switch (Index)
            {
                case 0:
                case 1:
                    Months = textBox1.Text; // для прибавления или вычитания месяцев
                    button1.Enabled = Calc.CheckMonths(Months) && Calc.CheckDate(Date, isAmerican);
                    return button1.Enabled;
                case 2:
                case 3:
                    Days = textBox2.Text; // для прибавления или вычитания дней
                    button1.Enabled = Calc.CheckDays(Days) && Calc.CheckDate(Date, isAmerican);
                    return button1.Enabled;
                default: // для вычитания дат
                    if (!isAmerican)
                    {
                        Date2[0] = maskedTextBox7.Text;
                        Date2[1] = maskedTextBox8.Text;
                    }
                    else
                    {
                        Date2[1] = maskedTextBox7.Text;
                        Date2[2] = maskedTextBox8.Text;
                    }
                    Date2[2] = maskedTextBox9.Text;
                    Date2[3] = maskedTextBox10.Text;
                    Date2[4] = maskedTextBox11.Text;
                    Date2[5] = maskedTextBox12.Text;
                    button1.Enabled = Calc.CheckDate(Date2, isAmerican) && Calc.CheckDate(Date, isAmerican);
                    return button1.Enabled;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAns f2 = new FormAns();
            f2.ShowDialog();
        }

        #endregion
    }
}
