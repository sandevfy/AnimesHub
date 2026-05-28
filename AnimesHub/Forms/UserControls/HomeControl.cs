using AnimesHub.Forms.UserControls.HomeUserControls;
using AnimesHub.Models;

namespace AnimesHub.Forms
{
    public partial class HomeControl : UserControl
    {
        private Usuario _usuarioLogado;
        public HomeControl(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogado = usuario;
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            HomePrincipal home = new HomePrincipal(_usuarioLogado);
            home.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(home);

        }

        private void btnCategoriaStrip_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnCategoriaStrip, 0, btnCategoriaStrip.Height);
        }

        private void btnNovidadesHome_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();
        }
    }
}
