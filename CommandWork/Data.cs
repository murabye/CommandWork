using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class Data
    {
        // ограничители, то есть минимальные и максимальные значения типов
        // для ограничения количества дней в отдельном месяце встроенная функция
        public const int MinYear = 1583;                // вычисления корректны только с начала 
        public const int MaxYear = 9999;                // григорианского календаря
        public const int MinTime = 0;
        public const int MaxTime = 59;
        public const int MinMonth = 1;
        public const int MaxMonth = 12;
        public const int MinDay = 1;

        // свойства, доступные только изнутри
        private int month;                           // месяц даты
        private int day;                             // день даты
        private int year;                            // год
        private int hour;                            // час
        private int minute;                          // минута
        private int second;                          // секунда

        // свойства, доступные извне
        public int Month { get { return month; } }     // публичные свойства
        public int Day { get { return day; } }         // допустимо только чтение
        public int Year { get { return year; } }       // соответствуют полям
        public int Hour { get { return hour; } }
        public int Minute { get { return minute; } }
        public int Second { get { return second; } }
        public string DayOfWeek
        {
            // григорианский календарь, то есть работает для годов позже
            // 1583 года
            get
            {
                // массив всех дней недели
                string[] days = { "воскресенье", "понедельник",
                    "вторник", "среда", "четверг", "пятница", "суббота" };

                // промежуточные вычисления, спонсор формулы википедия
                int a = (14 - Month) / 12;
                int y = Year - a;
                int m = Month + 12 * a - 2;

                return days[(7000 + (Day + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12))];
            }
        }                      // возвращает день недели от данной даты

        // конструкторы
        public Data()
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас

            month = now.Month;
            year = now.Year;
            day = now.Day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }                                // создание сегодняшнего дня
        public Data(int day)
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас

            month = now.Month;
            year = now.Year;
            this.day = day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }                         // текущий месяц и год, заданный день
        public Data(int day, int month)
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас

            this.month = month;
            year = now.Year;
            this.day = day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }              // заданный день и месяц, текущий год
        public Data(int day, int month, int year)
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас
            
            this.month = month;
            this.year = year;
            this.day = day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }    // заданная дата
        public Data(int day, int month, int year,       // полностью заданное время
            int hour, int minute, int second)
        {
            this.month = month;
            this.year = year;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        // статичные свойства, т. е. свойства, к которым необходимо обращаться по имени класса
        public static int DaysInMonth(int month, int year)
        {
            int leap = (1 - (year % 4 + 2) % (year % 4 + 1)) * 
                ((year % 100 + 2) % (year % 100 + 1)) + 
                (1 - (year % 400 + 2) % (year % 400 + 1));

            return 28 + ((month + (month / 8)) % 2) + 
                2 % month + ((1 + leap) / month) + 
                (1 / month) - (leap / month);
        }   // возвращает количество дней в месяце

        // методы
        public string ToAmerican()
        {
            // формат даты: MM-DD-YYYY
            // формат времени: HH:MI:SS

            return Month + "-" + Day + "-" + Year +      // дата
                " " + Hour + ":" + Minute +":" + Second; // время
        }                  // возврат строки в американском формате

        // перегрузки
        public override string ToString()
        {
            // дата DD.MM.YYYY, время HH:MI: SS
            return Day + "." + Month + "." + Year +             // дата
                   " " + Hour + ":" + Minute + ": " + Second;   // время

        }           // обычно ToString возвращает российский формат
    }
}
