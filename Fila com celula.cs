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
    class celula
    {
       public int dado;
        public celula prox;

    }
    class fila
    {
        celula primeiro;
        celula ultimo;
        int tam;

        public fila()
        {
            primeiro = new celula();
            ultimo = primeiro;
            tam = 0;
            primeiro.prox = null;

        }
        public void enfileirar(int Dado)
        {
            celula temp = new celula();
            temp.dado = Dado;
            temp.prox = null;
            ultimo.prox = temp;
            ultimo = temp;
            tam++;

        }
        public bool Vazia()
        {
            return primeiro == ultimo;

        }
        public int desenfileirar()
        {

            if (Vazia())
            {
                Console.WriteLine("Fila vazia!!!");
                return -1;
            }
            primeiro = primeiro.prox;
            tam--;
            return primeiro.dado;
        }
        public void imprimir()
        {
            celula temp = primeiro;
            while (temp != ultimo)
            {
                temp = temp.prox;
                Console.WriteLine(temp.dado);
            }
            
        }
        public bool pesquisa(int x)
        {
            celula temp = primeiro.prox;
            while (temp != null)
            {
                if (temp.dado == x)
                    return true;
            }
            return false;
        }
    }
    

    }

