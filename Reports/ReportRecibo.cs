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
        DateTime data1;
        DateTime data2;
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
            carregarDataeLista();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            sound1();
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                dateTimePicker1.Focus();
            }
            else
            {
                panel1.Visible = false;
                carregarDataeLista();
            }
        }
        private void carregarDataeLista() 
        {
            data1 = DateTime.Parse("1/1/1753");
            data2 = DateTime.Parse("31/12/9999");
            this.reciboTableAdapter.Fill(this.dbpetsepetsDataSet.Recibo, Convert.ToString(data1), Convert.ToString(data2));
            this.reportViewer1.RefreshReport();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            data1 = dateTimePicker1.Value;
            data2 = dateTimePicker2.Value;
            this.reciboTableAdapter.Fill(this.dbpetsepetsDataSet.Recibo, Convert.ToString(data1), Convert.ToString(data2));
            this.reportViewer1.RefreshReport();
        }
    }
}
