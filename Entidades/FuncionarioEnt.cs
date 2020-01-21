using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FuncionarioEnt
    {
        private int id;
        private string nome;
        private string rg;
        private string cpf;
        private string telefone;
        private string email;
        private string rua;
        private string numero;
        private string bairro;
        private string comp;
        private string admissao;
        private string demissao;
        private string nascimento;
        private string status;
        private string jtInic;
        private string jtFinal;
        private string hora1;
        private string hora2;
        private string salario;
        private int id_funcao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Comp { get => comp; set => comp = value; }
        public string Admissao { get => admissao; set => admissao = value; }
        public string Demissao { get => demissao; set => demissao = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Status { get => status; set => status = value; }
        public string JtInic { get => jtInic; set => jtInic = value; }
        public string JtFinal { get => jtFinal; set => jtFinal = value; }
        public string Hora1 { get => hora1; set => hora1 = value; }
        public string Hora2 { get => hora2; set => hora2 = value; }
        public string Salario { get => salario; set => salario = value; }
        public int Id_funcao { get => id_funcao; set => id_funcao = value; }
    }
}
