using System;
using System.Data;
using System.Data.SqlClient;


namespace CamadaDados
{
    public class DPrograma
    {
        // Criacao das variáveis
        private int _Codigo;
        private string _Audio;
        private string _Duracao;
        private string _DataCadastro;
        private string _Sintese;
        private string _TextBusca;

        // Codigo
        public int Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                _Codigo = value;
            }
        }

        // Audio
        public string Audio
        {
            get
            {
                return _Audio;
            }
            set
            {
                _Audio = value;
            }
        }

        // Duracao
        public string Duracao
        {
            get
            {
                return _Duracao;
            }
            set
            {
                _Duracao = value;
            }
        }

        // Data Cadastro
        public string DataCadastro
        {
            get
            {
                return _DataCadastro;
            }
            set
            {
                _DataCadastro = value;
            }
        }

        // Sintese
        public string Sintese
        {
            get
            {
                return _Sintese;
            }
            set
            {
                _Sintese = value;
            }
        }

        // Texto de busca
        public string TextBusca
        {
            get
            {
                return _TextBusca;
            }
            set
            {
                _TextBusca = value;
            }
        }

        //Cosntrutor vazio
        public DPrograma()
        {

        }

        //Construtor com parametros
        public DPrograma(int codigo,string audio, string duracao, string dataCadastro, string sintese, string textBusca)
        {
            this.Codigo = codigo;
            this.Audio = audio;
            this.Duracao = duracao;
            this.DataCadastro = dataCadastro;
            this.Sintese = sintese;
            this.TextBusca = textBusca;
        }

        //Método Inserir
        public string Inserir(DPrograma Programa)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_programa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParAudio = new SqlParameter();
                ParAudio.ParameterName = "@audio";
                ParAudio.SqlDbType = SqlDbType.VarChar;
                ParAudio.Size = 100;
                ParAudio.Value = Programa.Audio;
                SqlCmd.Parameters.Add(ParAudio);

                SqlParameter ParDuracao = new SqlParameter();
                ParDuracao.ParameterName = "@duracao";
                ParDuracao.SqlDbType = SqlDbType.VarChar;
                ParDuracao.Size = 5;
                ParDuracao.Value = Programa.Duracao;
                SqlCmd.Parameters.Add(ParDuracao);

                SqlParameter ParDataCadastro = new SqlParameter();
                ParDataCadastro.ParameterName = "@dataCadastro";
                ParDataCadastro.SqlDbType = SqlDbType.DateTime;
                ParDataCadastro.Size = 10;
                ParDataCadastro.Value = Programa.DataCadastro;
                SqlCmd.Parameters.Add(ParDataCadastro);

                SqlParameter ParSintese = new SqlParameter();
                ParSintese.ParameterName = "@sintese";
                ParSintese.SqlDbType = SqlDbType.VarChar;
                ParSintese.Size = 1000;
                ParSintese.Value = Programa.Sintese;
                SqlCmd.Parameters.Add(ParSintese);

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi inserido";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        //Método Editar
        public string Editar(DPrograma Programa)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_programa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Programa.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParAudio = new SqlParameter();
                ParAudio.ParameterName = "@audio";
                ParAudio.SqlDbType = SqlDbType.VarChar;
                ParAudio.Size = 100;
                ParAudio.Value = Programa.Audio;
                SqlCmd.Parameters.Add(ParAudio);

                SqlParameter ParDuracao = new SqlParameter();
                ParDuracao.ParameterName = "@duracao";
                ParDuracao.SqlDbType = SqlDbType.VarChar;
                ParDuracao.Size = 5;
                ParDuracao.Value = Programa.Duracao;
                SqlCmd.Parameters.Add(ParDuracao);

                SqlParameter ParDataCadastro = new SqlParameter();
                ParDataCadastro.ParameterName = "@dataCadastro";
                ParDataCadastro.SqlDbType = SqlDbType.DateTime;
                ParDataCadastro.Size = 5;
                ParDataCadastro.Value = Programa.DataCadastro;
                SqlCmd.Parameters.Add(ParDataCadastro);

                SqlParameter ParSintese = new SqlParameter();
                ParSintese.ParameterName = "@sintese";
                ParSintese.SqlDbType = SqlDbType.VarChar;
                ParSintese.Size = 1000;
                ParSintese.Value = Programa.Sintese;
                SqlCmd.Parameters.Add(ParSintese);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A Edição não foi feita.";
            }

            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Método Excluir
        public string Excluir(DPrograma Programa)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_programa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@Codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Programa.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi feita.";
            }

            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;

        }

        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Programa");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_programa";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Método Buscar Nome
        public DataTable BuscarNome(DPrograma Programa)
        {
            DataTable DtResultado = new DataTable("Programa");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextBuscar = new SqlParameter();
                ParTextBuscar.ParameterName = "@textbuscar";
                ParTextBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextBuscar.Size = 100;
                ParTextBuscar.Value = Programa.TextBusca;
                SqlCmd.Parameters.Add(ParTextBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
