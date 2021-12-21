using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clube.Classes;

namespace Clube.model
{
    public class CadastroNovaMensalidade
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public CadastroNovaMensalidade(Mensalidade mensalidade)
        {
            cmd.CommandText = "insert into mensalidade (dataVencimento,dataPagamento,valor,jurosAplicados,quitada) values(@dataVencimento,@dataPagamento,@valor,@jurosAplicados,@quitada)";

            cmd.Parameters.AddWithValue("@dataVencimento", mensalidade.Data);
            cmd.Parameters.AddWithValue("@dataPagamento", mensalidade.DataPagamento);
            cmd.Parameters.AddWithValue("@valor", mensalidade.Valor);
            cmd.Parameters.AddWithValue("@jurosAplicados", mensalidade.JurosAplicados);
            cmd.Parameters.AddWithValue("@quitada", mensalidade.Quitada);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.fechar();
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao cadastrar no banco!" + e;
                throw;
            }
        }

    }
}
