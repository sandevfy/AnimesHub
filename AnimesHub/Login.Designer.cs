namespace AnimesHub
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnlLogin = new Panel();
            picLoginPerfil = new PictureBox();
            btnLoginCadastrar = new Button();
            btnLoginEntrar = new Button();
            lblLoginEsqueceuSenha = new LinkLabel();
            txtUserSenha = new TextBox();
            txtUserLogin = new TextBox();
            label1 = new Label();
            pnlCadastrar = new Panel();
            lblJaPossuiConta = new LinkLabel();
            btnCadastrar = new Button();
            txtSenhaCadastro = new TextBox();
            txtEmailCadastro = new TextBox();
            txtUserCadastro = new TextBox();
            label4 = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoginPerfil).BeginInit();
            pnlCadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackgroundImage = (Image)resources.GetObject("pnlLogin.BackgroundImage");
            pnlLogin.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLogin.Controls.Add(picLoginPerfil);
            pnlLogin.Controls.Add(btnLoginCadastrar);
            pnlLogin.Controls.Add(btnLoginEntrar);
            pnlLogin.Controls.Add(lblLoginEsqueceuSenha);
            pnlLogin.Controls.Add(txtUserSenha);
            pnlLogin.Controls.Add(txtUserLogin);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(607, 395);
            pnlLogin.TabIndex = 0;
            // 
            // picLoginPerfil
            // 
            picLoginPerfil.BackgroundImage = (Image)resources.GetObject("picLoginPerfil.BackgroundImage");
            picLoginPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            picLoginPerfil.BorderStyle = BorderStyle.FixedSingle;
            picLoginPerfil.Location = new Point(152, 89);
            picLoginPerfil.Name = "picLoginPerfil";
            picLoginPerfil.Size = new Size(80, 80);
            picLoginPerfil.TabIndex = 9;
            picLoginPerfil.TabStop = false;
            // 
            // btnLoginCadastrar
            // 
            btnLoginCadastrar.BackColor = Color.MediumSlateBlue;
            btnLoginCadastrar.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnLoginCadastrar.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnLoginCadastrar.Location = new Point(139, 334);
            btnLoginCadastrar.Name = "btnLoginCadastrar";
            btnLoginCadastrar.Size = new Size(116, 31);
            btnLoginCadastrar.TabIndex = 7;
            btnLoginCadastrar.Text = "Criar Conta";
            btnLoginCadastrar.UseVisualStyleBackColor = false;
            btnLoginCadastrar.Click += btnLoginCadastrar_Click;
            // 
            // btnLoginEntrar
            // 
            btnLoginEntrar.BackColor = Color.MediumSlateBlue;
            btnLoginEntrar.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnLoginEntrar.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnLoginEntrar.Location = new Point(139, 278);
            btnLoginEntrar.Name = "btnLoginEntrar";
            btnLoginEntrar.Size = new Size(116, 40);
            btnLoginEntrar.TabIndex = 5;
            btnLoginEntrar.Text = "Entrar";
            btnLoginEntrar.UseVisualStyleBackColor = false;
            btnLoginEntrar.Click += btnLoginEntrar_Click;
            // 
            // lblLoginEsqueceuSenha
            // 
            lblLoginEsqueceuSenha.AutoSize = true;
            lblLoginEsqueceuSenha.BackColor = Color.Transparent;
            lblLoginEsqueceuSenha.Location = new Point(199, 250);
            lblLoginEsqueceuSenha.Name = "lblLoginEsqueceuSenha";
            lblLoginEsqueceuSenha.Size = new Size(105, 15);
            lblLoginEsqueceuSenha.TabIndex = 6;
            lblLoginEsqueceuSenha.TabStop = true;
            lblLoginEsqueceuSenha.Text = "Esqueceu a senha?";
            lblLoginEsqueceuSenha.LinkClicked += lblLoginEsqueceuSenha_LinkClicked;
            // 
            // txtUserSenha
            // 
            txtUserSenha.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserSenha.Location = new Point(96, 219);
            txtUserSenha.Name = "txtUserSenha";
            txtUserSenha.PlaceholderText = "Digite sua senha";
            txtUserSenha.Size = new Size(208, 25);
            txtUserSenha.TabIndex = 3;
            txtUserSenha.UseSystemPasswordChar = true;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserLogin.Location = new Point(96, 178);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.PlaceholderText = "Digite seu nome de usuario";
            txtUserLogin.Size = new Size(208, 25);
            txtUserLogin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(96, 32);
            label1.Name = "label1";
            label1.Size = new Size(189, 45);
            label1.TabIndex = 0;
            label1.Text = "Faça Login";
            // 
            // pnlCadastrar
            // 
            pnlCadastrar.BackColor = Color.Transparent;
            pnlCadastrar.BackgroundImage = (Image)resources.GetObject("pnlCadastrar.BackgroundImage");
            pnlCadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            pnlCadastrar.Controls.Add(lblJaPossuiConta);
            pnlCadastrar.Controls.Add(btnCadastrar);
            pnlCadastrar.Controls.Add(txtSenhaCadastro);
            pnlCadastrar.Controls.Add(txtEmailCadastro);
            pnlCadastrar.Controls.Add(txtUserCadastro);
            pnlCadastrar.Controls.Add(label4);
            pnlCadastrar.Dock = DockStyle.Fill;
            pnlCadastrar.Location = new Point(0, 0);
            pnlCadastrar.Name = "pnlCadastrar";
            pnlCadastrar.Size = new Size(607, 395);
            pnlCadastrar.TabIndex = 8;
            // 
            // lblJaPossuiConta
            // 
            lblJaPossuiConta.AutoSize = true;
            lblJaPossuiConta.BackColor = Color.Transparent;
            lblJaPossuiConta.Location = new Point(143, 281);
            lblJaPossuiConta.Name = "lblJaPossuiConta";
            lblJaPossuiConta.Size = new Size(126, 15);
            lblJaPossuiConta.TabIndex = 13;
            lblJaPossuiConta.TabStop = true;
            lblJaPossuiConta.Text = "Já possui conta? Entrar";
            lblJaPossuiConta.LinkClicked += lblJaPossuiConta_LinkClicked;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumSlateBlue;
            btnCadastrar.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            btnCadastrar.FlatAppearance.BorderSize = 3;
            btnCadastrar.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(143, 324);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(126, 40);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            txtSenhaCadastro.Location = new Point(107, 237);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "Senha";
            txtSenhaCadastro.Size = new Size(208, 25);
            txtSenhaCadastro.TabIndex = 11;
            txtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            txtEmailCadastro.Location = new Point(107, 185);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.PlaceholderText = "Email";
            txtEmailCadastro.Size = new Size(208, 25);
            txtEmailCadastro.TabIndex = 9;
            // 
            // txtUserCadastro
            // 
            txtUserCadastro.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            txtUserCadastro.Location = new Point(107, 123);
            txtUserCadastro.Name = "txtUserCadastro";
            txtUserCadastro.PlaceholderText = "Usuario";
            txtUserCadastro.Size = new Size(208, 25);
            txtUserCadastro.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 27.75F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(107, 32);
            label4.Name = "label4";
            label4.Size = new Size(179, 45);
            label4.TabIndex = 0;
            label4.Text = "Cadastrar";
            // 
            // Login
            // 
            AcceptButton = btnLoginEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(607, 395);
            Controls.Add(pnlLogin);
            Controls.Add(pnlCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLoginPerfil).EndInit();
            pnlCadastrar.ResumeLayout(false);
            pnlCadastrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label label1;
        private LinkLabel lblLoginEsqueceuSenha;
        private Button btnLoginEntrar;
        private TextBox txtUserSenha;
        private TextBox txtUserLogin;
        private Button btnLoginCadastrar;
        private Panel pnlCadastrar;
        private TextBox txtUserCadastro;
        private Label label4;
        private Button btnCadastrar;
        private TextBox txtSenhaCadastro;
        private TextBox txtEmailCadastro;
        private LinkLabel lblJaPossuiConta;
        private PictureBox picLoginPerfil;
    }
}
