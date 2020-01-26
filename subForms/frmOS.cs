using Bunifu.Framework.UI;
using Entidades;
using Model;
using SistemaPet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.subForms
{
    public partial class frmOS : Form
    {
        
        string pasta_aplicacao = "";

        private string opc = "";
        public frmOS()
        {
            InitializeComponent();
        }
        private void LimparCampos()
        {
            foreach (Control ctrl in panel3.Controls)
            {
                if (ctrl is CheckBox)
                {

                    ((CheckBox)ctrl).Checked = false;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Text = string.Empty;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = string.Empty;
                }
            }
        }
        private void CarregarGrid()
        {
            /*try
            {
                List<ServicoEnt> lista = new List<ServicoEnt>();
                lista = new ServicoModel().Lista();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "VALOR";
                dataGridView1.Columns[2].HeaderText = "RECEBEMOSDE";
                dataGridView1.Columns[3].HeaderText = "IMPORTÂNCIA";
                dataGridView1.Columns[4].HeaderText = "IMPORTÂNCIA...";
                dataGridView1.Columns[5].HeaderText = "REFERENTE";
                dataGridView1.Columns[6].HeaderText = "REFERENTE...";
                dataGridView1.Columns[7].HeaderText = "EMITENTE";
                dataGridView1.Columns[8].HeaderText = "CNPJ";
                dataGridView1.Columns[9].HeaderText = "DATA/HORA";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }*/
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
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\caixa.wav");
            player.Play();
        }

        private void LimparCamposCheck()
        {
            if (checkServico1.Checked == false)
            {
                comboServico2.Text = string.Empty;
                checkServico2.Checked = false;
                textValor2.Text = string.Empty;
            }
            
            if (checkServico2.Checked == false)
            {
                comboServico3.Text = string.Empty;
                checkServico3.Checked = false;
                textValor3.Text = string.Empty;
            }

            if (checkServico3.Checked == false)
            {
                comboServico4.Text = string.Empty;
                textValor4.Text = string.Empty;
            }
        }
        private void DesabilitarCampos()
        {
            foreach (Control ctrl in panel3.Controls)
            {
                if (ctrl is ComboBox)
                {

                    ((ComboBox)ctrl).Enabled = false;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Enabled = false;
                }

                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = false;
                }
            }
        }


        private void HabilitarCampos()
        {
            foreach (Control ctrl in panel3.Controls)
            {
                if (ctrl is ComboBox)
                {

                    ((ComboBox)ctrl).Enabled = true;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Enabled = true;
                }

                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = true;
                }
            }

            fixaEnablecCampos();

        }

        private void fixaEnablecCampos() {

            textValor1.Enabled = false;
            textValor2.Enabled = false;
            textValor3.Enabled = false;
            textValor4.Enabled = false;

        }



        private void atualizaData()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            string data = diasemana + ", " + dia + " de " + mes + " de " + ano + ".";
            lbldata.Text = data;
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            //btnSalvar.Enabled = false;
            CarregarComboNomePet();
            CarregarComboServicos();
            CarregarGrid();
            //SelectPrinter();
            atualizaData();
            DesabilitarCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sound1();
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
                textPesquisar.Focus();
            }
            else
            {
                groupBox1.Visible = false;
                textPesquisar.Text = string.Empty;
            }


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            sound1();
            btnSalvar.Enabled = true;
            opc = "Salvar";
            HabilitarCampos();
            LimparCampos();
            atualizaData();
            //textValorRecibo.Text = Convert.ToDouble(textValorRecibo.Text).ToString("C");
            comboNomePet.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();
            btnSalvar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnPrepararImpressao_Click(object sender, EventArgs e)
        {

        }

        private void checkServico1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkServico1.Checked == true)
            {
                sound1();
                comboServico2.Visible = true;
                checkServico2.Visible = true;
                textValor2.Visible = true;
            }
            else
            {
                LimparCamposCheck();
                comboServico2.Visible = false;
                checkServico2.Visible = false;
                textValor2.Visible = false;
            }
        }
        private void checkServico2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkServico2.Checked == true)
            {
                sound1();
                comboServico3.Visible = true;
                checkServico3.Visible = true;
                textValor3.Visible = true;
            }
            else
            {
                LimparCamposCheck();
                comboServico3.Visible = false;
                checkServico3.Visible = false;
                textValor3.Visible = false;
            }
        }
        private void checkServico3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkServico3.Checked == true)
            {
                sound1();
                comboServico4.Visible = true;
                textValor4.Visible = true;
            }
            else
            {
                LimparCamposCheck();
                comboServico4.Visible = false;
                textValor4.Visible = false;
            }
        }
        private void CarregarComboNomePet()
        {
            List<AnimalEnt> AnimalFList = new List<AnimalEnt>();
            AnimalFList = new AnimalModel().Lista();

            foreach (var item in AnimalFList)
            {
                comboNomePet.Items.Add(item.Nome);
            }
        }


        private void CarregarComboServicos()
        {
            List<ServicoEnt> ServicoFList = new List<ServicoEnt>();
            ServicoFList = new ServicoModel().Lista();

            foreach (var item in ServicoFList)
            {
                comboServico1.Items.Add(item.Servico);
                comboServico2.Items.Add(item.Servico);
                comboServico3.Items.Add(item.Servico);
                comboServico4.Items.Add(item.Servico);
            }
        }

        private void comboNomePet_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                if (comboNomePet.Text == string.Empty) 
                { return; }

                try
                {
                    con.ConnectionString = Settings.Default.dbpetsepetsConnectionString;
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Animal WHERE nome = '" + comboNomePet.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        textEspecie.Text = dr["especie"].ToString();
                        textRaca.Text = dr["raca"].ToString();
                        textProprietario.Text = dr["proprietario"].ToString();
                        textTelefone.Text = dr["telefone"].ToString();
                        textEmail.Text = dr["email"].ToString();
                        textCespeciais.Text = dr["cuidados_esp"].ToString();
                        textObservacao.Text = dr["alergico"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao carregar Registro: " + ex.Message);
                }
            }

        }

        private void SelectIndexComboServico(int index) 
        {
            sound4();
            using (SqlConnection con = new SqlConnection())
            {
                
                if (comboServico1.Text == string.Empty)
                { 
                    return; 
                }

                try
                {
                    con.ConnectionString = Settings.Default.dbpetsepetsConnectionString;
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    if (index == 1)
                    {
                        cmd.CommandText = "SELECT * FROM Servico WHERE servico = '" + comboServico1.SelectedItem.ToString() + "'";
                    } else if (index == 2) 
                    {
                        cmd.CommandText = "SELECT * FROM Servico WHERE servico = '" + comboServico2.SelectedItem.ToString() + "'";
                    }
                    else if (index == 3)
                    {
                        cmd.CommandText = "SELECT * FROM Servico WHERE servico = '" + comboServico3.SelectedItem.ToString() + "'";
                    }
                    else if (index == 4)
                    {
                        cmd.CommandText = "SELECT * FROM Servico WHERE servico = '" + comboServico4.SelectedItem.ToString() + "'";
                    }

                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    if (index == 1)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            textValor1.Text = dr["valor"].ToString();
                        }
                        con.Close();
                    }
                    else if (index == 2) 
                    {
                     
                        foreach (DataRow dr in dt.Rows)
                        {
                            textValor2.Text = dr["valor"].ToString();
                        }
                        con.Close();

                    }else if(index == 3) 
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            textValor3.Text = dr["valor"].ToString();
                        }
                        con.Close();

                    }else if(index == 4) 
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            textValor4.Text = dr["valor"].ToString();
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao carregar Registro: " + ex.Message);
                }
            }
        }


        private void comboServico1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectIndexComboServico(1);
        }

        private void comboServico2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectIndexComboServico(2);
        }

        private void comboServico3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectIndexComboServico(3);
        }

        private void comboServico4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectIndexComboServico(4);
        }
    }
}
