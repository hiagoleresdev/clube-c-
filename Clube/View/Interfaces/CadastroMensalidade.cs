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
using Clube.model;

namespace Clube.Interfaces
{
    public partial class CadastroMensalidade : Form
    {
        Mensalidade mensalidade;
        Socio socio;
        
        public CadastroMensalidade()
        {
            InitializeComponent();
            mensalidade = new Mensalidade();
            socio = new Socio();
        }

        private void btnMensalidade_Click(object sender, EventArgs e)
        {
            mensalidade.Data = txtDataVencimento.Text;
            mensalidade.DataPagamento = txtDataPagamento.Text;
            mensalidade.Valor = Double.Parse( txtValorMensalidade.Text);
            mensalidade.JurosAplicados = Double.Parse(txtJurosAplicados.Text);
            mensalidade.Quitada = false;

            CadastroNovaMensalidade cadastro = new CadastroNovaMensalidade(mensalidade);
            MessageBox.Show(cadastro.mensagem);

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
