namespace ScreenLogin
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            lbl_erroLogin.Enabled = false;
            lbl_erroLogin2.Enabled = false;
        }

        int tentativasDeLogin = 0;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string usuarioLogin = "pipipi";
            string senhaLogin = "popopo";

            if (txt_usuario.Text == usuarioLogin && txt_senha.Text == senhaLogin)
            {
                Form_Index form = new();
                this.Hide();
                form.ShowDialog();
            }

            if (txt_usuario.Text != usuarioLogin && txt_senha.Text != senhaLogin)
            {
                tentativasDeLogin += 1;
                txt_senha.Clear();
                txt_usuario.Clear();

                lbl_erroLogin.Enabled = true;
                lbl_erroLogin.ForeColor = Color.Red;
                lbl_erroLogin2.Enabled = true;
                lbl_erroLogin2.ForeColor = Color.Red;

                lbl_erroLogin.Enabled = false;
                lbl_erroLogin2.Enabled = false;
                Thread.Sleep(100);
                lbl_erroLogin.Enabled = true;
                lbl_erroLogin2.Enabled = true;
            }

            if (tentativasDeLogin == 3)
            {
                DialogResult retorno = MessageBox.Show("Deseja fazer a recupera��o?", "USU�RIO OU SENHA INCORRETOS", MessageBoxButtons.YesNo,MessageBoxIcon.Error);

                if (retorno == DialogResult.Yes)
                {
                    Form_RecuperaSenha form = new();
                    form.ShowDialog();
                }
                else return;
            }
        }

        #region LinkLabel para cadastrar e recuperar senha
        private void linklbl_recuperaSenha_MouseClick(object sender, MouseEventArgs e)
        {
            Form_RecuperaSenha form = new();
            form.ShowDialog();
        }

        private void linklbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_NovoCadastro form = new();
            form.ShowDialog();
        }
        #endregion

        private void linklbl_recuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}