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
    public class FuncionarioModel
    {
        public static int Inseir(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Inserir(objTabela);
        }

        public List<FuncionarioEnt> Lista()
        {
            return new FuncionarioDAO().Lista();
        }

        public DataTable ListaJonn()
        {
            return new FuncionarioDAO().ListaJonn();
        }
        
        public static int Excluir(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Excluir(objTabela);
        }
        public static int Editar(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Editar(objTabela);
        }
        public List<FuncionarioEnt> Buscar(FuncionarioEnt objTabela)
        {
            return new FuncionarioDAO().Buscar(objTabela);
        }


    }
}
