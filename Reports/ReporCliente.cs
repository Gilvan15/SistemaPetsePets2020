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

namespace SistemaPet
{
    public partial class ReporCliente : Form
    {
        string pasta_aplicacao = "";

        DateTime data1;
        DateTime data2;

        public ReporCliente()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }

        private void ReporCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbpetsepetsDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteTableAdapter.Fill(this.dbpetsepetsDataSet.Cliente, textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sound1();
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                textBox1.Focus();
            }
            else
            {
                panel1.Visible = false;
                textBox1.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.ClienteTableAdapter.Fill(this.dbpetsepetsDataSet.Cliente, textBox1.Text) ;
            this.reportViewer1.RefreshReport();
        }
    }
}
