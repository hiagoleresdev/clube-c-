using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clube.Interfaces
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_clubeDataSet6.socio'. Você pode movê-la ou removê-la conforme necessário.
            this.socioTableAdapter1.Fill(this.db_clubeDataSet6.socio);
            // TODO: esta linha de código carrega dados na tabela 'db_clubeDataSet3.socio'. Você pode movê-la ou removê-la conforme necessário.
            this.socioTableAdapter.Fill(this.db_clubeDataSet3.socio);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
