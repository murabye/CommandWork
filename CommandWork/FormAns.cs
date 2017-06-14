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
        private static bool exc;
        public static string ExcInfo;
        private static Protocol proto = new Protocol();
        public FormAns(bool status)
        {
            InitializeComponent();
            IsAmerican = status;
            object[] us;
            comboBox1.Items.Clear(); // предварительная очистка ComboBox
            if (Variant != 4)
            {
                us = new[] { "Перевод в российский формат", "Перевод в американский формат" };
                
                #region отпраление данных на обработку(TimeInterval)

                bool isPlus = Variant == 1 || Variant == 3;
                if (Variant == 0 || Variant == 1)
                    Calc.PushTimeInterval(FormMain.Date, FormMain.Months, "6", isPlus);
                else Calc.PushTimeInterval(FormMain.Date, FormMain.Days, "4", isPlus);
                
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

                #region отпраление данных на обработку(Date)

                Calc.PushDate(FormMain.Date, FormMain.Date2);

                #endregion
            }
            // выгрузка данных из файла в ComboBox
            comboBox1.Items.AddRange(us);

            textBox1.Enabled = true;
            if (Variant != 4 && !exc)
                Result = IsAmerican ? Answer.ToAmerican() : Answer.ToString();
            else if (Variant == 4 && !exc) Result = Answer2.ToString();
            else if (exc)
            {
                Result = ExcInfo;
                comboBox1.Items.Clear();
            }
            textBox1.Text = Result;

            string input = "";
            switch (FormMain.Index)
            {
                case 0:
                    input = FormMain.Data + "-" + FormMain.Months + "Месяцев";
                    break;
                case 1:
                    input = FormMain.Data + "+" + FormMain.Months + "Месяцев";
                    break;
                case 2:
                    input = FormMain.Data + "-" + FormMain.Days + "Дней";
                    break;
                case 3:
                    input = FormMain.Data + "+" + FormMain.Days + "Дней";
                    break;
                case 4:
                    input = FormMain.Data + "-" + FormMain.Data2;
                    break;
            }

            List<Pair> cur = proto.Operations;
            proto = new Protocol(input);

            foreach (var p in cur)
            {
                proto.AddOperation(p.Operation, p.Result);
            }

        }

        public static void Push(Date ans)
        {
            Result = !IsAmerican ? ans.ToString() : ans.ToAmerican();
            Answer = ans;
            
            proto.AddOperation("Вычисление", ans.ToString());

            exc = false;
        }

        public static void Push(TimeInterval ans)
        {
            Answer2 = ans;
            proto.AddOperation("Вычисление", ans.ToString());
            exc = false;
        }

        public static void Push(string exception)
        {
            proto.AddOperation("Вычисление", exception);
            ExcInfo = exception;
            exc = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            Index = comboBox1.SelectedIndex;
            if (Variant != 4 && Index == 0 && !exc) Result = Answer.ToString();
            else if (Variant != 4 && Index == 1 && !exc) Result = Answer.ToAmerican();
            else if (Variant == 4 && !exc)
                switch (Index)
                {
                    case 0:
                        Result = Answer2.TotalDays.ToString();
                        proto.AddOperation("Перевод в дни", Result);
                        break;
                    case 1:
                        Result = Answer2.TotalWeeks.ToString();
                        proto.AddOperation("Перевод в недели", Result);
                        break;
                    case 2:
                        Result = Answer2.TotalMonths.ToString();
                        proto.AddOperation("Перевод в месяцы", Result);
                        break;
                    case 3:
                        Result = Answer2.TotalHours.ToString();
                        proto.AddOperation("Перевод в часы", Result);
                        break;
                    case 4:
                        Result = Answer2.TotalMinutes.ToString();
                        proto.AddOperation("Перевод в минуты", Result);
                        break;
                    case 5:
                        Result = Answer2.TotalSecond.ToString();
                        proto.AddOperation("Перевод в секунды", Result);
                        break;
                }
            textBox1.Text = Result;
        }

        private void FormAns_FormClosing(object sender, FormClosingEventArgs e)
        {
            proto.Finish();
            proto.ClearOperation();
        }
    }
}
