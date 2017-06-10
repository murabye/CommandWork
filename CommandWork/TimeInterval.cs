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
        static string[] types = { " seconds", " minutes",
            " hours", " days", " weeks", " months" };

        // поля
        private ulong num = 0;             // из данных полей хранить информацию
        private int type;
        
        // публичная штука
        // ОБЯЗАТЕЛЬНО при использовании этих свойств запрашивайте проверку
        // на то, влезло ли число
        // для интервалов в месяце 30 дней
        public ulong TotalMonths
        {
            get
            {
                if (type == 5) return num;
                return TotalDays / 30;
            }
        }
        public ulong TotalWeeks
        {
            get
            {
                if (type == 4) return num;
                return TotalDays / 7;
            }
        }
        public ulong TotalDays
        {
            get
            {
                if (type < 3) return TotalHours / 24;
                if (type == 3) return num;
                else if (type == 4) return TotalWeeks * 7;
                return TotalMonths * 30;
            }
        }      
        public ulong TotalHours
        {
            get
            {
                if (type < 2) return TotalMinutes / 60;
                if (type == 2) return num;
                return TotalDays * 24;
            }
        }
        public ulong TotalMinutes
        {
            get
            {
                if (type < 1) return TotalSecond / 60; 
                if (type == 1) return num;
                return TotalHours * 60;
            }
        }
        public ulong TotalSecond
        {
            get
            {
                if (type == 0) return num;
                return TotalMinutes * 60;
            }
        }

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
            string[] types = {" seconds"," minutes"," hours"," days", " weeks", " months" };


            return num + types[type];
        }
    }
}
