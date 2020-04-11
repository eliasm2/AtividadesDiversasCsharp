using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de pratos: ");
            int n = int.Parse(Console.ReadLine());
            pilha pratos = new pilha(n);

            Console.WriteLine("Digite a quantidade de comida de cada prato:");
            int qtde = 0;
            for (int i = 0; i < n; i++)
            {
                qtde = int.Parse(Console.ReadLine());
                pratos.Empilhar(qtde);
            }
            Console.WriteLine("Os valores dos pratos são: \n \n ");
            pratos.imprimir();
            Console.WriteLine("\n tamanho da pilha: "+pratos.tamanho());


            Console.ReadKey();

        }
    }
    class pilha
    {
        private int[] dados;
        private int topo;
        private int MAX;

        public pilha(int n)
        {
            dados = new int[n];
            MAX = n;
            topo = 0;

        }
        public void Empilhar(int dado)
        {
            if (topo < MAX)
            {
                dados[topo] = dado;
                topo++;
            }
            else
            {
                Console.WriteLine("Pilha Cheia!");
            }
        }
        public int Desimpilhar()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha vazia");
                return -1;
            }
            else
            {
                topo--;
                return dados[topo];
            }
        }
        public bool Vazia()
            {
            return topo == 0;
            }
        public void imprimir()
        {
            for (int i=topo-1;i>=0; i--)
            {
                Console.WriteLine(dados[i]);
            }
        }
        public int tamanho()
        {
            return topo;
        }
    }

    
}
