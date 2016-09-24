using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PROJETO001
{
    public partial class Form1 : Form
    {
        private float media, mediacol, medialin; //Numero de pontos que calcula a média menor ou igual a 100
        private int total = 0, somacol, somalin; //calcula média das cores RGB dos pixels
        private readonly String httpDefault = "http://"; //default do início de entrada de url, para que o usuário não precise digitar na tela

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            Close();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            realizaFiltroPorCorDesejada(Color.White);
        }

        private void pictureBox1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            /// função que desenha uma linha média de ponto a ponto
            /// definida do ponto médio até o ponto 200,330
            Pen p = new Pen(Color.Blue);

            Point p1 = new Point(200, 330);
            Point p2 = new Point((int)mediacol, 330 - (int)medialin);

            e.Graphics.DrawLine(p, p1, p2);

        }

        private void FILTROR_Click(object sender, EventArgs e) {
            realizaFiltroPorCorDesejada(Color.Red);
        }

        private void FILTROG_Click(object sender, EventArgs e) {
            realizaFiltroPorCorDesejada(Color.Green);
        }

        private void FILTROB_Click(object sender, EventArgs e) {
            realizaFiltroPorCorDesejada(Color.Blue);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void iniciarCamera_Click(object sender, EventArgs e) {
            //pela variável vinda do ipCamera da tela, é feito uma soma com o httpDefault para ir para o caminho desejado
            webBrowser1.Navigate(httpDefault + ipCamera.Text);
        }

        private void transferirImagem_Click(object sender, EventArgs e) {
            ///função referente à transferencia da imagem da camera para o bloco do sistema
            ///podendo assim fazer os filtros requeridos pelo usuário
            
            //criação das imagens de transferencia
            Bitmap bmpScreenshot;
            Graphics gfxScreenshot;
            
            //tira um print da tela
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
            Screen.PrimaryScreen.Bounds.Height,  PixelFormat.Format32bppArgb);

            //após tirar o screenshot, cola a imagem no clipboard
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
            Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size,
            CopyPixelOperation.SourceCopy);
            Clipboard.SetImage(bmpScreenshot);
            pictureBox1.Image = Clipboard.GetImage();
        }

        private void ipCamera_TextChanged(object sender, EventArgs e)
        {

        }

        private void realizaFiltroPorCorDesejada(Color  cor) {
            //função de click no botão para que 
            //reseta todas as variáveis
            media = somacol = somalin = total = 0;
            // criação das variáveis para controle da imagem
            Bitmap b = new Bitmap(pictureBox1.Image);
            Color corpixel;

            /// Percorre a grid da imagem, fazendo com que a 
            /// média do RBG, caso sejá maior que 100 ele pinta de branco
            /// caso não pinta de preto
            for (int lin = 0; lin < 330; lin++)
            {
                for (int col = 0; col < 400; col++)
                {
                    corpixel = b.GetPixel(col, lin);
                    media = (corpixel.R + corpixel.G + corpixel.B) / 3;
                    if (media > 100)
                    {
                        b.SetPixel(col, lin, cor);
                        total++;
                        somacol += col;
                        somalin += lin;
                    }
                    else
                    {
                        b.SetPixel(col, lin, Color.Black);
                    }
                }
            }
            mediacol = somacol / total;
            medialin = somalin / total;

            pictureBox2.BackgroundImage = b;
        }

        private void btnTransImagem2_Click(object sender, EventArgs e)
        {
            Graphics g = webBrowser1.CreateGraphics();

            Bitmap bmp = new Bitmap(webBrowser1.Width, webBrowser1.Height);

            webBrowser1.DrawToBitmap(bmp, new Rectangle(0, 0, webBrowser1.Width, webBrowser1.Height));

            pictureBox1.Image = bmp;
        }
    }
}
