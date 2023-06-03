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
using System.Data;

namespace ProjetoDevSistemas2023Vini
{
    public partial class listaClientes : Form
    {
        private readonly ClienteDAO clienteDAO;
        public listaClientes()
        {
            InitializeComponent();

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
        }

       
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDadoCliente.Columns.Clear();
                dataGridViewDadoCliente.AutoGenerateColumns = true;
                dataGridViewDadoCliente.DataSource = linhas;
                dataGridViewDadoCliente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listaClientes_Load(object sender, EventArgs e)
        {
            AtualizarTela();    
        }
    }
}
