﻿using System;
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
        public FormAns()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            var index = comboBox1.SelectedIndex;
            if (index != -1) // если выбрано хоть что-то
                textBox1.Enabled = true;
            else if (index == 0) // для перевода
            {
                
            }
            else if (index == 2) // для вычитания дат
            {
                
            }
        }
    }
}
