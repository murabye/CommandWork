using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class TimeInterval
    {
        // Максимальная протяженность задаваемого периода
        public const uint MaxSeconds = uint.MaxValue; 
        public const uint MaxMinutes = MaxSeconds / 60; 
        public const uint MaxHours = MaxMinutes / 60; 
        public const uint MaxDays = MaxHours / 24; 
        public const uint MaxWeeks = MaxDays / 7; 
        public const uint MaxMonths = MaxDays / 30; 

        // сколько типов данных входных
        public int MaxType = types.Length;

        // какие типы
        static string[] types = { " секунд", " минут",
            " часов", " дней", " недель", " месяцев" };

        // поля
        private ulong num = 0;             // из данных полей хранить информацию
        private int type;
        
        // для интервалов в месяце 30 дней
        // количество всего 
        public ulong TotalMonths
        {
            get
            {
                if (type == 6) return num;
                return TotalDays / 30;
            }
        }
        public ulong TotalWeeks
        {
            get
            {
                if (type == 5) return num;
                return TotalDays / 7;
            }
        }
        public ulong TotalDays
        {
            get
            {
                if (type < 4) return TotalHours / 24;
                if (type == 4) return num;
                else if (type == 5) return TotalWeeks * 7;
                return TotalMonths * 30;
            }
        }      
        public ulong TotalHours
        {
            get
            {
                if (type < 3) return TotalMinutes / 60;
                if (type == 3) return num;
                return TotalDays * 24;
            }
        }
        public ulong TotalMinutes
        {
            get
            {
                if (type < 2) return TotalSecond / 60; 
                if (type == 2) return num;
                return TotalHours * 60;
            }
        }
        public ulong TotalSecond
        {
            get
            {
                if (type == 1) return num;
                return TotalMinutes * 60;
            }
        }

        // 2 года, 3 дня и 15 секунд - общая протяженность периода, иначе говоря
        public int Years { get { return (int)TotalMonths/12; } }
        public int Month { get { return (int) TotalMonths % 12; } }
        public int Days { get { return (int) TotalDays % 30; } }
        public int Hours { get { return (int) TotalHours % 24; } }
        public int Minutes { get { return (int) TotalMinutes % 60; } }
        public int Second { get { return (int) TotalSecond % 60; } }


        // конструкторы
        public TimeInterval()
        {
            type = 0;
            num = 0;
        }
        public TimeInterval(ulong num, int type)
        {
            // месяцев = 6, недель = 5, дней = 4, часов = 3, минут = 2, секунд = 1

            this.num = num;
            this.type = type;
        }
        
        // перегрузки
        public override string ToString()
        {
            return num + types[type - 1];
        }
    }
}
