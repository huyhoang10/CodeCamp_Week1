using System;
namespace Week1
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Div(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap a, b: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong 2 so: "+Sum(a, b));
            Console.WriteLine("Thuong 2 so: "+Div(a, b));
            Console.ReadKey();
        }

    }

}
