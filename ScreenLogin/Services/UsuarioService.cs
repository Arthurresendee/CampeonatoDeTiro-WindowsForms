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
        private readonly UsuarioContext _usuarioContext;
        public UsuarioService(UsuarioContext dbcontext)
        {
            _usuarioContext = dbcontext;
        }

        public void AtualizarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void InserirUsuario(UsuarioModel usuario)
        {   
            _usuarioContext.Usuarios.Add(usuario);
            _usuarioContext.SaveChanges();
        }

        public void LerUsuario()
        {
            throw new NotImplementedException();
        }

        public void LerUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
