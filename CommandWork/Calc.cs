using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class Calc
    {
        // ReadMe для Артёма
        // date1 - основная дата, date2 - вторая дата для промежутка
        // months и days - в них только цифры (их нужно пропарсить на инт) - максимум 10 символов, могу увеличить
        // number в этой функции можно извлечь и кинуть Варе, но лучше ее спроси, в каком формате она это принимает для подсчета
        // кстати тебе скорее всего не понадобится isAmerican, потому что массивы с датами я кидаю в одинаковом русском формате 
        // если будешь убирать у себя это - скажи мне
        public static bool CheckDate(string[] date, bool isAmerican) // Проверка на 30 февраля
        {
            ulong days, months, years; // days - дни, months - месяцы, years - года
            bool leapYear = false; // Високосность года

            if (CheckNumber(date[2], 1583, 9999)) // Проверка года на соответствие промежутку и типу Int
            {
                years = ulong.Parse(date[2]);
                if ((years % 4) == 0) leapYear = true; // Проверка на високосность года
            }
            else return false;

            if (CheckNumber(date[1], 1, TimeInterval.MaxMonths)) // Проверка месяца на соответствие промежутку и типу Int
            {
                months = ulong.Parse(date[1]);
            }
            else return false;

            switch (months) // Проверка дней на соответствие промежутку и типу Int
            {
                case 1: 
                    if (CheckNumber(date[0], 1, 31))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 2:
                    if (!leapYear && CheckNumber(date[0], 1, 28))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else if (leapYear && CheckNumber(date[0], 1, 29))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 3:
                    if (CheckNumber(date[0], 1, 31))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 4:
                    if (CheckNumber(date[0], 1, 30))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 5:
                    if (CheckNumber(date[0], 1, 31))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 6:
                    if (CheckNumber(date[0], 1, 30))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 7:
                    if (CheckNumber(date[0], 1, 31))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 8:
                    if (CheckNumber(date[0], 1, 31))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 9:
                    if (CheckNumber(date[0], 1, 30))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 10:
                    if (CheckNumber(date[0], 1, 31))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 11:
                    if (CheckNumber(date[0], 1, 30))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;

                case 12:
                    if (CheckNumber(date[0], 1, 31))
                    {
                        days = ulong.Parse(date[0]);
                    }
                    else return false;
                    break;
            }

            if (!CheckNumber(date[3], 0, TimeInterval.MaxHours)) // Проверка часов на соответствие промежутку и типу Int
            {
                return false;
            }

            if (!CheckNumber(date[4], 0, TimeInterval.MaxMinutes)) // Проверка минут на соответствие промежутку и типу Int
            {
                return false;
            }

            if (!CheckNumber(date[5], 0, TimeInterval.MaxSeconds)) // Проверка секунд на соответствие промежутку и типу Int
            {
                return false;
            }

            return true;
        }

        public static bool CheckMonths(string days) // лучше оставь это. я тут проверяю корректно ли введено значение дней или месяцев
        {
            return CheckNumber(days, 0, TimeInterval.MaxDays);
        }

        public static bool CheckDays(string months)
        {
            return CheckNumber(months, 0, TimeInterval.MaxMonths);
        }

        public static bool CheckTimeInterval(string arg, int type) // 
        {
                

            return true;
        }

        public static void PushDate(string arg1, string arg2, bool isAmericanArg1, bool isAmericanArg2)
        {
            return new Date();
        }

        public static void PushTimeInterval(string arg1, string arg2, bool isAmericanArg1, bool isPlus)
        {
            
        }

        static bool CheckNumber(string text, uint minSize, uint maxSize) // проверка соответствия ввода типу int 
        {
            try
            {
                var number = Convert.ToUInt32(text);
                return number >= minSize && number <= maxSize;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

    }
}
