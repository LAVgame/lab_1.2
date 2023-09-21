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
            Console.Write("Введите число C = ");
            float c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"A + Б = {Add(a,b)}");
            Console.WriteLine($"A - Б = {Min(a,b)}");
            Console.WriteLine($"A x Б = {Myl(a,b)}");
            Console.WriteLine($"A : Б = {Del(a,b)}");
            Console.ReadLine();
        }
        public static float Add(float a, float b) 
        {
            return a + b;      
        }
        public static float Min(float a, float b)
        {
            return a - b;
        }
        public static float Myl(float a, float b)
        {
            return a * b;
        }
        public static float Del(float a, float b)
        {
            return a / b;
        }
    }
}
