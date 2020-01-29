using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class LembrarLoginModel
    {
        public static int Editar(LembrarLoginEnt objTabela)
        {
            return new LembrarLoginDAO().Editar(objTabela);
        }

        public List<LembrarLoginEnt> Lista()
        {
            return new LembrarLoginDAO().Lista();
        }

    }
}
