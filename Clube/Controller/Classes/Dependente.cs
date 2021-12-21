using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube.Classes
{
    public class Dependente
    {
        public Socio socio;
        private int numeroCartao;
        private String nome;
        private String parentesco;
        private String email;
        

        public int NumeroCartao { get => numeroCartao; set => numeroCartao = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Email { get => email; set => email = value; }
    }
}
