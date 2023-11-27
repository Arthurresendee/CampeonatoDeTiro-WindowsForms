using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLogin.Data
{
    public class LoginContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure a string de conexão aqui
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AJ8AD1P;Initial Catalog=LoginWF;Persist Security Info=True;User ID=sa;Password=root;Connect Timeout=180;Encrypt=False");
        }
    }
}
