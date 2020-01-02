using System;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FrmPrograma : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public DateTime hoje = DateTime.Today.Date; //data atual

        public FrmPrograma()
        {
            InitializeComponent();
            this.tpMensagem.SetToolTip(this.txtAudio, "Insira o título do audio MP3");
        }

        //Mostrar mensagem de confirmação

        private void MensagemOK(string mensagem)
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
            this.txtDataCadastro.Text = hoje.Date.ToShortDateString();
            this.txtDuracao.Text = string.Empty;
            this.txtSintese.Text = string.Empty;
            this.txtDataCadastro.Enabled = false;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtAudio.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.txtDataCadastro.ReadOnly = !valor;
            this.txtDuracao.ReadOnly = !valor;
            this.txtSintese.ReadOnly = !valor;
            this.txtDataCadastro.Enabled = true;
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
            this.dataLista.DataSource = NPrograma.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();
            LblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //Abrindo formulário

        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            
            //this.Top = 0;
           // this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
            this.txtDataCadastro.Text = hoje.Date.ToShortDateString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtAudio.Focus();
            this.txtCodigo.Enabled = false;
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if(this.txtAudio.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                    erroIcone.SetError(txtBuscar,"Insira o nome do audio");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NPrograma.Inserir(this.txtAudio.Text.Trim(),
                            this.txtDuracao.Text,
                            this.txtDataCadastro.Text,
                            this.txtSintese.Text.Trim());
                    }
                    else
                    {
                        resp = NPrograma.Editar(Convert.ToInt32(
                            this.txtCodigo.Text), 
                            this.txtAudio.Text.Trim(), 
                            this.txtDuracao.Text, 
                            this.txtDataCadastro.Text, 
                            this.txtSintese.Text);
                    }

                    if (resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOK("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOK("Registro editado com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;
                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostrar();
                }
            }catch( Exception ex)
            {
                //detalhamento do erro
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

         private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["codigo"].Value);
            this.txtAudio.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["audio"].Value);
            this.txtDuracao.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["duracao"].Value);
            this.txtDataCadastro.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["dataCadastro"].Value);
            this.txtSintese.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["sintese"].Value);
            this.tabControl1.SelectedIndex = 1;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para inserir");
            }
            else
            {
                this.eEditar = true;
                this.botoes();
                this.Habilitar(true);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.botoes();
            this.Habilitar(false);
            this.Limpar();

        }

        private void chkDeletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
            }
            else
            {
                this.dataLista.Columns[0].Visible = false;

            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar o(s) registro(s)", "Sistema Pregações", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Cod;
                    string Resp = "";

                    foreach(DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Cod = Convert.ToString(row.Cells[1].Value);
                            Resp = NPrograma.Excluir(Convert.ToInt32(Cod));

                            if (Resp.Equals("OK"))
                            {
                                this.MensagemOK("Registro(s) excluido(s) com sucesso");
                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }catch (Exception ex)
            {
                //detalhamento do erro
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


    }
}

