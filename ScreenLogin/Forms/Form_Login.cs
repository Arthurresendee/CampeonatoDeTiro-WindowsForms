using ScreenLogin.Data;
using ScreenLogin.Models;
using ScreenLogin.Services;
using System.ServiceProcess;

namespace ScreenLogin
{
    public partial class Form_Login : Form
    {
        private readonly UsuarioService _usuarioService;
        public Form_Login(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
            button1.Visible = false;
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
                button1.Visible = true; //Botão De Recuperar senha
                tentativasDeLogin += 1;
                txt_usuario.Clear();
                txt_senha.Clear();

                #region animacaoLoginErrado
                label6.Visible = true;
                label7.Visible = true;
                label6.Enabled = false;
                label7.Enabled = false;
                Thread.Sleep(200);
                label6.Enabled = true;
                label7.Enabled = true;
                #endregion
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

        private void button1_Click(object sender, EventArgs e) //Botão de esqueci a senha;
        {
            Form_RecuperaSenha form = new();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //Botão de Cadastrar novo usuário
        {
            var dbContext = new DataContext();
            var usuarioService = new UsuarioService(dbContext);
            var novoCadastroForm = new Form_NovoCadastro(usuarioService);
            novoCadastroForm.ShowDialog();
        }

        private void linklbl_recuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void linklbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void linklbl_recuperaSenha_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}