using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clube.Classes
{
    public class Socio
    {
        public List<Dependente> Dependentes = new List<Dependente>();
        public List<Mensalidade> mensalidades = new List<Mensalidade>();


        private String nome;
        private int numeroCartao;
        private String parentesco;
        private String email;

        public string Nome { get => nome; set => nome = value; }
        public int NumeroCartao { get => numeroCartao; set => numeroCartao = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Email { get => email; set => email = value; }

        public void pagarMensalidade(Mensalidade mensalidade)
        {
            Console.WriteLine("Pagar mensalidades: " + mensalidade);
        }
    }
}
