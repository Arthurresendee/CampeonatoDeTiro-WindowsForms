using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ScreenLogin.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        //Nome Completo
        [Required(ErrorMessage = "Nome invalido", AllowEmptyStrings = false)]
        public string NomeCompleto { get; set; }

        //Email
        [Required(ErrorMessage = "Email invalido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Formato de Email Invalido")]
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Genero? GeneroUsuario { get; set; } = null; // se nenhuma opção for marcada, será nulo.

        [StringLength(11,ErrorMessage = "Numero de telefone invalido")]
        public string? NumeroDeTelefone { get; set; }

        //Nome De Usuario Para Login
        [Required(ErrorMessage = "Nome de usuario invalido")]
        public string NomeDeUsuarioParaLogin { get; set; }

        //Senha
        [Required(ErrorMessage = "Senha deve ter 4 caracteres no mínimo")]
        [MinLength(4,ErrorMessage = "Senha deve ter 4 caracteres no mínimo")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        //ConfirmaSenha
        [Required(ErrorMessage = "As senhas não coincidem")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem")]
        public string ConfirmaSenha { get; set; }

        public enum Genero
        {
            masculino,
            Feminino,
            PrefiroNaoDizer
        }
    }
}
