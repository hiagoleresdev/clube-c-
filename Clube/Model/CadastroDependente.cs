using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clube.model;
using Clube.Classes;

namespace Clube.model
{
    public class CadastroDependente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public CadastroDependente(Dependente dependente)
        {
            cmd.CommandText = "insert into dependente (nome,numeroCartao,parentesco,email) values(@nome,@numCartao,@parentesco,@email)";

            cmd.Parameters.AddWithValue("@nome", dependente.Nome);
            cmd.Parameters.AddWithValue("@numCartao", dependente.NumeroCartao) ;
            cmd.Parameters.AddWithValue("@parentesco", dependente.Parentesco); ;
            cmd.Parameters.AddWithValue("@email", dependente.Email);
           

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
