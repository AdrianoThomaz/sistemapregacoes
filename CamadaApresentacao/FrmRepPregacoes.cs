using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class FrmRepPregacoes : Form
    {
        public FrmRepPregacoes()
        {
            InitializeComponent();
        }

        private void FrmRepPregacoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbpregacoesDataSet.programa'. Você pode movê-la ou removê-la conforme necessário.
            this.programaTableAdapter.Fill(this.dbpregacoesDataSet.programa);

            this.reportViewer1.RefreshReport();
        }
    }
}
