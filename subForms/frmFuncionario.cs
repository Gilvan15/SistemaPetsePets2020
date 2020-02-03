using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;
using Model;
using Bunifu.Framework.UI;
using System.Data.SqlClient;
using SistemaPet.Properties;
using System.Data.SqlTypes;
using SistemaPet.Utils;

namespace SistemaPet.subForms
{
    public partial class frmFuncionario : Form
    {
        FuncionarioEnt objTabela = new FuncionarioEnt();
        FuncaoEnt objFuncao = new FuncaoEnt();

        string CPFFormatado;

        string ContentmaskAdmin;
        string pasta_aplicacao = "";
        private string opc = "";
        int id_funcao;

        public frmFuncionario()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }


        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }
        public void sound2()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\limpar.wav");
            player.Play();
        }
        public void sound3()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\aviso.wav");
            player.Play();
        }

        public void sound4()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\salvar.wav");
            player.Play();
        }


        private void CarregarGrid()
        {
            try
            {
                DataTable lista;
                lista = new FuncionarioModel().ListaJonn();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "NOME";
                dataGridView1.Columns[2].HeaderText = "RG";
                dataGridView1.Columns[3].HeaderText = "CPF";
                dataGridView1.Columns[4].HeaderText = "TELEFONE";
                dataGridView1.Columns[5].HeaderText = "EMAIL";
                dataGridView1.Columns[6].HeaderText = "RUA";
                dataGridView1.Columns[7].HeaderText = "NUMERO";
                dataGridView1.Columns[8].HeaderText = "BAIRRO";
                dataGridView1.Columns[9].HeaderText = "COMP.";
                dataGridView1.Columns[10].HeaderText = "ADMISSÃO";
                dataGridView1.Columns[11].HeaderText = "DEMISSÃO";
                dataGridView1.Columns[12].HeaderText = "NASCIMENTO";
                dataGridView1.Columns[13].HeaderText = "STATUS";
                dataGridView1.Columns[14].HeaderText = "JT-INICIAL";
                dataGridView1.Columns[15].HeaderText = "JT-FINAL";
                dataGridView1.Columns[16].HeaderText = "HORA ENTRADA";
                dataGridView1.Columns[17].HeaderText = "HORA SAÍDA";
                dataGridView1.Columns[18].HeaderText = "SALÁRIO";
                dataGridView1.Columns[19].HeaderText = "FUNÇÃO";
                
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }
        }


        private void HabilitarCampos()
        {

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {

                    ((TextBox)ctrl).Enabled = true;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Enabled = true;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                }
            }

            foreach (Control ctrl in groupDadosAdicionais.Controls)
            {
                if (ctrl is TextBox)
                {

                    ((TextBox)ctrl).Enabled = true;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = true;
                }
            }

            textCod.Enabled = false; 
            btnSalvar.Enabled = true;

        }
        private void DesabilitarCampos()
        {
            textCod.Enabled = false;
            btnSalvar.Enabled = false;

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {

                    ((TextBox)ctrl).ReadOnly = false;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Enabled = false;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }
            }

            foreach (Control ctrl in groupDadosAdicionais.Controls)
            {
                if (ctrl is TextBox)
                {

                    ((TextBox)ctrl).Enabled = false;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = false;
                }
            }
        }
        private void LimparCampos()
        {
            textCod.Text = null;
            textNome.Text = null;
            textRg.Text = null;
            textCpf.Text = null;
            textTelefone.Text = null;
            textEmail.Text = null;
            textRua.Text = null;
            textNumero.Text = null;
            textBairro.Text = null;
            textComp.Text = null;
            maskAdmin.Text = null;
            maskDemi.Text = null;
            maskNascimento.Text = null;
            comboStatus.Text = null;
            comboJtInic.Text = null;
            comboJtFinal.Text = null;
            maskHora1.Text = null;
            maskHora2.Text = null;
            textSalario.Text = null;
            comboFuncao.Text = null;
            textPesquisar.Text = null;

        }
        private void CarregarCombo()
        {
            List<FuncaoEnt> FuncaoFList = new List<FuncaoEnt>();
            FuncaoFList = new FuncaoModel().Lista();

            foreach (var item in FuncaoFList)
            {
                comboFuncao.Items.Add(item.Descricao);
            }
        }

        private void checDadosAdiconais_CheckedChanged(object sender, EventArgs e)
        {
            sound1();
            if (groupDadosAdicionais.Visible == false)
            {
                groupDadosAdicionais.Visible = true;
            }
            else
            {
                groupDadosAdicionais.Visible = false;
            }
        }

        private void Moeda(ref TextBox txt)
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
        private void textSalario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Moeda(ref textSalario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Salvar";
            HabilitarCampos();
            LimparCampos();
            textNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            sound1();
            if (textCod.Text == "")
            {
                sound3();
                MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                return;
            }
            opc = "Editar";
            HabilitarCampos();
            textNome.Focus();
            btnSalvar.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            sound1();
            try
            {
                if (textCod.Text == Convert.ToString(null) || textNome.Text == "")
                {
                    sound3();
                    MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                DialogResult result1 = MessageBox.Show("Confima a Exclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    objTabela.Id = Convert.ToInt32(textCod.Text);
                    int x = FuncionarioModel.Excluir(objTabela);

                    if (x > 0)
                    {
                        sound2();
                        LimparCampos();
                        DesabilitarCampos();
                        CarregarGrid();
                        MessageBox.Show(string.Format("Registro  excluído com sucesso!"));
                    }
                    else
                    {
                        MessageBox.Show("Error ao Tentar Excluir o Registro");
                    }
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um error ao excluir o registro: " + ex.Message);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sound1();
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
                textPesquisar.Visible = true;
                textPesquisar.Text = null;
                textPesquisar.Enabled = true;
                textPesquisar.Focus();
            }
            else
            {
                pictureBox1.Visible = false;
                textPesquisar.Visible = false;
                textPesquisar.Text = null;
                textPesquisar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();
            textPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sound1();
            switch (opc)
            {
                case "Salvar":
                    try
                    {
                        DialogResult result1 = MessageBox.Show("Confirma a inclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            objTabela.Nome = textNome.Text;
                            objTabela.Rg = textRg.Text;
                            objTabela.Cpf = textCpf.Text;
                            objTabela.Telefone = textTelefone.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.Rua = textRua.Text;
                            objTabela.Numero = textNumero.Text;
                            objTabela.Bairro = textBairro.Text;
                            objTabela.Numero = textNumero.Text;
                            objTabela.Comp = textComp.Text;

                                objTabela.Admissao = maskAdmin.Text;
                                objTabela.Demissao = maskDemi.Text;
                                objTabela.Nascimento = maskNascimento.Text;

                            objTabela.Status = comboStatus.Text;
                            objTabela.JtInic = comboJtInic.Text;
                            objTabela.JtFinal = comboJtFinal .Text;
                            objTabela.Hora1 = maskHora1.Text;
                            objTabela.Hora2 = maskHora2.Text;
                            objTabela.Salario = textSalario.Text;
                            objTabela.Id_funcao = id_funcao;

                            int x = FuncionarioModel.Inseir(objTabela);

                            if (x > 0)
                            {
                                sound4();
                                MessageBox.Show("Registro cadastrado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                LimparCampos();
                                DesabilitarCampos();
                                CarregarGrid();
                                btnSalvar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar cadastrar Funcionário!", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um error tentar salvar REGISTRO:" + ex.Message);
                       }
                    break;

                case "Editar":
                    try
                    {
                        DialogResult result2 = MessageBox.Show("Confima a Edição do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result2 == DialogResult.Yes)
                        {
                            objTabela.Id = Convert.ToInt32(textCod.Text);
                            objTabela.Nome = textNome.Text;
                            objTabela.Rg = textRg.Text;
                            objTabela.Cpf = textCpf.Text;
                            objTabela.Telefone = textTelefone.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.Rua = textRua.Text;
                            objTabela.Numero = textNumero.Text;
                            objTabela.Bairro = textBairro.Text;
                            objTabela.Numero = textNumero.Text;
                            objTabela.Comp = textComp.Text;
                            
                                objTabela.Admissao = maskAdmin.Text;
                                objTabela.Demissao = maskDemi.Text;
                                objTabela.Nascimento = maskNascimento.Text;
                            
                            objTabela.Status = comboStatus.Text;
                            objTabela.JtInic = comboJtInic.Text;
                            objTabela.JtFinal = comboJtFinal.Text;
                            objTabela.Hora1 = maskHora1.Text;
                            objTabela.Hora2 = maskHora2.Text;
                            objTabela.Salario = textSalario.Text;
                            objTabela.Id_funcao = id_funcao;

                            int x = FuncionarioModel.Editar(objTabela);

                            if (x > 0)
                            {
                                sound4();
                                MessageBox.Show("Registro Editado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                LimparCampos();
                                DesabilitarCampos();
                                CarregarGrid();
                                btnSalvar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar Editar o Registro", "Aviso!", MessageBoxButtons.OK);
                                btnSalvar.Enabled = false;
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Editar ERROR: " + ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                if (comboFuncao.Text == "")
                {
                    return;
                }

                if (comboFuncao.SelectedIndex != -1 && opc == "Editar")
                { btnSalvar.Enabled = true; }

                try
                {

                    con.ConnectionString = Settings.Default.dbpetsepetsConnectionString;
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Funcao WHERE descricao = '" + comboFuncao.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        id_funcao = Convert.ToInt32(dr["id"].ToString());
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao carregar Registro Funcao:  no comboBox!  " + ex.Message);
                }
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            CarregarCombo();
            CarregarGrid();
            DesabilitarCampos();
            ContentmaskAdmin = maskAdmin.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textCod.Text = codId.ToString("D5");
                textNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textRg.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textCpf.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textTelefone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textRua.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textNumero.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBairro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textComp.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                maskAdmin.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                maskDemi.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                maskNascimento.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

                comboStatus.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                comboJtInic.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                comboJtFinal.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                maskHora1.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                maskHora2.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                textSalario.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                comboFuncao.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DataGrid: TESTE! " + ex.Message);
            }


        }

        private void textPesquisar_OnValueChanged(object sender, EventArgs e)
        {
            if (textPesquisar.Text == "")
            {
                CarregarGrid();
                return;
            }
            else
            {
                try
                {
                    objTabela.Nome = textPesquisar.Text;
                    List<FuncionarioEnt> lista = new List<FuncionarioEnt>();
                    lista = new FuncionarioModel().Buscar(objTabela);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = lista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao Listar Dados: " + ex.Message);
                }
            }
        }
        private void textCpf_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textCpf.Text.Length == 11)
                {
                    textCpf.Text = FormatCnpjCpf.FormatCPF(textCpf.Text);
                    textTelefone.Focus();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void textTelefone_OnValueChanged(object sender, EventArgs e)
        {
             if(textTelefone.Text.Length == 11) 
             {
                textTelefone.Text = FormatCnpjCpf.FormatCelular(textTelefone.Text);
                textEmail.Focus();
             }
        }

        private void textNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textRg.Focus();
            }
        }
        private void textCpf_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                textTelefone.Focus();
            }
        }

        private void textRg_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                textCpf.Focus();
            }
        }
        private void textTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textEmail.Focus();
            }
        }
        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (FormatCnpjCpf.ValidarEmail(textEmail.Text) == false)
                {
                    sound3();
                    MessageBox.Show("Email com formato incorreto!", "Aviso!!!", MessageBoxButtons.OK);
                    textEmail.Text = "";
                    textEmail.Focus();
                    return;
                }
                textRua.Focus();
            }
        }
        private void textNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBairro.Focus();
            }
        }
        private void textRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textNumero.Focus();
            }
        }

        private void textBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textComp.Focus();
            }
        }
        private void textComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboFuncao.Focus();
            }
        }
        private void comboFuncao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSalvar.Focus();
            }
        }
    }
}
