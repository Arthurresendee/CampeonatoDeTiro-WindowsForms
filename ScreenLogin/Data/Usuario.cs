using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenLogin.Data
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SenhaHash { get; set; }
    }
}
