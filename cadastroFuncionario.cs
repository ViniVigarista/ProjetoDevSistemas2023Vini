using ProjetoDevSistemas2023Vini.DAO;
using System.Configuration;
using System.Data;

namespace ProjetoDevSistemas2023Vini
{
    public partial class Funcionarios : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;
        public Funcionarios()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            this.maskedTextBoxCep.Leave += MaskedTextBoxCep_Leave;

            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;

        }

        public void MaskedTextBoxCep_Leave(object? sender, EventArgs e)
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
                this.textBoxId.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                this.textBoxEndereco.Text = "";
                this.textBoxBairro.Text = "";
                this.textBoxCidade.Text = "";
                this.comboBoxUF.Text = "";
                this.textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    this.textBoxId.Text = row["id"].ToString(); ;
                    this.maskedTextBoxCep.Text = row["cep"].ToString(); ;
                    this.textBoxEndereco.Text = row["logradouro"].ToString(); ;
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

        public void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
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

        void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (this.textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = textBoxNome.Text,
                Cpf = maskedTextBoxCPF.Text,
                Matricula = textBoxId.Text,
                Senha = Funcoes.Sha256Hash(textBoxSenha.Text),
                Grupo = (radioButtonGrupoAdmin.Checked) ? '1' : (radioButtonGrupoAtendente.Checked) ? '2' : '3',
                Motorista = textBoxCNH.Text,
                Validade = dateTimePickerValidade.Value,
                Observacao = textBoxObservacao.Text,
                Telefone = maskedTextBoxtelefone.Text,
                Email = textBoxEMail.Text,
                EnderecoId = int.Parse(this.textBoxId.Text),
                Numero = textBoxNumCasa.Text,
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonlistaFunc_Click(object sender, EventArgs e)
        {
            AtualizarTela();
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
        }

        public void DataGridViewDados_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = ClassEnum.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }

            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }

        
    }

}




