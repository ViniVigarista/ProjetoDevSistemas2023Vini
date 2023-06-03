namespace ProjetoDevSistemas2023Vini
{
    partial class cadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            labelNomeBebida = new Label();
            textBoxNomeBebida = new TextBox();
            textBoxValor = new TextBox();
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            listBoxTipo = new ListBox();
            label3 = new Label();
            label4 = new Label();
            buttonProdutos = new Button();
            dataGridViewDados = new DataGridView();
            listBoxML = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(82, 278);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelarIngrediente_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(172, 278);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 7;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelNomeBebida
            // 
            labelNomeBebida.AutoSize = true;
            labelNomeBebida.Location = new Point(23, 32);
            labelNomeBebida.Name = "labelNomeBebida";
            labelNomeBebida.Size = new Size(17, 15);
            labelNomeBebida.TabIndex = 2;
            labelNomeBebida.Text = "Id";
            // 
            // textBoxNomeBebida
            // 
            textBoxNomeBebida.Location = new Point(46, 29);
            textBoxNomeBebida.Name = "textBoxNomeBebida";
            textBoxNomeBebida.Size = new Size(60, 23);
            textBoxNomeBebida.TabIndex = 0;
            textBoxNomeBebida.Visible = false;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(73, 108);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(121, 23);
            textBoxValor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 111);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 9;
            label1.Text = "Valor";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(73, 68);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(121, 23);
            textBoxNome.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome:";
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(240, 37);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(120, 94);
            listBoxTipo.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 19);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 14;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 19);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 15;
            label4.Text = "Tamanho";
            // 
            // buttonProdutos
            // 
            buttonProdutos.Location = new Point(262, 278);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(75, 23);
            buttonProdutos.TabIndex = 16;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(633, 29);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(541, 150);
            dataGridViewDados.TabIndex = 17;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            // 
            // listBoxML
            // 
            listBoxML.FormattingEnabled = true;
            listBoxML.ItemHeight = 15;
            listBoxML.Location = new Point(401, 37);
            listBoxML.Name = "listBoxML";
            listBoxML.Size = new Size(120, 94);
            listBoxML.TabIndex = 13;
            listBoxML.SelectedIndexChanged += listBoxTamanho_SelectedIndexChanged;
            // 
            // cadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1359, 333);
            Controls.Add(dataGridViewDados);
            Controls.Add(buttonProdutos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxML);
            Controls.Add(listBoxTipo);
            Controls.Add(textBoxNome);
            Controls.Add(label2);
            Controls.Add(textBoxValor);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxNomeBebida);
            Controls.Add(labelNomeBebida);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "cadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Produto";
            WindowState = FormWindowState.Maximized;
            Load += cadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label labelNomeBebida;
        private TextBox textBoxNomeBebida;
        private TextBox textBoxValor;
        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private ListBox listBoxTipo;
        private Label label3;
        private Label label4;
        private Button buttonProdutos;
        private DataGridView dataGridViewDados;
        private ListBox listBoxML;
    }
}