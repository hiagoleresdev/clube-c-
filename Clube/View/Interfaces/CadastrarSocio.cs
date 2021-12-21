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
  
    public partial class CadastrarCliente : Form
    {
        Dependente dependente;
        Mensalidade mensalidade;
        Socio socio;
        public CadastrarCliente()
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
            socio.Nome = txtNomeSocio.Text;
            socio.NumeroCartao = Int32.Parse(txtNumCartaoSocio.Text);
            socio.Email = txtEmailSocio.Text;
            socio.Parentesco = txtParentescoSocio.Text;

            Cadastro cadastro = new Cadastro(socio);

            MessageBox.Show(cadastro.mensagem);
            this.Close();
            CadastrarDependente dep = new CadastrarDependente();
            
            
        }



        public DataTable GetCategoria()
        {
            DataTable dataUf = new DataTable("SOCIO");
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-14PEP5G;Initial Catalog=db_clube;Integrated Security=True");
            SqlCommand Command = new SqlCommand("select descricao from categoria;", Connection);
            {
                Connection.Open();
                dataUf.Load(Command.ExecuteReader());
            }
            return dataUf;
        }


        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.DataSource = GetCategoria();
            comboCategoria.ValueMember = "descricao";
            comboCategoria.DisplayMember = "descricao";

            comboCategoria.Update();
        }
    }
}
