using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clube.Classes;
using Clube.Interfaces;

namespace Clube.Interfaces
{
    public partial class TelaMensalidade : Form
    {
        
        Form1 form1;
        public TelaMensalidade()
        {
            InitializeComponent();
            form1 = new Form1();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Mensalidade mensalidade = new Mensalidade();
            
            mensalidade.Data = dtVencimento.Text;
            mensalidade.DataPagamento = dtPagamento.Text;
            mensalidade.Valor = Double.Parse(txtValor.Text);
            mensalidade.JurosAplicados = Double.Parse(txtValorFinal.Text);

            mensalidade.Quitada = true;
            
            MessageBox.Show("Mensalidade paga com sucesso!");
           
            this.Close();
        }

        private void TelaMensalidade_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 