using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevSistemas2023Vini
{
    public partial class Clientes : Form
    {
        

        public Clientes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            
        }

        private void buttonCancelarCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue; 
        }
    }
}
