using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using AForge.Video;
using Entidades;
using Model;
using System.IO;
using SistemaPet.Properties;

namespace SistemaPet.subForms
{
    public partial class frmCadastroPet : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private bool DeviceExist = false;
        AnimalEnt objTabela = new AnimalEnt();
        private string opc = "";
        string pasta_aplicacao = "";        
        public frmCadastroPet()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
            carregarCamera();
        }
        private void DesabilitarCampos()
        {
            LimparCampos();
            comboEspecie.Enabled = false;
            textRaca.Enabled = false;
            textNome.Enabled = false;
            cbIdade.Enabled = false;
            comboBox1.Enabled = false;
            comboProprietario.Enabled = false;
            textTelefone.Enabled = false;
            textEmail.Enabled = false;
            richTextBoxCE.Enabled = false;
            textAlegMedic.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void LimparCampos()
        {
            textCod.Text = null;
            comboEspecie.Text = null;
            textRaca.Text = null;
            textNome.Text = null;
            cbIdade.Text = null;
            comboBox1.Text = null;
            comboProprietario.Text = null;
            textTelefone.Text = null;
            textEmail.Text = null;
            richTextBoxCE.Text = null;
            textAlegMedic.Text = null;
            pictureCamera.Image = Image.FromFile(pasta_aplicacao + "img\\dog1.png");
            textPesquisar.Text = null;

        }

        private void HabilitarCampos()
        {
            comboEspecie.Enabled = true;
            textRaca.Enabled = true;
            textNome.Enabled = true;
            cbIdade.Enabled = true;
            comboBox1.Enabled = true;
            comboProprietario.Enabled = true;
            textTelefone.Enabled = true;
            textEmail.Enabled = true;
            richTextBoxCE.Enabled = true;
            textAlegMedic.Enabled = true;
            btnSalvar.Enabled = true;
        }
        public void CarregarFoto()
        {
            //Reculperando a imagem do banco de dados
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = Settings.Default.dbpetsepetsConnectionString;
                    SqlCommand cn = new SqlCommand();
                    cn = new SqlCommand("SELECT Foto FROM Animal WHERE id = " + textCod.Text, con);
                    con.Open();
                    SqlDataReader dr;
                    dr = cn.ExecuteReader();
                    Image figura = null;

                    if (dr.Read())
                    {
                        if (dr["Foto"] == System.DBNull.Value)
                        {
                            MessageBox.Show("Registro sem foto!");
                            videoSource = null;
                            return;
                        }

                        byte[] foto = (byte[])dr["Foto"];
                        MemoryStream ms = new MemoryStream(foto);
                        figura = Image.FromStream(ms);
                    }
                    pictureCamera.Image = figura;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao carregar Foto: " + ex.Message);
                }
            }
        }
        private void CarregaCombo() 
        {
            List<ClientesEnt> PessoaFList = new List<ClientesEnt>();
            PessoaFList = new ClienteModel().Lista();

            foreach (var item in PessoaFList)
            {
               comboProprietario.Items.Add(item.Nome);
            }
        }
        private void CarregarGrid()
        {
            try
            {
                //List<AnimalEnt> lista = new List<AnimalEnt>();
                //lista = new AnimalModel().Lista();

                DataTable lista;
                lista = new AnimalModel().ListaDataTable();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "ESPÉCIE";
                dataGridView1.Columns[2].HeaderText = "RAÇA";
                dataGridView1.Columns[3].HeaderText = "NOME";
                dataGridView1.Columns[4].HeaderText = "PROPRIETÁRIO";
                dataGridView1.Columns[5].HeaderText = "TELEFONE";
                dataGridView1.Columns[6].HeaderText = "EMAIL";
                dataGridView1.Columns[7].HeaderText = "CUIDADOS ESPECIAIS";
                dataGridView1.Columns[8].HeaderText = "ALÉRGICO";
                dataGridView1.Columns[9].HeaderText = "FOTO";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                //dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }
        }

        private void InicarOpc()
        {
            switch (opc)
            {
                case "Buscar":

                    try
                    {
                        objTabela.Nome = textPesquisar.Text;
                        List<AnimalEnt> lista = new List<AnimalEnt>();
                        lista = new AnimalModel().Buscar(objTabela);
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = lista;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ao Listar Dados: " + ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }

        public void sound2()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\Limpar.wav");
            player.Play();
        }

        public void sound3()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\aviso.wav");
            player.Play();
        }
        public void sound4()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\klickfoto.wav");
            player.Play();
        }
        public void sound5()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\stopcamera.wav");
            player.Play();
        }
        private void frmCadastroPet_Load(object sender, EventArgs e)
        {
            CarregaComboIdade();
            CarregaCombo();
            CarregarGrid();
            DesabilitarCampos();
        }

        private void CarregaComboIdade() 
        {
            for (int x = 1; x <= 100; x++) 
            {
                cbIdade.Items.Add(x);
                cbIdade2.Items.Add(x);

            }
        }

        private void carregarCamera() 
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                comboCamera.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    comboCamera.Items.Add(device.Name);
                }
                comboCamera.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                comboCamera.Items.Add("Nenhum dispositivo encontrado!");
            }
        }
        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            sound1();
            if (pictureLupa.Visible == false)
            {
                pictureLupa.Visible = true;
                textPesquisar.Visible = true;
                textPesquisar.Text = null;
                textPesquisar.Focus();
            }
            else
            {
                pictureLupa.Visible = false;
                textPesquisar.Visible = false;
            }
        }        
        private void comboProprietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                if (comboProprietario.Text == string.Empty) {return;}

                try
                {
                    con.ConnectionString = Settings.Default.dbpetsepetsConnectionString;
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Cliente WHERE nome = '" + comboProprietario.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        textTelefone.Text = dr["fone1"].ToString();
                        textEmail.Text = dr["email"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao carregar Registro: " + ex.Message);
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sound1();
            if (checkBox2.Checked == true)
            {
                lblQuais.Visible = true;
                textAlegMedic.Visible = true;
            }
            else
            {
                lblQuais.Visible = false;
                textAlegMedic.Visible = false;
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //HabilitarCampos();
                int codId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textCod.Text = codId.ToString("D5");
                comboEspecie.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textRaca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textNome.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboProprietario.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textTelefone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                richTextBoxCE.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textAlegMedic.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                CarregarFoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DataGridView: " + ex.Message);
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
                textPesquisar.Text = "";
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            sound1();
            try
            {
                if (textCod.Text == "")
                {
                    sound3();
                    MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }
                DialogResult result1 = MessageBox.Show("Confima a Exclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    objTabela.Id = Convert.ToInt32(textCod.Text);
                    int x = AnimalModel.Excluir(objTabela);
                    if (x > 0)
                    {
                        sound2();
                        LimparCampos();
                        DesabilitarCampos();
                        CarregarGrid();
                        MessageBox.Show(string.Format("Registro excluído com sucesso!"));
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


            /*
            try
            {
                if (textCod.Text == Convert.ToString(null))
                {
                    sound3();
                    MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                objTabela.Id = Convert.ToInt32(textCod.Text);
                int x = AnimalModel.Excluir(objTabela);

                if (x > 0)
                {
                    MessageBox.Show("Registro  excluído com suceso!", "Aviso!", MessageBoxButtons.OK);
                    DesabilitarCampos();
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Error ao Tentar Excluir o Registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir: " + ex.Message);
            }
            */
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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();
        }
        private void btnNovo1_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Salvar";
            HabilitarCampos();
            LimparCampos();
            textNome.Focus();
            btnSalvar.Enabled = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sound1();
            if (textNome.Text == string.Empty)
            {
                sound3();
                MessageBox.Show("Impossivel salvar registro vazio!", "Aviso!", MessageBoxButtons.OK);
                textNome.Focus();
                LimparCampos();
                DesabilitarCampos();
                return;
            }
            switch (opc)
            {
                case "Salvar":
                    try
                    {
                        DialogResult result1 = MessageBox.Show("Confirma a inclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            objTabela.Especie = comboEspecie.Text;
                            objTabela.Raca = textRaca.Text;
                            objTabela.Nome = textNome.Text;
                            objTabela.Proprietario = comboProprietario.Text;
                            objTabela.Telefone = textTelefone.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.Cuidados_esp = richTextBoxCE.Text;
                            objTabela.Alergico = textAlegMedic.Text;

                            int x = AnimalModel.Inseir(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show("Registro cadastrado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                DesabilitarCampos();
                                CarregarGrid();
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar cadastrar Registro!", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um error tentar cadastrar o Registro:" + ex.Message);
                    }
                    break;

                case "Editar":

                    if (textCod.Text == "")
                    {
                        sound3();
                        MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                        return;
                    }

                    try
                    {
                        DialogResult result1 = MessageBox.Show("Confima alteração do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            objTabela.Id = Convert.ToInt32(textCod.Text);
                            objTabela.Especie = comboEspecie.Text;
                            objTabela.Raca = textRaca.Text;
                            objTabela.Nome = textNome.Text;
                            objTabela.Proprietario = comboProprietario.Text;
                            objTabela.Telefone = textTelefone.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.Cuidados_esp = richTextBoxCE.Text;
                            objTabela.Alergico = textAlegMedic.Text;

                            int x = AnimalModel.Editar(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show("Registro Editado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                DesabilitarCampos();
                                CarregarGrid();
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar Editar o Registro", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Editar ERROR: " + ex.Message);
                    }
                    break;
            }
        }
        private void btnAtivarCamera_Click(object sender, EventArgs e)
        {
            if (videoSource != null)
            {
                MessageBox.Show("A câmera já está ativada!", "Aviso!", MessageBoxButtons.OK);
            }
            else
            {
                sound1();
                FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videosources != null)
                {
                    try
                    {
                        videoSource = new VideoCaptureDevice(videosources[0].MonikerString);
                        videoSource.NewFrame += (s, i) => pictureCamera.Image = (Bitmap)i.Frame.Clone();
                        videoSource.Start();
                    }
                    catch (Exception)
                    {
                        sound3();
                        MessageBox.Show("Erro Câmera: " + "Dispositivo WebCam não encontrado neste computador!", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void btnTirarFoto1_Click(object sender, EventArgs e)
        {
            if (videoSource == null)
            {
                MessageBox.Show("Ative primerio a camera!", "Aviso!", MessageBoxButtons.OK);
                return;
            }
            sound4();
            base.OnClosed(e);
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }
        private void btnOffCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource != null)
                {
                    sound5();
                    videoSource.SignalToStop();
                    pictureCamera.Image = null;
                    videoSource = null;
                    pictureCamera.Image = Image.FromFile(pasta_aplicacao + "img\\dog1.png");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAtivarCamera_MouseHover(object sender, EventArgs e)
        {
            btnAtivarCamera.ForeColor = Color.Black;
        }

        private void btnAtivarCamera_MouseLeave(object sender, EventArgs e)
        {
            btnAtivarCamera.ForeColor = Color.White;
        }

        private void btnSalvarFoto_Click(object sender, EventArgs e)
        {
            if (pictureCamera.Image == null)
            {
                MessageBox.Show("Antes de salvar, ative primerio a Camera e tire a foto");
                return;
            }
            if (textCod.Text == "")
            {
                sound3();
                MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                return;
            }



            // Carrega a imagem para o nosso formulário
            Bitmap bmp = new Bitmap(pictureCamera.Image);
            pictureCamera.Image = bmp;
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Bmp);
            byte[] foto = ms.ToArray();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Settings.Default.dbpetsepetsConnectionString;
            SqlCommand cn = new SqlCommand("UPDATE Animal SET Foto = @foto WHERE id =" + textCod.Text, con);

            SqlParameter paramFoto = new SqlParameter("@foto", SqlDbType.Binary);
            paramFoto.Value = foto;
            cn.Parameters.Add(paramFoto);
            con.Open();

            if (MessageBox.Show("Salvar Foto em Restrito?", "Salvar Foto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cn.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Foto Cadastrada com Sucesso!");
                    LimparCampos();
                    CarregarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ao salvar a foto!!: " + ex.Message);
                }
            }
            else
            {
                //pictureCamera.Image = null;
                return;
            }
        }
        private void textRaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textNome.Focus();
            }
        }

        private void textNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbIdade.Focus();
            }
        }

        private void comboProprietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textTelefone.Focus();
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
                richTextBoxCE.Focus();
            }

        }
        private void textAlegMedic_KeyPress(object sender, KeyPressEventArgs e)
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
            opc = "Buscar";
            InicarOpc();
        }
    }
}
