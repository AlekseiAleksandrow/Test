// See https://aka.ms/new-console-template for more information




//{
//    int a;
//    Console.Write("введите число: ");
//    a = Console.Read();

//    if (a % 2 == 1)
//    {
//        Console.WriteLine("число нечетное");

//    }
//    else
//    {
//        Console.WriteLine("Число четное");
//    }


//    Console.ReadKey();
//}

//{
//    int a;
//    Console.Write("введите число: ");
//    a = Console.Read();



//    if (a % 2 == 0)
//{ 
//    Console.WriteLine("делится");

//}
//    else
//{ 
//        Console.WriteLine("не делится");
//    }
//    Console.ReadKey();

//}



using System.Globalization;

internal partial class Program
{
    private static void Main(string[] args)
    {
        //int age;
        //Console.Write("Введите свой возраст:");
        //age = Convert.ToInt32(Console.ReadLine());
        //if (age >= 18) 
        //{
        //    Console.WriteLine("Добро пожаловать в наш бар");


        //        Console.WriteLine("Вы слишком юны");
        //}


        //else
        //    {
        //        Console.WriteLine("Вы слишком юны");
        //    }
        //int age;

        //Console.Write("Введите ваш возраст:");

        //age=Convert.ToInt32(Console.ReadLine());  

        //while (age-->0)
        //{
        //    if (age == 5)
        //    {
        //        continue;
        //    }

        //    Console.WriteLine(age);

        //}
        //        for (int i = 1; i < 10; i++)
        //        {
        //            for (int j = 1; j < 10; j++)
        //            {
        //                Console.Write($"{i * j}\t");
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.ReadKey();
        //    }
        //}
        //        

        //    
        int i = 1;
        while (i<10)
        {
            int j= 1;
            while (j<10)
            {
                Console.Write($"{i * j}\t");
                j++;
            }
            i++;
            Console.WriteLine();
        }
    }
}


