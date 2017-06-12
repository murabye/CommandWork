using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class Protocol
    {
        // поля
        private string[] _arg1, _arg2;
        private string _path;
        private bool _isPlus, _isAmerican;
        private Dictionary<string, string> _operations;

        // публичные свойства
        // переделать, когда будет ясно, как передается аргумент
        public string Input
        {
            get
            {
                var ans = "";
                
                if (_isAmerican)
                {
                    ans += _arg1[0] + "-" + _arg1[1] + "-" + _arg1[2] + " " + _arg1[3] + ":" + _arg1[4] + ":" +
                           _arg1[5];
                    ans += _isPlus ? "+" : "-";
                }
                else
                {
                    ans += _arg1[0] + "." + _arg1[1] + "." + _arg1[2] + " " + _arg1[3] + ":" + _arg1[4] + ":" +
                           _arg1[5];
                    ans += _isPlus ? "+" : "-";

                }


                return ans;
            }
        }
        public Dictionary<string, string> Operations { get { return _operations; } }

        // конструктор, переделать когда будет ясен ввод
        public Protocol(string path, string[] arg1, string[] arg2, bool isPlus)
        {
            // чистый протокол
            _arg1 = arg1;
            _arg2 = arg2;
            _path = path;
            _isPlus = isPlus;
            _operations = new Dictionary<string, string>();
        }

        // добавление операции
        public void AddOperation(string op, string result)
        {
            _operations.Add(op, result);
        }

        // exceptions
        public void AddException(string op, string exception)
        {
            _operations.Add(op, exception);
        }

        // запись в файл
        public void Finish()
        {
            var flow = new StreamWriter(_path, true);
            /* тип записи:
             *
             * Начало записи:
             * Входные данные 
             * Операция - результат (заголовок)
             * Операция - результат
             * ... 
             * Операция - результат
             * Конец записи.
             * 
             * */

            flow.WriteLine("Начало записи: ");
            flow.WriteLine(Input);
            flow.WriteLine("Операция - Результат");
            foreach (var operation in _operations)
                flow.WriteLine(operation.Key + " - " + operation.Value);
            flow.WriteLine("Конец записи.");

        }
    }
}
