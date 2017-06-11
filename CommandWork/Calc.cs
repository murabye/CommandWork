using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class Calc
    {

        public static bool CheckDate(string arg, bool isAmerican)
        {
            return false;
        }
        public static bool CheckTimeInterval(string arg, int type)
        {
            return true;
        }

        public static void PushDate(string arg1, string arg2, bool isAmericanArg1, bool isAmericanArg2)
        {
            // здесь также нужно завести протокол сеанса
        }
        public static void PushTimeInterval(string arg1, string arg2, bool isAmericanArg1, bool isPlus)
        {
            // здесь также нужно завести протокол сеанса

        }
        public static void Push(string path)
        {
            // для протокола, читает и формирует его, на выходе List<Protocol>

        }
    }
}
