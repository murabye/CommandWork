using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWork
{
    public partial class FormAns : Form
    {
        public static string Result;
        public static bool IsAmerican;
        public static int Index;
        public readonly int Variant = FormMain.Index;
        private static Date Answer;
        private static TimeInterval Answer2;
        public FormAns(bool status)
        {
            InitializeComponent();
            IsAmerican = status;
            object[] us;
            comboBox1.Items.Clear(); // предварительная очистка ComboBox
            if (Variant != 4)
            {
                us =new[] { "Перевод в другой формат" };

                #region отпраление данных на обработку(Date)

                Calc.PushDate(FormMain.Date, FormMain.Date2);

                #endregion
            }
            else
            {
                us = new[]
                {
                    "Запрос количества дней в интервале",
                    "Запрос количества недель в интервале",
                    "Запрос количества месяцев в интервале",
                    "Запрос количества часов в интервале",
                    "Запрос количества минут в интервале",
                    "Запрос количества секунд в интервале"
                };

                #region отпраление данных на обработку(TimeInterval)

                Calc.PushTimeInterval(FormMain.Date, ???, Index, ???);

                #endregion
            }
            // выгрузка данных из файла в ComboBox
            comboBox1.Items.AddRange(us);

        }

        public static void Push(Date ans)
        {
            Result = !IsAmerican ? ans.ToString() : ans.ToAmerican();
            Answer = ans;
        }

        public static void Push(TimeInterval ans)
        {
            Answer2 = ans;
        }

        public static void Push(string exception)
        {
            Result = exception;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            Index = comboBox1.SelectedIndex;
            if (Index != -1) // если выбрано хоть что-то
                textBox1.Enabled = true;
            if (Variant != 4 && Index == 0)
            {
                Result = IsAmerican ? Answer.ToString() : Answer.ToAmerican();
            }
            if (Variant == 4)
                switch (Index)
                {
                    case 0:
                        Result = Answer2.TotalDays.ToString();
                        break;
                    case 1:
                        Result = Answer2.TotalWeeks.ToString();
                        break;
                    case 2:
                        Result = Answer2.TotalMonths.ToString();
                        break;
                    case 3:
                        Result = Answer2.TotalHours.ToString();
                        break;
                    case 4:
                        Result = Answer2.TotalMinutes.ToString();
                        break;
                    case 5:
                        Result = Answer2.TotalSecond.ToString();
                        break;
                }
            textBox1.Text = Result;
        }
    }
}
