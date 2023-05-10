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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelNumCasa_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumCasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void buttonValidade_Click(object sender, EventArgs e)
        {
            Form calendario = new calendario();
            calendario.ShowDialog();
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
