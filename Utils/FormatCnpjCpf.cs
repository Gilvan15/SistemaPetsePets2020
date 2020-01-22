using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaPet.Utils
{
    public class FormatCnpjCpf
    {
        public static string FormatCPF(string cpf)
        {
                cpf = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                return cpf;
        }

        public static string FormatCNPJ(string CNPJ)
        {
            CNPJ =  Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
            return CNPJ;
        }

        public static string FormatCelular(string celular)
        {
            celular = Convert.ToUInt64(celular).ToString(@"(##) #####-####");
            return celular;
        }

    }
}
