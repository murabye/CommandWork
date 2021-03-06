﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class Date : IComparable
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
        public const int MaxHours = 23;

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

        // конструкторы
        public Date()
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас

            month = now.Month;
            year = now.Year;
            day = now.Day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }                                // создание сегодняшнего дня
        public Date(int day)
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас

            month = now.Month;
            year = now.Year;
            this.day = day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }                         // текущий месяц и год, заданный день
        public Date(int day, int month)
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас

            this.month = month;
            year = now.Year;
            this.day = day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }              // заданный день и месяц, текущий год
        public Date(int day, int month, int year)
        {
            DateTime now = DateTime.Now;                // запомним дату сейчас
            
            this.month = month;
            this.year = year;
            this.day = day;
            hour = now.Hour;
            minute = now.Minute;
            second = now.Second;
        }    // заданная дата
        public Date(int day, int month, int year,       // полностью заданное время
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
            // дата DD.MM.YYYY, время HH:MI:SS
            return Day + "." + Month + "." + Year +             // дата
                   " " + Hour + ":" + Minute + ":" + Second;   // время

        }           // обычно ToString возвращает российский формат

        public int CompareTo(object ob)
        {
            Date comp = (Date) ob;

            int year = Year.CompareTo(comp.Year);
            int month = Month.CompareTo(comp.Month);
            int day = Day.CompareTo(comp.Day);
            int hour = Hour.CompareTo(comp.Hour);
            int minute = Minute.CompareTo(comp.Minute);
            int second = Second.CompareTo(comp.Second);

            if (year == 0 && month == 0 && day == 0 && hour == 0 && minute == 0 && second == 0)
                return 0;

            if (year != 0) return year;
            if (month != 0) return month;
            if (day != 0) return day;
            if (hour != 0) return hour;
            if (minute != 0) return minute;
            if (second != 0) return second;
            
            return 1;
        } 
    }
}
