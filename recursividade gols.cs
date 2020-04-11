using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de gols: \n \n Exemplo: 3 x 2");
            golsrecursivos(3, 2);
            Console.ReadKey();
        }
        static void gols(string[] v, int pos, int a, int b)
        {
            if (pos == v.Length)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    Console.Write(v[i]);
                }
                Console.WriteLine();
            }
            else
            {
                v[pos] ="a";
                gols(v, pos + 1,a,b);

                v[pos] = "b";
                gols(v, pos - 1,a,b);

            }

        }
        static void golsrecursivos(int a, int b)
        {
            int valor = a + b;
            string[] tabelagols = new string[valor];
            gols(tabelagols, 0, a, b);


        }
    }
}
