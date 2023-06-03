using System.Configuration;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace ProjetoDevSistemas2023Vini
{
    public partial class telaInicial : Form
    {
        private object comboBoxIdioma;

        public object ButtonInicio_Click { get; private set; }
        public object Cor { get; set; }

        public telaInicial()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormIsClosing!);
            this.Resize += new EventHandler(telaInicial_Resize!);
            

            inicioToolStripMenuItem.Click += new EventHandler(principal_Click!);
            inicioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            funcionárioToolStripMenuItem.Click += new EventHandler(buttonFuncionarios!);
            funcionárioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            clienteToolStripMenuItem.Click += new EventHandler(buttonClientes!);
            clienteToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            ingredienteToolStripMenuItem.Click += new EventHandler(buttonIngredientes!);
            ingredienteToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            saboresToolStripMenuItem.Click += new EventHandler(buttonSabores!);
            saboresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            cadastroValoresToolStripMenuItem.Click += new EventHandler(cadastroValor_Click!);
            cadastroValoresToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F6;
            configuraçõesToolStripMenuItem.Click += new EventHandler(buttonIdioma_Click!);
            configuraçõesToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F7;
            sairToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F8;

             
            


        }

      

        public void telaInicial_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        public static void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {

                    DialogResult result = MessageBox.Show(Properties.Resources.confirm, "",

                                               MessageBoxButtons.YesNoCancel,
                                               MessageBoxIcon.Question);


                    switch (result)
                    {

                        case DialogResult.Yes:
                            ((Form)sender).WindowState = FormWindowState.Minimized;
                            e.Cancel = true; // Cancela o evento de fechamento
                            break;
                        case DialogResult.No:
                            e.Cancel = false;
                            break;
                        default:
                            e.Cancel = true;
                            break;
                    }


                }
            }
        }






        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }




        private void buttonClientes(object sender, EventArgs e)
        {
            Form clientes = new Clientes();
            clientes.TopLevel = false;
            panelDados.Controls.Add(clientes);
            clientes.Show();
            DisposeAllButThis(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            
        }

        private void buttonFuncionarios(object sender, EventArgs e)
        {
            Form funcionarios = new Funcionarios();
            funcionarios.TopLevel = false;
            funcionarios.BackColor = Color.Yellow;
            funcionarios.BackColor = Color.White;
            panelDados.Controls.Add(funcionarios);
            funcionarios.Show();
            DisposeAllButThis(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void buttonIngredientes(object sender, EventArgs e)
        {

            Form ingrediente = new Ingredientes();
            ingrediente.TopLevel = false;
            panelDados.Controls.Add(ingrediente);
            ingrediente.Show();
            DisposeAllButThis(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


        }

        private void buttonSabores(object sender, EventArgs e)
        {
            Form sabores = new Sabores();
            sabores.TopLevel = false;
            panelDados.Controls.Add(sabores);
            sabores.Show();
            DisposeAllButThis(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }




        private void buttonCadastroProduto(object sender, EventArgs e)
        {
            Form cadastroProduto = new cadastroProduto();
            cadastroProduto.TopLevel = false;
            panelDados.Controls.Add(cadastroProduto);
            cadastroProduto.Show();
            DisposeAllButThis(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

        }

        private void principal_Click(object sender, EventArgs e)
        {
            Form principal = new Form();
            principal.TopLevel = false;
            panelDados.Controls.Add(principal);

            DisposeAllButThis(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);



        }




        private void cadastroValor_Click(object sender, EventArgs e)
        {
            Form cadastroValor = new cadastroValores();
            cadastroValor.TopLevel = false;
            panelDados.Controls.Add(cadastroValor);
            cadastroValor.Show();
            DisposeAllButThis(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.DialogResult = DialogResult.OK;

        }



        private void buttonIdioma_Click(object sender, EventArgs e)
        {
            Form idioma = new Idioma();
            idioma.Show();
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


        }





        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void cadastroValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void encerrarAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }

        private void panelDados_Paint(object sender, PaintEventArgs e)
        {
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            BackColor = Color.LightBlue;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        public void buttonCor_Click(object sender, EventArgs e)
        {






        }
    }
}