using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevSistemas2023Vini
{
    public partial class cadastroProduto : Form
    {
        public cadastroProduto()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelarIngrediente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroProduto_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }
    }
}
