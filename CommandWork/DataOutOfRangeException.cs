using System;


// свой класс ошибок для выхода за допустимые границы даты
namespace CommandWork
{
    class DataOutOfRangeException : ArgumentOutOfRangeException
    {

        public DataOutOfRangeException()
        {
        }

        public DataOutOfRangeException(string message)
            : base(message)
        {
        }

        public DataOutOfRangeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
