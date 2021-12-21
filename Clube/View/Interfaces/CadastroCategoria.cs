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
using Clube.Model;


namespace Clube.View.Interfaces
{
    public partial class CadastroCategoria : Form
    {
        Categoria categoria;
        public CadastroCategoria()
        {
            InitializeComponent();
            categoria = new Categoria();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoria.Descricao = txtDescricaoCategoria.Text;
            CadastrarCategoria c = new CadastrarCategoria(categoria);
           
        }
    }
}
