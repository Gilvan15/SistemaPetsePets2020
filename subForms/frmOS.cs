using Bunifu.Framework.UI;
using Entidades;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            foreach (Control ctrl in panel2.Controls)
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
            foreach (Control ctrl in panel2.Controls)
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
            foreach (Control ctrl in panel2.Controls)
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
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();
            btnSalvar.Enabled = false;

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

        private void comboNomePet_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            //btnSalvar.Enabled = false;
            CarregarGrid();
            //SelectPrinter();
            atualizaData();
            DesabilitarCampos();
        }
    }
}
