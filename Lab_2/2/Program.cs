using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор простых операций");
            Console.WriteLine("Введите число А");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите число Б");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"A + B = {a+b}");
            Console.WriteLine($"A - B = {a-b}");
            Console.WriteLine($"A x B = {a*b}");
            Console.WriteLine($"A : B = {a/b:0.00}");
            Console.ReadLine();
        }
    }
}
