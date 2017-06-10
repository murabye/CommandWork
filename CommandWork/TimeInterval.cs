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
        public const uint MaxTime = uint.MaxValue;
        public int MaxType = 7;

        // поля
        private ulong num = 0;             // из данных полей хранить информацию
        private int type;
        
        // публичная штука
        // ОБЯЗАТЕЛЬНО при использовании этих свойств запрашивайте проверку
        // на то, влезло ли число
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
            // месяцев = 1, недель = 2, дней = 3, часов = 4, минут = 5, секунд = 6
            int min = 1, max = 6;                   // максимальное и минимальное колва измерений

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
