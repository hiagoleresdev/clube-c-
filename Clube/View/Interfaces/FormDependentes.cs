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
    public partial class FormDependentes : Form
    {
        public FormDependentes()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDependentes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_clubeDataSet2.dependente'. Você pode movê-la ou removê-la conforme necessário.
            this.dependenteTableAdapter.Fill(this.db_clubeDataSet2.dependente);

        }
    }
}
