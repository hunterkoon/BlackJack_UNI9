using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_jogo : Form
    {
        public Form_jogo()
        {
            InitializeComponent();
            btn_reiniciar.Enabled = false;
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;
        }

        int pontos_A = 0;
        int pontos_B = 0;

        public void resultado()
        {

            /*

                jogador 1   x   jogador 2   resultado
                <= 21           <= 21       maior ponto ganha   REGRA 1
                > 21            <= 21       jogador 2 ganha     REGRA 2
                <= 21           > 21        jogador 1 ganha     REGRA 3
                > 21            > 21        2 perderam          REGRA 4
                jogador 2       jogador 1   EMPATE              REGRA 5

             

            if (pontos_A > pontos_B && pontos_A <= 21)
                lbl_Resultado.Text = "Jogador 1 GANHOU!";
            else
                if (pontos_A < pontos_B && pontos_B <= 21)
                lbl_Resultado.Text = "Jogador 2 GANHOU!";
            else
                    if (pontos_A <= 21 && pontos_B <= 21)
                lbl_Resultado.Text = "EMPATE";
            else
                lbl_Resultado.Text = "SEM VENCEDOR.";
            */

            if (pontos_A == pontos_B)
                lbl_Resultado.Text = "Empate Tecnico!!";
            else if (pontos_A == 21)
                lbl_Resultado.Text = "Jogador 1 Venceu!!";
            else if (pontos_B == 21)
                lbl_Resultado.Text = "Jogador 2 Venceu!!";
            else if (pontos_A > 21 && pontos_B < 21)
                lbl_Resultado.Text = "Jogador 2 Venceu!!";
            else if (pontos_A < 21 && pontos_B > 21)
                lbl_Resultado.Text = "Jogador 1 Venceu!!";
            else if (pontos_A > pontos_B && pontos_A <= 21)
                lbl_Resultado.Text = "Jogador 1 Venceu!!";
            else if (pontos_A < pontos_B && pontos_B <= 21)
                lbl_Resultado.Text = "Jogador 2 Venceu!!";
            else if (pontos_A > 21 || pontos_B > 21)
                lbl_Resultado.Text = "Ninguem venceu!";
            else
                lbl_Resultado.Text = "ué que aconteceu!?";


        }

        public void Jogada(PictureBox A, int jogador)
        {
            int x, total_pontos=0;
            Random sorteio = new Random();
            x = sorteio.Next(1, 52);


            switch (x)
            {

                case 1:     A.Image = Properties.Resources._1_1;    total_pontos += 1;     break;
                case 2:     A.Image = Properties.Resources._2_1;   total_pontos += 2;     break;
                case 3:     A.Image = Properties.Resources._3_1;   total_pontos += 3;     break;
                case 4:     A.Image = Properties.Resources._4_1;   total_pontos += 4;     break;
                case 5:     A.Image = Properties.Resources._5_1;   total_pontos += 5;     break;
                case 6:     A.Image = Properties.Resources._6_1;   total_pontos += 6;     break;
                case 7:     A.Image = Properties.Resources._7_1;   total_pontos += 7;     break;
                case 8:     A.Image = Properties.Resources._8_1;   total_pontos += 8;     break;
                case 9:     A.Image = Properties.Resources._9_1;   total_pontos += 9;     break;
                case 10:    A.Image = Properties.Resources._10_1;  total_pontos += 10;    break;
                case 11:    A.Image = Properties.Resources._10_P_1;    total_pontos += 10;    break;
                case 12:    A.Image = Properties.Resources._10_P_2;    total_pontos += 10;    break;
                case 13:    A.Image = Properties.Resources._10_P;    total_pontos += 10;    break;

                case 14: A.Image = Properties.Resources._1_2; total_pontos += 1; break;
                case 15: A.Image = Properties.Resources._2_2; total_pontos += 2; break;
                case 16: A.Image = Properties.Resources._3_2; total_pontos += 3; break;
                case 17: A.Image = Properties.Resources._4_2; total_pontos += 4; break;
                case 18: A.Image = Properties.Resources._5_2; total_pontos += 5; break;
                case 19: A.Image = Properties.Resources._6_2; total_pontos += 6; break;
                case 20: A.Image = Properties.Resources._7_2; total_pontos += 7; break;
                case 21: A.Image = Properties.Resources._8_2; total_pontos += 8; break;
                case 22: A.Image = Properties.Resources._9_2; total_pontos += 9; break;
                case 23: A.Image = Properties.Resources._10_2; total_pontos += 10; break;
                case 24: A.Image = Properties.Resources._10_O_1; total_pontos += 10; break;
                case 25: A.Image = Properties.Resources._10_O_2; total_pontos += 10; break;
                case 26: A.Image = Properties.Resources._10_O; total_pontos += 10; break;

                case 27: A.Image = Properties.Resources._1_3; total_pontos += 1; break;
                case 28: A.Image = Properties.Resources._2_3; total_pontos += 2; break;
                case 29: A.Image = Properties.Resources._3_3; total_pontos += 3; break;
                case 30: A.Image = Properties.Resources._4_3; total_pontos += 4; break;
                case 31: A.Image = Properties.Resources._5_3; total_pontos += 5; break;
                case 32: A.Image = Properties.Resources._6_3; total_pontos += 6; break;
                case 33: A.Image = Properties.Resources._7_3; total_pontos += 7; break;
                case 34: A.Image = Properties.Resources._8_3; total_pontos += 8; break;
                case 35: A.Image = Properties.Resources._9_3; total_pontos += 9; break;
                case 36: A.Image = Properties.Resources._10_3; total_pontos += 10; break;
                case 37: A.Image = Properties.Resources._10_C_1; total_pontos += 10; break;
                case 38: A.Image = Properties.Resources._10_C_2; total_pontos += 10; break;
                case 39: A.Image = Properties.Resources._10_C; total_pontos += 10; break;

                case 40: A.Image = Properties.Resources._1_4; total_pontos += 1; break;
                case 41: A.Image = Properties.Resources._2_4; total_pontos += 2; break;
                case 42: A.Image = Properties.Resources._3_4; total_pontos += 3; break;
                case 43: A.Image = Properties.Resources._4_4; total_pontos += 4; break;
                case 44: A.Image = Properties.Resources._5_4; total_pontos += 5; break;
                case 45: A.Image = Properties.Resources._6_4; total_pontos += 6; break;
                case 46: A.Image = Properties.Resources._7_4; total_pontos += 7; break;
                case 47: A.Image = Properties.Resources._8_4; total_pontos += 8; break;
                case 48: A.Image = Properties.Resources._9_4; total_pontos += 9; break;
                case 49: A.Image = Properties.Resources._10_4; total_pontos += 10; break;
                case 50: A.Image = Properties.Resources._10_E_1; total_pontos += 10; break;
                case 51: A.Image = Properties.Resources._10_E_2; total_pontos += 10; break;
                case 52: A.Image = Properties.Resources._10_E; total_pontos += 10; break;
            }

            if (jogador == 1)
                pontos_A += total_pontos;
            else
                pontos_B += total_pontos;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            

            Jogada(pictureBox1, 1);
           

            if(pontos_A <= 21)
            {   // JOGANDO
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                if(pontos_A == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_1.Enabled = false;
                    btn_reiniciar.Enabled = true;
                }
            }
            else
            {   // PARTIDA PERDIDA
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                //lbl_Resultado.Text = "PERDEU!!!! ";
                
                btn_jogar_1.Enabled = false;
                btn_parar_1.Enabled = false;

                btn_jogar_2.Enabled = true;
                btn_parar_2.Enabled = true;

                //btn_reiniciar.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pontos_A = 0;
            pontos_B = 0;
            btn_jogar_1.Enabled = true;
            btn_jogar_2.Enabled = false;
            btn_parar_1.Enabled = true;
            btn_parar_2.Enabled = false;

            btn_reiniciar.Enabled = false;
            lbl_Pontos_A.Text = "0";
            lbl_Pontos_B.Text = "0";
            lbl_Resultado.Text = "";

            pictureBox1.Image = Properties.Resources.VERSO;
            pictureBox2.Image = Properties.Resources.VERSO;

        }

        private void btn_jogar_2_Click(object sender, EventArgs e)
        {
            //  ESCOLHER AS CARTAS
            Jogada(pictureBox2, 2);

            if (pontos_B <= 21)
            {   // JOGANDO
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
                if (pontos_B == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_2.Enabled = false;
                    btn_reiniciar.Enabled = true;
                    resultado();
                }
            }
            else
            {   // PARTIDA PERDIDA
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
                //lbl_Resultado.Text = "PERDEU!!!! ";

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                resultado();
                btn_reiniciar.Enabled = true;
            }
        }

        private void btn_parar_1_Click(object sender, EventArgs e)
        {
            btn_jogar_1.Enabled = false;
            btn_parar_1.Enabled = false;
            btn_jogar_2.Enabled = true;
            btn_parar_2.Enabled = true;
        }

        private void btn_parar_2_Click(object sender, EventArgs e)
        {
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;
            btn_reiniciar.Enabled = true;
            resultado();
        }
    }



    /*
           int x;
           Random sorteio = new Random();
           x = sorteio.Next(1, 14);

           switch (x)
           {
               case 1: 
                   pictureBox1.Image = Properties.Resources.a;
                   pontos_A += 1;
                   break;
               case 2:
                   pictureBox1.Image = Properties.Resources._2;
                   pontos_A += 2;
                   break;
               case 3:
                   pictureBox1.Image = Properties.Resources._3;
                   pontos_A += 3;
                   break;
               case 4:
                   pictureBox1.Image = Properties.Resources._4;
                   pontos_A += 4;
                   break;
               case 5:
                   pictureBox1.Image = Properties.Resources._5;
                   pontos_A += 5;
                   break;
               case 6:
                   pictureBox1.Image = Properties.Resources._6;
                   pontos_A += 6;
                   break;
               case 7:
                   pictureBox1.Image = Properties.Resources._7;
                   pontos_A += 7;
                   break;
               case 8:
                   pictureBox1.Image = Properties.Resources._8;
                   pontos_A += 8;
                   break;
               case 9:
                   pictureBox1.Image = Properties.Resources._9;
                   pontos_A += 9;
                   break;
               case 10:
                   pictureBox1.Image = Properties.Resources._10;
                   pontos_A += 10;
                   break;
               case 11:
                   pictureBox1.Image = Properties.Resources.J;
                   pontos_A += 11;
                   break;
               case 12:
                   pictureBox1.Image = Properties.Resources.Q;
                   pontos_A += 12;
                   break;
               case 13:
                   pictureBox1.Image = Properties.Resources.K;
                   pontos_A += 13;
                   break;

           }

           */
}
