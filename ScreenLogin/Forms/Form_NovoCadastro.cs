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

namespace ScreenLogin
{
    public partial class Form_NovoCadastro : Form
    {
        private readonly UsuarioService _usuarioService;
        public Form_NovoCadastro(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
            lbl_confirmaSenha.Enabled = false;
            lbl_usuarioExistente.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var novoUsuario = new UsuarioModel
            {
                NomeCompleto = txt_nomeCompleto.Text,
                Email = txt_email.Text,
                //novoUsuario.DataDeNascimento = txt_DataDeNascimento.Text; Arrumar data De Nascimento
                //novoUsuario.GeneroUsuario = gpb_genero.Text; Arrumar genero
                NumeroDeTelefone = txt_numeroDeTelefone.Text,
                NomeDeUsuarioParaLogin = txt_NomeDeUsuario.Text,
                Senha = txt_senha.Text,
                ConfirmaSenha = txt_confirmarSenha.Text
            };
            var usuarioValidado = ValidarUsuario(novoUsuario);

            if (usuarioValidado)
            {
                _usuarioService.InserirUsuario(novoUsuario);
                MessageBox.Show("Usuario Inserido com sucesso");
                this.Close();
            }
            else
            {
                //ações a serem tomadas caso haja algum erro de validação.
                return;
            }
        }

        #region ---
        //O método ValidarUsuario retorna false se hover algum erro dentro da lista de erros retornados
        //pelo método estático getValidationErros() da classe (Validacao), que recebe como parâmetro, uma classe do tipo usuarioModel.
        //Essa classe faz a verificação dos dataAnnotations(regras individuais de campos na criação de um objeto.).
        //A medida que é verificao cada campo, se houver erros de validação, é adicionado à uma lista e posteriormente retornada.
        //Logo em seguida, o Método Any() irá verificar há erro em algum campo. Se houver, irá retorna um MessageBox() para cada erro.
        #endregion
        private bool ValidarUsuario(UsuarioModel usuario)
        {
            var validationResults = Validacao.getValidationErros(usuario);

            if (validationResults.Any())
            {
                foreach (var error in validationResults)
                {
                    MessageBox.Show((error.ErrorMessage));
                }

                return false;
            }
            return true;
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
    }
}
