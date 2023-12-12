using Microsoft.VisualBasic.Logging;
using ScreenLogin.Data;
using ScreenLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLogin.Services
{
    //dá para fazer utlizando classe concreta ao invés da injeção de dependencia.
    public class UsuarioService : IUsuarioService
    {
        private readonly DataContext _dbContext;
        public UsuarioService(DataContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public UsuarioModel AutenticarUsuario(string nomeDeUsuario, string senha)
        {
            return _dbContext.Usuarios
                .FirstOrDefault(u => u.NomeDeUsuarioParaLogin == nomeDeUsuario && u.Senha == senha);
        }

        public UsuarioModel ObterNomeDeUsuario(string nomeDoUsuario)
        {
            var buscaUsuario = _dbContext.Usuarios.FirstOrDefault(u => u.NomeDeUsuarioParaLogin == nomeDoUsuario);
            return buscaUsuario;
        }

        public UsuarioModel InserirUsuario(UsuarioModel usuario)
        {   
            _dbContext.Usuarios.Add(usuario);
            _dbContext.SaveChanges();
            return(usuario);
        }

    }
}
