using Microsoft.VisualBasic;
using ScreenLogin.Models;
using ScreenLogin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScreenLogin
{
    public partial class Form_NovoCadastro : Form
    {
        private readonly UsuarioService _usuarioService;
        public Form_NovoCadastro(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
            InicializarVisibilidadeDeLabelsDeErros();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            InicializarVisibilidadeDeLabelsDeErros();
            var novoUsuario = new UsuarioModel
            {
                NomeCompleto = txt_nomeCompleto.Text,
                Email = txt_email.Text,
                DataDeNascimento = dtp_Nascimento.Value,
                GeneroUsuario = radioButton1.Checked ? UsuarioModel.Genero.masculino :
                                radioButton2.Checked ? UsuarioModel.Genero.Feminino :
                                radioButton3.Checked ? UsuarioModel.Genero.PrefiroNaoDizer : null,
                NumeroDeTelefone = txt_numeroDeTelefone.Text,
                NomeDeUsuarioParaLogin = txt_NomeDeUsuario.Text,
                Senha = txt_senha.Text,
                ConfirmaSenha = txt_confirmarSenha.Text
            };
            var usuarioValidado = ValidarModeloDeUsuario(novoUsuario);
            if (usuarioValidado)
            {
                _usuarioService.InserirUsuario(novoUsuario);
                MessageBox.Show("Usuario Inserido com sucesso");
                this.Close();
            }
        }

        #region ---
        //O método ValidarUsuario retorna false se hover algum erro dentro da lista de erros retornados
        //pelo método estático getValidationErros() da classe (Validacao), que recebe como parâmetro, uma classe do tipo usuarioModel.
        //Essa classe faz a verificação dos dataAnnotations(regras individuais de campos na criação de um objeto.).
        //A medida que é verificao cada campo, se houver erros de validação, é adicionado à uma lista e posteriormente retornada.
        //Logo em seguida, o Método Any() irá verificar há erro em algum campo. Se houver, irá retorna um MessageBox() para cada erro.
        #endregion
        private bool ValidarModeloDeUsuario(UsuarioModel usuario)
        {
            var listaDeErrosNoModelo = new List<ValidationResult>();
            listaDeErrosNoModelo = Validacao.getValidationErros(usuario);

            #region [Adiciona erro do campo NomeDeUsuarioParaLogin para listadeErrosNoModelo]
            var usuarioValidado = _usuarioService.ObterNomeDeUsuario(usuario.NomeDeUsuarioParaLogin);
            if (usuarioValidado)
            {
                var error = new ValidationResult("UsuarioDeLoginInvalido");
                listaDeErrosNoModelo.Add(error);
            }
            #endregion

            if (listaDeErrosNoModelo.Any())
            {
                foreach (var error in listaDeErrosNoModelo)
                    switch (error.ErrorMessage)
                    {
                        case "Nome invalido":
                            txt_nomeInvalido.Visible = true;
                            break;
                        case "Email invalido":
                        case "Formato de Email Invalido":
                            txt_emailInvalido.Visible = true;
                            break;
                        case "Numero de telefone invalido":
                            txt_numeroDeTelefoneInvalido.Visible = true;
                            break;
                        case "UsuarioDeLoginInvalido":
                            txt_usuarioInvalido.Visible = true;
                            break;
                        case "Senha deve ter 4 caracteres no mínimo":
                            txt_senhaInvalida.Visible = true;
                            break;
                        case "As senhas não coincidem":
                            txt_senhaConfirmadaInvalida.Visible = true;
                            break;
                    }
                return false;
            }
            return true;
        }

        public void InicializarVisibilidadeDeLabelsDeErros()
        {
            radioButton3.Checked = true;
            txt_nomeInvalido.Visible = false;
            txt_emailInvalido.Visible = false;
            txt_DataDeAniversarioInvalida.Visible = false;
            txt_numeroDeTelefoneInvalido.Visible = false;
            txt_usuarioInvalido.Visible = false;
            txt_senhaConfirmadaInvalida.Visible = false;
            txt_senhaInvalida.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_usuarioExistente_Click(object sender, EventArgs e)
        {

        }

        private void txt_nomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
        }

        private void txt_senhaInvalida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
