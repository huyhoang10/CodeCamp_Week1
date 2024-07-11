using System;

namespace Week1
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong 2 so: "+Sum(a, b));
            Console.ReadKey();
        }
    }

}