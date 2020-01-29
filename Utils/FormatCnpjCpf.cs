using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            { return true; }
            else { return false; }
        }


        public static void Moeda(ref TextBox txt)
        {
            //procedure para formatar textbox em formato moeda c/2 casas decimais
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception c)
            {
                //MessageBox.Show(c.Message);
            }
        }

    }
}
