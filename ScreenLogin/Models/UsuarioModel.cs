using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLogin.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Email { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public Genero GeneroUsuario { get; set; }
        public string? NumeroDeTelefone { get; set; }
        public string NomeDeUsuarioParaLogin { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }

        public enum Genero
        {
            masculino = 0,
            Feminino = 1,
            PrefiroNaoDizer = 2
        }

    }
}
