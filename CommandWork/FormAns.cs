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
        public FormAns(bool status)
        {
            InitializeComponent();
            IsAmerican = status;
            ArrayList us;
            comboBox1.Items.Clear(); // предварительная очистка ComboBox
            if (Variant != 4)
            {
                us = new ArrayList { "Перевод в другой формат" };
            }
            else
            {
                us = new ArrayList
                {
                    "Запрос количества дней в интервале",
                    "Запрос количества недель в интервале",
                    "Запрос количества месяцев в интервале",
                    "Запрос количества часов в интервале",
                    "Запрос количества минут в интервале",
                    "Запрос количества секунд в интервале"
                };
            }
            foreach (var t in us) // выгрузка данных из файла в ComboBox
                comboBox1.Items.Add(t);
        }

        public static void Push(Date ans)
        {
            Result = !IsAmerican ? ans.ToString() : ans.ToAmerican();
        }

        public static void Push(TimeInterval ans)
        { 

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
        }
    }
}
