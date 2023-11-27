using Microsoft.EntityFrameworkCore;
using ScreenLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLogin.Data
{
    public class UsuarioContext : DbContext
    {
        public DbSet<UsuarioLoginModel> UsuariosLogins { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure a string de conexão aqui
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AJ8AD1P;Initial Catalog=LoginWF;Persist Security Info=True;User ID=sa;Password=root;Connect Timeout=180;Encrypt=False");
        }
    }
}
