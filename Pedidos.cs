using ProjetoDevSistemas2023Vini.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevSistemas2023Vini
{
    public partial class Pedidos : Form
    {
        public SaborDAO saborDAO;
        public IngredienteDAO ingredienteDAO;
        public EnderecoDAO enderecoDAO;
        public ClienteDAO clienteDAO;

        public Pedidos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            CarregaIngredientesCheckedListBox();
            CarregaEnumListBox();
            

            clienteDAO = new ClienteDAO(provider, strConnection);




        }


        public void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()), row["Nome"].ToString()));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));

            listBoxML.Items.Clear();
            listBoxML.DataSource = Enum.GetValues(typeof(EnumProdutoTamanho));


        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void textBoxNome_Leave(object sender, EventArgs e)
        {
            if (this.textBoxNome.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Nome = this.textBoxNome.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela

                //userControlEndereco.maskedTextBoxCep.Text = "";
                this.maskedTextBoxtelefone.Text = "";
                this.maskedTextBoxCPF.Text = "";
                this.textBoxNome.Text = "";

                foreach (DataRow row in linhas.Rows)
                {
                    this.maskedTextBoxtelefone.Text = row["telefone"].ToString(); ;
                    this.maskedTextBoxCPF.Text = row["cpf"].ToString(); ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxObservação_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
