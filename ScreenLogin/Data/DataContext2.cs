using Microsoft.EntityFrameworkCore;
using ScreenLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLogin.Data
{
    public class DataContext2 : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-AJ8AD1P;Initial Catalog=LoginWF;Persist Security Info=True;User ID=sa;Password=root;Connect Timeout=180;Encrypt=False");
            optionsBuilder.UseSqlServer("Data Source=ARTHUREMANUEL;Initial Catalog=LoginWF;Persist Security Info=True;User ID=sa;Password=root;Connect Timeout=180;Encrypt=False");
        }
    }
}
