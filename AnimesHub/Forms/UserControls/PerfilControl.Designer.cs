namespace AnimesHub.Forms
{
    partial class PerfilControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilControl));
            btnSolicitarEditUser = new Button();
            btnBuscarEditUser = new Button();
            txtIdUserEditBuscar = new TextBox();
            label7 = new Label();
            pnlUserEditAdm = new Panel();
            btnLimparUsers = new Button();
            btnListarUsers = new Button();
            pnlPermissoes = new Panel();
            cmbRole = new ComboBox();
            label8 = new Label();
            btnExcluirUsuario = new Button();
            btnSalvarPerfil = new Button();
            label6 = new Label();
            txtSenhaUserEdit = new TextBox();
            label5 = new Label();
            txtEmailUserEdit = new TextBox();
            label4 = new Label();
            txtIdadeUserEdit = new TextBox();
            label3 = new Label();
            txtBoxUserEdit = new TextBox();
            txtNameUserEdit = new TextBox();
            label2 = new Label();
            button1 = new Button();
            picUserImage = new PictureBox();
            label1 = new Label();
            pnlPerfil = new Panel();
            pnlListarUsuarios = new Panel();
            dgvListarUsers = new DataGridView();
            panel1 = new Panel();
            pnlUserEditAdm.SuspendLayout();
            pnlPermissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserImage).BeginInit();
            pnlPerfil.SuspendLayout();
            pnlListarUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSolicitarEditUser
            // 
            btnSolicitarEditUser.Location = new Point(379, 162);
            btnSolicitarEditUser.Name = "btnSolicitarEditUser";
            btnSolicitarEditUser.Size = new Size(75, 23);
            btnSolicitarEditUser.TabIndex = 15;
            btnSolicitarEditUser.Text = "Solicitar";
            btnSolicitarEditUser.UseVisualStyleBackColor = true;
            btnSolicitarEditUser.Click += btnSolicitarEditUser_Click;
            // 
            // btnBuscarEditUser
            // 
            btnBuscarEditUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscarEditUser.Location = new Point(181, 19);
            btnBuscarEditUser.Name = "btnBuscarEditUser";
            btnBuscarEditUser.Size = new Size(83, 23);
            btnBuscarEditUser.TabIndex = 18;
            btnBuscarEditUser.Text = "Buscar";
            btnBuscarEditUser.UseVisualStyleBackColor = true;
            btnBuscarEditUser.Click += btnBuscarEditUser_Click;
            // 
            // txtIdUserEditBuscar
            // 
            txtIdUserEditBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtIdUserEditBuscar.Location = new Point(92, 20);
            txtIdUserEditBuscar.Name = "txtIdUserEditBuscar";
            txtIdUserEditBuscar.Size = new Size(83, 23);
            txtIdUserEditBuscar.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label7.Location = new Point(9, 20);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 16;
            label7.Text = "Usuario:";
            // 
            // pnlUserEditAdm
            // 
            pnlUserEditAdm.Controls.Add(btnLimparUsers);
            pnlUserEditAdm.Controls.Add(btnListarUsers);
            pnlUserEditAdm.Controls.Add(pnlPermissoes);
            pnlUserEditAdm.Controls.Add(btnExcluirUsuario);
            pnlUserEditAdm.Controls.Add(label7);
            pnlUserEditAdm.Controls.Add(txtIdUserEditBuscar);
            pnlUserEditAdm.Controls.Add(btnBuscarEditUser);
            pnlUserEditAdm.Dock = DockStyle.Bottom;
            pnlUserEditAdm.Location = new Point(0, 438);
            pnlUserEditAdm.Name = "pnlUserEditAdm";
            pnlUserEditAdm.Size = new Size(526, 320);
            pnlUserEditAdm.TabIndex = 14;
            // 
            // btnLimparUsers
            // 
            btnLimparUsers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimparUsers.Location = new Point(130, 48);
            btnLimparUsers.Name = "btnLimparUsers";
            btnLimparUsers.Size = new Size(115, 23);
            btnLimparUsers.TabIndex = 22;
            btnLimparUsers.Text = "Limpar Users";
            btnLimparUsers.UseVisualStyleBackColor = true;
            btnLimparUsers.Click += btnLimparUsers_Click;
            // 
            // btnListarUsers
            // 
            btnListarUsers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnListarUsers.Location = new Point(9, 49);
            btnListarUsers.Name = "btnListarUsers";
            btnListarUsers.Size = new Size(115, 23);
            btnListarUsers.TabIndex = 21;
            btnListarUsers.Text = "Listar Usuarios";
            btnListarUsers.UseVisualStyleBackColor = true;
            btnListarUsers.Click += btnListarUsers_Click;
            // 
            // pnlPermissoes
            // 
            pnlPermissoes.Controls.Add(cmbRole);
            pnlPermissoes.Controls.Add(label8);
            pnlPermissoes.Dock = DockStyle.Bottom;
            pnlPermissoes.Location = new Point(0, 258);
            pnlPermissoes.Name = "pnlPermissoes";
            pnlPermissoes.Size = new Size(526, 62);
            pnlPermissoes.TabIndex = 20;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(115, 21);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(96, 23);
            cmbRole.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label8.Location = new Point(9, 21);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 16;
            label8.Text = "User Role:";
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluirUsuario.Location = new Point(411, 229);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(115, 23);
            btnExcluirUsuario.TabIndex = 19;
            btnExcluirUsuario.Text = "Excluir Usuario";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnSalvarPerfil
            // 
            btnSalvarPerfil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalvarPerfil.Location = new Point(268, 320);
            btnSalvarPerfil.Name = "btnSalvarPerfil";
            btnSalvarPerfil.Size = new Size(105, 36);
            btnSalvarPerfil.TabIndex = 13;
            btnSalvarPerfil.Text = "Salvar Perfil";
            btnSalvarPerfil.UseVisualStyleBackColor = true;
            btnSalvarPerfil.Click += btnSalvarPerfil_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label6.Location = new Point(46, 249);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 11;
            label6.Text = "Senha:";
            // 
            // txtSenhaUserEdit
            // 
            txtSenhaUserEdit.Location = new Point(141, 249);
            txtSenhaUserEdit.Name = "txtSenhaUserEdit";
            txtSenhaUserEdit.Size = new Size(232, 23);
            txtSenhaUserEdit.TabIndex = 12;
            txtSenhaUserEdit.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label5.Location = new Point(46, 220);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 9;
            label5.Text = "Email:";
            // 
            // txtEmailUserEdit
            // 
            txtEmailUserEdit.Location = new Point(141, 220);
            txtEmailUserEdit.Name = "txtEmailUserEdit";
            txtEmailUserEdit.Size = new Size(232, 23);
            txtEmailUserEdit.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label4.Location = new Point(46, 191);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 7;
            label4.Text = "Idade:";
            // 
            // txtIdadeUserEdit
            // 
            txtIdadeUserEdit.Location = new Point(141, 191);
            txtIdadeUserEdit.Name = "txtIdadeUserEdit";
            txtIdadeUserEdit.Size = new Size(232, 23);
            txtIdadeUserEdit.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label3.Location = new Point(46, 162);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 5;
            label3.Text = "Usuario:";
            // 
            // txtBoxUserEdit
            // 
            txtBoxUserEdit.Location = new Point(141, 162);
            txtBoxUserEdit.Name = "txtBoxUserEdit";
            txtBoxUserEdit.Size = new Size(232, 23);
            txtBoxUserEdit.TabIndex = 6;
            // 
            // txtNameUserEdit
            // 
            txtNameUserEdit.Location = new Point(141, 133);
            txtNameUserEdit.Name = "txtNameUserEdit";
            txtNameUserEdit.PlaceholderText = "Guest";
            txtNameUserEdit.Size = new Size(232, 23);
            txtNameUserEdit.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 133);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // button1
            // 
            button1.Location = new Point(148, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Editar foto";
            button1.UseVisualStyleBackColor = true;
            // 
            // picUserImage
            // 
            picUserImage.BackgroundImage = (Image)resources.GetObject("picUserImage.BackgroundImage");
            picUserImage.BackgroundImageLayout = ImageLayout.Stretch;
            picUserImage.BorderStyle = BorderStyle.FixedSingle;
            picUserImage.Location = new Point(46, 30);
            picUserImage.Name = "picUserImage";
            picUserImage.Size = new Size(80, 80);
            picUserImage.TabIndex = 1;
            picUserImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label1.Location = new Point(148, 20);
            label1.Name = "label1";
            label1.Size = new Size(202, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome do usuario aqui";
            // 
            // pnlPerfil
            // 
            pnlPerfil.Controls.Add(btnSolicitarEditUser);
            pnlPerfil.Controls.Add(btnSalvarPerfil);
            pnlPerfil.Controls.Add(txtSenhaUserEdit);
            pnlPerfil.Controls.Add(label6);
            pnlPerfil.Controls.Add(txtEmailUserEdit);
            pnlPerfil.Controls.Add(label5);
            pnlPerfil.Controls.Add(txtIdadeUserEdit);
            pnlPerfil.Controls.Add(label4);
            pnlPerfil.Controls.Add(txtBoxUserEdit);
            pnlPerfil.Controls.Add(label3);
            pnlPerfil.Controls.Add(txtNameUserEdit);
            pnlPerfil.Controls.Add(label2);
            pnlPerfil.Controls.Add(button1);
            pnlPerfil.Controls.Add(picUserImage);
            pnlPerfil.Controls.Add(label1);
            pnlPerfil.Dock = DockStyle.Top;
            pnlPerfil.Location = new Point(0, 0);
            pnlPerfil.Name = "pnlPerfil";
            pnlPerfil.Size = new Size(526, 438);
            pnlPerfil.TabIndex = 16;
            // 
            // pnlListarUsuarios
            // 
            pnlListarUsuarios.Controls.Add(dgvListarUsers);
            pnlListarUsuarios.Dock = DockStyle.Fill;
            pnlListarUsuarios.Location = new Point(526, 0);
            pnlListarUsuarios.Name = "pnlListarUsuarios";
            pnlListarUsuarios.Size = new Size(627, 758);
            pnlListarUsuarios.TabIndex = 17;
            // 
            // dgvListarUsers
            // 
            dgvListarUsers.BackgroundColor = SystemColors.Control;
            dgvListarUsers.BorderStyle = BorderStyle.None;
            dgvListarUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarUsers.Dock = DockStyle.Fill;
            dgvListarUsers.Location = new Point(0, 0);
            dgvListarUsers.Name = "dgvListarUsers";
            dgvListarUsers.Size = new Size(627, 758);
            dgvListarUsers.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlUserEditAdm);
            panel1.Controls.Add(pnlPerfil);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 758);
            panel1.TabIndex = 1;
            // 
            // PerfilControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pnlListarUsuarios);
            Controls.Add(panel1);
            Name = "PerfilControl";
            Size = new Size(1153, 758);
            Load += PerfilControl_Load;
            pnlUserEditAdm.ResumeLayout(false);
            pnlUserEditAdm.PerformLayout();
            pnlPermissoes.ResumeLayout(false);
            pnlPermissoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserImage).EndInit();
            pnlPerfil.ResumeLayout(false);
            pnlPerfil.PerformLayout();
            pnlListarUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarUsers).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSolicitarEditUser;
        private Button btnBuscarEditUser;
        private TextBox txtIdUserEditBuscar;
        private Label label7;
        private Panel pnlUserEditAdm;
        private Button btnSalvarPerfil;
        private Label label6;
        private TextBox txtSenhaUserEdit;
        private Label label5;
        private TextBox txtEmailUserEdit;
        private Label label4;
        private TextBox txtIdadeUserEdit;
        private Label label3;
        private TextBox txtBoxUserEdit;
        private TextBox txtNameUserEdit;
        private Label label2;
        private Button button1;
        private PictureBox picUserImage;
        private Label label1;
        private Button btnExcluirUsuario;
        private Label label8;
        private Panel pnlPermissoes;
        private ComboBox cmbRole;
        private Panel pnlPerfil;
        private Panel pnlListarUsuarios;
        private DataGridView dgvListarUsers;
        private Button btnListarUsers;
        private Button btnLimparUsers;
        private Panel panel1;
    }
}
