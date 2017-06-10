using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class TimeInterval
    {
        // для всех total используется ulong - целое число без знака
        // соответственно ограничители, константы
        public const uint MaxTime = uint.MaxValue;
        public const uint MinTime = uint.MinValue;

        // поля внутренние
        private Data _start;
        private Data _end;

        // свойства, доступные извне
        // учтены такие особенности, как:
        //       високосные годы;
        //       месяцы с 30, 31, 28 и 29 днями
        public int Years;                            // данная группа свойств
        public int Month;                            // предоставляет не полное кол-во
        public int Days;                             // чего-либо в периоде
        public int Hours;                            // а именно часть, то есть
        public int Minutes;                          // пример: 2 года 1 месяц 7 дней
        public int Second;                           // а не 2 года, 25 месяцев и тд

        public ulong TotalYears;                     // данная группа свойств
        public ulong TotalMonth;                     // предоставляет
        public ulong TotalDays;                      // полное количество чего-либо
        public ulong TotalHours;                      
        public ulong TotalMinutes;                   
        public ulong TotalSecond;                    
        
        // конструкторы
        public TimeInterval()
        {
            _start = new Data();
            _end = new Data();
        }                     // начало и конец - дата сейчас
        public TimeInterval(Data start)
        {
            _start = start;
            _end = new Data();
        }           // конец - дата в данный момент
        public TimeInterval(Data start, Data end)
        {
            _start = start;
            _end = end;
        } // полностью заданный интервал

        // статические методы

        // методы

        // перегрузки
        public override string ToString()
        {
            // возвращает интервал вида 2:3:8 3-8-17
            // где сначала возврачается в дате, затем в часах

            return Years + ":" + Month + ":" + Days + 
                " " + Hours + "-" + Minutes + "-" + Second;
        }

        // операторы
    }
}
