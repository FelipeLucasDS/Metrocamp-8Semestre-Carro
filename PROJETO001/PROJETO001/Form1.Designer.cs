namespace PROJETO001
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FILTROR = new System.Windows.Forms.Button();
            this.FILTROB = new System.Windows.Forms.Button();
            this.FILTROG = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ipCamera = new System.Windows.Forms.TextBox();
            this.iniciarCamera = new System.Windows.Forms.Button();
            this.transferirImagem = new System.Windows.Forms.Button();
            this.btnTransImagem2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(1175, 396);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.ForeColor = System.Drawing.Color.Blue;
            this.btnImagem.Location = new System.Drawing.Point(431, 396);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(75, 23);
            this.btnImagem.TabIndex = 2;
            this.btnImagem.Text = "IMAGEM";
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJETO001.Properties.Resources.FOTOEXEMPLOTESTE001;
            this.pictureBox1.Location = new System.Drawing.Point(431, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 330);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragOver);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(850, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 330);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // FILTROR
            // 
            this.FILTROR.ForeColor = System.Drawing.Color.Blue;
            this.FILTROR.Location = new System.Drawing.Point(512, 396);
            this.FILTROR.Name = "FILTROR";
            this.FILTROR.Size = new System.Drawing.Size(75, 23);
            this.FILTROR.TabIndex = 4;
            this.FILTROR.Text = "FILTRO R";
            this.FILTROR.UseVisualStyleBackColor = true;
            this.FILTROR.Click += new System.EventHandler(this.FILTROR_Click);
            // 
            // FILTROB
            // 
            this.FILTROB.ForeColor = System.Drawing.Color.Blue;
            this.FILTROB.Location = new System.Drawing.Point(674, 396);
            this.FILTROB.Name = "FILTROB";
            this.FILTROB.Size = new System.Drawing.Size(75, 23);
            this.FILTROB.TabIndex = 5;
            this.FILTROB.Text = "FILTRO B";
            this.FILTROB.UseVisualStyleBackColor = true;
            this.FILTROB.Click += new System.EventHandler(this.FILTROB_Click);
            // 
            // FILTROG
            // 
            this.FILTROG.ForeColor = System.Drawing.Color.Blue;
            this.FILTROG.Location = new System.Drawing.Point(593, 396);
            this.FILTROG.Name = "FILTROG";
            this.FILTROG.Size = new System.Drawing.Size(75, 23);
            this.FILTROG.TabIndex = 6;
            this.FILTROG.Text = "FILTRO G";
            this.FILTROG.UseVisualStyleBackColor = true;
            this.FILTROG.Click += new System.EventHandler(this.FILTROG_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(782, 396);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(122, 23);
            this.hScrollBar1.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 60);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(400, 330);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("http://www.msn.com/pt-br/?ocid=iehp", System.UriKind.Absolute);
            // 
            // ipCamera
            // 
            this.ipCamera.Location = new System.Drawing.Point(12, 31);
            this.ipCamera.Name = "ipCamera";
            this.ipCamera.Size = new System.Drawing.Size(156, 20);
            this.ipCamera.TabIndex = 10;
            this.ipCamera.TextChanged += new System.EventHandler(this.ipCamera_TextChanged);
            // 
            // iniciarCamera
            // 
            this.iniciarCamera.Location = new System.Drawing.Point(12, 397);
            this.iniciarCamera.Name = "iniciarCamera";
            this.iniciarCamera.Size = new System.Drawing.Size(156, 23);
            this.iniciarCamera.TabIndex = 11;
            this.iniciarCamera.Text = "Iniciar Camera";
            this.iniciarCamera.UseVisualStyleBackColor = true;
            this.iniciarCamera.Click += new System.EventHandler(this.iniciarCamera_Click);
            // 
            // transferirImagem
            // 
            this.transferirImagem.Location = new System.Drawing.Point(175, 397);
            this.transferirImagem.Name = "transferirImagem";
            this.transferirImagem.Size = new System.Drawing.Size(112, 23);
            this.transferirImagem.TabIndex = 12;
            this.transferirImagem.Text = "Transferir Imagem";
            this.transferirImagem.UseVisualStyleBackColor = true;
            this.transferirImagem.Click += new System.EventHandler(this.transferirImagem_Click);
            // 
            // btnTransImagem2
            // 
            this.btnTransImagem2.Location = new System.Drawing.Point(294, 397);
            this.btnTransImagem2.Name = "btnTransImagem2";
            this.btnTransImagem2.Size = new System.Drawing.Size(111, 23);
            this.btnTransImagem2.TabIndex = 13;
            this.btnTransImagem2.Text = "Transferir Imagem 2";
            this.btnTransImagem2.UseVisualStyleBackColor = true;
            this.btnTransImagem2.Click += new System.EventHandler(this.btnTransImagem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 432);
            this.Controls.Add(this.btnTransImagem2);
            this.Controls.Add(this.transferirImagem);
            this.Controls.Add(this.iniciarCamera);
            this.Controls.Add(this.ipCamera);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.FILTROG);
            this.Controls.Add(this.FILTROB);
            this.Controls.Add(this.FILTROR);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Name = "Form1";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button FILTROR;
        private System.Windows.Forms.Button FILTROB;
        private System.Windows.Forms.Button FILTROG;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox ipCamera;
        private System.Windows.Forms.Button iniciarCamera;
        private System.Windows.Forms.Button transferirImagem;
        private System.Windows.Forms.Button btnTransImagem2;
    }
}

