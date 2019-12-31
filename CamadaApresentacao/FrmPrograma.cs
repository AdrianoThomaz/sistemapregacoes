using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FrmPrograma : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        public FrmPrograma()
        {
            InitializeComponent();
            this.tpMensagem.SetToolTip(this.txtAudio, "Insira o título do audio MP3");
        }

        //Mostrar mensagem de confirmação

        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Pregações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensagem de erro

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Pregações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Limpar Campos
        private void Limpar()
        {
            this.txtAudio.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtDataCadastro.Text = string.Empty;
            this.txtDuracao.Text = string.Empty;
            this.txtSintese.Text = string.Empty;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtAudio.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.txtDataCadastro.ReadOnly = !valor;
            this.txtDuracao.ReadOnly = !valor;
            this.txtSintese.ReadOnly = !valor;
        }

        //Habilitar os botões
        private void botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;

            }
        }

        //Ocultar as colunas do Grid
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            //this.dataLista.Columns[1].Visible = false;
        }

        //Mostrar no Data Grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NPrograma.Mostrar();
            this.ocultarColunas();
            LblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //Buscar pelo Audio
        private void BuscarNome()
        {
            this.dataLista.DataSource = NPrograma.BuscarNome(this.TxtBuscar.Text);
            this.ocultarColunas();
            LblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();

        }
    }
}

