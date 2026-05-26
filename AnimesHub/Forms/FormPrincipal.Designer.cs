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
            btnSairLogin = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            lblNomeUsuarioLongado = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnAdicionarAnimes = new Button();
            btnSolicitarAnime = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnUcHome.Location = new Point(12, 117);
            btnUcHome.Name = "btnUcHome";
            btnUcHome.Size = new Size(115, 23);
            btnUcHome.TabIndex = 1;
            btnUcHome.Text = "Home";
            btnUcHome.UseVisualStyleBackColor = true;
            btnUcHome.Click += btnUcHome_Click;
            // 
            // btnUcPerfil
            // 
            btnUcPerfil.Location = new Point(12, 146);
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
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblNomeUsuarioLongado);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUcPerfil);
            panel1.Controls.Add(btnUcHome);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 739);
            panel1.TabIndex = 4;
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
            // button7
            // 
            button7.Location = new Point(12, 204);
            button7.Name = "button7";
            button7.Size = new Size(115, 23);
            button7.TabIndex = 9;
            button7.Text = "Acompanhando";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 291);
            button6.Name = "button6";
            button6.Size = new Size(115, 23);
            button6.TabIndex = 8;
            button6.Text = "Assistido";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 262);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 7;
            button5.Text = "Assistir";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 233);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 6;
            button4.Text = "Assistindo";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 175);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 5;
            button2.Text = "Favoritos";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblNomeUsuarioLongado
            // 
            lblNomeUsuarioLongado.AutoSize = true;
            lblNomeUsuarioLongado.Location = new Point(44, 81);
            lblNomeUsuarioLongado.Name = "lblNomeUsuarioLongado";
            lblNomeUsuarioLongado.Size = new Size(40, 15);
            lblNomeUsuarioLongado.TabIndex = 4;
            lblNomeUsuarioLongado.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 66);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(31, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAdicionarAnimes
            // 
            btnAdicionarAnimes.Location = new Point(12, 675);
            btnAdicionarAnimes.Name = "btnAdicionarAnimes";
            btnAdicionarAnimes.Size = new Size(115, 23);
            btnAdicionarAnimes.TabIndex = 11;
            btnAdicionarAnimes.Text = "Adicionar Animes";
            btnAdicionarAnimes.UseVisualStyleBackColor = true;
            // 
            // btnSolicitarAnime
            // 
            btnSolicitarAnime.Location = new Point(12, 320);
            btnSolicitarAnime.Name = "btnSolicitarAnime";
            btnSolicitarAnime.Size = new Size(115, 23);
            btnSolicitarAnime.TabIndex = 12;
            btnSolicitarAnime.Text = "Solicitar";
            btnSolicitarAnime.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Button btnUcHome;
        private Button btnUcPerfil;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Label lblNomeUsuarioLongado;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button btnSairLogin;
        private Button button7;
        private Button btnSolicitarAnime;
        private Button btnAdicionarAnimes;
    }
}