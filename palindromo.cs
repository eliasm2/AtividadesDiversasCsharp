using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto: ");
            string texto;

            texto = Console.ReadLine();
            invertida(texto,0,texto.Length-1);
            Console.WriteLine();
            Console.ReadKey();

        }

      
        static bool invertida(string []texto, int i, int j)
        {


            if (i < j)
            {
                string aux = "";
                aux = texto[i];
                texto[i] = texto[j];
                texto[j] = aux;

                return invertida(texto, i + 1, j - 1);
            }
            else
                return false;
        }
    }
}
