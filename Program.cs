using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
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

                while(true)
                {
                    Console.Write("Введите число: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0)
                    {
                        Console.WriteLine($"x={x + 1}");
                    }
                    else if(x == 0)
                    {
                        x = 10;
                        Console.WriteLine($"x={x}");
                    }
                    else if (x < 0)
                    {
                        Console.WriteLine($"x={x - 2}");
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
