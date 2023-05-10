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
    public partial class Idioma : Form
    {
        public Idioma()
        {
            InitializeComponent();
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            //seleciona no combo a cultura atual
            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("Cultura");
            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxStringConexao.Text = connectionStringSettings.ConnectionString;
        }

        private void buttonSalvarIdioma_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show(Properties.Resources.confirmidioma, "Idioma/região alterada com sucesso!");
            if (checkBoxAplicar.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }

            //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config

            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");
            //fecha a tela
            Close();
            //dispara msg para usuário
            _ = MessageBox.Show("Dados alterados com sucesso!");
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void checkBoxAplicar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
