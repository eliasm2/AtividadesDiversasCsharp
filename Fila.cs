using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_Implementada
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class fila
    {
        int max, primeiro, ultimo, tam;
        int[] dados;
        public fila(int n)
        {
            max = n;
            dados = new int[n];
            primeiro = 0;
            ultimo = 0;
            tam = 0;
        }
        public bool Vazia()
        {
            return tam==0;
        }
        public void enfileirar(int dado)
        {
            int pos = (ultimo + 1) % max;
            if (pos == primeiro)
            {
                Console.WriteLine("Fila Cheia!!!");
            }
            else
            {
                ultimo = pos;
                dados[ultimo] = dado;
                tam++;
            }

        }
        public int desinfileirar()
        {
            if (Vazia())
            {
                Console.WriteLine("Fila Vazia!!!");
                return -1;
            }
            primeiro = (primeiro + 1) % max;
            tam--;
            return dados[primeiro];
        }
        public void imprimir()
        {
            int pos = (primeiro + 1) % max;
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine(dados[pos]);
                pos = (pos + 1) % max;

            }
        }

    }
}
