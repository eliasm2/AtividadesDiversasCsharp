using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Pilha
    {
        private int[] dados;
        private int topo;
        private int MAX;

        public Pilha(int n)
        {
            dados = new int[n];
            MAX = n;
            topo = 0;
        }

        public void Empilhar(int dado)
        {
            if(topo < MAX)
            {
                dados[topo] = dado;
                topo++;
            }
            else
            {
                Console.WriteLine("Pilha Cheia!!!");
            }
        }

        public int Desempilhar()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha Vazia!");
                return -1;
            }
            else
            {
                topo--;
                return dados[topo];

            }
        }

        public int Tamanho()
        {
            return topo;
        }

        public bool Vazia()
        {
            return topo == 0;
        }

        public void Imprimir()
        {
            for(int i=topo-1; i>=0; i--)
                Console.WriteLine(dados[i]);
        }
    }

    class Celula
    {
        public int dado { get; set; }
        public Celula prox { get; set; }
    }

    class PilhaDinamica
    {
        private Celula topo;
        private int tam;

        public PilhaDinamica()
        {
            topo = null;
            tam = 0;
        }

        public void Empilhar(int dado)
        {
            Celula temp = new Celula();
            temp.dado = dado;
            temp.prox = topo;
            topo = temp;
            tam++;
        }

        public void Imprimir()
        {
            Celula temp = topo;
            while (temp != null)
            {
                Console.WriteLine(temp.dado);
                temp = temp.prox;
            }
        }

        public int Tamanho()
        {
            return tam;
        }

        public bool Vazia()
        {
            return topo == null;
        }

        public int Desempilhar()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha Vazia!");
                return -1;
            }

            int dado = topo.dado;
            topo = topo.prox;
            tam--;
            return dado;
        }



    }


    class Program
    {
        static bool valida_exp(string exp)
        {
            Pilha p = new Pilha(exp.Length);
            for(int i=0; i < exp.Length; i++)
            {
                if(exp[i] == '(')  {
                    p.Empilhar(1);
                }
                else if (exp[i] == ')')   {
                    if (p.Vazia())
                        return false;

                    p.Desempilhar();
                }      
            }

            if (p.Vazia())
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            int N = 5;
            //Pilha p = new Pilha(N);
            PilhaDinamica p = new PilhaDinamica();

            for(int i=0; i<N+1;i++)
                p.Empilhar(i+1);

            p.Imprimir();
            while (!p.Vazia())
            {
                int x = p.Desempilhar();
                Console.WriteLine("Item desempilhado: {0}", x);
                p.Imprimir();
            }

            p.Desempilhar();

            /*string exp = "(()))";

            if (valida_exp(exp))
            {
                Console.WriteLine("Expressao Valida!");
            }
            else
            {
                Console.WriteLine("Expressao Invalida!");
            }*/







            Console.ReadKey();
        }
    }
}
