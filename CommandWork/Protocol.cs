using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandWork
{
    class Protocol
    {
        // поля
        private string _arg1, _arg2;
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

        // добавление операции
        public void AddOperation(string op, string result)
        {
            _operations.Add(op, result);
        }
    }
}
