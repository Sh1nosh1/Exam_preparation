using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 11

                /*while (true)
                {
                    Console.Write("Введите объем флешки в Гб: ");
                    double v = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Количество файлов - {(int)(v * 1024 / 820)}");
                }*/

                //Task 12

                /*Console.Write("Введите двузначное число: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"e={x%10}\td={x/10}");*/

                //Task 13

                /*while (true)
                {
                    Console.Write("Введите число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0)
                    {
                        Console.WriteLine($"x={x + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"x={x - 1}");
                    }
                    Console.WriteLine();
                }*/

                //Task 14
                //Дано целое число. Если оно является положительным, то прибавить к нему 1; если
                //отрицательным, то вычесть из него 2; если нулевым, то заменить его на 10.Вывести полученное число.

                /*while (true)
                {
                    Console.Write("Введите число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0)
                    {
                        Console.WriteLine($"x={x + 1}");
                    }
                    if (x == 0)
                    {
                        x = 10;
                        Console.WriteLine($"x={x}");
                    }
                    if (x < 0)
                    {
                        Console.WriteLine($"x={x - 2}");
                    }
                    Console.WriteLine();
                }*/

                //Task 15
                //Определить, является ли число положительным, отрицательным или нулевым.

                /*while (true)
                {
                    Console.Write("Введите число x: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0)
                    {
                        Console.WriteLine("Число x является положительным.");
                    }
                    else if (x == 0)
                    {
                        Console.WriteLine($"Число x является нулевым");
                    }
                    else if (x < 0)
                    {
                        Console.WriteLine("Число x является отрицательным");
                    }
                    Console.WriteLine();
                }*/

                //Task 16
                //Определить, является ли треугольник со сторонами a, b, c равносторонним.

                /*Console.Write("Введите сторону A треугольника: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите B сторону треугольника: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите C сторону треугольника: ");
                double c = Convert.ToDouble(Console.ReadLine());
                if (a == b & a == c & b == c)
                {
                    Console.WriteLine($"Ваш треугольник равносторонний, т.к. все его стороны равны {a}.");
                }
                else
                {
                    Console.WriteLine($"Ваш треугольник не равносторонний, т.к. все его стороны не равны.\nA={a}; B={b}; C={c}");
                }*/

                //Task 17
                //Составьте программу, определяющую, является ли данное число делителем числа 3.

                /*while (true)
                {
                    Console.Write("Введите число x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    if (3 % x == 0)
                    {
                        Console.WriteLine("Число x является делителем числа 3.");
                    }
                    else
                    {
                        Console.WriteLine("Число x не является делителем числа 3.");
                    }
                    Console.WriteLine();
                }*/

                //Task 18
                //Генерируется 10 случайных чисел в интервале (–30, 30). Выводятся эти числа и сообщения:
                //отрицательное – положительное.

                /*int[] array = new int[10];
                Random rand = new Random();
                int i;
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-30, 30);
                    if(array[i] > 0)
                    {
                        Console.WriteLine($"{array[i]} - положительное.");
                    }
                    else if(array[i] < 0)
                    {
                        Console.WriteLine($"{array[i]} - отрицательное.");
                    }
                }*/

                //Task 19
                //Генерируется 8 случайных чисел в интервале (–20, 330). Выводятся эти числа и сообщения: чётное – нечетное.

                int[] array = new int[8];
                Random rand = new Random();
                int i;
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-20, 330);
                    if (array[i] % 2 == 0)
                    {
                        Console.WriteLine($"{array[i]} - четное.");
                    }
                    else if (array[i] % 2 != 0)
                    {
                        Console.WriteLine($"{array[i]} - нечетное.");
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            Console.ReadKey();
        }
    }
}
