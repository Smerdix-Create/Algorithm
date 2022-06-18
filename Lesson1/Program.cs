using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                switch (Tasks())
                {
                    case "1":
                        Console.Clear();
                        Task1();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Task2();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Task3();
                        Console.Clear();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Неверный номер задания!!!");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static string Tasks()
        {
            Console.WriteLine("Выберите номер задания");
            Console.WriteLine("=======================");
            Console.WriteLine("1 - Реализация функции согласно блок-схеме");
            Console.WriteLine("2 - Оценка сложности функции");
            Console.WriteLine("3 - Вычисление числа Фибоначчи с рекурсией и без");
            Console.WriteLine("0 - Выход");
            string x = Console.ReadLine();
            return x;
        }

        /// <summary>
        /// 1 - Реализация функции согласно блок-схеме 
        /// </summary>
        static void Task1()
        {
            Console.Write($"Введите число: ");
            bool a = int.TryParse(Console.ReadLine(), out int n);

            if (!a)
            {
                Console.WriteLine("Неверное число");
                Console.ReadKey(true);
                return;
            }

            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Простое число");
            }
            else
            {
                Console.WriteLine("Не простое число");  
            }

            Console.ReadKey(true);
        }

        /// <summary>
        /// 2 - Оценка сложности функции
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Асимптотическая сложность равна O(n^3)");
            Console.ReadKey(true);
        }


        /// <summary>
        /// 3 - Вычисление числа Фибоначчи с рекурсией и без
        /// </summary>
        static void Task3()
        {
            Console.Write($"Введите число: ");
            bool a = int.TryParse(Console.ReadLine(), out int n);

            if (!a)
            {
                Console.WriteLine("Неверное число");
                Console.ReadKey(true);
                return;
            }

            Console.Write("С рекурсией - ");
            Console.WriteLine(withRecursion(n));

            Console.Write("Без рекурсии, циклом - ");
            Console.WriteLine(withoutRecursion(n));

            Console.ReadKey();
        }

        //С рекурсией
        static int withRecursion(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return withRecursion(n - 1) + withRecursion(n - 2);
        }

        //Без рекурсии
        static int withoutRecursion(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            int sum1 = 0;
            int sum2 = 1;
            int sum3 = 0;

            for(int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum3 = sum1 + sum2;
                    sum1 = sum3;
                }
                else
                {
                    sum3 = sum1 + sum2;
                    sum2 = sum3;
                }
            }

            return sum3;
        }
    }
}
