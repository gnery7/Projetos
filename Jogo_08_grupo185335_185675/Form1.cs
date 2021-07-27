using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_08_grupo185335_185675
{
    public partial class Form_Jogo08 : Form
    {
        #region Varíaveis Globais
        int conterrado = 0, contcerto = 0, contForma = 1, acertos = 0, errados = 0, pixel;
        int circulo, triangulo, quadrado, retangulo;
        int circuloP, trianguloP, quadradoP, retanguloP;
        int tempo = 20;
        Random sorteio = new Random();
        #endregion

        public Form_Jogo08()
        {
            InitializeComponent();
        }

        #region Sortear imagem
        private void Form_Jogo08_Load(object sender, EventArgs e)
        {
            pixel = sorteio.Next(1, 21);
            Pixel(pixel);
        }
        #endregion

        #region Sobre
        private void btn_Autores_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Nomes:Geovanne Nery e Luiz Ricardo \nNumeros de Ra: 185335 e 185675 \nDisciplina: Programação Visual e Games", "Elaborado por: Geovanne Nery e Luiz Ricardo");
        }
        #endregion

        #region Fechar
        private void Form_Jogo08_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Encerrando o Aplicativo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
            else
            {
                MessageBox.Show("Obrigado por jogar !!!! \n Parabéns pela pontuação.", "Obrigado");
            }
        }

        #endregion

        #region Respostas das imagens
        private void Pixel(int pixel)
        {
            pictureBox1.Controls.Add(pcb_imagem);
            pcb_imagem.Location = new Point(13, 0);
            pcb_imagem.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\pixel" + pixel + ".png");
            pcb_imagem.BackColor = Color.Transparent;
            switch (pixel)
            {
                case 1:
                    circulo = 2;
                    triangulo = 3;
                    quadrado = 4;
                    retangulo = 5;
                    break;
                case 2:
                    circulo = 3;
                    triangulo = 3;
                    quadrado = 4;
                    retangulo = 7;
                    break;
                case 3:
                    circulo = 2;
                    triangulo = 1;
                    quadrado = 4;
                    retangulo = 9;
                    break;
                case 4:
                    circulo = 4;
                    triangulo = 3;
                    quadrado = 5;
                    retangulo = 4;
                    break;
                case 5:
                    circulo = 3;
                    triangulo = 3;
                    quadrado = 2;
                    retangulo = 5;
                    break;
                case 6:
                    circulo = 3;
                    triangulo = 3;
                    quadrado = 2;
                    retangulo = 5;
                    break;
                case 7:
                    circulo = 1;
                    triangulo = 2;
                    quadrado = 3;
                    retangulo = 6;
                    break;
                case 8:
                    circulo = 3;
                    triangulo = 5;
                    quadrado = 2;
                    retangulo = 7;
                    break;
                case 9:
                    circulo = 3;
                    triangulo = 3;
                    quadrado = 5;
                    retangulo = 6;
                    break;
                case 10:
                    circulo = 2;
                    triangulo = 2;
                    quadrado = 4;
                    retangulo = 7;
                    break;
                case 11:
                    circulo = 1;
                    triangulo = 4;
                    quadrado = 6;
                    retangulo = 7;
                    break;
                case 12:
                    circulo = 2;
                    triangulo = 3;
                    quadrado = 3;
                    retangulo = 7;
                    break;
                case 13:
                    circulo = 3;
                    triangulo = 1;
                    quadrado = 10;
                    retangulo = 7;
                    break;
                case 14:
                    circulo = 1;
                    triangulo = 1;
                    quadrado = 6;
                    retangulo = 8;
                    break;
                case 15:
                    circulo = 1;
                    triangulo = 1;
                    quadrado = 1;
                    retangulo = 2;
                    break;
                case 16:
                    circulo = 1;
                    triangulo = 3;
                    quadrado = 4;
                    retangulo = 8;
                    break;
                case 17:
                    circulo = 1;
                    triangulo = 5;
                    quadrado = 4;
                    retangulo = 7;
                    break;
                case 18:
                    circulo = 1;
                    triangulo = 3;
                    quadrado = 8;
                    retangulo = 10;
                    break;
                case 19:
                    circulo = 1;
                    triangulo = 5;
                    quadrado = 8;
                    retangulo = 9;
                    break;
                case 20:
                    circulo = 2;
                    triangulo = 2;
                    quadrado = 7;
                    retangulo = 9;
                    break;
            }
        }
        #endregion

        #region Botão Reniciar
        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            lbl_escolhacirculo.Text = "";
            lbl_escolhaquadrado.Text = "";
            lbl_escolharetangulo.Text = "";
            lbl_escolhatriangulo.Text = "";
            lbl_contcerto.Text = "";
            lbl_conterrado.Text = "";
            pixel = sorteio.Next(1, 21);
            Pixel(pixel);
            acertos = 0;
            contForma = 0;
            contcerto = 0;
            conterrado = 0;
            resetall();

        }
        #endregion

        #region Botoes
        private void btn_1_Click_1(object sender, EventArgs e)
        {            
            switch (contForma)
            {
                case 1:
                    circuloP = 1;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "1";
                    break;
                case 2:
                    trianguloP = 1;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "1";
                    break;
                case 3:
                    quadradoP = 1;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "1";
                    break;
                case 4:
                    retanguloP = 1;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "1";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        

        private void btn_2_Click(object sender, EventArgs e)
        {         
            switch (contForma)
            {
                case 1:
                    circuloP = 2;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "2";
                    break;
                case 2:
                    trianguloP = 2;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "2";
                    break;
                case 3:
                    quadradoP = 2;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "2";
                    break;
                case 4:
                    retanguloP = 2;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "2";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;              
            }
            contForma++;
        }
        
        private void btn_3_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 3;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "3";
                    break;
                case 2:
                    trianguloP = 3;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "3";
                    break;
                case 3:
                    quadradoP = 3;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "3";
                    break;
                case 4:
                    retanguloP = 3;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "3";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 4;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "4";
                    break;
                case 2:
                    trianguloP = 4;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "4";
                    break;
                case 3:
                    quadradoP = 4;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "4";
                    break;
                case 4:
                    retanguloP = 4;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "4";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 5;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "5";
                    break;
                case 2:
                    trianguloP = 5;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "5";
                    break;
                case 3:
                    quadradoP = 5;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "5";
                    break;
                case 4:
                    retanguloP = 5;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "5";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 6;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "6";
                    break;
                case 2:
                    trianguloP = 6;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "6";
                    break;
                case 3:
                    quadradoP = 6;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "6";
                    break;
                case 4:
                    retanguloP = 6;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "6";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 7;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "7";
                    break;
                case 2:
                    trianguloP = 7;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "7";
                    break;
                case 3:
                    quadradoP = 7;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "7";
                    break;
                case 4:
                    retanguloP = 7;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "7";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 8;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "8";
                    break;
                case 2:
                    trianguloP = 8;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "8";
                    break;
                case 3:
                    quadradoP = 8;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "8";
                    break;
                case 4:
                    retanguloP = 8;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "8";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 9;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "9";
                    break;
                case 2:
                    trianguloP = 9;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "9";
                    break;
                case 3:
                    quadradoP = 9;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "9";
                    break;
                case 4:
                    retanguloP = 9;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "9";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            switch (contForma)
            {
                case 1:
                    circuloP = 10;
                    if (circuloP == circulo)
                    {
                        acertos++;
                    }
                    lbl_escolhacirculo.Text = "10";
                    break;
                case 2:
                    trianguloP = 10;
                    if (trianguloP == triangulo)
                    {
                        acertos++;
                    }
                    lbl_escolhatriangulo.Text = "10";
                    break;
                case 3:
                    quadradoP = 10;
                    if (quadradoP == quadrado)
                    {
                        acertos++;
                    }
                    lbl_escolhaquadrado.Text = "10";
                    break;
                case 4:
                    retanguloP = 10;
                    if (retanguloP == retangulo)
                    {
                        acertos++;
                    }
                    lbl_escolharetangulo.Text = "10";

                    if (acertos == 4)
                    {
                        contcerto++;
                        lbl_contcerto.Text = Convert.ToString(contcerto);
                        
                    }
                    else
                    {
                        conterrado++;
                        lbl_conterrado.Text = Convert.ToString(conterrado);
                    }
                    resetall();
                    break;
            }
            contForma++;
        }
        #endregion

        #region Configuração do botão de som
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\AUDIOOOOOOOOO.wav");

            simpleSound.Play();
        }
        #endregion

        #region TIMER 1

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(tempo > 0)
            {
                tempo--;
                lbl_temporestante.Text = Convert.ToString(tempo);
                
            }
            else
            {
                timer1.Stop();
                conterrado++;
                lbl_conterrado.Text = Convert.ToString(conterrado);
                resetall();
            }
        }
        #endregion

        #region Reset

        private void resetall()
        {
            lbl_escolhacirculo.Text = "";
            lbl_escolhaquadrado.Text = "";
            lbl_escolharetangulo.Text = "";
            lbl_escolhatriangulo.Text = "";
            pixel = sorteio.Next(1, 21);
            Pixel(pixel);
            acertos = 0;
            contForma = 0;
            tempo = 20;
            lbl_temporestante.Text = Convert.ToString(tempo);
        }
        #endregion
    }
}

