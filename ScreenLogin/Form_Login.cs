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
                //Colocar uma mensagem de cor vermelha escrito que a senha est� errada. Ou ent�o fazer algum label aparecer embaixo ou em cima do campo em vemlho falando que deu erro.
            }

            //Se o usu�rio errar a senha 3 vezes, mostrar uma MessageBox perguntando se ele quer tentar fazer uma recupera��o de senha. Se errar 5 vezes, o usu�rio ser� direcionado para um formul�rio de recupera��o de senha. 
            if (tentativasDeLogin == 3)
            {
                DialogResult retorno = MessageBox.Show("Deseja fazer a recupera��o?", "USU�RIO OU SENHA INCORRETOS", MessageBoxButtons.YesNo);
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
            //se o usuario ou senha estiver errado, habilita esse link e ser� poss�vel redefinir usuario ou senha
            Form_RecuperaSenha form = new();
            form.ShowDialog();
        }

        private void linklbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ficar� sempre habilitado para poder criar uma nova conta
            Form_NovoCadastro form = new();
            form.ShowDialog();
        }
        #endregion

        private void linklbl_recuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}