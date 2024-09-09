using System;

namespace Session03
{
    internal class Baitap
    {
        public static void Main(string[] args)
        {
            //baitap_01();
            //baitap_02();
            //baitap_03();
            baitap_04();
        }
        static void baitap_01() 
        {
            Console.WriteLine("Enter a number as Celsius:");
            float C = Convert.ToSingle(Console.ReadLine());
            float F = C * 18 / 10 + 32;
            float K = C + 273;
            Console.WriteLine($"Convert Celsius to Fahrenheit: {C} do C = {F} do F");
            Console.WriteLine($"Convert Celsius to Kelvin: {C} do C =  {K} do K");
        }
        static void baitap_02()
        {
            Console.WriteLine("Enter a radius of a sphere:");
            float r = Convert.ToSingle(Console.ReadLine());
            //float pi = 3.14f;
            //float S = 4 * pi * (r * r);
            //float V = 4 / 3 * pi * (r * r * r);
            double pi = Math.PI;
            double S = 4 * pi * Math.Pow(r,2);
            double V = 4 / 3 * pi * Math.Pow(r,3);
            Console.WriteLine($"Surface of a sphere: {S}");
            Console.WriteLine($"Volume of a sphere: {V}");
        }
        static void baitap_03()
        {
            Console.WriteLine("Enter two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int adding = a + b;
            int subtracting = a - b;
            int multiplying = a * b;
            int dividing = a / b;
            int module = a % b;
            Console.WriteLine($"{a} + {b} = {adding}");
            Console.WriteLine($"{a} - {b} = {subtracting}");
            Console.WriteLine($"{a} * {b} = {multiplying}");
            Console.WriteLine($"{a} / {b} = {dividing}");
            Console.WriteLine($"{a} mod {b} = {module}");
        }
        static void baitap_04()
        {
            Console.WriteLine(@"Begin
                /\
               /  \
              /    \
             /______\
End");
        }
    }
}
