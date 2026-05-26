using AnimesHub.Data;
using AnimesHub.Enums;
using AnimesHub.Models;

namespace AnimesHub.Forms
{
    public partial class PerfilControl : UserControl
    {
        private Usuario _usuarioLongado;

        public PerfilControl(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLongado = usuario;
        }
        private void PermissaoChecked()
        {
            bool isAdmin = _usuarioLongado.Role == Enums.UserRole.Admin;
            bool isMod = _usuarioLongado.Role == Enums.UserRole.Mod;

            txtBoxUserEdit.Enabled = isAdmin || isMod;
            pnlUserEditAdm.Visible = isAdmin || isMod;

            pnlPermissoes.Visible = isAdmin;

        }

        private void PerfilControl_Load(object sender, EventArgs e)
        {
            PermissaoChecked();
            LoadUserPerfil();

            cmbRole.DataSource = Enum.GetValues<UserRole>();
        }
        private void LoadUserPerfilAdm()
        {
            using var db = new AppDbContext();
            if (!int.TryParse(txtIdUserEditBuscar.Text, out int id))
            {
                MessageBox.Show("Digite um Id valido!");
                return;
            }

            var usuario = db.Usuarios.Find(id);

            if (usuario != null)
            {
                txtNameUserEdit.Text = usuario.Name ?? "guest";
                txtBoxUserEdit.Text = usuario.UserLogin;
                txtIdadeUserEdit.Text = usuario.Age?.ToString() ?? "";
                txtEmailUserEdit.Text = usuario.Email;
                txtSenhaUserEdit.Text = usuario.Password;
                cmbRole.SelectedItem = usuario.Role;
            }
            else
            {
                MessageBox.Show("Usuario Não Encontrado.");
                ClearFields();
            }

        }
        private void LoadUserPerfil()
        {
            txtIdUserEditBuscar.Text = _usuarioLongado.Id.ToString();
            txtNameUserEdit.Text = _usuarioLongado.Name ?? "guest";
            txtBoxUserEdit.Text = _usuarioLongado.UserLogin;
            txtIdadeUserEdit.Text = _usuarioLongado.Age?.ToString() ?? "";
            txtEmailUserEdit.Text = _usuarioLongado.Email;
            txtSenhaUserEdit.Text = _usuarioLongado.Password;
            cmbRole.SelectedItem = _usuarioLongado.Role;
        }

        private void ClearFields()
        {
            txtNameUserEdit.Clear();
            txtBoxUserEdit.Clear();
            txtIdadeUserEdit.Clear();
            txtEmailUserEdit.Clear();
            txtSenhaUserEdit.Clear();
            cmbRole.SelectedItem = -1;
        }
        private void btnSolicitarEditUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitação disponivel em breve");
        }

        private void btnSalvarPerfil_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            if (!int.TryParse(txtIdUserEditBuscar.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            var usuario = db.Usuarios.Find(id);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }
            if (!int.TryParse(txtIdadeUserEdit.Text, out int idade))
            {
                MessageBox.Show("Digite uma idade válida.");
                return;
            }
            usuario.Name = txtNameUserEdit.Text;
            usuario.UserLogin = txtBoxUserEdit.Text;
            usuario.Age = idade;
            usuario.Email = txtEmailUserEdit.Text;
            usuario.Password = txtSenhaUserEdit.Text;

            if (_usuarioLongado.Role == UserRole.Admin)
            {
                if (cmbRole.SelectedItem != null)
                {
                    usuario.Role = (UserRole)cmbRole.SelectedItem;
                }
            }

            db.SaveChanges();

            MessageBox.Show(
                    "Usuario Atualizado." +
                    Environment.NewLine +
                    "Saia para atualizar os Dados.");
        }

        private void btnBuscarEditUser_Click(object sender, EventArgs e)
        {
            LoadUserPerfilAdm();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            if (!int.TryParse(txtIdUserEditBuscar.Text, out int id))
            {
                MessageBox.Show("Digite um Id valido!");
                return;
            }

            var usuario = db.Usuarios.Find(id);

            if (usuario == null)
            {
                MessageBox.Show("Usuario Nao Encontrado!");
                return;
            }
            if (usuario.Role == Enums.UserRole.Admin)
            {
                MessageBox.Show("Não é possível excluir um administrador.");
                return;
            }

            DialogResult result = MessageBox.Show($"Deseja excluir o usuário: {usuario.Name} ?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
                MessageBox.Show("Usuário excluído com sucesso.");
            }

        }
    }
}
