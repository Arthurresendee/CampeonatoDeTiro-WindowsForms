namespace ScreenLogin
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int tentativasDeLogin = 0;
            string usuarioLogin = "Pipipipopopo";
            string senhaLogin = "abc12345";

            if (txt_usuario.Text == usuarioLogin && txt_senha.Text == senhaLogin)
            {
                Form_Index form = new();
                form.ShowDialog();
            }
            else
            {
                tentativasDeLogin += 1;
                //txt_senha.
                //Colocar uma mensagem de cor vermelha escrito que a senha está errada. Ou então fazer algum label aparecer embaixo ou em cima do campo em vemlho falando que deu erro.
            }

            //Se o usuário errar a senha 3 vezes, mostrar uma MessageBox perguntando se ele quer tentar fazer uma recuperação de senha. Se errar 5 vezes, o usuário será direcionado para um formulário de recuperação de senha. 
            if (tentativasDeLogin == 3)
            {
                DialogResult retorno = MessageBox.Show("Deseja fazer a recuperação?", "USUÁRIO OU SENHA INCORRETOS", MessageBoxButtons.YesNo);
            }
            else if (tentativasDeLogin == 5)
            {
                Form_RecuperaSenha form = new();
                form.ShowDialog();
                tentativasDeLogin = 0;
            }
        }

        #region Recupera Senha e Cadastro
        private void linklbl_recuperaSenha_MouseClick(object sender, MouseEventArgs e)
        {
            //se o usuario ou senha estiver errado, habilita esse link e será possível redefinir usuario ou senha
            Form_RecuperaSenha form = new();
            form.ShowDialog();
        }

        private void linklbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ficará sempre habilitado para poder criar uma nova conta
            Form_NovoCadastro form = new();
            form.ShowDialog();
        }
        #endregion

        private void linklbl_recuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}