using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Arquitetura
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] registradorNome = { "a", "b", "c", "d", "e", "f" };
            String instrucoes = null;
            String[] instrucaoCompleta = new String[2];
            //VARIAVEIS POP MEMORIA
            String teste;
            int t;
            //VARIAVEIS PUSH COM INTEIROS
            String conv_push;
            int t_push;

            int?[] registrador = new int?[6];
            int?[] pilha = new int?[25];
            int[] operadores = new int[2];

            int r1 = 0;
            int r2 = 0;
            int pos_inicial = 0; //VARIAVEL QUE INICIA pilha

            String ir;
            int pc;
            int cont;

            Console.WriteLine("Digite o valor de cada Registrador: ");
            for (int i = 0; i < registrador.Length; i++)
            {
                Console.Write(registradorNome[i] + ": ");
                registrador[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite a instrucão de inicializao da pilha");
            instrucoes = Console.ReadLine();
            ir = instrucoes;


            while (instrucoes != "end")
            {

                if (instrucoes.Length >= 5)
                    instrucaoCompleta = instrucoes.Split();
                else
                    instrucaoCompleta[0] = instrucoes;
                switch (instrucaoCompleta[0].Trim())
                {
                    case "inic": //INSTRUÇÃO INICIAL! A PILHA COMECA NA POSIÇÃO PADRAO OU O USUARIO               Printar(pilha);
                        Console.WriteLine("\nIR: " + ir);
                        break;

                    case "clear":
                        Clear(pilha);
                        break;

                    case "pop":

                        if (operadores[0] != null)
                        {
                            // Console.WriteLine(""); 
                            switch (instrucaoCompleta[1].Trim())

                            {
                                case "a":
                                    Pop(pilha, registrador, 0);
                                    break;
                                case "b":
                                    Pop(pilha, registrador, 1);
                                    break;
                                case "c":
                                    Pop(pilha, registrador, 2);
                                    break;
                                case "d":
                                    Pop(pilha, registrador, 3);
                                    break;
                                case "e":
                                    Pop(pilha, registrador, 4);
                                    break;
                                case "f":
                                    Pop(pilha, registrador, 5);
                                    break;

                                default:
                                    teste = instrucaoCompleta[1];
                                    t = Convert.ToInt32(teste);
                                    Console.WriteLine(t);
                                    if (operadores[0] != null)
                                    {
                                        Mov(pilha, t);
                                        break;
                                    }
                                    break;
                                    // Console.WriteLine("--REGISTRADOR NÃO FOI ENCONTRADO--");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("--NÃO É POSSÍVEL EXECUTAR A INSTRUÇÃO--");
                        }
                        break;


                    case "push":
                        switch (instrucaoCompleta[1].Trim())
                        {
                            case "a":
                                //  Console.WriteLine("Pilha = " + pilha[0] + "; Registrador = " + registrador[0]);
                                Push(pilha, registrador, 0);
                                break;
                            case "b":
                                Push(pilha, registrador, 1);
                                break;
                            case "c":
                                Push(pilha, registrador, 2);
                                break;
                            case "d":
                                Push(pilha, registrador, 3);
                                break;
                            case "e":
                                Push(pilha, registrador, 4);
                                break;
                            case "f":
                                Push(pilha, registrador, 5);
                                break;

                            default:
                                conv_push = instrucaoCompleta[1];
                                t_push = Convert.ToInt32(conv_push);
                                Console.WriteLine(t_push);
                                if (operadores[0] != null)
                                {
                                    Push_int(pilha, t_push);
                                    break;
                                }

                                // Console.WriteLine("--REGISTRADOR NÃO FOI ENCONTRADO--");
                                break;
                        }

                        break;


                    case "add":
                        operadores = Op(pilha);
                        if (operadores[0] != 0)
                        {
                            r1 = operadores[0];
                            r2 = operadores[1];
                            pilha[r2] = pilha[r2] + pilha[r1];
                            pilha[r1] = null;
                        }
                        else
                        {
                            Console.WriteLine("--NÃO É POSSÍVEL EXECUTAR A INSTRUÇÃO--");
                        }
                        break;
                    case "subtract":
                        operadores = Op(pilha);
                        if (operadores[0] != null)
                        {
                            r1 = operadores[0];
                            r2 = operadores[1];
                            pilha[r2] = pilha[r2] - pilha[r1];
                            pilha[r1] = null;
                        }
                        else
                        {
                            Console.WriteLine("--NÃO É POSSÍVEL EXECUTAR A INSTRUÇÃO--");
                        }
                        break;
                    case "multiply":
                        operadores = Op(pilha);
                        if (operadores[0] != null)
                        {
                            r1 = operadores[0];
                            r2 = operadores[1];
                            pilha[r2] = pilha[r2] * pilha[r1];
                            pilha[r1] = null;
                        }
                        else
                        {
                            Console.WriteLine("--NÃO É POSSÍVEL EXECUTAR A INSTRUÇÃO--");
                        }
                        break;
                    case "divide":
                        operadores = Op(pilha);
                        if (operadores[0] != null)
                        {
                            r1 = operadores[0];
                            r2 = operadores[1];
                            pilha[r2] = pilha[r2] / pilha[r1];
                            pilha[r1] = null;
                        }
                        else
                        {
                            Console.WriteLine("--NÃO É POSSÍVEL EXECUTAR A INSTRUÇÃO--");
                        }
                        break;

                    default:
                        Console.WriteLine("--INSTRUÇÃO DESCONHECIDA--");
                        break;

                }
                //VERIFICAÇÃO DA MEMORIA PARA IR:

                Printar(pilha);
                Console.WriteLine("\nIR: " + ir);
                Console.WriteLine("\nDigite a instrução: ");
                instrucoes = Console.ReadLine();
                ir = instrucoes;
            }
            Console.WriteLine("--Programa encerrado!--");
            Console.ReadKey();

        }


        //MÉTODO DA INSTRUÇÃO PUSH
        static void Push(int?[] pilha, int?[] registrador, int index)
        {
            int limite;
            limite = pilha.Length - 10;
            for (int pos_inicial = 5; pos_inicial < limite; pos_inicial++)
            {
                if (pilha[pos_inicial] == null)
                {
                    pilha[pos_inicial] = registrador[index];
                    break;
                }
                else
                    Console.WriteLine("A pilha atingiu o limite!");
            }
        }
        //MÉTODO DA INSTRUÇÃO POP
        static void Pop(int?[] pilha, int?[] registrador, int indice)
        {
            int[] operadores = Op(pilha);
            int topo = operadores[0];
            if (topo != null)
            {
                registrador[indice] = pilha[topo];
                pilha[topo] = null;

            }
            else
            {
                registrador[indice] = pilha[0];
                pilha[0] = null;
            }
        }
        // MÉTODO DA INSTRUÇÃO mov (MOVER PARA QUALQUER CANTO DA MEMORIA:)
        static void Mov(int?[] pilha, int indice)
        {
            int[] operadores = Op(pilha);
            int topo = operadores[0];
            if (topo != null)
            {
                pilha[indice] = pilha[topo];
                pilha[topo] = null;

            }
            else
            {
                pilha[indice] = pilha[0];
                pilha[0] = null;
            }

        }
        //MÉTODO DA INSTRUÇÃO PUSH COM INTEIROS
        static void Push_int(int?[] pilha, int index)
        {
            for (int pos_inicial = 5; pos_inicial < pilha.Length - 10; pos_inicial++)
            {
                if (pilha[pos_inicial] == null)
                {
                    pilha[pos_inicial] = index;
                    break;
                }
            }
        }
        //MÉTODO PARA OPERAÇOES DA PILHA
        static int[] Op(int?[] pilha)
        {
            int[] operadores = new int[2];
            int index = 0;
            for (int pos_inicial = 5; pos_inicial < pilha.Length; pos_inicial++)
            {
                if (pilha[pos_inicial] == null)
                {
                    index = pos_inicial;
                    break;
                }
                else
                {
                    index = pilha.Length;
                }
            }
            if ((index - 2) >= 0)
            {
                operadores[0] = (index - 1);
                operadores[1] = (index - 2);
            }
            return operadores;
        }
        //RESGISTRADORES IR E PC 
        static void registradores_UC(int?[] pilha)
        {
            int[] pc = new int[1];
            String[] ir = new String[1];
            for (int pos_inicial = 5; pos_inicial < pilha.Length; pos_inicial++)
            {

            }

        }
        static void Clear(int?[] registradores)
        {

            for (int i = 0; i < registradores.Length; i++)
            {
                registradores[i] = null;
            }
        }

        //MÉTODO PARA IMPRIMIR NA TELA A MEMORIA
        static void Printar(int?[] registradores)
        {

            Console.WriteLine("#---------MEMORIA--------------#");
            Console.WriteLine("#-ENDERECO# --VALORES ---------#");
            for (int i = registradores.Length - 1; i >= 0; i--)
            {
                if (registradores[i] == null)
                {
                    if ((i >= 0 && i < 5) || (i >= 15 && i < 25))
                        Console.WriteLine("M:   " + i + "        =[] ");
                    else
                        Console.WriteLine("P:   " + i + "        =[] " + registradores[i] + "                ");
                }

                if (registradores[i] != null)
                {
                    if ((i >= 15 && i < 24) || (i <= 0 && i < 5))
                        Console.WriteLine("M:   " + i + "        =" + registradores[i]);
                    else
                        Console.WriteLine("P:   " + i + "        = " + registradores[i] + "                ");
                }
            }
            for (int i = 5; i < registradores.Length - 10; i++)
            {
                if (registradores[i] == null)
                {
                    if (i == 5)
                    {
                        Console.WriteLine("\nREGISTRADORES DA UC:\nPC:" + i);
                    }
                    else
                        Console.WriteLine("\nREGISTRADORES DA UC:\nPC:" + (i - 1));
                    break;
                }
            }
        }

    }
}