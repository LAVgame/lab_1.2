using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор простых операций");
            Console.Write("Введите число А = ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите число Б = ");   
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите число В = ");
            float v = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"A + Б = {a+b}");
            Console.WriteLine($"A - Б = {a-b}");
            Console.WriteLine($"A x Б = {a*b}");
            Console.WriteLine($"A : Б = {a/b:0.00}");
            Console.WriteLine("");
            Console.WriteLine($"A + B = {a + v}");
            Console.WriteLine($"A - B = {a - v}");
            Console.WriteLine($"A x B = {a * v}");
            Console.WriteLine($"A : B = {a / v:0.00}");
            Console.WriteLine("");
            Console.WriteLine($"В + Б = {v + b}");
            Console.WriteLine($"В - Б = {v - b}");
            Console.WriteLine($"В x Б = {v * b}");
            Console.WriteLine($"В : Б = {v / b:0.00}");
            Console.ReadLine();
        }
    }
}
