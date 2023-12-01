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
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="Números e caracteres especiais não são permitidos no nome.")]
        public string? NomeCompleto { get; set; }

        //Email
        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string? Email { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public Genero? GeneroUsuario { get; set; }
        public string? NumeroDeTelefone { get; set; }

        //Nome De Usuario Para Login
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string NomeDeUsuarioParaLogin { get; set; }

        //Senha
        [Required]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 4)]
        public string Senha { get; set; }

        //ConfirmaSenha
        [Required]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmaSenha { get; set; }

        public enum Genero
        {
            masculino = 0,
            Feminino = 1,
            PrefiroNaoDizer = 2
        }
    }
}
