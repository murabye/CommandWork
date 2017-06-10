using System;


// свой класс ошибок для выхода за допустимые границы даты
namespace CommandWork
{
    class DataOutOfRange : ArgumentOutOfRangeException
    {

        public DataOutOfRange()
        {
        }

        public DataOutOfRange(string message)
            : base(message)
        {
        }

        public DataOutOfRange(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
