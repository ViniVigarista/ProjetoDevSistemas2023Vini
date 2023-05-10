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
    public partial class cadastroValores : Form
    {
        public cadastroValores()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            Funcoes.EventoFocoCampos(this);



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastroValores_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void buttonCancelarIngrediente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private string GetText()
        {
            return Text;
        }


        private void textBoxIDpizza_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.textBoxValor);
        }

        private void textBoxvalorBorda_TextChanged(object sender, EventArgs e)
        {
            Masks.AplicaMascaraMoeda2(this.textBoxvalorBorda);
        }
    }
}
