using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AnimalEnt
    {
        private int id;
        private string especie;
        private string raca;
        private string nome;
        private string idadenumero1;
        private string idadetipo1;
        private string idadenumero2;
        private string idadetipo2;
        private string proprietario;
        private string telefone;
        private string email;
        private string cuidados_esp;
        private string alergico;
        private byte[] foto;

        public int Id { get => id; set => id = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raca { get => raca; set => raca = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Idadenumero1 { get => idadenumero1; set => idadenumero1 = value; }
        public string Idadetipo1 { get => idadetipo1; set => idadetipo1 = value; }
        public string Idadenumero2 { get => idadenumero2; set => idadenumero2 = value; }
        public string Idadetipo2 { get => idadetipo2; set => idadetipo2 = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cuidados_esp { get => cuidados_esp; set => cuidados_esp = value; }
        public string Alergico { get => alergico; set => alergico = value; }
        public byte[] Foto { get => foto; set => foto = value; }
    }
}
