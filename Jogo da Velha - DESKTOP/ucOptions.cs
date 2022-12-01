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
    public partial class ucOptions : UserControl
    {
        public static ucOptions instance;
        public ucOptions()
        {
            InitializeComponent();
            instance = this;
        }

        private void ucOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnClaro_Click(object sender, EventArgs e)
        {

            Form1.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundlight;
            ucJogo.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.gamelight;
            ucOptions.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundlight;
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            Form1.instance.titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado1.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado2.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado3.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado4.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado5.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado6.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado7.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado8.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado9.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnEscuro_Click(object sender, EventArgs e)
        {

            Form1.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgrounddark;
            ucJogo.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.gamedark;
            ucOptions.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgrounddark;
            label2.ForeColor = System.Drawing.SystemColors.Control;
            Form1.instance.titulo.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado1.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado2.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado3.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado4.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado5.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado6.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado7.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado8.ForeColor = System.Drawing.SystemColors.Control;
            ucJogo.instance.quadrado9.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
           
            Form1.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundblue;
            ucJogo.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.gameblue;
            ucOptions.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundblue;
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            Form1.instance.titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado1.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado2.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado3.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado4.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado5.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado6.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado7.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado8.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado9.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnRosa_Click(object sender, EventArgs e)
        {

            Form1.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundred;
            ucJogo.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.gamered;
            ucOptions.instance.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundred;
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            Form1.instance.titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado1.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado2.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado3.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado4.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado5.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado6.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado7.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado8.ForeColor = System.Drawing.SystemColors.ControlText;
            ucJogo.instance.quadrado9.ForeColor = System.Drawing.SystemColors.ControlText;
        }

    }
}
