using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_sharp
{
    internal class Program
    {
        static void Main(string[] args)

        // static - вызывается не из под объекта а сразу из класса

        // проверяем символы на что-то
        {
            /* Console.WriteLine(char.IsControl('\t')); // является ли символ управляющим

             Console.WriteLine(char.IsDigit('5')); // является ли символ цифрой (0-9)

             Console.WriteLine(char.IsLetter('x')); // является ли символ буквой 


             Console.WriteLine(char.IsLower('m')); // нижний регистр

             Console.WriteLine(char.IsUpper('P')); // верхний регистр

             Console.WriteLine(char.IsNumber('2')); // проверяет является ли числом

             Console.WriteLine(char.IsSeparator('.')); // является ли разделителем (только пробел)

             Console.WriteLine(char.IsSymbol('<')); // является ли специальным символом

             Console.WriteLine(char.IsWhiteSpace(' ')); // является ли пробелом

             Console.WriteLine(char.ToLower('T')); // метод перевода в нижний регистр

             Console.WriteLine(char.ToUpper('t')); // метод перевода в верхний регистр

             // строки

             string str = "hello :)";
             object anotherString = str.Clone();
             Console.WriteLine(anotherString);

             Console.WriteLine(str.Contains("hello")); // проверяет существует ли подстрока 

             Console.WriteLine(str.Insert(6, "world")); // вставка с какого-то индекса, не перезаписывает строку

             Console.WriteLine(str.Remove(5, 1)); // удаление (индекс + количество символов которое нужно удалить)

             Console.WriteLine(str.Replace(":)", ":(")); // заменить искомый символ на предложенный, заменит все символы в строке

             Console.WriteLine(str.StartsWith("hell")); // проверяет начинается ли строка/подстрока с этого символа

             Console.WriteLine(str.Substring(6)); // показывают строку с какого-то индекса

             Console.WriteLine(str.ToUpper()); // конвертирует всю строку в верхний регистр 

             str = "       " + str + "       ";
             Console.WriteLine(str.TrimEnd());

             str = "       " + str + "       ";
             str = str.Trim(); // удаляет пробелы лишние +  можно перегнрузить на конкретный символв
             Console.WriteLine(str);

             Console.WriteLine(string.Format("the message is \"{0}\" and some numeric value is {1}", str, 512)); // пихает параметры в конце скобок на место фигурных скобок с цифрами в строке, можно добавлять параметры и цифры

             Console.WriteLine($"the message is \"{str}\" and some numeric value is {512} {"scsicns"}"); // либо так с помощью $ вставляем объекты напрямую

             // get_types

             *//*при помощи метода GetType() 
             программа возвращает тип данных литералов,
             демонстрируя действие суффиксов
             ----------------------------------------*//*
             Console.WriteLine((10D).GetType());
             *//*выводит в консоль: System.Double
              что соответствует типу данных double*//*
             Console.WriteLine((10F).GetType());
             *//*выводит в консоль: System.Single
              что соответствует типу данных float*//*
             Console.WriteLine((10M).GetType());
             *//*выводит в консоль: System.Decimal
              что соответствует типу данных decimal*//*
             Console.WriteLine((10).GetType());
             *//*выводит в консоль: System.Int32
              что соответствует типу данных int*//*
             Console.WriteLine((10L).GetType());
             *//*выводит в консоль: System.Int64
             что соответствует типу данных long*//*
             Console.WriteLine((10UL).GetType());
             *//*выводит в консоль: System.UInt64
             что соответствует типу данных ulong*//*
             Console.WriteLine(0xFF);
             *//*выводит в консоль: 255
             шестнадцатиричное число 0xFF соответствует 
             десятичному числу 255*//*

             //

             Console.WriteLine("Некоторое простое сообщение\nИ ещё одно простое сообщение на новой строке");
             *//*выводит в консоль следующее сообщение:
              "Некоторое простое сообщение
              И ещё одно простое сообщение на новой строке"*//*
             Console.WriteLine("Пример табуляции:\n1\t2\t3\n4\t5\t6");
             *//*выводит в консоль следующее сообщение:
              "Пример табуляции:
              1  2   3
              4  5   6"*//*
             Console.WriteLine(@"Пример буквального строкового литерала: // всё превратиться в обычный текст из-за @
             1       \t     3
                 \n   5       6");
             *//*выводит в консоль следующее сообщение:
              "Пример буквального строкового литерала:
                           1       \t     3
                                \n   5       6"*/

            // Arrays
            Random r = new Random();
            /* Console.Write("Введите размер массива: ");
             string n;
             n = Console.ReadLine();
             int n2 = Convert.ToInt32(n);
             int[] arr = new int[n2];
             for (int i = 0; i < n2; i++)
             {
                 arr[i] = r.Next(-20, 20);
                 Console.Write(arr[i] + " ");
             }
             Console.WriteLine();
             Console.WriteLine("*******************************************");

             int[] tmp = (int[])arr.Clone();
             Array.Reverse(tmp); // разворачивает массив, можно по индексу и до конца

             for (int i = 0; i < n2; i++)
             {
                 Console.Write(tmp[i] + " ");
             }
             Console.WriteLine();
             Console.WriteLine("*******************************************");

             int[] tmp1 = new int[15];
             tmp.CopyTo(tmp1, 5);

             for (int i = 0; i < tmp1.Length; i++)
             {
                 Console.Write(tmp1[i] + " ");
             }
             Console.WriteLine();

             Console.WriteLine("*******************************************");
             Array.Sort(tmp);
             for (int i = 0; i < tmp1.Length; i++)
             {
                 Console.Write(tmp[i] + " ");
             }*/

            /*int[,] arr2 = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i,j] = r.Next(50);
                    Console.Write(arr2[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/

            int[][] arr3 = new int[5][];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = new int[r.Next(1,10)];
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    arr3[i][j] = r.Next(50);
                    Console.Write($"{arr3[i][j]}      ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************");

            for (int i = 0; i < arr3.Length; i++)
            {
                Array.Sort(arr3[i]);
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    
                    Console.Write($"{(arr3[i][j]).ToString().PadLeft(5)}      "); // Padleft() = setw()
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }      
    }
}
