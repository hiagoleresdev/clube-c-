using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clube.Classes;


namespace Clube.View.Interfaces
{
    public partial class FormPagarMensalidade : Form
    {
        Mensalidade mensalidade;
        public FormPagarMensalidade()
        {
            InitializeComponent();
            mensalidade = new Mensalidade();    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable GetMensalidade()
        {
            DataTable dataUf = new DataTable("SOCIO");
            SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-14PEP5G;Initial Catalog=db_clube;Integrated Security=True");
            SqlCommand Command = new SqlCommand("select dataVencimento from mensalidade;", Connection);
            {
                Connection.Open();
                dataUf.Load(Command.ExecuteReader());
            }
            return dataUf;
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


        private void FormPagarMensalidade_Load(object sender, EventArgs e)
        {

            comboSocio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSocio.DataSource = GetSocio();
            comboSocio.ValueMember = "nome";
            comboSocio.DisplayMember = "nome";

            comboSocio.Update();



            comboMensalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMensalidade.DataSource = GetMensalidade();
            comboMensalidade.ValueMember = "dataVencimento";
            comboMensalidade.DisplayMember = "dataVencimento";

            comboMensalidade.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mensalidade.Quitada = true;

        }
    }
}
