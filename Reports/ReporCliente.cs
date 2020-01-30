using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet
{
    public partial class ReporCliente : Form
    {
        public ReporCliente()
        {
            InitializeComponent();
        }

        private void ReporCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbpetsepetsDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteTableAdapter.Fill(this.dbpetsepetsDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'dbpetsepetsDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteTableAdapter.Fill(this.dbpetsepetsDataSet.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
