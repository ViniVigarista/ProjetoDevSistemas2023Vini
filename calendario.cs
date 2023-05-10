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
    public partial class calendario : Form
    {
        public calendario()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calendario_Load(object sender, EventArgs e)
        {
            
            BackColor = Color.LightBlue;
        }
    }
}
