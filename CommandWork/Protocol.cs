﻿using System;
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
        private string _input,                                          // ввод пользователем
                        _path;                                          // путь к файлу
        private List<Pair> _operations;                                 // коллекция значений операция-результат 

        // публичные свойства
        public string Input { get { return _input; } }                   // ввод пользователем
        public List<Pair> Operations { get { return _operations; } }    // коллекция сделанного

        // конструктор
        public Protocol(string input)
        {
            // чистый протокол
            _path = "proto.txt";
            _input = input;
            _operations = new List<Pair>();
            //new FileStream(_path, FileMode.Create).Close();
        }
        public Protocol()
        {
            _path = "proto.txt";
            _input = "";
            _operations = new List<Pair>();
            //new FileStream(_path, FileMode.Create).Close();
        }

        // добавление операции или ошибки (аналогично добавлению операции, просто результат ошибка)
        public void AddOperation(string op, string result)
        {
            _operations.Add(new Pair(op, result));
        }

        public void ClearOperation()
        {
            _operations = new List<Pair>();
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

            flow.WriteLine("Начало записи:");
            flow.WriteLine(Input);
            flow.WriteLine("Операция - Результат");
            foreach (var op in _operations)
                flow.WriteLine(op.Operation + '-' + op.Result);
            flow.WriteLine("Конец записи.");
            flow.Close();

        }

        // достать из файла все протоколы, статика
        public static List<Protocol> Start(string path)
        {

            var flow = new StreamReader(path);

            /* тип записи (т. е. как в файле один сеанс выглядит):
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

            var line = flow.ReadLine();
            var ans = new List<Protocol>();
            while (line != null)
            {
                if (line == "Начало записи:")
                {
                    var input = flow.ReadLine();
                    var cur = new Protocol(input);
                    line = flow.ReadLine();
                    line = flow.ReadLine();

                    while (line != "Конец записи.")
                    {
                        
                        var args = line.Split('-');
                        cur.AddOperation(args[0], args[1]);
                        line = flow.ReadLine();
                    }
                    ans.Add(cur);
                }
                line = flow.ReadLine();
            }


            flow.Close();
            return ans;
        }
    }

    // пары операция-результат
    public class Pair
    {
        public string Operation { get; set; }
        public string Result { get; set; }

        public Pair(string operation, string result)
        {
            Operation = operation;
            Result = result;
        }

        public override string ToString()
        {
            return Operation + " - " + Result;
        }
    }
}
