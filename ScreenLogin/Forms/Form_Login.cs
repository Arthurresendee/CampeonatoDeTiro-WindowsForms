using ScreenLogin.Data;
using ScreenLogin.Models;
using ScreenLogin.Services;

namespace ScreenLogin
{
    public partial class Form_Login : Form
    {
        private readonly UsuarioService _usuarioService;
        public Form_Login(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
            lbl_erroLogin.Enabled = false;
            lbl_erroLogin2.Enabled = false;
        }

        int tentativasDeLogin = 0;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string usuarioLogin = txt_usuario.Text;
            string senhaLogin = txt_senha.Text;

            UsuarioModel usuarioAutenticado = _usuarioService.AutenticarUsuario(usuarioLogin, senhaLogin);

            if (usuarioAutenticado != null)
            {
                var form = new Form_Index();
                this.Hide();
                form.ShowDialog();
            }
            else //(txt_usuario.Text != usuarioLogin && txt_senha.Text != senhaLogin)
            {
                tentativasDeLogin += 1;
                txt_senha.Clear();

                lbl_erroLogin.Enabled = true;
                lbl_erroLogin2.Enabled = true;

                lbl_erroLogin.Enabled = false;
                lbl_erroLogin2.Enabled = false;
                Thread.Sleep(100);
                lbl_erroLogin.Enabled = true;
                lbl_erroLogin2.Enabled = true;
            }

            if (tentativasDeLogin == 3)
            {
                DialogResult retorno = MessageBox.Show("Deseja fazer a recuperação?", "USUÁRIO OU SENHA INCORRETOS", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (retorno == DialogResult.Yes)
                {
                    Form_RecuperaSenha form = new();
                    form.ShowDialog();
                }
                tentativasDeLogin = 0;
            }
        }

        #region LinkLabel para cadastrar e recuperar senha
        private void linklbl_recuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_RecuperaSenha form = new();
            form.ShowDialog();
        }
        private void linklbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dbContext = new DataContext();
            var usuarioService = new UsuarioService(dbContext);
            var novoCadastroForm = new Form_NovoCadastro(usuarioService);
            novoCadastroForm.ShowDialog();
        }
        private void linklbl_recuperaSenha_MouseClick(object sender, MouseEventArgs e)
        {
        }

        #endregion

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}