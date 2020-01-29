using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LembrarLoginDAO
    {
        public int Editar(LembrarLoginEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Lembrarlogin SET username = @username, password = @password, checksave = @checksave  WHERE id = @id";
                cn.Parameters.Add("username", SqlDbType.VarChar).Value = objTabela.Username;
                cn.Parameters.Add("password", SqlDbType.VarChar).Value = objTabela.Password;
                cn.Parameters.Add("checksave", SqlDbType.Bit).Value = objTabela.Checksave;
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }

        public List<LembrarLoginEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Lembrarlogin";
                cn.Connection = con;
                SqlDataReader dr;
                List<LembrarLoginEnt> lista = new List<LembrarLoginEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        LembrarLoginEnt dado = new LembrarLoginEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Username = Convert.ToString(dr["username"]);
                        dado.Password = Convert.ToString((dr["password"]));
                        dado.Checksave = Convert.ToBoolean((dr["checksave"]));
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }







    }
}
