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
        public Form_NovoCadastro()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioModel novoUsuario = new();
            novoUsuario.NomeCompleto = txt_nomeCompleto.Text;
            novoUsuario.Email = txt_email.Text;
            //novoUsuario.DataDeNascimento = txt_DataDeNascimento.Text; Arrumar data De Nascimento
            //novoUsuario.GeneroUsuario = gpb_genero.Text; Arrumar genero
            novoUsuario.NumeroDeTelefone = txt_numeroDeTelefone.Text;
            novoUsuario.NomeDeUsuarioParaLogin = txt_NomeDeUsuario.Text;
            novoUsuario.Senha = txt_senha.Text;
            novoUsuario.ConfirmaSenha = txt_confirmarSenha.Text;

            //UsuarioService usuarioService = new UsuarioService();
            //usuarioService.InserirUsuario(usuario);

            MessageBox.Show("Usuário cadastrado com sucesso!");
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

    }
}
