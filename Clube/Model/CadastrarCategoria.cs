using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clube.Classes;

using Clube.model;


namespace Clube.Model
{
    public class CadastrarCategoria
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public CadastrarCategoria(Categoria categoria)
        {
            
            cmd.CommandText = "insert into categoria (descricao) values(@categoria)";

            cmd.Parameters.AddWithValue("@categoria", categoria.Descricao);
           
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
