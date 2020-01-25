using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ServicoModel
    {
        public static int Inseir(ServicoEnt objTabela)
        {
            return new ServicoDAO().Inserir(objTabela);
        }

        public List<ServicoEnt> Lista()
        {
            return new ServicoDAO().Lista();
        }

        public static int Excluir(ServicoEnt objTabela)
        {
            return new ServicoDAO().Excluir(objTabela);
        }

        public static int Editar(ServicoEnt objTabela)
        {
            return new ServicoDAO().Editar(objTabela);
        }
        public List<ServicoEnt> Buscar(ServicoEnt objTabela)
        {
            return new ServicoDAO().Buscar(objTabela);
        }
        public List<ServicoEnt> BuscarPorId(ServicoEnt objTabela)
        {
            return new ServicoDAO().BuscarPorId(objTabela);
        }
        public DataTable ListaDataTable()
        {
            return new ServicoDAO().ListaDataTable();
        }


    }
}
