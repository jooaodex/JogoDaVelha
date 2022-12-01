
namespace Jogo_da_Velha___DESKTOP
{
    partial class ucOptions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnClaro = new System.Windows.Forms.Button();
            this.btnEscuro = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temas";
            // 
            // btnClaro
            // 
            this.btnClaro.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnClaro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClaro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClaro.Location = new System.Drawing.Point(87, 127);
            this.btnClaro.Name = "btnClaro";
            this.btnClaro.Size = new System.Drawing.Size(125, 50);
            this.btnClaro.TabIndex = 8;
            this.btnClaro.Text = "Claro";
            this.btnClaro.UseVisualStyleBackColor = false;
            this.btnClaro.Click += new System.EventHandler(this.btnClaro_Click);
            // 
            // btnEscuro
            // 
            this.btnEscuro.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnEscuro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEscuro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEscuro.Location = new System.Drawing.Point(282, 127);
            this.btnEscuro.Name = "btnEscuro";
            this.btnEscuro.Size = new System.Drawing.Size(125, 50);
            this.btnEscuro.TabIndex = 9;
            this.btnEscuro.Text = "Escuro";
            this.btnEscuro.UseVisualStyleBackColor = false;
            this.btnEscuro.Click += new System.EventHandler(this.btnEscuro_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAzul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAzul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAzul.Location = new System.Drawing.Point(87, 212);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(125, 50);
            this.btnAzul.TabIndex = 10;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnRosa
            // 
            this.btnRosa.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnRosa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRosa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRosa.Location = new System.Drawing.Point(282, 212);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(125, 50);
            this.btnRosa.TabIndex = 11;
            this.btnRosa.Text = "Vermelho";
            this.btnRosa.UseVisualStyleBackColor = false;
            this.btnRosa.Click += new System.EventHandler(this.btnRosa_Click);
            // 
            // ucOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Velha___DESKTOP.Properties.Resources.backgroundlight;
            this.Controls.Add(this.btnRosa);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnEscuro);
            this.Controls.Add(this.btnClaro);
            this.Controls.Add(this.label2);
            this.Name = "ucOptions";
            this.Size = new System.Drawing.Size(494, 474);
            this.Load += new System.EventHandler(this.ucOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClaro;
        private System.Windows.Forms.Button btnEscuro;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnRosa;
    }
}
