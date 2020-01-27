using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Data;

namespace Model
{
    public class OsModel
    {
        public static int Inseir(OSEnt objTabela)
        {
            return new OsDAO().Inserir(objTabela);
        }

        public DataTable ListaDataTable()
        {
            return new OsDAO().ListaDataTable();
        }

        public static int Editar(OSEnt objTabela)
        {
            return new OsDAO().Editar(objTabela);
        }


        /*
        public List<OSEnt> Lista()
        {
            return new OsDAO().Lista();
        }

        /*
        public static int Excluir(OSEnt objTabela)
        {
            return new OsDAO().Excluir(objTabela);
        }       
        */
        public List<OSEnt> Buscar(OSEnt objTabela)
        {
            return new OsDAO().Buscar(objTabela);
        }
    }
}
