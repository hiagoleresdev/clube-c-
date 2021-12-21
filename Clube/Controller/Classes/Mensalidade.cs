using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube.Classes
{
    public class Mensalidade
    {
        public Socio socio;
        private String data;
        private double valor;
        private String dataPagamento;
        private double jurosAplicados;
        private bool quitada;

        public string Data { get => data; set => data = value; }
        public double Valor { get => valor; set => valor = value; }
        public string DataPagamento { get => dataPagamento; set => dataPagamento = value; }
       
        public bool Quitada { get => quitada; set => quitada = value; }
        public double JurosAplicados { get => jurosAplicados; set => jurosAplicados = value; }
    }
}
