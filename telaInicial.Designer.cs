namespace ProjetoDevSistemas2023Vini
{
    partial class telaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystem = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            encerrarAplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            botaoSabores = new Button();
            botaoIngredientes = new Button();
            botaoClientes = new Button();
            botaoCadastroValor = new Button();
            botaoFuncionarios = new Button();
            botaoCadastroProduto = new Button();
            botaoPrincipal = new Button();
            Idioma = new Button();
            panel1 = new Panel();
            buttonCor = new Button();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelDados = new Panel();
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            inicioToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            ingredienteToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            cadastroValoresToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            contextMenuStripSystem.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDados.SuspendLayout();
            contextMenuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystem;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé";
            // 
            // contextMenuStripSystem
            // 
            contextMenuStripSystem.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, encerrarAplicaçãoToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStripSystem.Name = "contextMenuStripSystem";
            contextMenuStripSystem.Size = new Size(173, 70);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(172, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // encerrarAplicaçãoToolStripMenuItem
            // 
            encerrarAplicaçãoToolStripMenuItem.Name = "encerrarAplicaçãoToolStripMenuItem";
            encerrarAplicaçãoToolStripMenuItem.Size = new Size(172, 22);
            encerrarAplicaçãoToolStripMenuItem.Text = "Encerrar Aplicação";
            encerrarAplicaçãoToolStripMenuItem.Click += encerrarAplicaçãoToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(172, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // botaoSabores
            // 
            botaoSabores.Location = new Point(56, 155);
            botaoSabores.Name = "botaoSabores";
            botaoSabores.Size = new Size(97, 23);
            botaoSabores.TabIndex = 4;
            botaoSabores.Text = "Sabores";
            botaoSabores.UseVisualStyleBackColor = true;
            botaoSabores.Click += buttonSabores;
            // 
            // botaoIngredientes
            // 
            botaoIngredientes.Location = new Point(56, 126);
            botaoIngredientes.Name = "botaoIngredientes";
            botaoIngredientes.Size = new Size(97, 23);
            botaoIngredientes.TabIndex = 3;
            botaoIngredientes.Text = "Ingredientes";
            botaoIngredientes.UseVisualStyleBackColor = true;
            botaoIngredientes.Click += buttonIngredientes;
            // 
            // botaoClientes
            // 
            botaoClientes.Location = new Point(56, 97);
            botaoClientes.Name = "botaoClientes";
            botaoClientes.Size = new Size(97, 23);
            botaoClientes.TabIndex = 2;
            botaoClientes.Text = "Clientes";
            botaoClientes.UseVisualStyleBackColor = true;
            botaoClientes.Click += buttonClientes;
            // 
            // botaoCadastroValor
            // 
            botaoCadastroValor.Location = new Point(56, 184);
            botaoCadastroValor.Name = "botaoCadastroValor";
            botaoCadastroValor.Size = new Size(97, 42);
            botaoCadastroValor.TabIndex = 5;
            botaoCadastroValor.Text = "Cadastro Valores";
            botaoCadastroValor.UseVisualStyleBackColor = true;
            botaoCadastroValor.Click += cadastroValor_Click;
            // 
            // botaoFuncionarios
            // 
            botaoFuncionarios.AutoSize = true;
            botaoFuncionarios.Location = new Point(56, 68);
            botaoFuncionarios.Name = "botaoFuncionarios";
            botaoFuncionarios.Size = new Size(97, 25);
            botaoFuncionarios.TabIndex = 1;
            botaoFuncionarios.Text = "Funcionários";
            botaoFuncionarios.UseVisualStyleBackColor = true;
            botaoFuncionarios.Click += buttonFuncionarios;
            botaoFuncionarios.Enter += buttonFuncionarios;
            botaoFuncionarios.Leave += buttonFuncionarios;
            // 
            // botaoCadastroProduto
            // 
            botaoCadastroProduto.Location = new Point(56, 232);
            botaoCadastroProduto.Name = "botaoCadastroProduto";
            botaoCadastroProduto.Size = new Size(97, 40);
            botaoCadastroProduto.TabIndex = 6;
            botaoCadastroProduto.Text = "Cadastro Produtos";
            botaoCadastroProduto.UseVisualStyleBackColor = true;
            botaoCadastroProduto.Click += buttonCadastroProduto;
            // 
            // botaoPrincipal
            // 
            botaoPrincipal.Location = new Point(56, 39);
            botaoPrincipal.Name = "botaoPrincipal";
            botaoPrincipal.Size = new Size(97, 23);
            botaoPrincipal.TabIndex = 0;
            botaoPrincipal.Text = "Principal";
            botaoPrincipal.UseVisualStyleBackColor = true;
            botaoPrincipal.Click += principal_Click;
            // 
            // Idioma
            // 
            Idioma.Location = new Point(17, 345);
            Idioma.Name = "Idioma";
            Idioma.Size = new Size(75, 23);
            Idioma.TabIndex = 9;
            Idioma.Text = "Idioma";
            Idioma.UseVisualStyleBackColor = true;
            Idioma.Click += buttonIdioma_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCor);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Idioma);
            panel1.Controls.Add(botaoPrincipal);
            panel1.Controls.Add(botaoCadastroProduto);
            panel1.Controls.Add(botaoFuncionarios);
            panel1.Controls.Add(botaoCadastroValor);
            panel1.Controls.Add(botaoClientes);
            panel1.Controls.Add(botaoIngredientes);
            panel1.Controls.Add(botaoSabores);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 380);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // buttonCor
            // 
            buttonCor.Location = new Point(138, 345);
            buttonCor.Name = "buttonCor";
            buttonCor.Size = new Size(44, 23);
            buttonCor.TabIndex = 17;
            buttonCor.Text = "Cor";
            buttonCor.UseVisualStyleBackColor = true;
            buttonCor.Click += buttonCor_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 232);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(38, 40);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 184);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 42);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 155);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 23);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 126);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 68);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDados
            // 
            panelDados.ContextMenuStrip = contextMenuStripPrincipal;
            panelDados.Controls.Add(pictureBox1);
            panelDados.Dock = DockStyle.Fill;
            panelDados.Location = new Point(200, 0);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(496, 380);
            panelDados.TabIndex = 10;
            panelDados.Paint += panelDados_Paint;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, funcionárioToolStripMenuItem, clienteToolStripMenuItem, ingredienteToolStripMenuItem, saboresToolStripMenuItem, cadastroValoresToolStripMenuItem, configuraçõesToolStripMenuItem, sairToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStrip1";
            contextMenuStripPrincipal.Size = new Size(162, 180);
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(161, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(161, 22);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(161, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // ingredienteToolStripMenuItem
            // 
            ingredienteToolStripMenuItem.Name = "ingredienteToolStripMenuItem";
            ingredienteToolStripMenuItem.Size = new Size(161, 22);
            ingredienteToolStripMenuItem.Text = "Ingrediente";
            ingredienteToolStripMenuItem.Click += ingredienteToolStripMenuItem_Click;
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.Size = new Size(161, 22);
            saboresToolStripMenuItem.Text = "Sabores";
            saboresToolStripMenuItem.Click += saboresToolStripMenuItem_Click;
            // 
            // cadastroValoresToolStripMenuItem
            // 
            cadastroValoresToolStripMenuItem.Name = "cadastroValoresToolStripMenuItem";
            cadastroValoresToolStripMenuItem.Size = new Size(161, 22);
            cadastroValoresToolStripMenuItem.Text = "Cadastro Valores";
            cadastroValoresToolStripMenuItem.Click += cadastroValoresToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(161, 22);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += configuraçõesToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(161, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // telaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 380);
            Controls.Add(panelDados);
            Controls.Add(panel1);
            Name = "telaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            WindowState = FormWindowState.Maximized;
            Load += telaInicial_Load;
            contextMenuStripSystem.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDados.ResumeLayout(false);
            panelDados.PerformLayout();
            contextMenuStripPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIconSystemTray;
        private Button botaoSabores;
        private Button botaoIngredientes;
        private Button botaoClientes;
        private Button botaoCadastroValor;
        private Button botaoFuncionarios;
        private Button botaoCadastroProduto;
        private Button botaoPrincipal;
        private Button Idioma;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelDados;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem ingredienteToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem cadastroValoresToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ContextMenuStrip contextMenuStripSystem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem encerrarAplicaçãoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button buttonCor;
        private ColorDialog colorDialog1;
    }
}