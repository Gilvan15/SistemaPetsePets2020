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
    public class FuncionarioDAO
    {
        public int qtd;
        public int Inserir(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Funcionario ([nome], [rg], [cpf], [telefone], [email], " +
                        "[rua], [numero], [bairro], [comp], [admissao], [demissao], [nascimento], " +
                        "[status], [jtinic], [jtfinal], [hora1], [hora2], [salario], [id_funcao]) " +
                        "VALUES (@nome, @rg, @cpf, @telefone, @email, @rua, @numero, @bairro, @comp, @admissao," +
                        " @demissao, @nascimento, @status, @jtinic, @jtfinal, @hora1, @hora2, @salario, @id_funcao)";

                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                    cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objTabela.Rg;
                    cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                    cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objTabela.Telefone;
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                    cn.Parameters.Add("rua", SqlDbType.VarChar).Value = objTabela.Rua;
                    cn.Parameters.Add("numero", SqlDbType.VarChar).Value = objTabela.Numero;
                    cn.Parameters.Add("bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                    cn.Parameters.Add("comp", SqlDbType.VarChar).Value = objTabela.Comp;

                    cn.Parameters.Add("admissao", SqlDbType.VarChar).Value = objTabela.Admissao;
                    cn.Parameters.Add("demissao", SqlDbType.VarChar).Value = objTabela.Demissao;
                    cn.Parameters.Add("nascimento", SqlDbType.VarChar).Value = objTabela.Nascimento; ;

                    cn.Parameters.Add("status", SqlDbType.VarChar).Value = objTabela.Status;
                    cn.Parameters.Add("jtinic", SqlDbType.VarChar).Value = objTabela.JtInic;
                    cn.Parameters.Add("jtfinal", SqlDbType.VarChar).Value = objTabela.JtFinal;
                    cn.Parameters.Add("hora1", SqlDbType.VarChar).Value = objTabela.Hora1;
                    cn.Parameters.Add("hora2", SqlDbType.VarChar).Value = objTabela.Hora2;
                    cn.Parameters.Add("salario", SqlDbType.VarChar).Value = objTabela.Salario;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Id_funcao;
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
        public List<FuncionarioEnt> Buscar(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Funcionario WHERE nome like @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncionarioEnt dado = new FuncionarioEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Rua = Convert.ToString(dr["rua"]);
                        dado.Numero = Convert.ToString(dr["numero"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Comp = Convert.ToString(dr["comp"]);
                        dado.Admissao = Convert.ToString(dr["admissao"]);
                        dado.Demissao = Convert.ToString(dr["demissao"]);
                        dado.Nascimento = Convert.ToString(dr["nascimento"]);
                        dado.Status = Convert.ToString(dr["status"]);
                        dado.JtInic = Convert.ToString(dr["jtinic"]);
                        dado.JtFinal = Convert.ToString(dr["jtfinal"]);
                        dado.Hora1 = Convert.ToString(dr["hora1"]);
                        dado.Hora2 = Convert.ToString(dr["hora2"]);
                        dado.Salario = Convert.ToString(dr["salario"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }

        }

        public int Editar(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Funcionario SET nome = @nome, rg = @rg, " +
                    "cpf = @cpf, telefone = @telefone,   email = @email, rua = @rua, " +
                    "numero = @numero, bairro = @bairro, comp = @comp, admissao = @admissao, " +
                    "demissao = @demissao, nascimento = @nascimento, " +
                    "status = @status, jtinic = @jtinic, jtFinal = @jtfinal, hora1 = @hora1," +
                    "hora2 = @hora2, salario = @salario, id_funcao = @id_funcao WHERE id = @id";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objTabela.Rg;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objTabela.Telefone;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("rua", SqlDbType.VarChar).Value = objTabela.Rua;
                cn.Parameters.Add("numero", SqlDbType.VarChar).Value = objTabela.Numero;
                cn.Parameters.Add("bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                cn.Parameters.Add("comp", SqlDbType.VarChar).Value = objTabela.Comp;

                                
                cn.Parameters.Add("admissao", SqlDbType.VarChar).Value = objTabela.Admissao;
                cn.Parameters.Add("demissao", SqlDbType.VarChar).Value = objTabela.Demissao;
                cn.Parameters.Add("nascimento", SqlDbType.VarChar).Value = objTabela.Nascimento;
                               

                cn.Parameters.Add("status", SqlDbType.VarChar).Value = objTabela.Status;
                cn.Parameters.Add("jtinic", SqlDbType.VarChar).Value = objTabela.JtInic;
                cn.Parameters.Add("jtfinal", SqlDbType.VarChar).Value = objTabela.JtFinal;
                cn.Parameters.Add("hora1", SqlDbType.VarChar).Value = objTabela.Hora1;
                cn.Parameters.Add("hora2", SqlDbType.VarChar).Value = objTabela.Hora2;
                cn.Parameters.Add("salario", SqlDbType.VarChar).Value = objTabela.Salario;

                cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id_funcao);
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public int Excluir(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Funcionario WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public DataTable ListaJonn()
        {
            using (SqlConnection con = new SqlConnection())
            {
                
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    con.Open();
                    string query = "SELECT Funcionario.[id], [Nome], [rg], [cpf], [telefone], [email], [rua], [numero], [bairro], [comp], [admissao], [demissao], [nascimento],[status], [jtInic], [jtFinal], [hora1], [hora2],[salario], [descricao] FROM Funcionario INNER JOIN Funcao ON Funcionario.id_funcao = Funcao.id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
            }
        }




        public List<FuncionarioEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT Funcionario.[id], [Nome], [rg], [cpf], [telefone], " +
                    "[email],[rua], [numero], [bairro], [comp], [admissao], [demissao], [nascimento], " +
                    "[status], [jtinic], [jtfinal], [hora1], [hora2],[salario], [descricao] " +
                    "FROM Funcionario INNER JOIN Funcao ON Funcionario.id_funcao = Funcao.id";
                //"SELECT * FROM Usuario ORDER BY nome ASC";

                cn.Connection = con;
                SqlDataReader dr;
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();

                dr = cn.ExecuteReader();
                
                /*if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncionarioEnt dado = new FuncionarioEnt();

                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                */
                return lista;
            }
        }

        /*
        public DataTable ListaJonn()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                con.Open();
                string query = "SELECT Funcionario.[id], [Nome], [email], [username], [senha], [descricao] FROM Usuario INNER JOIN Funcao ON Usuario.id_funcao = Funcao.id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }*/
    }
}