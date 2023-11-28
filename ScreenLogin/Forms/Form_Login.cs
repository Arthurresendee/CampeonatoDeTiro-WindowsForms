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
                Form_Index form = new();
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

            //tentativasDeLogin += 1;
            if (tentativasDeLogin == 3 || tentativasDeLogin == 6 || tentativasDeLogin == 9)
            {
                DialogResult retorno = MessageBox.Show("Deseja fazer a recuperação?", "USUÁRIO OU SENHA INCORRETOS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (retorno == DialogResult.Yes)
                {
                    Form_RecuperaSenha form = new();
                    form.ShowDialog();
                }
                else return;
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
            UsuarioService usuarioService = new UsuarioService(dbContext); // Crie a instância do seu serviço
            Form_NovoCadastro novoCadastroForm = new Form_NovoCadastro(usuarioService);
            novoCadastroForm.ShowDialog();
        }
        private void linklbl_recuperaSenha_MouseClick(object sender, MouseEventArgs e)
        {
        }

        #endregion

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}