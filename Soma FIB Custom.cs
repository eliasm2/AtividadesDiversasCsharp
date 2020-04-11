using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma");
            Console.WriteLine("1 = " + Soma(1));
            Console.WriteLine("2 = " + Soma(2));
            Console.WriteLine("3 = " + Soma(3));
            Console.WriteLine("4 = " + Soma(4));
            Console.WriteLine("5 = " + Soma(5));
            Console.WriteLine("6 = " + Soma(6));
            Console.WriteLine("7 = " + Soma(7));
            Console.WriteLine("8 = " + Soma(8));

            Console.WriteLine();

            Console.WriteLine("Fibonacci");
            Console.WriteLine("0 = " + Fib(0));
            Console.WriteLine("1 = " + Fib(1));
            Console.WriteLine("2 = " + Fib(2));
            Console.WriteLine("3 = " + Fib(3));
            Console.WriteLine("4 = " + Fib(4));
            Console.WriteLine("5 = " + Fib(5));
            Console.WriteLine("6 = " + Fib(6));
            Console.WriteLine("7 = " + Fib(7));
            Console.WriteLine("8 = " + Fib(8));

            Console.WriteLine();


            Console.WriteLine("Soma Fibonacci");
            Console.WriteLine("0 = " + SomaFib(0));
            Console.WriteLine("1 = " + SomaFib(1));
            Console.WriteLine("2 = " + SomaFib(2));
            Console.WriteLine("3 = " + SomaFib(3));
            Console.WriteLine("4 = " + SomaFib(4));
            Console.WriteLine("5 = " + SomaFib(5));
            Console.WriteLine("6 = " + SomaFib(6));
            Console.WriteLine("7 = " + SomaFib(7));
            Console.WriteLine("8 = " + SomaFib(8));

            Console.WriteLine();

            Console.WriteLine("Fatorial");
            Console.WriteLine("1 = " + Fat(1));
            Console.WriteLine("2 = " + Fat(2));
            Console.WriteLine("3 = " + Fat(3));
            Console.WriteLine("4 = " + Fat(4));
            Console.WriteLine("5 = " + Fat(5));
            Console.WriteLine("6 = " + Fat(6));
            Console.WriteLine("7 = " + Fat(7));
            Console.WriteLine("8 = " + Fat(8));

            Console.ReadLine();
        }

        static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        static int SomaFib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Fib(n) + SomaFib(n - 1);
        }

        static int Soma(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return Soma(n - 1) + n;
            }
        }

        static int Fat(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fat(n - 1) * n;
            }
        }
    }
}
