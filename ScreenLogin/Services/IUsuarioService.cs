using Microsoft.EntityFrameworkCore;
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
        UsuarioModel AutenticarUsuario(string nomeDeUsuario, string senha);
    }
}
