using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_da_Velha___DESKTOP
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Label titulo;
        public Form1()
        {
            InitializeComponent();
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Music1);
            soundPlayer.PlayLooping();
            instance = this;
            titulo = lblTitulo;
            button2.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucJogo1.Hide();
            ucOptions1.Hide();
            btnVoltar.Hide();
            btnVoltar2.Hide();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            lblTitulo.Hide();
            btnJogar.Hide();
            btnOpt.Hide();
            btnSair.Hide();
            ucJogo1.Show();
            ucJogo1.BringToFront();
            btnVoltar.Show();
            btnVoltar.BringToFront();

        }

        private void btnOpt_Click(object sender, EventArgs e)
        {
            lblTitulo.Hide();
            btnJogar.Hide();
            btnOpt.Hide();
            btnSair.Hide();
            ucOptions1.Show();
            ucOptions1.BringToFront();
            btnVoltar2.Show();
            btnVoltar2.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ucJogo1.Hide();
            ucOptions1.Hide();
            btnVoltar.Hide();
            lblTitulo.Show();
            btnJogar.Show();
            btnOpt.Show();
            btnSair.Show();
            
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            ucJogo1.Hide();
            ucOptions1.Hide();
            btnVoltar2.Hide();
            lblTitulo.Show();
            btnJogar.Show();
            btnOpt.Show();
            btnSair.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Music1);
            soundPlayer.Stop();
            button1.Hide();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Music1);
            soundPlayer.PlayLooping();
            button1.Show();
            button2.Hide();
        }
    }
}
