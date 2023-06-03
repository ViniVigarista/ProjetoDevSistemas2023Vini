using ProjetoDevSistemas2023Vini.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDevSistemas2023Vini;
using ProjetoDevSistemas2023Vini.DAO;
using MySqlX.XDevAPI;

namespace ProjetoDevSistemas2023Vini
{

    public partial class Clientes : Form
    {

        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;


        public Clientes()
        {
            InitializeComponent();
            maskedTextBoxCPF.MaxLength = 11;
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);


        }







        private void buttonCancelarCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            if (this.maskedTextBoxCep.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = this.maskedTextBoxCep.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                this.textBoxID.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                this.textBoxLogradouro.Text = "";
                this.textBoxBairro.Text = "";
                this.textBoxCidade.Text = "";
                this.comboBoxUF.Text = "";
                this.textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    this.textBoxID.Text = row["id"].ToString(); ;
                    this.maskedTextBoxCep.Text = row["cep"].ToString(); ;
                    this.textBoxLogradouro.Text = row["logradouro"].ToString(); ;
                    this.textBoxBairro.Text = row["bairro"].ToString(); ;
                    this.textBoxCidade.Text = row["cidade"].ToString(); ;
                    this.comboBoxUF.Text = row["uf"].ToString(); ;
                    this.textBoxPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonListaEndereco_Click(object sender, EventArgs e)
        {
            Form listaEnd = new listaEnd();
            listaEnd.Show();
        }

        public void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = textBoxNomeCliente.Text,
                Cpf = maskedTextBoxCPF.Text,
                Telefone = maskedTextBoxTelefone.Text,
                Email = textBoxEmail.Text,
                EnderecoId = int.Parse(this.textBoxID.Text),
                Numero = textBoxNumCasa.Text,
                Complemento = textBoxComplementoCliente.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBoxCep.MaxLength = 20;
        }

        private void buttonListaClientes_Click(object sender, EventArgs e)
        {
            Form listaClientes = new listaClientes();
            listaClientes.Show();
        }
    }
}
