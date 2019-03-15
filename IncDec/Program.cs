using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a = 2;
            int b = -5;
            int c;
            int d;

            // 2 different Types of incrementation
            c = a++ + b++;
            d = ++a - b++;

            // Results
            Console.WriteLine("O valor de C e = " + c + " e o valor de D e = " + d);
        }
    }
}
