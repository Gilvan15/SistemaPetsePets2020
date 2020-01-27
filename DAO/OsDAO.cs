using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class OsDAO
    {
        public int qtd;
        public int Inserir(OSEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Oservico ([nomepet], [especie], [raca], " +
                        "[proprietario], [telefone], [email], [c_especiais], [alergico], [observacao], [servico1], " +
                        "[checkserv1], [valorserv1], [servico2], [checkserv2], [valorserv2], [servico3], " +
                        "[checkserv3], [valorserv3], [servico4],  [valorserv4], [data], [desconto], [valortotal])" +

                        "VALUES (@nomepet, @especie, @raca, @proprietario, @telefone, @email, @c_especiais, @alergico," +
                        "@observacao, @servico1, @checkserv1, @valorserv1, @servico2, @checkserv2, @valorserv2," +
                        "@servico3, @checkserv3, @valorserv3, @servico4, @valorserv4, @data, @desconto, @valortotal)";
                        

                    cn.Parameters.Add("nomepet", SqlDbType.VarChar).Value = objTabela.Nomepet;
                    cn.Parameters.Add("especie", SqlDbType.VarChar).Value = objTabela.Especie;
                    cn.Parameters.Add("raca", SqlDbType.VarChar).Value = objTabela.Raca;
                    cn.Parameters.Add("proprietario", SqlDbType.VarChar).Value = objTabela.Proprietario;
                    cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objTabela.Telefone;
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                    cn.Parameters.Add("c_especiais", SqlDbType.VarChar).Value = objTabela.C_especiais;
                    cn.Parameters.Add("alergico", SqlDbType.VarChar).Value = objTabela.Alergico;
                    cn.Parameters.Add("observacao", SqlDbType.VarChar).Value = objTabela.Observacao;

                    cn.Parameters.Add("servico1", SqlDbType.VarChar).Value = objTabela.Servico1;
                    cn.Parameters.Add("checkserv1", SqlDbType.VarChar).Value = objTabela.Checkserv1;
                    cn.Parameters.Add("valorserv1", SqlDbType.VarChar).Value = objTabela.Valorserv1;

                    cn.Parameters.Add("servico2", SqlDbType.VarChar).Value = objTabela.Servico2;
                    cn.Parameters.Add("checkserv2", SqlDbType.VarChar).Value = objTabela.Checkserv2;
                    cn.Parameters.Add("valorserv2", SqlDbType.VarChar).Value = objTabela.Valorserv2;

                    cn.Parameters.Add("servico3", SqlDbType.VarChar).Value = objTabela.Servico3;
                    cn.Parameters.Add("checkserv3", SqlDbType.VarChar).Value = objTabela.Checkserv3;
                    cn.Parameters.Add("valorserv3", SqlDbType.VarChar).Value = objTabela.Valorserv3;

                    cn.Parameters.Add("servico4", SqlDbType.VarChar).Value = objTabela.Servico4;
                    cn.Parameters.Add("valorserv4", SqlDbType.VarChar).Value = objTabela.Valorserv4;
                    cn.Parameters.Add("data", SqlDbType.DateTime).Value = objTabela.Data;

                    cn.Parameters.Add("desconto", SqlDbType.VarChar).Value = objTabela.Desconto;
                    cn.Parameters.Add("valortotal", SqlDbType.VarChar).Value = objTabela.Valortotal;


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
        public DataTable ListaDataTable()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                con.Open();
                string query = "SELECT * FROM Oservico ORDER BY nomepet ASC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        /*
        public List<OSEnt> Buscar(OSEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Recibo WHERE recebemosde like @recebemosde";
                cn.Parameters.Add("recebemosde", SqlDbType.VarChar).Value = objTabela.Nomepet + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<OSEnt> lista = new List<OSEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        OSEnt dado = new OSEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nomepet = Convert.ToString(dr["nomepet"]);
                        dado.Especie = Convert.ToString(dr["especie"]);
                        dado.Raca = Convert.ToString(dr["raca"]);
                        dado.Proprietario = Convert.ToString(dr["proprietario"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.C_especiais = Convert.ToString(dr["c_especiais"]);
                        dado.Obervacao = Convert.ToString(dr["obervacao"]);

                        dado.Servico1 = Convert.ToString(dr["servico1"]);
                        dado.Checkserv1 = Convert.ToString(dr["checkserv1"]);
                        dado.Valorserv1 = Convert.ToString(dr["valorserv1"]);

                        
        

        dado.Data = Convert.ToDateTime(dr["data"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }

        }
        /*

        public int Editar(OSEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Recibo SET  valor = @valor, recebemosde = @recebemosde, " +
                    "importanciade1 = @importanciade1, importanciade2 = @importanciade2, referentea1 = @referentea1, " +
                    "referentea2 = @referentea2, emitente = @emitente, cnpj = @cnpj " + "WHERE id = @id";
                cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                cn.Parameters.Add("recebemosde", SqlDbType.VarChar).Value = objTabela.Recebemosde;
                cn.Parameters.Add("importanciade1", SqlDbType.VarChar).Value = objTabela.Importancia1;
                cn.Parameters.Add("importanciade2", SqlDbType.VarChar).Value = objTabela.Importancia2;
                cn.Parameters.Add("referentea1", SqlDbType.VarChar).Value = objTabela.Referentea1;
                cn.Parameters.Add("referentea2", SqlDbType.VarChar).Value = objTabela.Referentea2;
                cn.Parameters.Add("emitente", SqlDbType.VarChar).Value = objTabela.Emitente;
                cn.Parameters.Add("cnpj", SqlDbType.VarChar).Value = objTabela.Cnpj;
                //cn.Parameters.Add("data", SqlDbType.DateTime).Value = objTabela.Data;
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public int Excluir(OSEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Recibo WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public List<OSEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Recibo ORDER BY id ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<OSEnt> lista = new List<OSEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        OSEnt dado = new OSEnt();

                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Valor = Convert.ToString(dr["valor"]);
                        dado.Recebemosde = Convert.ToString(dr["recebemosde"]);
                        dado.Importancia1 = Convert.ToString(dr["importanciade1"]);
                        dado.Importancia2 = Convert.ToString(dr["importanciade2"]);
                        dado.Referentea1 = Convert.ToString(dr["referentea1"]);
                        dado.Referentea2 = Convert.ToString(dr["referentea2"]);
                        dado.Emitente = Convert.ToString(dr["emitente"]);
                        dado.Cnpj = Convert.ToString(dr["cnpj"]);
                        dado.Data = Convert.ToDateTime(dr["data"]);

                        lista.Add(dado);
                    }
                }

                return lista;
            }
        }
        */


    }
}
