using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clube.view.Interfaces
{
    public partial class FormMensalidades : Form
    {
        public FormMensalidades()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMensalidades_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_clubeDataSet4.mensalidade'. Você pode movê-la ou removê-la conforme necessário.
            this.mensalidadeTableAdapter.Fill(this.db_clubeDataSet4.mensalidade);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
