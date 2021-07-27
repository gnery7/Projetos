namespace Jogo_08_grupo185335_185675
{
    partial class Form_Jogo08
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jogo08));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_imagem = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_contcerto = new System.Windows.Forms.Label();
            this.lbl_conterrado = new System.Windows.Forms.Label();
            this.lbl_Errado = new System.Windows.Forms.Label();
            this.lbl_Certo = new System.Windows.Forms.Label();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.btn_Autores = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_escolharetangulo = new System.Windows.Forms.Label();
            this.lbl_escolhaquadrado = new System.Windows.Forms.Label();
            this.lbl_escolhatriangulo = new System.Windows.Forms.Label();
            this.lbl_escolhacirculo = new System.Windows.Forms.Label();
            this.pcb_retangulo = new System.Windows.Forms.PictureBox();
            this.pcb_quadrado = new System.Windows.Forms.PictureBox();
            this.pcb_triangulo = new System.Windows.Forms.PictureBox();
            this.pcb_circulo = new System.Windows.Forms.PictureBox();
            this.lbl_escolhas = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_temporestante = new System.Windows.Forms.Label();
            this.rTB_orientacoes = new System.Windows.Forms.RichTextBox();
            this.pcb_iconesom = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_retangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_quadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_triangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_circulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_iconesom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcb_iconesom);
            this.panel1.Controls.Add(this.rTB_orientacoes);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pcb_imagem
            // 
            this.pcb_imagem.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pcb_imagem, "pcb_imagem");
            this.pcb_imagem.Name = "pcb_imagem";
            this.pcb_imagem.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_contcerto);
            this.panel2.Controls.Add(this.lbl_conterrado);
            this.panel2.Controls.Add(this.lbl_Errado);
            this.panel2.Controls.Add(this.lbl_Certo);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_contcerto
            // 
            resources.ApplyResources(this.lbl_contcerto, "lbl_contcerto");
            this.lbl_contcerto.Name = "lbl_contcerto";
            // 
            // lbl_conterrado
            // 
            resources.ApplyResources(this.lbl_conterrado, "lbl_conterrado");
            this.lbl_conterrado.Name = "lbl_conterrado";
            // 
            // lbl_Errado
            // 
            resources.ApplyResources(this.lbl_Errado, "lbl_Errado");
            this.lbl_Errado.Name = "lbl_Errado";
            // 
            // lbl_Certo
            // 
            resources.ApplyResources(this.lbl_Certo, "lbl_Certo");
            this.lbl_Certo.Name = "lbl_Certo";
            // 
            // btn_Reiniciar
            // 
            resources.ApplyResources(this.btn_Reiniciar, "btn_Reiniciar");
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.UseVisualStyleBackColor = true;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // btn_Autores
            // 
            resources.ApplyResources(this.btn_Autores, "btn_Autores");
            this.btn_Autores.Name = "btn_Autores";
            this.btn_Autores.UseVisualStyleBackColor = true;
            this.btn_Autores.Click += new System.EventHandler(this.btn_Autores_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_escolharetangulo);
            this.panel3.Controls.Add(this.lbl_escolhaquadrado);
            this.panel3.Controls.Add(this.lbl_escolhatriangulo);
            this.panel3.Controls.Add(this.lbl_escolhacirculo);
            this.panel3.Controls.Add(this.pcb_retangulo);
            this.panel3.Controls.Add(this.pcb_quadrado);
            this.panel3.Controls.Add(this.pcb_triangulo);
            this.panel3.Controls.Add(this.pcb_circulo);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lbl_escolharetangulo
            // 
            resources.ApplyResources(this.lbl_escolharetangulo, "lbl_escolharetangulo");
            this.lbl_escolharetangulo.Name = "lbl_escolharetangulo";
            // 
            // lbl_escolhaquadrado
            // 
            resources.ApplyResources(this.lbl_escolhaquadrado, "lbl_escolhaquadrado");
            this.lbl_escolhaquadrado.Name = "lbl_escolhaquadrado";
            // 
            // lbl_escolhatriangulo
            // 
            resources.ApplyResources(this.lbl_escolhatriangulo, "lbl_escolhatriangulo");
            this.lbl_escolhatriangulo.Name = "lbl_escolhatriangulo";
            // 
            // lbl_escolhacirculo
            // 
            resources.ApplyResources(this.lbl_escolhacirculo, "lbl_escolhacirculo");
            this.lbl_escolhacirculo.Name = "lbl_escolhacirculo";
            // 
            // pcb_retangulo
            // 
            resources.ApplyResources(this.pcb_retangulo, "pcb_retangulo");
            this.pcb_retangulo.Name = "pcb_retangulo";
            this.pcb_retangulo.TabStop = false;
            // 
            // pcb_quadrado
            // 
            resources.ApplyResources(this.pcb_quadrado, "pcb_quadrado");
            this.pcb_quadrado.Name = "pcb_quadrado";
            this.pcb_quadrado.TabStop = false;
            // 
            // pcb_triangulo
            // 
            resources.ApplyResources(this.pcb_triangulo, "pcb_triangulo");
            this.pcb_triangulo.Name = "pcb_triangulo";
            this.pcb_triangulo.TabStop = false;
            // 
            // pcb_circulo
            // 
            resources.ApplyResources(this.pcb_circulo, "pcb_circulo");
            this.pcb_circulo.Name = "pcb_circulo";
            this.pcb_circulo.TabStop = false;
            // 
            // lbl_escolhas
            // 
            resources.ApplyResources(this.lbl_escolhas, "lbl_escolhas");
            this.lbl_escolhas.Name = "lbl_escolhas";
            // 
            // btn_1
            // 
            resources.ApplyResources(this.btn_1, "btn_1");
            this.btn_1.Name = "btn_1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click_1);
            // 
            // btn_2
            // 
            resources.ApplyResources(this.btn_2, "btn_2");
            this.btn_2.Name = "btn_2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            resources.ApplyResources(this.btn_3, "btn_3");
            this.btn_3.Name = "btn_3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            resources.ApplyResources(this.btn_4, "btn_4");
            this.btn_4.Name = "btn_4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            resources.ApplyResources(this.btn_5, "btn_5");
            this.btn_5.Name = "btn_5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            resources.ApplyResources(this.btn_6, "btn_6");
            this.btn_6.Name = "btn_6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            resources.ApplyResources(this.btn_7, "btn_7");
            this.btn_7.Name = "btn_7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            resources.ApplyResources(this.btn_8, "btn_8");
            this.btn_8.Name = "btn_8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            resources.ApplyResources(this.btn_9, "btn_9");
            this.btn_9.Name = "btn_9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_10
            // 
            resources.ApplyResources(this.btn_10, "btn_10");
            this.btn_10.Name = "btn_10";
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lbl_temporestante
            // 
            resources.ApplyResources(this.lbl_temporestante, "lbl_temporestante");
            this.lbl_temporestante.Name = "lbl_temporestante";
            // 
            // rTB_orientacoes
            // 
            this.rTB_orientacoes.BackColor = System.Drawing.Color.LightGreen;
            this.rTB_orientacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rTB_orientacoes, "rTB_orientacoes");
            this.rTB_orientacoes.Name = "rTB_orientacoes";
            // 
            // pcb_iconesom
            // 
            resources.ApplyResources(this.pcb_iconesom, "pcb_iconesom");
            this.pcb_iconesom.Name = "pcb_iconesom";
            this.pcb_iconesom.TabStop = false;
            this.pcb_iconesom.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form_Jogo08
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.lbl_temporestante);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lbl_escolhas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Autores);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcb_imagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Jogo08";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Jogo08_FormClosing);
            this.Load += new System.EventHandler(this.Form_Jogo08_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_retangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_quadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_triangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_circulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_iconesom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb_imagem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Errado;
        private System.Windows.Forms.Label lbl_Certo;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Button btn_Autores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcb_retangulo;
        private System.Windows.Forms.PictureBox pcb_quadrado;
        private System.Windows.Forms.PictureBox pcb_triangulo;
        private System.Windows.Forms.PictureBox pcb_circulo;
        private System.Windows.Forms.Label lbl_escolhas;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_escolharetangulo;
        private System.Windows.Forms.Label lbl_escolhaquadrado;
        private System.Windows.Forms.Label lbl_escolhatriangulo;
        private System.Windows.Forms.Label lbl_escolhacirculo;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_contcerto;
        private System.Windows.Forms.Label lbl_conterrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_temporestante;
        private System.Windows.Forms.RichTextBox rTB_orientacoes;
        private System.Windows.Forms.PictureBox pcb_iconesom;
    }
}

