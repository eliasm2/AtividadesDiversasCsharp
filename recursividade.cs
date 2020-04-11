using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double K = expo_recursiva(2 , 2);

            Console.WriteLine(K);

            Console.ReadKey();

        }

        static double expo_recursiva(double x, double n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;

            return x * expo_recursiva(x, n - 1);

        }
    }
}
