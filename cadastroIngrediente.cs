using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDevSistemas2023Vini.DAO;
using System.Configuration;



namespace ProjetoDevSistemas2023Vini
{


    public partial class Ingredientes : Form
    {

        private readonly IngredienteDAO dao;


        public Ingredientes()
        {

            InitializeComponent();
            


            //pegar dados banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;


            //cria a instancia da classe da model
            dao = new IngredienteDAO(provider, strConnection);


            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);

            #region idioma/região interface - satellite assembly
            // com base no idioma/região escolhido pelo usuário,
            // ajusta as propriedades dos componentes da tela com base no conteúdo do arquivo resources
            Funcoes.AjustaResourcesControl(this);
            //ajuste manual de campos ou mensagens para o usuário que não puderam ser automatizadas acima
            this.Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            #endregion

        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void buttonCancelarIngrediente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            var ingrediente = new Ingrediente
            {
                Id = 0,
                Nome = textBoxNomeIngrediente.Text,
            };

            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(ingrediente);
                MessageBox.Show(Properties.Resources.dadosok, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxNomeIngrediente_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
