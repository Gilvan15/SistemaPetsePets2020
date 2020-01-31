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

namespace SistemaPet.Reports
{
    public partial class ReportRecibo : Form
    {

        string pasta_aplicacao = "";
        public ReportRecibo()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }

        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }

        private void ReportRecibo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbpetsepetsDataSet.Recibo'. Você pode movê-la ou removê-la conforme necessário.
            this.reciboTableAdapter.Fill(this.dbpetsepetsDataSet.Recibo);

            this.reportViewer1.RefreshReport();
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
            }

        }
    }
}
