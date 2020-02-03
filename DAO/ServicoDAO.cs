using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAO
{
    public class ServicoDAO
    {
        public int qtd;
        public int Inserir(ServicoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Servico ([servico], [valor]) VALUES (@servico, @valor)";
                    cn.Parameters.Add("servico", SqlDbType.VarChar).Value = objTabela.Servico;
                    cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                    cn.Connection = con;
                    qtd = cn.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error DAO: " + ex.Message);
                }
                return qtd;
            }
        }
        public List<ServicoEnt> BuscarPorId(ServicoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Servico WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                SqlDataReader dr;
                List<ServicoEnt> lista = new List<ServicoEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ServicoEnt dado = new ServicoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Servico = Convert.ToString(dr["servico"]);
                        dado.Valor = Convert.ToString(dr["valor"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public List<ServicoEnt> Buscar(ServicoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Servico WHERE servico like @servico";
                cn.Parameters.Add("servico", SqlDbType.VarChar).Value = objTabela.Servico+ "%";
                //cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;

                cn.Connection = con;
                SqlDataReader dr;
                List<ServicoEnt> lista = new List<ServicoEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ServicoEnt dado = new ServicoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Servico = Convert.ToString(dr["servico"]);
                        dado.Valor = Convert.ToString(dr["valor"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public int Editar(ServicoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Servico SET servico = @servico, valor = @valor  WHERE id = @id";
                cn.Parameters.Add("servico", SqlDbType.VarChar).Value = objTabela.Servico;
                cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }
        public int Excluir(ServicoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Servico WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public DataTable ListaDataTable()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                con.Open();
                string query = "SELECT * FROM Servico ORDER BY servico ASC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        public List<ServicoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Servico ORDER BY servico ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<ServicoEnt> lista = new List<ServicoEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ServicoEnt dado = new ServicoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Servico = Convert.ToString(dr["servico"]);
                        dado.Valor = Convert.ToString((dr["valor"]));   
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
    }
}
