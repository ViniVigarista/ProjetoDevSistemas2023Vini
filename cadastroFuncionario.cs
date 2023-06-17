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



        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxId.Text = row[0].ToString();
                    textBoxNome.Text = row[1].ToString();
                    maskedTextBoxCPF.Text = row[2].ToString();
                    textBoxId.Text = row[3].ToString();
                    textBoxSenha.Text = row[4].ToString();
                    if (row[5].ToString().Equals("1"))
                    {
                        radioButtonGrupoAdmin.Checked = true;
                    }
                    else if (row[5].ToString().Equals("2"))
                    {
                        radioButtonGrupoAtendente.Checked = true;
                    }
                    else
                    {
                        radioButtonGrupoEntregador.Checked = true;
                    }
                    textBoxCNH.Text = row[6].ToString();
                    dateTimePickerValidade.Text = row[7].ToString();
                    textBoxObservacao.Text = row[8].ToString();
                    maskedTextBoxtelefone.Text = row[9].ToString();
                    textBoxEMail.Text = row[10].ToString();
                    this.textBoxId.Text = row[11].ToString();
                    this.maskedTextBoxCep.Text = row[12].ToString();
                    this.textBoxEndereco.Text = row[13].ToString();
                    this.textBoxBairro.Text = row[14].ToString();
                    this.textBoxCidade.Text = row[16].ToString();
                    this.comboBoxUF.Text = row[18].ToString();
                    this.textBoxPais.Text = row[20].ToString();
                    textBoxNumCasa.Text = row[21].ToString();
                    textBoxComplemento.Text = row[22].ToString();
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
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
                e.Value = ClassEnum.GetDescription((EnumFuncionarioGrupo)int.Parse(s: e.Value.ToString()));
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

        private void dataGridViewDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length <= 0 || this.textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(textBoxId.Text),
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
                // chama o método da model para editar
                funcionarioDAO.Editar(funcionario);
                MessageBox.Show("Dados editados com sucesso! " + textBoxId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = int.Parse(textBoxId.Text),
            };
            try
            {
                // chama o método da model para excluir
                funcionarioDAO.Excluir(funcionario);
                MessageBox.Show("Dados excluidos com sucesso! " + textBoxId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}




