using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Celula
    {
        public int numero;
        public Celula Proximo = null;
    }

    public class ListaDinamica
    {
        private Celula prox;

        public ListaDinamica()
        {

            this.prox = null;
        }

        public void Inserir(int valor)
        {
            Celula node = new Celula();
            node.numero = valor;

            if (this.prox == null)
            {
                node.Proximo = node;
                this.prox = node;
            }
            else
            {
                node.Proximo = this.prox.Proximo;



                this.prox.Proximo = node;
            }
        }

        public void remover(int dado)
        {


            while (prox.Proximo.numero != dado)
            {

                prox = prox.Proximo;

            }
            prox.Proximo = prox.Proximo.Proximo;
        }

        public int jogo(int m, int o)
        {
            while (prox.numero != m)
            {
                prox = prox.Proximo;
            }

            while (prox != prox.Proximo)
            {
                for (int i = 0; i < (o - 1); i++)
                {
                    prox = prox.Proximo;
                }
                prox.Proximo = prox.Proximo.Proximo;
            }
            return prox.numero;
        }
    }


    public class Test
    {
        public static int solucao(int prim, int seg, int ter)
        {

            ListaDinamica Alunos = new ListaDinamica();

            for (int i = prim; i > 0; i--)
            {
                Alunos.Inserir(i);
            }

            int resultado = Alunos.jogo(seg, ter);

            return resultado;
        }
        class Program
        {
            static void Main(string[] args)
            {
                int resultado;
                int temp;
                int prim;
                int seg;
                int ter;

                temp = int.Parse(Console.ReadLine());

                while (temp > 0)
                {


                    string linha = Console.ReadLine();

                    string[] dados = linha.Split(' ');


                    prim = int.Parse(dados[0]);

                    seg = int.Parse(dados[1]);

                    ter = int.Parse(dados[2]);


                    resultado = solucao(prim, seg, ter);

                    Console.WriteLine(resultado);

                    temp--;
                }


            }
        }
    }
}

