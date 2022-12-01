using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha___DESKTOP
{
    public partial class ucJogo : UserControl
    {
        public static ucJogo instance;
        public Button quadrado1;
        public Button quadrado2;
        public Button quadrado3;
        public Button quadrado4;
        public Button quadrado5;
        public Button quadrado6;
        public Button quadrado7;
        public Button quadrado8;
        public Button quadrado9;

        int Xplayer = 0, Oplayer = 0, empatesPontos = 0, rodadas = 0;
        bool turno = true, jogofinal = false;
        string[] texto = new string[9];
        public ucJogo()
        {
            InitializeComponent();
            instance = this;

            quadrado1 = btn;
            quadrado2 = button1;
            quadrado3 = button2;
            quadrado4 = button3;
            quadrado5 = button4;
            quadrado6 = button5;
            quadrado7 = button6;
            quadrado8 = button7;
            quadrado9 = button8;
        }

        private void btnClean_Click(object sender, EventArgs e)     // Recomeçar
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            rodadas = 0;
            jogofinal = false;
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }

        private void Xpontos_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogofinal == false)

                if (turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
        }

        void Vencedor(int PlayerVencedor)
        {
            jogofinal = true;

            if (PlayerVencedor == 1)
            {
                Xplayer++;
                Xpontos.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Vitória do jogador 1");
                turno = true;
            }
            else
            {
                Oplayer++;
                OPontos.Text = Convert.ToString(Oplayer);
                MessageBox.Show("Vitória do jogador 2");
                turno = false;
            }
        }



        void Checagem(int ChecagemPlayer)
        {
            string suporte;

            if (ChecagemPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            } // Fínal do suporte

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        Vencedor(ChecagemPlayer);
                        return;

                    } // Final checagem horizontal
                }
            } // Final loop horizontal
            // Checagem vertical:
            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(ChecagemPlayer);
                        return;

                    } // Final checagem vertical
                }
            } // Final loop vertical

            //verificações diagonais:

            if (texto[0] == suporte)
            {


                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                } // Diagonal principal


            }

            if (texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                } // Diagonal secundária
            }


            if (rodadas == 9 && jogofinal == false)
            {
                empatesPontos++;
                empates.Text = Convert.ToString(empatesPontos);
                MessageBox.Show("Empate!");
                jogofinal = true;
                return;
            }
        }
    }
}
