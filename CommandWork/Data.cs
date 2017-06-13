using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    class Data
    {
        public static void Push(Date arg1, Date arg2)
        {
            // нахождение разницы между датами
            ulong yearDiff =(ulong)(arg1.Year - arg2.Year);
            ulong monthDiff = (ulong)(arg1.Month - arg2.Month);
            ulong dayDiff = (ulong)(arg1.Day - arg2.Day);
            ulong hourDiff = (ulong)(arg1.Hour - arg2.Hour);
            ulong minuteDiff = (ulong)(arg1.Minute - arg2.Minute);
            ulong secondDiff = (ulong)(arg1.Second - arg2.Second);

            if (yearDiff*12 + monthDiff + 10 > TimeInterval.MaxMonths)
            {
                FormAns.Push("Слишком большой интервал: некорректные вычисления");
                return;
            }
            
            // посчитать, сколько секунд прошло между событиями
            ulong seconds = secondDiff + minuteDiff*60 + hourDiff*60*60 + 
                dayDiff*60*60*24 + monthDiff * 60 * 60 * 24 * 30 + 
                yearDiff * 60 * 60 * 24 * 30 * 12;

            // выслать интервал
            FormAns.Push(new TimeInterval(seconds, 0));
        }
        public static void Push(List<Protocol> proto)
        {
            FormProto.Push(proto);
        }
        public static void Push(Date arg1, TimeInterval arg2, bool isPlus)
        {
            int year = 0, month = 0, day = 0, hour = 0, minute = 0, second = 0;
            
            if (isPlus)
            {
                second = PlusST(arg1.Second, arg2.Second, 60, second, ref month);
                minute = PlusST(arg1.Minute, arg2.Minutes, 60, minute, ref hour);
                hour = PlusST(arg1.Hour, arg2.Hours, 24, hour, ref day);

                day = PlusSD(arg1.Day, arg2.Days, 30, day, ref month);
                month = PlusSD(arg1.Month, arg2.Month, 12, month, ref year);
                year += arg1.Year + arg2.Years;
            }
            else
            {
                // так как Date не может быть ранее 1583, а лет не может быть больше 19
                // в интервале, то в отрицательные числа уйти никак
                second = MinusST(arg1.Second, arg2.Second, 60, second, ref month);
                minute = MinusST(arg1.Minute, arg2.Minutes, 60, minute, ref hour);
                hour = MinusST(arg1.Hour, arg2.Hours, 24, hour, ref day);

                day = MinusSD(arg1.Day, arg2.Days, 30, day, ref month);
                month = MinusSD(arg1.Month, arg2.Month, 12, month, ref year);
                year += arg1.Year - arg2.Years;
            }

            FormAns.Push(new Date(day, month, year, hour, minute, second));
        }

        static int PlusST(int arg1, int arg2, int maxtime, int first, ref int next)
        {
            // считает для времени
            var ans = first + arg1 + arg2;
            if (ans >= maxtime)                  // если, например, секунд больше или равно 60
            {
                next++;
                ans -= maxtime;
            }
            return ans;
        }
        static int PlusSD(int arg1, int arg2, int maxtime, int first, ref int next)
        {
            // считает для даты, т. к. у даты нет 0
            var ans = first + arg1 + arg2;
            if (ans > maxtime)
            {
                next++;
                ans -= maxtime;
            }
            return ans;
        }


        static int MinusST(int arg1, int arg2, int maxtime, int first, ref int next)
        {
            // считает для времени
            var ans = first + arg1 - arg2;
            if (ans < 0)
            {
                next--;
                ans += maxtime + 1;
            }
            return ans;
        }
        static int MinusSD(int arg1, int arg2, int maxtime, int first, ref int next)
        {
            // считает для даты
            var ans = first + arg1 - arg2;
            if (ans <= 0)
            {
                next--;
                ans += maxtime;
            }
            return ans;
        }

    }
}
