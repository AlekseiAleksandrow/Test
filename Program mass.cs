// See https://aka.ms/new-console-template for more information

using System;

namespace AleksandrowAlekseiProject
{
    internal class ConsoleApp3
    {
        private static void Main()
        {
            //Console.WriteLine("Введите число");

            //var input = Console.ReadLine();

            ////var number = int.Parse(input);

            // var x = int.TryParse(input, out var number);


            // if(x)
            // {
            //     number *= 2;
            //     Console.WriteLine(number); 
            // }
            // else 
            // {   
            //     Console.WriteLine("Не коректное значение"); 
            // }


            //var number = int.Parse(input);




            //if (x)
            //{
            //    Console.WriteLine(Math.Pow(number, 2 ));

            //}

            //bool x;

            //int number;

            //do
            //{
            //    Console.WriteLine("Введите число");

            //    var input = Console.ReadLine();

            //    x = int.TryParse(input, out number);
            //}
            //while (!x);

            //Console.WriteLine(Math.Pow(number, 2));



            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int i = 10;

            //do
            //{
            //    Console.WriteLine("Введите число");
            //    var input = Console.ReadLine();
            //    i = int.TryParse(input, out numbers);
            //    i++;
            //}
            //while (i < numbers.Length);
            //Console.WriteLine(Math.Pow(numbers, 2));

            int[] a = new int[10];
            Console.WriteLine("Введите 10 чисел");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Введите a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine()); 
            }
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                Console.WriteLine($"Сумма 10 элементов массива: {sum}");
            }
        }
    }
    }

