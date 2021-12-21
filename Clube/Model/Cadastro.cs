using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clube.Classes;

namespace Clube.model
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public Cadastro(Socio socio)
        {
            cmd.CommandText = "insert into socio (nome,numeroCartao,parentesco,email) values(@nome,@numCartao,@parentesco,@email)";

            cmd.Parameters.AddWithValue("@nome",socio.Nome);
            cmd.Parameters.AddWithValue("@numCartao", socio.NumeroCartao);
            cmd.Parameters.AddWithValue("@parentesco", socio.Parentesco);
            cmd.Parameters.AddWithValue("email", socio.Email);

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
