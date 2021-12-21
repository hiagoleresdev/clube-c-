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
using Clube.Classes;
using Clube.model;
using System.Data.SqlClient;

namespace Clube.Interfaces
{
  
    public partial class CadastrarDependente : Form
    {
        Dependente dependente;
        Mensalidade mensalidade;
        Socio socio;


        Conexao conexao = new Conexao();

       
        public CadastrarDependente()
        {
            InitializeComponent();
            dependente = new Dependente();
            mensalidade = new Mensalidade();
            socio = new Socio();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dependente.Nome = txtNomeDependente.Text;
            dependente.NumeroCartao = Int32.Parse(txtNumCartaoDependente.Text);
            dependente.Email = txtEmailDependente.Text;
            dependente.Parentesco = txtParentescoSocio.Text;
            MessageBox.Show(comboSocio.SelectedItem.ToString());
            
            

            CadastroDependente cadastro = new CadastroDependente(dependente);
            MessageBox.Show(cadastro.mensagem);
            this.Close();
        }

        public DataTable GetSocio()
        {
            DataTable dataUf = new DataTable("SOCIO");
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-14PEP5G;Initial Catalog=db_clube;Integrated Security=True");
            SqlCommand Command = new SqlCommand("select nome,id from socio;", Connection);
            {
                Connection.Open();
                dataUf.Load(Command.ExecuteReader());
            }
            return dataUf;
        }

        private void CadastrarDependente_Load(object sender, EventArgs e)
        {
            comboSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSocio.DataSource = GetSocio();
            comboSocio.ValueMember = "nome";
            comboSocio.DisplayMember = "nome";
            
            comboSocio.Update();
        }

        

        private void comboSocio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailDependente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParentesco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNumCartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeDependente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
