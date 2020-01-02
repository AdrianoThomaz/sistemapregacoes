using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NPrograma
    {

        // Metodo Inserir
        public static string Inserir(
            string audio, 
            string duracao, 
            string dataCadastro, 
            string sintese)
        {
            DPrograma Obj = new CamadaDados.DPrograma();
            Obj.Audio = audio;
            Obj.Duracao = duracao;
            Obj.DataCadastro = dataCadastro;
            Obj.Sintese = sintese;

            return Obj.Inserir(Obj);
        }

        // Metodo Editar
        public static string Editar(
            int codigo,
            string audio,
            string duracao,
            string dataCadastro,
            string sintese)
        {
            DPrograma Obj = new CamadaDados.DPrograma();
            Obj.Codigo = codigo;
            Obj.Audio = audio;
            Obj.Duracao = duracao;
            Obj.DataCadastro = dataCadastro;
            Obj.Sintese = sintese;

            return Obj.Editar(Obj);
        }

        // Metodo Excluir
        public static string Excluir(int codigo)
        {
            DPrograma Obj = new CamadaDados.DPrograma();
            Obj.Codigo = codigo;

            return Obj.Excluir(Obj);
        }

        // Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DPrograma().Mostrar();
        }

        // Metodo Buscar Nome
        public static DataTable BuscarNome(string testbusca)
        {
            DPrograma Obj = new DPrograma();
            Obj.TextBusca = testbusca;
            return Obj.BuscarNome(Obj);
        }

    }
}
