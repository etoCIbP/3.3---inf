using System;

namespace _3._3____inf
{
    class Program
    {
        static void Main(string[] args)
        {
            ////3.3  Вычисление бесконечных сумм
            //double x = 1;
            //for (double i = Math.Pow(x, 3) / 3!, j = Math.Pow(x, 5) / 5!; ;)
            //{
            //    Console.WriteLine($"i = {i}");
            //    Console.WriteLine($"j = {j}");
            //    i++; j++;
            //}

            int factorial(int n)
            {
                if (n == 1) return 1;
                return n * factorial(n - 1);
            }

            int factorial3 = factorial(3); //6
            int factorial5 = factorial(5); //120

            //Console.WriteLine($"Ответ = {factorial3}");
            //Console.WriteLine($"Ответ = {factorial5}");

            double x = 1;
            for (double i = Math.Pow(x, 3) / factorial3, j = Math.Pow(x, 5) / factorial5; ;)
            {
                Console.WriteLine($"i = {i}");
                Console.WriteLine($"j = {j}");
                Console.WriteLine($"Ответ = {factorial3}");
                Console.WriteLine($"Ответ = {factorial5}");
                i++; j++;
            }
        }
    }
}
