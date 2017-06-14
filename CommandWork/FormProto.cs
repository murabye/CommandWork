using System;
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
    public partial class FormProto : Form
    {
        private static List<Protocol> pr;

        public FormProto()
        {
            InitializeComponent();
            pr = Protocol.Start("proto.txt");
            foreach (var p in pr)
            {
                textBox1.Text += "Начало записи: \r\n";
                textBox1.Text += p.Input + "\r\n";
                foreach (var x in p.Operations)
                {
                    textBox1.Text += x + "\r\n";
                }
                textBox1.Text += "Конец записи.\r\n\r\n";
            }
        }

        public static void Push(List<Protocol> proto)
        {
            pr = proto;
        }
    }
}
