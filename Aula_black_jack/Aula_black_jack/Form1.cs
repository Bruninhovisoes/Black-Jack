using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
namespace Aula_black_jack
{
    public partial class Form1 : Form
    {
        private List<Image> cartaImagens;
        private Random random = new Random();
        private int soma1;
        private int soma2;
        private List<int> cartasJogador1 = new List<int>();
        private List<int> cartasJogador2 = new List<int>();
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            cartaImagens = new List<Image>
           {
             Properties.Resources.carta_1,
             Properties.Resources.carta_2,
             Properties.Resources.carta_3,
             Properties.Resources.carta_4,
             Properties.Resources.carta_5,
             Properties.Resources.carta_6,
             Properties.Resources.carta_7,
             Properties.Resources.carta_8,
             Properties.Resources.carta_9,
             Properties.Resources.carta_10,
             Properties.Resources.carta_Q1,
             Properties.Resources.carta_J,
             Properties.Resources.carta_K,
           };

        }
        private int CalcularSoma(List<int> Valores)
        {
            int soma = 0;
            int ases = 0;

            foreach (int valor in Valores)
            {
                if (valor == 1)
                {
                    ases++;
                    soma += 11;
                }
                else if (valor > 10)
                {
                    soma += 10;
                }
                else
                {
                    soma += valor;
                }
            }


            while (soma > 21 && ases > 0)
            {
                soma -= 10;
                ases--;
            }

            return soma;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pegar1_Click(object sender, EventArgs e)
        {
            int indexCarta = random.Next(cartaImagens.Count);
            pictureBox1.Image = cartaImagens[indexCarta];
            cartasJogador1.Add(indexCarta + 1);
            soma1 = CalcularSoma(cartasJogador1);
            textbox1.Text = soma1.ToString();
            if (soma1 > 21)
            {
                

                if (!btn_pegarcarta2.Enabled && !btn_parar2.Enabled)
                {
                    DeterminarVencedor();


                }
                btn_pegarcarta.Enabled = false;
                btn_parar1.Enabled = false;
                return; // Sai do método após o jogador parar.
            }

            if (soma1 == 21)
            {
                btn_parar1_Click(sender, e);
            }


        }

        private void btn_pegar2_Click(object sender, EventArgs e)
        {
            int indexCarta = random.Next(cartaImagens.Count);
            pictureBox2.Image = cartaImagens[indexCarta];
            cartasJogador2.Add(indexCarta + 1);
            soma2 = CalcularSoma(cartasJogador2);
            textbox2.Text = soma2.ToString();
            if (soma2 > 21)
            {
                

                if (!btn_pegarcarta.Enabled && !btn_parar1.Enabled)
                {
                    DeterminarVencedor();


                }
                btn_pegarcarta2.Enabled = false;
                btn_parar2.Enabled = false;
                return; // Sai do método após o jogador parar.
            }

            if (soma2 == 21)
            {
                btn_parar2_Click(sender, e);
            }


        }


        private int jogador1(int point)
        {
            return point;
        }

        private int jogador2(int point)
        {
            return point;
        }

        private void btn_parar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O jogador 1 parou.");


            btn_pegarcarta.Enabled = false;
            btn_parar1.Enabled = false;

            if (!btn_pegarcarta.Enabled && !btn_pegarcarta2.Enabled)
            {
                DeterminarVencedor();
            }
        }

        private void btn_parar2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O jogador 2 parou.");


            btn_pegarcarta2.Enabled = false;
            btn_parar2.Enabled = false;

            if (!btn_pegarcarta.Enabled && !btn_pegarcarta2.Enabled)
            {
                DeterminarVencedor();
            }
        }
        private void DeterminarVencedor()
        {
            if (soma1 > 21 && soma2 > 21)
            {
                MessageBox.Show("Ambos os jogadores estouraram. Não há vencedor.");
            }
            else if (soma1 > 21)
            {
                MessageBox.Show("Jogador 2 ganhou! Jogador 1 estourou.");
            }
            else if (soma2 > 21)
            {
                MessageBox.Show("Jogador 1 ganhou! Jogador 2 estourou.");
            }
            else if (soma1 > soma2)
            {
                MessageBox.Show("Jogador 1 ganhou com " + soma1 + " pontos!");
            }
            else if (soma2 > soma1)
            {
                MessageBox.Show("Jogador 2 ganhou com " + soma2 + " pontos!");
            }
            else if (soma1 < 21 && soma2 < 21)
            {
                vencedorParou();
                if (soma1 == 21)
                {
                    MessageBox.Show("jogador 1 venceu");
                }
                else
                {
                    MessageBox.Show("jogador 2 venceu");
                }
            }
            else
            {
                MessageBox.Show("Empate! Ambos os jogadores têm " + soma1 + " pontos.");
            }
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            cartasJogador1.Clear();
            cartasJogador2.Clear();
            soma1 = 0;
            soma2 = 0;


            pictureBox1.Image = null;
            pictureBox2.Image = null;
            textbox1.Text = "";
            textbox2.Text = "";


            btn_pegarcarta.Enabled = true;
            btn_parar1.Enabled = true;
            btn_pegarcarta2.Enabled = true;
            btn_parar2.Enabled = true;


            MessageBox.Show("Jogo reiniciado. Comece uma nova rodada!");
        }

        private void vencedorParou()
        {

            while (soma1 == 21 || soma2 == 21)
            {
                soma1+=1;
                soma2+=1;
            }

            
        }

    }
}
