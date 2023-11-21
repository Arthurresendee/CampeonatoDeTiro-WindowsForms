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

        }

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
    }
}