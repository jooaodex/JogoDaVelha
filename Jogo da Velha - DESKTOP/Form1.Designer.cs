
namespace Jogo_da_Velha___DESKTOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOpt = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ucOptions1 = new Jogo_da_Velha___DESKTOP.ucOptions();
            this.ucJogo1 = new Jogo_da_Velha___DESKTOP.ucJogo();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(185, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 47);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOpt
            // 
            this.btnOpt.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnOpt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpt.Location = new System.Drawing.Point(185, 259);
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.Size = new System.Drawing.Size(119, 47);
            this.btnOpt.TabIndex = 6;
            this.btnOpt.Text = "Opções";
            this.btnOpt.UseVisualStyleBackColor = false;
            this.btnOpt.Click += new System.EventHandler(this.btnOpt_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJogar.Location = new System.Drawing.Point(185, 155);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(119, 47);
            this.btnJogar.TabIndex = 5;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(84, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 42);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Jogo da Velha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnVoltar2);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.ucOptions1);
            this.panel1.Controls.Add(this.ucJogo1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 488);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Jogo_da_Velha___DESKTOP.Properties.Resources.audioplaying;
            this.button1.Location = new System.Drawing.Point(-13, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 65);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnVoltar2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar2.Location = new System.Drawing.Point(195, 393);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(99, 40);
            this.btnVoltar2.TabIndex = 3;
            this.btnVoltar2.Text = "Voltar";
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(4, 356);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 40);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ucOptions1
            // 
            this.ucOptions1.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundlight;
            this.ucOptions1.Location = new System.Drawing.Point(0, 0);
            this.ucOptions1.Name = "ucOptions1";
            this.ucOptions1.Size = new System.Drawing.Size(494, 473);
            this.ucOptions1.TabIndex = 2;
            // 
            // ucJogo1
            // 
            this.ucJogo1.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.gamelight;
            this.ucJogo1.Location = new System.Drawing.Point(0, 1);
            this.ucJogo1.Name = "ucJogo1";
            this.ucJogo1.Size = new System.Drawing.Size(492, 487);
            this.ucJogo1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Jogo_da_Velha___DESKTOP.Properties.Resources.audiomuted1;
            this.button2.Location = new System.Drawing.Point(-13, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 65);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundlight;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOpt);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOpt;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private ucJogo ucJogo1;
        private System.Windows.Forms.Button btnVoltar;
        private ucOptions ucOptions1;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

