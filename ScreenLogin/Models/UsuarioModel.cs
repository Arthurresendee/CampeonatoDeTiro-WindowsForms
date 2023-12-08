using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ScreenLogin.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        //Nome Completo
        [Required(ErrorMessage = "Nome invalido", AllowEmptyStrings = false)]
        public string? NomeCompleto { get; set; }

        //Email
        [Required(ErrorMessage = "Email invalido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Formato de Email Invalido")]
        public string? Email { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public Genero? GeneroUsuario { get; set; } = null; // se nenhuma opção for marcada, será nulo.
        public string? NumeroDeTelefone { get; set; }

        //Nome De Usuario Para Login
        [Required(ErrorMessage = "Nome de usuario invalido", AllowEmptyStrings = false)]
        public string NomeDeUsuarioParaLogin { get; set; }

        //Senha
        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4,ErrorMessage ="Senha deve ter 8 caracteres")]
        public string Senha { get; set; }

        //ConfirmaSenha
        [Required]
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
