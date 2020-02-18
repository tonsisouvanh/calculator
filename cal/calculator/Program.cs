using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + add(a, b));
            Console.WriteLine("a - b = " + minus(a, b));

        }
        public static int add(int a,int b)
        {
            return a + b;
        }
         public static int minus(int a,int b)
        {
            return a - b;
        }
    }
}
