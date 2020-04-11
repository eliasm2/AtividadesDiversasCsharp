using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Informe um valor para X e para Y");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            double resultado = mdc_recursivo(x, y);
            Console.WriteLine("O MDC de "+x+" e "+y+" é igual a: "+resultado);
            Console.ReadKey();
        }

        static int mdc_recursivo(int x, int y)
        {
            if (x % y == 0)
                return y;
            else
                return mdc_recursivo(y, x % y);
                

            

        }
    }
}
