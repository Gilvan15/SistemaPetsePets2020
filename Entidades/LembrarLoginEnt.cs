using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LembrarLoginEnt
    {
        private int id;
        private string username;
        private string password;
        private Boolean checksave;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Boolean Checksave { get => checksave; set => checksave = value; }
    }
}
