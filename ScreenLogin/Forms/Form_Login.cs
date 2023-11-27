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
            else //(txt_usuario.Text != usuarioLogin && txt_senha.Text != senhaLogin)
            {
                tentativasDeLogin += 1;
                txt_senha.Clear();

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
            Form_NovoCadastro form = new();
            form.ShowDialog();
        }
        private void linklbl_recuperaSenha_MouseClick(object sender, MouseEventArgs e)
        {
        }

        #endregion

    }
}