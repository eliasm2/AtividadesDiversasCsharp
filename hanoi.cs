using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Recursividade
{
    public partial class Exerc : Form
    {
        int min = 0, seg = 0, hora = 0, cont = 0;

        public Exerc()
        {
            InitializeComponent();
        }

        #region FUNÇÕES

        // Função fatorial
        int fatorial(int x)
        {
            // Escrever a função fatorial substituindo o código abaixo
            if (x == 0) return 1;
            return x * fatorial(x - 1);
        }

        // Função fibonacci
        int fibonacci(int x)
        {
            if (x < 3) return 1;
            return fibonacci(x - 2) + fibonacci(x - 1);
        }

        // Função Recursiva para resolver as torres de Hanói        
        void MoverDiscos(int NumDiscos, int TorreOrigem, int TorreDestino, int TorreTemp)
        {
            if (NumDiscos == 0) return;
            cont++;
            MoverDiscos(NumDiscos - 1, TorreOrigem, TorreTemp, TorreDestino);
            // RenderizarMovimento(TorreOrigem, TorreDestino);
            MoverDiscos(NumDiscos - 1, TorreTemp, TorreDestino, TorreOrigem);
            //    Thread.Sleep(100);
            /* Escrever a função hanoi
             * Para mover visualmente um disco de uma torre para outra, 
             * utilize a função MoverDiscos(), passando a torre de origem e a torre de destino dos discos. */
        }

        // Função auxiliar que move graficamente um disco de uma torre para outra
        void RenderizarMovimento(int TorreOrigem, int TorreDestino)
        {
            ListBox lbOrigem = null, lbDestino = null;
            switch (TorreOrigem)
            {
                case 1: lbOrigem = lb1; break;
                case 2: lbOrigem = lb2; break;
                case 3: lbOrigem = lb3; break;
            }
            switch (TorreDestino)
            {
                case 1: lbDestino = lb1; break;
                case 2: lbDestino = lb2; break;
                case 3: lbDestino = lb3; break;
            }
            lbDestino.Items.Insert(0, lbOrigem.Items[0]);
            lbOrigem.Items.RemoveAt(0);
            Application.DoEvents();
            Thread.Sleep(100);
        }

        #endregion

        // Evento clique o fatorial
        private void btnFat_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(udFat.Value);
            lblFat.Text = Convert.ToString(fatorial(x));
        }

        // Evento clique do fibonacci
        private void btnFib_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(udFib.Value);
            lblFib.Text = Convert.ToString(fibonacci(x));
        }

        // Evento para adicionar discos nas torres
        private void udDiscos_ValueChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(udDiscos.Value);
            lb1.Items.Clear();
            lb2.Items.Clear();
            lb3.Items.Clear();
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += "_";
                lb1.Items.Add(s);
            }
            Text = "ACABEI! " + DateTime.Now.ToString(); ;
        }

        // Move os discos simulando as torres de hanói
        private void btnDiscos_Click(object sender, EventArgs e)
        {
            udDiscos_ValueChanged(sender, e);
            int n = Convert.ToInt32(udDiscos.Value);
            cont = min = seg = hora = 0;
            timer1.Start();

            MoverDiscos(n, 1, 3, 2);
            timer1.Stop();
            lblHora.Text = hora + ":" + min + ":" + seg + " - Movimentos: " + cont;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                seg = 0;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                hora++;
            }


            lblHora.Text = hora + ":" + min + ":" + seg + " - Movimentos: " + cont;
        }


        private int recursao(int a, int b, int la, int lb)
        {
            int cont = 0;
            if (a > 0 && la > 0)
                cont += recursao(a - 1, b, la - 1, lb);
            if (b > 0 && lb > 0)
                cont += recursao(a, b - 1, la, lb - 1);
            if (a == 0 && b == 0 && la == 0 && lb == 0)
                return 1;

            return cont;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i;
            i = recursao(2, 2, 2, 2);
            MessageBox.Show(i.ToString());

            i = recursao(4, 4, 4, 4);
            MessageBox.Show(i.ToString());

            i = recursao(4, 4, 2, 2);
            MessageBox.Show(i.ToString());
        }

    }
}