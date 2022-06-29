namespace FestaDoFaustao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdade = new System.Windows.Forms.Label();
            this.nudIdade = new System.Windows.Forms.NumericUpDown();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDiaAtual = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pibFaustao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFaustao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(12, 74);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(149, 24);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Digite sua idade:";
            // 
            // nudIdade
            // 
            this.nudIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdade.Location = new System.Drawing.Point(16, 101);
            this.nudIdade.Name = "nudIdade";
            this.nudIdade.Size = new System.Drawing.Size(145, 29);
            this.nudIdade.TabIndex = 1;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(16, 136);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(145, 31);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Posso entrar?";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(16, 173);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 31);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDiaAtual
            // 
            this.lblDiaAtual.AutoSize = true;
            this.lblDiaAtual.Location = new System.Drawing.Point(13, 13);
            this.lblDiaAtual.Name = "lblDiaAtual";
            this.lblDiaAtual.Size = new System.Drawing.Size(35, 13);
            this.lblDiaAtual.TabIndex = 4;
            this.lblDiaAtual.Text = "label1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(187, 225);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(206, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Será que você pode entrar?";
            // 
            // pibFaustao
            // 
            this.pibFaustao.Image = global::FestaDoFaustao.Properties.Resources.f0;
            this.pibFaustao.Location = new System.Drawing.Point(191, 13);
            this.pibFaustao.Name = "pibFaustao";
            this.pibFaustao.Size = new System.Drawing.Size(200, 200);
            this.pibFaustao.TabIndex = 5;
            this.pibFaustao.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 268);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pibFaustao);
            this.Controls.Add(this.lblDiaAtual);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.nudIdade);
            this.Controls.Add(this.lblIdade);
            this.Name = "Form1";
            this.Text = "Festa do Faustão";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFaustao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.NumericUpDown nudIdade;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDiaAtual;
        private System.Windows.Forms.PictureBox pibFaustao;
        private System.Windows.Forms.Label lblResultado;
    }
}

