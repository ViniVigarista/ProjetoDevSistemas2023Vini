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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProjetoDevSistemas2023Vini
{

    public partial class Pedidos : Form
    {
        public SaborDAO saborDAO;
        public IngredienteDAO ingredienteDAO;
        public EnderecoDAO enderecoDAO;
        public ClienteDAO clienteDAO;
        public readonly PedidoDAO pedidoDAO;
        public ProdutoDAO produtoDAO;
        public int valorpizza;
        public List<Pizza> Pizzas = new List<Pizza>();

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
            //CarregaListaProduto();

            comboBoxtamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            comboBoxBorda.DataSource = Enum.GetValues(typeof(EnumBorda));

            produtoDAO = new ProdutoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            pedidoDAO = new PedidoDAO(provider, strConnection);
            valorpizza = 0;



        }


        public void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                DataTable linhas = saborDAO.Buscar(sabor);
                checkedListBoxSabores.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    string descricao = row["Nome"].ToString();
                    sabor = new Sabor();
                    sabor.Descricao = descricao; // Atribui o valor da coluna "Nome" à propriedade Descricao do objeto sabor
                    checkedListBoxSabores.Items.Add(sabor.Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //public void CarregaListaProduto()
        //{
        //    var produtao = new Produto();
        //    try
        //    {
        //        DataTable linhas = produtoDAO.Buscar(produtao);
        //        checkedListBoxProduto.Items.Clear();
        //        foreach (DataRow row in linhas.Rows)
        //        {
        //            string descricao = row["Descricao"].ToString();
        //            produtao = new Produto();
        //            produtao.Descricao = descricao; // Atribui o valor da coluna "Nome" à propriedade Descricao do objeto sabor
        //            checkedListBoxProduto.Items.Add(produtao.Descricao);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void Pedidos_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form clientes = new Clientes();
            clientes.ShowDialog();
        }

        public void textBoxNome_Leave(object sender, EventArgs e)
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
                this.maskedTextBoxTelefone.Text = "";
                this.textBoxCPF.Text = "";
                this.textBoxNome.Text = "";
                this.textBoxNum.Text = "";


                foreach (DataRow row in linhas.Rows)
                {
                    this.textBoxNome.Text = row["nome"].ToString(); ;
                    this.maskedTextBoxTelefone.Text = row["telefone"].ToString(); ;
                    this.textBoxCPF.Text = row["cpf"].ToString(); ;
                    this.textBoxRua.Text = row["logradouro"].ToString(); ;
                    this.textBoxbairro.Text = row["bairro"].ToString(); ;
                    this.textBoxNum.Text = row["Número"].ToString(); ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void textBoxCPF_Leave(object sender, EventArgs e)
        {
            if (this.textBoxCPF.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Cpf = this.textBoxCPF.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela

                //userControlEndereco.maskedTextBoxCep.Text = "";
                this.maskedTextBoxTelefone.Text = "";
                this.textBoxCPF.Text = "";
                this.textBoxNome.Text = "";

                foreach (DataRow row in linhas.Rows)
                {
                    this.textBoxNome.Text = row["nome"].ToString(); ;
                    this.maskedTextBoxTelefone.Text = row["telefone"].ToString(); ;
                    this.textBoxCPF.Text = row["cpf"].ToString(); ;
                    this.textBoxRua.Text = row["logradouro"].ToString(); ;
                    this.textBoxbairro.Text = row["bairro"].ToString(); ;
                    this.textBoxNum.Text = row["Número"].ToString(); ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void maskedTextBoxTelefone_Leave(object sender, EventArgs e)
        {
            if (this.maskedTextBoxTelefone.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Telefone = this.maskedTextBoxTelefone.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela

                //userControlEndereco.maskedTextBoxCep.Text = "";
                this.maskedTextBoxTelefone.Text = "";
                this.textBoxCPF.Text = "";
                this.textBoxNome.Text = "";

                foreach (DataRow row in linhas.Rows)
                {
                    this.textBoxNome.Text = row["nome"].ToString(); ;
                    this.maskedTextBoxTelefone.Text = row["telefone"].ToString(); ;
                    this.textBoxCPF.Text = row["cpf"].ToString(); ;
                    this.textBoxRua.Text = row["logradouro"].ToString(); ;
                    this.textBoxbairro.Text = row["bairro"].ToString(); ;
                    this.textBoxNum.Text = row["Número"].ToString(); ;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInserirPizza_Click(object sender, EventArgs e)
        {
            Pizzas.Add(new Pizza
            {
                Sabores = checkedListBoxSabores.CheckedItems.OfType<Sabor>().ToList(),
                Tamanho = (char)(EnumProdutoTamanho)Enum.Parse(typeof(EnumValorTamanho), comboBoxtamanho.Text),
                Borda = (char)(EnumBorda)Enum.Parse(typeof(EnumBorda), comboBoxBorda.Text),
                Observacao = textBoxObservação.Text,
                 
            });

            
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSalvarPedido_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonInserirBebida_Click(object sender, EventArgs e)
        {

        }

        
    }
}
