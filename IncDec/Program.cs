using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = -5;
            int c;
            int d;


            c = a++ + b++;

            Console.WriteLine("O valor de C e =" + c);
        }
    }
}
