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
        public static bool CheckDate(string[] date1, bool isAmerican) // тут проверить на 30 февраля
        {
            return false;
        }

        public static bool CheckMonthsDates(string num) // лучше оставь это. я тут проверяю корректно ли введено значение дней или месяцев
        {
            return CheckNumber(num, 0, Int32.MaxValue);
        }

        public static bool CheckTimeInterval(string arg, int type) // что тут и дальше - хз, но оставлю так, как сделала Варя, сам поменяешь
        {
            return true;
        }

        public static void PushDate(string arg1, string arg2, bool isAmericanArg1, bool isAmericanArg2)
        {
            
        }

        public static void PushTimeInterval(string arg1, string arg2, bool isAmericanArg1, bool isPlus)
        {
            
        }

        static bool CheckNumber(string text, int minSize, int maxSize) // проверка соответствия ввода типу int 
        {
            try
            {
                var number = Convert.ToInt32(text);
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
