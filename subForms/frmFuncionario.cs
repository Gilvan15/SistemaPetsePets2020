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

namespace SistemaPet.subForms
{
    public partial class frmFuncionario : Form
    {
        UsuarioEnt objTabela = new UsuarioEnt();
        FuncaoEnt objFuncao = new FuncaoEnt();

        string pasta_aplicacao = "";
        private string opc = "";

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
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\avisovoz.wav");
            player.Play();
        }


        private void CarregarGrid()
        {
            try
            {
                DataTable lista;
                lista = new UsuarioModel().ListaJonn();
                
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                /*
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "NOME";
                dataGridView1.Columns[2].HeaderText = "EMAIL";
                dataGridView1.Columns[3].HeaderText = "USUÁRIO";
                dataGridView1.Columns[4].HeaderText = "SENHA";
                dataGridView1.Columns[5].HeaderText = "FUNÇÃO";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //dataGridView1.Columns[5].Visible = false;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }
        }


        private void HabilitarCampos()
        {
            /*
            textNome.Enabled = true;
            textEmail.Enabled = true;
            textRg.Enabled = true;
            textCpf.Enabled = true;
            textTelefone.Enabled = true;
            textEmail.Enabled = true;
            textRua.Enabled = true;
            textNumero.Enabled = true;
            textBairro.Enabled = true;
            textComp.Enabled = true;
            comboFuncao.Enabled = true;
            maskAdmin.Enabled = true;
            maskDemi.Enabled = true;
            maskNascimento.Enabled = true;
            comboStatus.Enabled = true;
            comboJtInic.Enabled = true;
            comboJtFinal.Enabled = true;
            maskHora1.Enabled = true;
            maskHora2.Enabled = true;
            textSalario.Enabled = true;
            textPesquisar.Enabled = true;
            btnSalvar.Enabled = true;
            */

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
            textCod.Enabled = false; 
            btnSalvar.Enabled = true;

        }
        private void DesabilitarCampos()
        {
            textCod.Enabled = false;
            /*
            textNome.Enabled = false;
            textEmail.Enabled = false;
            textRg.Enabled = false;
            textCpf.Enabled = false;
            textTelefone.Enabled = false;
            textEmail.Enabled = false;
            textRua.Enabled = false;
            textNumero.Enabled = false;
            textBairro.Enabled = false;
            textComp.Enabled = false;
            comboFuncao.Enabled = false;
            maskAdmin.Enabled = false;
            maskDemi.Enabled = false;
            maskNascimento.Enabled = false;
            comboStatus.Enabled = false;
            comboJtInic.Enabled = false;
            comboJtFinal.Enabled = false;
            maskHora1.Enabled = false;
            maskHora2.Enabled = false;
            textSalario.Enabled = false;
            textPesquisar.Enabled = false;
            */
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
            maskHora1.Text = null;
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
                    int x = UsuarioModel.Excluir(objTabela);

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
                textPesquisar.Focus();
            }
            else
            {
                pictureBox1.Visible = false;
                textPesquisar.Visible = false;
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

        }
    }
}
