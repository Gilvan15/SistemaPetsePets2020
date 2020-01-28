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
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.subForms
{
    public partial class frmOS : Form
    {

        private PrintDocument printDocument1 = new PrintDocument();
        Bitmap memoryImage;
        string pasta_aplicacao = "";
        string nomeImpessora = "";
        private string opc = "";
        string valor;
        OSEnt objTabela = new OSEnt();

        int verify = 1;
        decimal valor1 = 0;
        decimal valor2 = 0;
        decimal valor3 = 0;
        decimal valor4 = 0;
        decimal desconto = 0;
        decimal valorTotal = 0;
        
        public frmOS()
        {
            InitializeComponent();
        }
        public frmOS(string vtextCod, string vcombonomepet, string vtextEspecie, string vtextraca,
            string vtextproprietario, string vtexttelefone, string vtextemail, string vtextcespeciais,
            string vtextalergico, string vtextobservacao, string comboservico1, Boolean checkservico1, string vtextvalor1,
            string comboservico2, Boolean checkservico2, string vtextvalor2, string comboservico3, Boolean checkservico3, string vtextvalor3,
            string comboservico4, string vtextvalor4, string vdesconto, string vvalortotal)
        {
            InitializeComponent();
            textCod.Text = vtextCod;
            comboNomePet.Text = vcombonomepet;
            textEspecie.Text = vtextEspecie;
            textRaca.Text = vtextraca;
            textProprietario.Text = vtextproprietario;
            textTelefone.Text = vtexttelefone;
            textEmail.Text = vtextemail;
            textCespeciais.Text = vtextcespeciais;
            textAlergico.Text = vtextalergico;
            textObservacao.Text = vtextobservacao;

            comboServico1.Text = comboservico1;
            checkServico1.Checked = checkservico1;
            textValor1.Text = vtextvalor1;

            comboServico2.Text = comboservico2;
            checkServico2.Checked = checkservico2;
            textValor2.Text = vtextvalor2;

            comboServico3.Text = comboservico3;
            checkServico3.Checked = checkservico3;
            textValor3.Text = vtextvalor3;

            comboServico4.Text = comboservico4;
            textValor4.Text = vtextvalor4;

            textDesconto.Text = vdesconto;
            textValorTotal.Text = vvalortotal;
            //DesabilitarCampos();
            apenasLeitura();
            //HabilitarCampos();
            this.Size = new Size(880,650);
            this.AutoScroll = false;
            panel2.Visible = false;
            hiderButtons();
        }

        private void hiderButtons()
        {
            btnNovo.Visible = false;
            dataGridView1.Visible = false;
            btnPrepararImpressao.Visible = false;
            btnFecharRecibo.Visible = true;
            btnImprimir.Visible = true;
            comboPrinter1.Visible = true;
            labelSelecionePrint.Visible = true;
        }


        private void apenasLeitura()
        {

            foreach (Control ctrl in panel3.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).ReadOnly = true;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Enabled = false;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                }

            }
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

                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
            }
            verify = 1;

        }
        private void CarregarGrid()
        {
            try
            {
                DataTable lista;
                lista = new OsModel().ListaDataTable();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "NOME PET";
                dataGridView1.Columns[2].HeaderText = "ESPÉCIE";
                dataGridView1.Columns[3].HeaderText = "RAÇA";
                dataGridView1.Columns[4].HeaderText = "DONO";
                dataGridView1.Columns[5].HeaderText = "TELEFONE";
                dataGridView1.Columns[6].HeaderText = "EMAIL";
                dataGridView1.Columns[7].HeaderText = "CUID.ESPECIAIS";
                dataGridView1.Columns[8].HeaderText = "ALERGICO";
                dataGridView1.Columns[9].HeaderText = "OBS";
                dataGridView1.Columns[10].HeaderText = "SERVICO1";
                dataGridView1.Columns[11].HeaderText = "CHECKADO1";
                dataGridView1.Columns[12].HeaderText = "VALORSERV1";

                dataGridView1.Columns[13].HeaderText = "SERVICO2";
                dataGridView1.Columns[14].HeaderText = "CHECKADO2";
                dataGridView1.Columns[15].HeaderText = "VALORSERV2";

                dataGridView1.Columns[16].HeaderText = "SERVICO3";
                dataGridView1.Columns[17].HeaderText = "CHECKADO3";
                dataGridView1.Columns[18].HeaderText = "VALORSERV3";

                dataGridView1.Columns[19].HeaderText = "SERVICO4";
                dataGridView1.Columns[20].HeaderText = "VALORSERV4";

                dataGridView1.Columns[21].HeaderText = "DATA";
                dataGridView1.Columns[22].HeaderText = "DESCONTO";
                dataGridView1.Columns[23].HeaderText = "VALORTOTAL";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 7; i <= 20; i++)
                {
                    dataGridView1.Columns[i].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }
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

                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
                }
            }
            btnSalvar.Enabled = false;
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

                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }
            }
            fixaEnablecCampos();
        }

        private void fixaEnablecCampos() {
            textValor1.Enabled = false;
            textValor2.Enabled = false;
            textValor3.Enabled = false;
            textValor4.Enabled = false;
            textCod.Enabled = false; 
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
            SelectPrinter();
            CarregarGrid();
            //SelectPrinter();
            atualizaData();
            DesabilitarCampos();
        }

        private void SelectPrinter()
        {
            comboPrinter1.Items.Clear();
            foreach (string impressora in PrinterSettings.InstalledPrinters)
            {
                comboPrinter1.Items.Add(impressora.Trim().ToLower());
            }
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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();
            btnSalvar.Enabled = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sound1();
            if (opc == "") { return; }

            if(comboNomePet.Text == string.Empty){ sound3(); MessageBox.Show("Selecione um PET antes de salvar!"); return;}

            if (textValorTotal.Text == string.Empty) { sound3();  MessageBox.Show("Lançe algum valor na OS, antes de salvar!"); return; }

            switch (opc)
            {
                case "Salvar":
                    try
                    {
                        DialogResult result1 = MessageBox.Show("Confima a inclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {

                            objTabela.Nomepet = comboNomePet.Text;
                            objTabela.Especie = textEspecie.Text;
                            objTabela.Raca = textRaca.Text;
                            objTabela.Proprietario = textProprietario.Text;
                            objTabela.Telefone = textTelefone.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.C_especiais = textCespeciais.Text;
                            objTabela.Alergico = textAlergico.Text;
                            objTabela.Observacao = textObservacao.Text;
                            
                            objTabela.Servico1   = comboServico1.Text;
                            if(checkServico1.Checked == true){objTabela.Checkserv1 = "1";}else{objTabela.Checkserv1 = "0";}
                            objTabela.Valorserv1 = textValor1.Text;

                            objTabela.Servico2 = comboServico2.Text;
                            if (checkServico2.Checked == true) { objTabela.Checkserv2 = "1"; } else { objTabela.Checkserv2 = "0"; }
                            objTabela.Valorserv2 = textValor2.Text;

                            objTabela.Servico3 = comboServico3.Text;
                            if (checkServico3.Checked == true) { objTabela.Checkserv3 = "1"; } else { objTabela.Checkserv3 = "0"; }
                            objTabela.Valorserv3 = textValor3.Text;
                            
                            objTabela.Servico4 = comboServico4.Text;
                            objTabela.Valorserv4 = textValor4.Text;
                            objTabela.Data = DateTime.Now;

                            objTabela.Desconto= textDesconto.Text;
                            objTabela.Valortotal = textValorTotal.Text;

                            int x = OsModel.Inseir(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show("Registro cadastrado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                LimparCampos();
                                DesabilitarCampos();
                                CarregarGrid();
                                btnSalvar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar cadastrar Usuário!", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um error tentar salvar Registro:" + ex.Message);
                        btnSalvar.Enabled = false;
                    }
                    break;

                case "Editar":
                    
                    try
                    {
                        DialogResult result2 = MessageBox.Show("Confima a Edição do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result2 == DialogResult.Yes)
                        {
                            objTabela.Id = Convert.ToInt32(textCod.Text);
                            objTabela.Nomepet = comboNomePet.Text;
                            objTabela.Especie = textEspecie.Text;
                            objTabela.Raca = textRaca.Text;
                            objTabela.Proprietario = textProprietario.Text;
                            objTabela.Telefone = textTelefone.Text;
                            objTabela.Email    = textEmail.Text;
                            objTabela.C_especiais = textCespeciais.Text;
                            objTabela.Alergico = textAlergico.Text;
                            objTabela.Observacao = textObservacao.Text;

                            objTabela.Servico1 = comboServico1.Text;
                            if (checkServico1.Checked == true) { objTabela.Checkserv1 = "1"; } else { objTabela.Checkserv1 = "0"; }
                            objTabela.Valorserv1 = textValor1.Text;

                            objTabela.Servico2 = comboServico2.Text;
                            if (checkServico2.Checked == true) { objTabela.Checkserv2 = "1"; } else { objTabela.Checkserv2 = "0"; }
                            objTabela.Valorserv2 = textValor2.Text;

                            objTabela.Servico3 = comboServico3.Text;
                            if (checkServico3.Checked == true) { objTabela.Checkserv3 = "1"; } else { objTabela.Checkserv3 = "0"; }
                            objTabela.Valorserv3 = textValor3.Text;

                            objTabela.Servico4 = comboServico4.Text;
                            objTabela.Valorserv4 = textValor4.Text;
                            objTabela.Data = DateTime.Now;

                            objTabela.Desconto = textDesconto.Text;
                            objTabela.Valortotal = textValorTotal.Text;
                            int x = OsModel.Editar(objTabela);

                            if (x > 0)
                            {
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            verify = 1;
            sound1();
            if (textCod.Text == "")
            {
                sound3();
                MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                return;
            }
            opc = "Editar";
            HabilitarCampos();
            comboNomePet.Focus();
            btnSalvar.Enabled = true;
        }
        public void AbrirsegundoPlano()
        {
            frmPanodeFundo.AbrirPanodeFundo();
        }
        public void FecharPanodeFundo()
        {
            int tot = Application.OpenForms.OfType<frmRecibo>().Count();
            //MessageBox.Show("total de janelas abertas: " + tot);
            for (int i = 0; i <= tot; i++)
            {
                frmPanodeFundo.FecharPanodeFundo();
            }
        }
        private void btnPrepararImpressao_Click(object sender, EventArgs e)
        {
         
            verify = 0;
            //sound1();
            if (Application.OpenForms.OfType<frmOS>().Count() > 2)
            {
                MessageBox.Show("O Recibo já está aberto!");
            }
            else
            {
                if (textCod.Text == string.Empty)
                {
                    sound3();
                    MessageBox.Show("Selecione um registro ou Salve primeiro para preparar a impressão ok!", "AVISO!", MessageBoxButtons.OK);
                    return;
                }

                AbrirsegundoPlano();

                Form frmrec = new frmOS(textCod.Text, comboNomePet.Text, textEspecie.Text, 
                    textRaca.Text, textProprietario.Text, textTelefone.Text, textEmail.Text, textCespeciais.Text, 
                    textAlergico.Text, textObservacao.Text, comboServico1.Text, checkServico1.Checked, textValor1.Text,
                    comboServico2.Text, checkServico2.Checked, textValor2.Text, comboServico3.Text, checkServico3.Checked, textValor3.Text,
                    comboServico4.Text, textValor4.Text, textDesconto.Text, textValorTotal.Text);
                frmrec.TopMost = true;
                frmrec.StartPosition = FormStartPosition.CenterScreen;
                frmrec.Show();
            }

        }      

        private void checkServico3_CheckedChanged(object sender, EventArgs e)
        {
            
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
                        textAlergico.Text = dr["alergico"].ToString();
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
        private void verifyValue() 
        {
            if(textValor1.Text == string.Empty) { return; }


            if (textValor2.Text == string.Empty)
            {
                valorTotal = (valor1);
            }
            else if (textValor2.Text != string.Empty && textValor3.Text == string.Empty)
            {
                valor2 = Convert.ToDecimal(textValor2.Text);
                valorTotal = (valor1 + valor2);
            }
            else if (textValor2.Text != string.Empty && textValor3.Text != string.Empty && textValor4.Text == string.Empty)
            {
                valor2 = Convert.ToDecimal(textValor2.Text);
                valor3 = Convert.ToDecimal(textValor2.Text);
                valorTotal = (valor1 + valor2 + valor3);
            }
            else if (textValor2.Text != string.Empty && textValor3.Text != string.Empty && textValor4.Text != string.Empty)
            {
                valor2 = Convert.ToDecimal(textValor2.Text);
                valor3 = Convert.ToDecimal(textValor3.Text);
                valor4 = Convert.ToDecimal(textValor4.Text);
                valorTotal = (valor1 + valor2 + valor3 + valor4);
            }

            if(textDesconto.Text != string.Empty || textDesconto.Text == "0,00" ) 
            {
                desconto = Convert.ToDecimal(textDesconto.Text);
                textValorTotal.Text = Convert.ToString(valorTotal - desconto );
            }
            else 
            {
                textValorTotal.Text = Convert.ToString(valorTotal);
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
        
        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0, 800.0F, 600.0F);
        }

        private void ReadyCheck()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");

            foreach (ManagementObject printer in searcher.Get())
            {
                string printerName = printer["Name"].ToString().ToLower();

                if (printer["Name"].ToString().ToLower() == nomeImpessora)
                {
                    if (printer["WorkOffline"].ToString().ToLower().Equals("true") && printer["Default"].ToString().ToLower().Equals("true"))
                    {
                        MessageBox.Show("A Impressora está Offline: Ligue a impressora:" + printerName.ToUpper());
                        return;
                    }
                    else
                    {
                        //MessageBox.Show("Online: " + printerName);
                        try
                        {
                            sound1();
                            btnImprimir.Visible = false;
                            btnFecharRecibo.Visible = false;
                            comboPrinter1.Visible = false;
                            labelSelecionePrint.Visible = false;
                            CaptureScreen();
                            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                            printDocument1.Print();
                            btnImprimir.Visible = true;
                            btnFecharRecibo.Visible = true;
                            comboPrinter1.Visible = true;
                            labelSelecionePrint.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Error de Impressão: "  + ex);
                        }
                    }
                }
            }
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
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

        private void btnFecharRecibo_Click(object sender, EventArgs e)
        {
            sound1();
            comboPrinter1.Visible = false;
            this.Close();
            FecharPanodeFundo();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (comboPrinter1.Text == string.Empty)
            {
                sound3();
                MessageBox.Show("Selecione uma Impressora Ativa:");
                return;
            }
            nomeImpessora = comboPrinter1.Text;
            ReadyCheck();

        }

        private void comboServico1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (verify == 1) { sound4(); }
            SelectIndexComboServico(1);
        }

        private void checkServico1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkServico1.Checked == true)
            {
                if (verify == 1) { sound1(); }

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

        private void comboServico2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (verify == 1) { sound4(); }
            SelectIndexComboServico(2);
        }
        private void checkServico2_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkServico2.Checked == true)
            {
                if (verify == 1) { sound1(); }
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
        private void comboServico3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (verify == 1) { sound4(); }
            SelectIndexComboServico(3);
        }
        private void checkServico3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkServico3.Checked == true)
            {
                if (verify == 1) { sound1(); }
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

        private void comboServico4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (verify == 1) { sound4(); }
            SelectIndexComboServico(4);

        }

        private void textPesquisar_OnValueChanged_1(object sender, EventArgs e)
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
                    objTabela.Nomepet = textPesquisar.Text;
                    List<OSEnt> lista = new List<OSEnt>();
                    lista = new OsModel().Buscar(objTabela);

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = lista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao Listar Dados: " + ex.Message);
                }
            }
        }
        private void comboNomePet_SelectedIndexChanged_1(object sender, EventArgs e)
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
                        textAlergico.Text = dr["alergico"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao carregar Registro: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                verify = 0;
                DesabilitarCampos();
                int codId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textCod.Text = codId.ToString("D5");
                comboNomePet.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textEspecie.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textRaca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textProprietario.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textTelefone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textCespeciais.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textAlergico.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textObservacao.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                comboServico1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[11].Value.ToString() == "1") { checkServico1.Checked = true; } else { checkServico1.Checked = false; }
                textValor1.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                comboServico2.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[14].Value.ToString() == "1") { checkServico2.Checked = true; } else { checkServico2.Checked = false; }
                textValor2.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                comboServico3.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[17].Value.ToString() == "1") { checkServico3.Checked = true; } else { checkServico3.Checked = false; }
                textValor3.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                comboServico4.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                textValor4.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                lbldata.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                textDesconto.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                textValorTotal.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DataGrid: " + ex.Message);
            }
        }
        private void textValor1_OnValueChanged_1(object sender, EventArgs e)
        {
            if (textValor1.Text == string.Empty)
            {
                valor1 = 0;
                verifyValue();
            }
            else
            {
                valor1 = Convert.ToDecimal(textValor1.Text);
                verifyValue();
            }
        }

        private void textValor2_OnValueChanged_1(object sender, EventArgs e)
        {
            if (textValor2.Text == string.Empty)
            {
                valor2 = 0;
                verifyValue();
            }
            else
            {
                valor2 = Convert.ToDecimal(textValor2.Text);
                verifyValue();
            }
        }
        private void textValor3_OnValueChanged_1(object sender, EventArgs e)
        {
            if (textValor3.Text == string.Empty)
            {
                valor3 = 0;
                verifyValue();
            }
            else
            {
                valor3 = Convert.ToDecimal(textValor3.Text);
                verifyValue();
            }
        }
        private void textValor4_OnValueChanged_1(object sender, EventArgs e)
        {
            if (textValor4.Text == string.Empty)
            {
                valor4 = 0;
                verifyValue();
            }
            else
            {
                valor4 = Convert.ToDecimal(textValor4.Text);
                verifyValue();
            }
        }
        private void textDesconto_TextChanged_1(object sender, EventArgs e)
        {
            if (textDesconto.Text == string.Empty) { return; }
            try
            {
                Moeda(ref textDesconto);
                verifyValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
