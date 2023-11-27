using ScreenLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLogin.Services
{
    public interface IUsuarioService
    {
        void InserirUsuario(UsuarioModel usuario);
        void LerUsuario(); // retorna todos
        void LerUsuarioPorId(int id);
        void AtualizarUsuarioPorId(int id);
        void DeletarUsuarioPorId(int id);
    }
}
