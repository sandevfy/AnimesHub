namespace AnimesHub.Forms
{
    partial class FormPrincipal
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
            pnlConteudo = new Panel();
            btnUcHome = new Button();
            btnUcPerfil = new Button();
            panel1 = new Panel();
            btnSolicitarAnime = new Button();
            btnAdicionarAnimes = new Button();
            btnSairLogin = new Button();
            btnUcAcompanhando = new Button();
            btnAssistido = new Button();
            btnAssistir = new Button();
            btnAssistindo = new Button();
            button2 = new Button();
            lblNomeUsuarioLongado = new Label();
            picUserImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserImage).BeginInit();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.BorderStyle = BorderStyle.FixedSingle;
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(133, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(914, 739);
            pnlConteudo.TabIndex = 0;
            // 
            // btnUcHome
            // 
            btnUcHome.Location = new Point(12, 130);
            btnUcHome.Name = "btnUcHome";
            btnUcHome.Size = new Size(115, 23);
            btnUcHome.TabIndex = 1;
            btnUcHome.Text = "Home";
            btnUcHome.UseVisualStyleBackColor = true;
            btnUcHome.Click += btnUcHome_Click;
            // 
            // btnUcPerfil
            // 
            btnUcPerfil.Location = new Point(12, 159);
            btnUcPerfil.Name = "btnUcPerfil";
            btnUcPerfil.Size = new Size(115, 23);
            btnUcPerfil.TabIndex = 3;
            btnUcPerfil.Text = "Perfil";
            btnUcPerfil.UseVisualStyleBackColor = true;
            btnUcPerfil.Click += btnUcPerfil_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSolicitarAnime);
            panel1.Controls.Add(btnAdicionarAnimes);
            panel1.Controls.Add(btnSairLogin);
            panel1.Controls.Add(btnUcAcompanhando);
            panel1.Controls.Add(btnAssistido);
            panel1.Controls.Add(btnAssistir);
            panel1.Controls.Add(btnAssistindo);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblNomeUsuarioLongado);
            panel1.Controls.Add(btnUcPerfil);
            panel1.Controls.Add(btnUcHome);
            panel1.Controls.Add(picUserImage);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 739);
            panel1.TabIndex = 4;
            // 
            // btnSolicitarAnime
            // 
            btnSolicitarAnime.Location = new Point(12, 333);
            btnSolicitarAnime.Name = "btnSolicitarAnime";
            btnSolicitarAnime.Size = new Size(115, 23);
            btnSolicitarAnime.TabIndex = 12;
            btnSolicitarAnime.Text = "Solicitar";
            btnSolicitarAnime.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarAnimes
            // 
            btnAdicionarAnimes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdicionarAnimes.Location = new Point(12, 675);
            btnAdicionarAnimes.Name = "btnAdicionarAnimes";
            btnAdicionarAnimes.Size = new Size(115, 23);
            btnAdicionarAnimes.TabIndex = 11;
            btnAdicionarAnimes.Text = "Adicionar Animes";
            btnAdicionarAnimes.UseVisualStyleBackColor = true;
            btnAdicionarAnimes.Click += btnAdicionarAnimes_Click;
            // 
            // btnSairLogin
            // 
            btnSairLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSairLogin.Location = new Point(12, 704);
            btnSairLogin.Name = "btnSairLogin";
            btnSairLogin.Size = new Size(115, 23);
            btnSairLogin.TabIndex = 10;
            btnSairLogin.Text = "Sair";
            btnSairLogin.UseVisualStyleBackColor = true;
            btnSairLogin.Click += btnSairLogin_Click;
            // 
            // btnUcAcompanhando
            // 
            btnUcAcompanhando.Location = new Point(12, 217);
            btnUcAcompanhando.Name = "btnUcAcompanhando";
            btnUcAcompanhando.Size = new Size(115, 23);
            btnUcAcompanhando.TabIndex = 9;
            btnUcAcompanhando.Text = "Acompanhando";
            btnUcAcompanhando.UseVisualStyleBackColor = true;
            btnUcAcompanhando.Click += btnUcAcompanhando_Click;
            // 
            // btnAssistido
            // 
            btnAssistido.Location = new Point(12, 304);
            btnAssistido.Name = "btnAssistido";
            btnAssistido.Size = new Size(115, 23);
            btnAssistido.TabIndex = 8;
            btnAssistido.Text = "Assistido";
            btnAssistido.UseVisualStyleBackColor = true;
            btnAssistido.Click += btnAssistido_Click;
            // 
            // btnAssistir
            // 
            btnAssistir.Location = new Point(12, 275);
            btnAssistir.Name = "btnAssistir";
            btnAssistir.Size = new Size(115, 23);
            btnAssistir.TabIndex = 7;
            btnAssistir.Text = "Assistir";
            btnAssistir.UseVisualStyleBackColor = true;
            btnAssistir.Click += btnAssistir_Click;
            // 
            // btnAssistindo
            // 
            btnAssistindo.Location = new Point(12, 246);
            btnAssistindo.Name = "btnAssistindo";
            btnAssistindo.Size = new Size(115, 23);
            btnAssistindo.TabIndex = 6;
            btnAssistindo.Text = "Assistindo";
            btnAssistindo.UseVisualStyleBackColor = true;
            btnAssistindo.Click += btnAssistindo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 188);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 5;
            button2.Text = "Favoritos";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblNomeUsuarioLongado
            // 
            lblNomeUsuarioLongado.AutoSize = true;
            lblNomeUsuarioLongado.Font = new Font("Noto Sans JP", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeUsuarioLongado.Location = new Point(43, 96);
            lblNomeUsuarioLongado.Name = "lblNomeUsuarioLongado";
            lblNomeUsuarioLongado.Size = new Size(48, 19);
            lblNomeUsuarioLongado.TabIndex = 4;
            lblNomeUsuarioLongado.Text = "Nome";
            // 
            // picUserImage
            // 
            picUserImage.BackgroundImage = Properties.Resources.PerfilTeste;
            picUserImage.BackgroundImageLayout = ImageLayout.Stretch;
            picUserImage.BorderStyle = BorderStyle.FixedSingle;
            picUserImage.Location = new Point(28, 13);
            picUserImage.Name = "picUserImage";
            picUserImage.Size = new Size(80, 80);
            picUserImage.TabIndex = 0;
            picUserImage.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 739);
            Controls.Add(pnlConteudo);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animes Hub";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Button btnUcHome;
        private Button btnUcPerfil;
        private Panel panel1;
        private PictureBox picUserImage;
        private Panel panel2;
        private Button button2;
        private Label lblNomeUsuarioLongado;
        private Button btnAssistido;
        private Button btnAssistir;
        private Button btnAssistindo;
        private Button btnSairLogin;
        private Button btnUcAcompanhando;
        private Button btnSolicitarAnime;
        private Button btnAdicionarAnimes;
    }
}