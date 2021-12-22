using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clube.Interfaces;
using Clube.view;
using Clube.view.Interfaces;
using Clube.View.Interfaces;

namespace Clube.Interfaces
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
           
        }
        
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarDependente cliente = new CadastrarDependente();
            cliente.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente socio = new CadastrarCliente();
            socio.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroMensalidade cli = new CadastroMensalidade();
            cli.Show();
        }

        private void verDependentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDependentes depen = new FormDependentes();
            depen.Show();
        }

        private void verDependentesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDependentes dependentes = new FormDependentes();
            dependentes.Show();
        }

        private void verSóciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSocios socios = new FormSocios();
            socios.Show();
        }

        private void verMensalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMensalidades mensalidade = new FormMensalidades();
            mensalidade.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCategoria categoria = new CadastroCategoria();
            categoria.Show();
        }

        private void listarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria categoria = new FormCategoria();
            categoria.Show();
        }

        private void pagarMensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagarMensalidade p = new FormPagarMensalidade();
            p.Show();
        }
    }
}
