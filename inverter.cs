using System;

namespace Testinho.Console
{
    class Program
    {

        static float Media(int[] numeros, int tamanho)
        {
            if (tamanho == 1)
                return (float) numeros[tamanho - 1];
            else
                return ((float) (Media(numeros, tamanho - 1) * (tamanho - 1) + numeros[tamanho - 1]) / tamanho);
        }


        static int QtdMaiorQueMedia(int[] numeros, int tamanho, float media)
        {
            int qtd = 0;

            if (tamanho == 1)
                return qtd;

            if (numeros[tamanho - 1] > media)
                ++qtd;

            return (qtd + QtdMaiorQueMedia(numeros, tamanho - 1, media));


        }

 
        static int[] InverteRecursivo(int[] numeros, int i)
        {
            int [] v = new int[0];
            if (numeros.Length < 1)
                return v;

            int aux;
            aux = numeros[i];
            numeros[i] = numeros[numeros.Length - 1 - i];
            numeros[numeros.Length - 1 - i] = aux;
            i++;

            if (i >= numeros.Length - 1 - i)
                return numeros;
            else
            {
                InverteRecursivo(numeros, i);
                return numeros;
            }

        }


        static void Main(string[] args)
        {
            int[] vetor = {2, 4, 12, 8, 10, 6, 14};

            int tamanho = vetor.Length;

            float media = Media(vetor, tamanho);

            System.Console.WriteLine(string.Format("Média do Vetor: {0}", media));

            System.Console.WriteLine(string.Format("Quantidade de Itens Maior que a Média: {0}", QtdMaiorQueMedia(vetor, tamanho, media)));

            System.Console.WriteLine("Vetor Original:");
            foreach (int n in vetor)
            {
                System.Console.WriteLine(n);
            }

            int[] vetorInvertido = InverteRecursivo(vetor, 0);

            System.Console.WriteLine("Vetor Invertido:");
            foreach (int n in vetorInvertido)
            {
                System.Console.WriteLine(n);
            }

            System.Console.ReadKey();
        }
    }
}
