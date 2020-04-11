using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            tabelaverdaderecursiva(3);
            Console.ReadKey();
        }

        static void tabelaverdade(int [] v, int pos)
        {
            if (pos == v.Length)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    Console.Write(v[i]);
                }
                    Console.WriteLine(" ");
                    

                

            }
            else
            {

                v[pos] = 0;
                tabelaverdade(v, pos + 1);

                v[pos] = 1;
                tabelaverdade(v, pos + 1);

            }
        }

        static void tabelaverdaderecursiva(int n)
        {
            int[] tabela = new int[n];
            tabelaverdade(tabela, 0);

        }
    }
}
