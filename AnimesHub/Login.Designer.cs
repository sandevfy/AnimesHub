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
            pnlLogin = new Panel();
            btnLoginCadastrar = new Button();
            btnLoginEntrar = new Button();
            lblLoginEsqueceuSenha = new LinkLabel();
            label3 = new Label();
            txtUserSenha = new TextBox();
            txtUserLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlCadastrar = new Panel();
            lblJaPossuiConta = new LinkLabel();
            btnCadastrar = new Button();
            txtSenhaCadastro = new TextBox();
            label9 = new Label();
            txtEmailCadastro = new TextBox();
            label7 = new Label();
            txtUserCadastro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            pnlLogin.SuspendLayout();
            pnlCadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnLoginCadastrar);
            pnlLogin.Controls.Add(btnLoginEntrar);
            pnlLogin.Controls.Add(lblLoginEsqueceuSenha);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(txtUserSenha);
            pnlLogin.Controls.Add(txtUserLogin);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(291, 395);
            pnlLogin.TabIndex = 0;
            // 
            // btnLoginCadastrar
            // 
            btnLoginCadastrar.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginCadastrar.Location = new Point(83, 336);
            btnLoginCadastrar.Name = "btnLoginCadastrar";
            btnLoginCadastrar.Size = new Size(116, 31);
            btnLoginCadastrar.TabIndex = 7;
            btnLoginCadastrar.Text = "Cadastrar";
            btnLoginCadastrar.UseVisualStyleBackColor = true;
            btnLoginCadastrar.Click += btnLoginCadastrar_Click;
            // 
            // btnLoginEntrar
            // 
            btnLoginEntrar.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEntrar.Location = new Point(83, 252);
            btnLoginEntrar.Name = "btnLoginEntrar";
            btnLoginEntrar.Size = new Size(116, 40);
            btnLoginEntrar.TabIndex = 5;
            btnLoginEntrar.Text = "Entrar";
            btnLoginEntrar.UseVisualStyleBackColor = true;
            btnLoginEntrar.Click += btnLoginEntrar_Click;
            // 
            // lblLoginEsqueceuSenha
            // 
            lblLoginEsqueceuSenha.AutoSize = true;
            lblLoginEsqueceuSenha.BackColor = Color.Transparent;
            lblLoginEsqueceuSenha.Location = new Point(88, 318);
            lblLoginEsqueceuSenha.Name = "lblLoginEsqueceuSenha";
            lblLoginEsqueceuSenha.Size = new Size(105, 15);
            lblLoginEsqueceuSenha.TabIndex = 6;
            lblLoginEsqueceuSenha.TabStop = true;
            lblLoginEsqueceuSenha.Text = "Esqueceu a senha?";
            lblLoginEsqueceuSenha.LinkClicked += lblLoginEsqueceuSenha_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label3.Location = new Point(44, 177);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // txtUserSenha
            // 
            txtUserSenha.Location = new Point(44, 203);
            txtUserSenha.Name = "txtUserSenha";
            txtUserSenha.PlaceholderText = "Digite sua senha";
            txtUserSenha.Size = new Size(208, 23);
            txtUserSenha.TabIndex = 3;
            txtUserSenha.UseSystemPasswordChar = true;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(44, 128);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.PlaceholderText = "Digite seu nome de usuario";
            txtUserLogin.Size = new Size(208, 23);
            txtUserLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 102);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // pnlCadastrar
            // 
            pnlCadastrar.Controls.Add(lblJaPossuiConta);
            pnlCadastrar.Controls.Add(btnCadastrar);
            pnlCadastrar.Controls.Add(txtSenhaCadastro);
            pnlCadastrar.Controls.Add(label9);
            pnlCadastrar.Controls.Add(txtEmailCadastro);
            pnlCadastrar.Controls.Add(label7);
            pnlCadastrar.Controls.Add(txtUserCadastro);
            pnlCadastrar.Controls.Add(label5);
            pnlCadastrar.Controls.Add(label4);
            pnlCadastrar.Dock = DockStyle.Fill;
            pnlCadastrar.Location = new Point(0, 0);
            pnlCadastrar.Name = "pnlCadastrar";
            pnlCadastrar.Size = new Size(291, 395);
            pnlCadastrar.TabIndex = 8;
            // 
            // lblJaPossuiConta
            // 
            lblJaPossuiConta.AutoSize = true;
            lblJaPossuiConta.BackColor = Color.Transparent;
            lblJaPossuiConta.Location = new Point(80, 260);
            lblJaPossuiConta.Name = "lblJaPossuiConta";
            lblJaPossuiConta.Size = new Size(126, 15);
            lblJaPossuiConta.TabIndex = 13;
            lblJaPossuiConta.TabStop = true;
            lblJaPossuiConta.Text = "Já possui conta? Entrar";
            lblJaPossuiConta.LinkClicked += lblJaPossuiConta_LinkClicked;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(83, 293);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(126, 40);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(44, 216);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.Size = new Size(208, 23);
            txtSenhaCadastro.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(44, 190);
            label9.Name = "label9";
            label9.Size = new Size(71, 23);
            label9.TabIndex = 10;
            label9.Text = "Senha:";
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Location = new Point(44, 164);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.Size = new Size(208, 23);
            txtEmailCadastro.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 138);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 8;
            label7.Text = "Email:";
            // 
            // txtUserCadastro
            // 
            txtUserCadastro.Location = new Point(44, 112);
            txtUserCadastro.Name = "txtUserCadastro";
            txtUserCadastro.Size = new Size(208, 23);
            txtUserCadastro.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 86);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 4;
            label5.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 27.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(53, 20);
            label4.Name = "label4";
            label4.Size = new Size(179, 45);
            label4.TabIndex = 0;
            label4.Text = "Cadastrar";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(291, 395);
            Controls.Add(pnlLogin);
            Controls.Add(pnlCadastrar);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlCadastrar.ResumeLayout(false);
            pnlCadastrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label label1;
        private LinkLabel lblLoginEsqueceuSenha;
        private Button btnLoginEntrar;
        private Label label3;
        private TextBox txtUserSenha;
        private TextBox txtUserLogin;
        private Label label2;
        private Button btnLoginCadastrar;
        private Panel pnlCadastrar;
        private TextBox txtUserCadastro;
        private Label label5;
        private Label label4;
        private Button btnCadastrar;
        private TextBox txtSenhaCadastro;
        private Label label9;
        private TextBox txtEmailCadastro;
        private Label label7;
        private LinkLabel lblJaPossuiConta;
    }
}
