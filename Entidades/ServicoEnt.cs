using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ServicoEnt
    {
        private int id;
        private string servico;
        private string valor;

        public int Id { get => id; set => id = value; }
        public string Servico { get => servico; set => servico = value; }
        public string Valor { get => valor; set => valor = value; }
        
    }
}
