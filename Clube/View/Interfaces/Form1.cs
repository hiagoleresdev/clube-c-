using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clube.Classes;
using Clube.Interfaces;
using System.Windows.Forms;

namespace Clube
{
    public partial class Form1 : Form
    {
        Dependente dependente;
        Mensalidade mensalidade;
        Socio socio;
        public Form1()
        {
            InitializeComponent();
            dependente = new Dependente();
            mensalidade = new Mensalidade();   
            socio = new Socio();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socio.Nome = txtNomeSocio.Text;
            socio.NumeroCartao = Int32.Parse(txtNumCartaoSocio.Text);
            socio.Email = txtEmailSocio.Text;
            socio.Parentesco = txtParentescoSocio.Text;

            comboSocio.Items.Add(txtNomeSocio.Text);
            mmValores.Text += "\nSócio adicionado: " + socio.Nome;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dependente.Nome = txtNomeDependente.Text;
            dependente.NumeroCartao = Int32.Parse(txtNumCartao.Text);
            socio.Email = txtEmailDependente.Text;
            dependente.Parentesco = txtParentesco.Text;
            mmValores.Text += "\nDependente adicionado: " + dependente.Nome + ", associado ao sócio(a): " + comboSocio.SelectedItem;
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaMensalidade tela = new TelaMensalidade();
            tela.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
