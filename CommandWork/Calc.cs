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
        public static bool CheckDate(string[] date) // Проверка на 30 февраля
        {
            ulong months, years; // months - месяцы, years - года

            if (CheckNumber(date[2], Date.MinYear, Date.MaxYear)) // Проверка года на соответствие промежутку и типу Int
            {
                years = ulong.Parse(date[2]);
            }
            else return false;

            if (CheckNumber(date[1], Date.MinMonth, Date.MaxMonth)) // Проверка месяца на соответствие промежутку и типу Int
            {
                months = ulong.Parse(date[1]);
            }
            else return false;

            if (!CheckNumber(date[0], Date.MinDay, (uint)Date.DaysInMonth((int)months, (int)years))) return false; // Проверка дней на соответствие промежутку и типу Int

            if (!CheckNumber(date[3], Date.MinTime, Date.MaxHours)) return false; // Проверка часов на соответствие промежутку и типу Int

            if (!CheckNumber(date[4], Date.MinTime, Date.MaxTime)) return false; // Проверка минут на соответствие промежутку и типу Int

            if (!CheckNumber(date[5], Date.MinTime, Date.MaxTime)) return false; // Проверка секунд на соответствие промежутку и типу Int

            return true;
        }

        public static bool CheckMonths(string months) // Проверка на корректный ввод месяцев
        {
            return CheckNumber(months, Date.MinMonth, TimeInterval.MaxMonths);
        }

        public static bool CheckDays(string days) // Проверка на корректный ввод дней
        {
            return CheckNumber(days, Date.MinDay, TimeInterval.MaxDays);
        }

        public static void PushDate(string[] date1, string[] date2)  // Парс и отправка на решение
        {
            // Объявляем переменные, чтобы в дальнейшем перебросить массив в Date
            int data1_Day, data1_Month, data1_Year, data1_Hours, data1_Minutes, data1_Seconds,
                data2_Day, data2_Month, data2_Year, data2_Hours, data2_Minutes, data2_Seconds;

            // Присваиваем значения из массива
            #region 
            data1_Day = Int32.Parse(date1[0]); 
            data1_Month = Int32.Parse(date1[1]);
            data1_Year = Int32.Parse(date1[2]);
            data1_Hours = Int32.Parse(date1[3]);
            data1_Minutes = Int32.Parse(date1[4]);
            data1_Seconds = Int32.Parse(date1[5]);
            #endregion

            // Присваиваем значения из массива
            #region
            data2_Day = Int32.Parse(date2[0]);
            data2_Month = Int32.Parse(date2[1]);
            data2_Year = Int32.Parse(date2[2]);
            data2_Hours = Int32.Parse(date2[3]);
            data2_Minutes = Int32.Parse(date2[4]);
            data2_Seconds = Int32.Parse(date2[5]);
            #endregion

            // Создаем элементы типа Date
            Date pushData1 = new Date(data1_Day, data1_Month, data1_Year, data1_Hours, data1_Minutes, data1_Seconds);
            Date pushData2 = new Date(data2_Day, data2_Month, data2_Year, data2_Hours, data2_Minutes, data2_Seconds);

            // Отправляем решать 
            Data.Push(pushData1, pushData2);
        }

        public static void PushTimeInterval(string[] date1, string arg, string argType, bool isPlus) // Парс и отправка на решение
        {
            // Объявляем переменные, чтобы в дальнейшем перебросить массив в Date
            int data1_Day, data1_Month, data1_Year, data1_Hours, data1_Minutes, data1_Seconds, type;
            ulong num;

            // Присваиваем значения из массива
            #region
            data1_Day = Int32.Parse(date1[0]);
            data1_Month = Int32.Parse(date1[1]);
            data1_Year = Int32.Parse(date1[2]);
            data1_Hours = Int32.Parse(date1[3]);
            data1_Minutes = Int32.Parse(date1[4]);
            data1_Seconds = Int32.Parse(date1[5]);
            #endregion

            // месяцев = 6, недель = 5, дней = 4, часов = 3, минут = 2, секунд = 1
            #region Создаём 
            num = ulong.Parse(arg);
            type = Int32.Parse(argType);
            #endregion

            // Создаём элементы типа Date и TimeInterval
            Date pushDate = new Date(data1_Day, data1_Month, data1_Year, data1_Hours, data1_Minutes, data1_Seconds);
            TimeInterval pushTI = new TimeInterval(num, type);

            // Отправляем решать
            Data.Push(pushDate, pushTI, isPlus);
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

        // Работа с протоколом
        static List<Protocol> PushProto(string path)
        {
            List<Protocol> ans;
            try
            {
                ans = Protocol.Start(path);
            }
            catch (Exception e)
            {
                FormAns.Push(e.Message);
                throw;
            }

            return ans;
        }

    }
}
