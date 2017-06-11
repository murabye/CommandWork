using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    public class Protocol
    {
        // поля
        private string _arg1, _arg2, _path;
        private bool _isPlus;
        private Dictionary<string, string> _operations;

        // публичные свойства
        public string Input
        {
            get
            {
                var ans = _isPlus ? _arg1 + '+' + _arg2 : _arg1 + '-' + _arg2;
                return ans;
            }
        }
        public Dictionary<string, string> Operations { get { return _operations; } }

        // конструктор
        public Protocol(string path, string arg1, string arg2, bool isPlus)
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
            // запись в файл, находящийся по адресу _path
        }
    }
}
