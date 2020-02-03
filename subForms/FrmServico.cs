using Entidades;
using Model;
using SistemaPet.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.subForms
{
    public partial class frmServico : Form
    {
        ServicoEnt objTabela = new ServicoEnt();
        string pasta_aplicacao = "";
        private string opc = "";

        public frmServico()
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

        private void HabilitarCampos()
        {
            textCod.Enabled = false;
            textServico.Enabled = true;
            textValor.Enabled = true;

            
        }
        private void DesabilitarCampos()
        {
            textCod.Enabled = false;
            textServico.Enabled = false;
            textValor.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void LimparCampos()
        {
            textCod.Text = null;
            textServico.Text = null;
            textPesquisar.Text = null;
            textValor.Text = Convert.ToString(0);

        }
        private void CarregarGrid()
        {
            try
            {
                List<ServicoEnt> colecao = new List<ServicoEnt>();
                colecao = new ServicoModel().Lista();

                DataTable lista;
                lista = new ServicoModel().ListaDataTable();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;


                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "SERVIÇO";
                dataGridView1.Columns[2].HeaderText = "VALOR";

                dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }

        }




        private void btnNovo_Click(object sender, EventArgs e)
        {
                sound1();
                opc = "Salvar";
                HabilitarCampos();
                LimparCampos();
                textServico.Focus();
                btnSalvar.Enabled = true;
            
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            sound1();
            if (textCod.Text == "")
            {
                sound4();
                MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                return;
            }
            opc = "Editar";
            HabilitarCampos();
            textServico.Focus();
            btnSalvar.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            sound1();
            try
            {
                if (textCod.Text == Convert.ToString(null) || textServico.Text == "")
                {
                    sound3();
                    MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                DialogResult result1 = MessageBox.Show("Confima a Exclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    objTabela.Id = Convert.ToInt32(textCod.Text);
                    int x = ServicoModel.Excluir(objTabela);

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
                sound3();
                MessageBox.Show("Registro vinculado a outra tabela!", "Exclusão Negada!", MessageBoxButtons.OK);
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
                textPesquisar.Focus();
            }
            else
            {
                pictureBox1.Visible = false;
                textPesquisar.Visible = false;
                textPesquisar.Text = "";
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

            if (textServico.Text == string.Empty || textValor.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {
                switch (opc)
                {
                    case "Salvar":
                        try
                        {
                            DialogResult result1 = MessageBox.Show("Confima salvação do registro?", "Aviso!", MessageBoxButtons.YesNo);
                            if (result1 == DialogResult.Yes)
                            {
                                objTabela.Servico = textServico.Text;
                                objTabela.Valor = textValor.Text;

                                int x = ServicoModel.Inseir(objTabela);

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
                                    MessageBox.Show("Error ao Tentar cadastrar Usuário!", "Aviso!", MessageBoxButtons.OK);
                                }
                            }
                            else { return; }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um error tentar salvar Registro:" + ex.Message);
                        }
                        break;

                    case "Editar":
                        try
                        {
                            DialogResult result2 = MessageBox.Show("Confima a Edição do registro?", "Aviso!", MessageBoxButtons.YesNo);
                            if (result2 == DialogResult.Yes)
                            {
                                objTabela.Id = Convert.ToInt32(textCod.Text);
                                objTabela.Servico = textServico.Text;
                                objTabela.Valor = textValor.Text;

                                int x = ServicoModel.Editar(objTabela);

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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DesabilitarCampos();
                int codId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textCod.Text = codId.ToString("D5");
                textServico.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textValor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DataGrid: " + ex.Message);
            }
        }


        private void textValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormatCnpjCpf.Moeda(ref textValor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textServico_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                textValor.Focus();
            }

        }

        private void textValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSalvar.Focus();
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
                    objTabela.Servico  = textPesquisar.Text;
                    List<ServicoEnt> lista = new List<ServicoEnt>();
                    lista = new ServicoModel().Buscar(objTabela);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = lista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao Listar Dados: " + ex.Message);
                }
            }
        }
    }
}
