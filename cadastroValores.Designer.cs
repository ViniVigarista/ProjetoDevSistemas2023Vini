namespace ProjetoDevSistemas2023Vini
{
    partial class cadastroValores
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
            IDpizza = new Label();
            textBoxIDpizza = new TextBox();
            labelValorPizza = new Label();
            labelTamanhoPizza = new Label();
            labelCategoriaPizza = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            labelValorBorda = new Label();
            textBoxValor = new TextBox();
            textBoxvalorBorda = new TextBox();
            listBoxTamanho = new ListBox();
            listBoxCategoria = new ListBox();
            dataGridViewDados = new DataGridView();
            buttonSabores = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // IDpizza
            // 
            IDpizza.AutoSize = true;
            IDpizza.Location = new Point(45, 24);
            IDpizza.Name = "IDpizza";
            IDpizza.Size = new Size(18, 15);
            IDpizza.TabIndex = 0;
            IDpizza.Text = "ID";
            // 
            // textBoxIDpizza
            // 
            textBoxIDpizza.Location = new Point(69, 21);
            textBoxIDpizza.Name = "textBoxIDpizza";
            textBoxIDpizza.Size = new Size(100, 23);
            textBoxIDpizza.TabIndex = 1;
            // 
            // labelValorPizza
            // 
            labelValorPizza.AutoSize = true;
            labelValorPizza.Location = new Point(16, 213);
            labelValorPizza.Name = "labelValorPizza";
            labelValorPizza.Size = new Size(33, 15);
            labelValorPizza.TabIndex = 2;
            labelValorPizza.Text = "Valor";
            // 
            // labelTamanhoPizza
            // 
            labelTamanhoPizza.AutoSize = true;
            labelTamanhoPizza.Location = new Point(55, 65);
            labelTamanhoPizza.Name = "labelTamanhoPizza";
            labelTamanhoPizza.Size = new Size(56, 15);
            labelTamanhoPizza.TabIndex = 6;
            labelTamanhoPizza.Text = "Tamanho";
            // 
            // labelCategoriaPizza
            // 
            labelCategoriaPizza.AutoSize = true;
            labelCategoriaPizza.Location = new Point(225, 65);
            labelCategoriaPizza.Name = "labelCategoriaPizza";
            labelCategoriaPizza.Size = new Size(58, 15);
            labelCategoriaPizza.TabIndex = 7;
            labelCategoriaPizza.Text = "Categoria";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(94, 315);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelarIngrediente_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(184, 315);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 7;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Location = new Point(193, 213);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(67, 15);
            labelValorBorda.TabIndex = 21;
            labelValorBorda.Text = "Valor Borda";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(55, 210);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(100, 23);
            textBoxValor.TabIndex = 4;
            textBoxValor.TextChanged += textBox1_TextChanged_1;
            // 
            // textBoxvalorBorda
            // 
            textBoxvalorBorda.Location = new Point(266, 210);
            textBoxvalorBorda.Name = "textBoxvalorBorda";
            textBoxvalorBorda.Size = new Size(100, 23);
            textBoxvalorBorda.TabIndex = 5;
            textBoxvalorBorda.TextChanged += textBoxvalorBorda_TextChanged;
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 15;
            listBoxTamanho.Location = new Point(22, 83);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(120, 94);
            listBoxTamanho.TabIndex = 22;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(193, 83);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(120, 94);
            listBoxCategoria.TabIndex = 23;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(448, 27);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(334, 150);
            dataGridViewDados.TabIndex = 24;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            // 
            // buttonSabores
            // 
            buttonSabores.Location = new Point(275, 315);
            buttonSabores.Name = "buttonSabores";
            buttonSabores.Size = new Size(75, 23);
            buttonSabores.TabIndex = 25;
            buttonSabores.Text = "Valores";
            buttonSabores.UseVisualStyleBackColor = true;
            buttonSabores.Click += buttonSabores_Click;
            // 
            // cadastroValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 350);
            Controls.Add(buttonSabores);
            Controls.Add(dataGridViewDados);
            Controls.Add(listBoxCategoria);
            Controls.Add(listBoxTamanho);
            Controls.Add(textBoxvalorBorda);
            Controls.Add(textBoxValor);
            Controls.Add(labelValorBorda);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(labelCategoriaPizza);
            Controls.Add(labelTamanhoPizza);
            Controls.Add(labelValorPizza);
            Controls.Add(textBoxIDpizza);
            Controls.Add(IDpizza);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "cadastroValores";
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            Load += cadastroValores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDpizza;
        private TextBox textBoxIDpizza;
        private Label labelValorPizza;
        private Label labelTamanhoPizza;
        private Label labelCategoriaPizza;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label labelValorBorda;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBoxValor;
        private TextBox textBoxvalorBorda;
        private ListBox listBoxTamanho;
        private ListBox listBoxCategoria;
        private DataGridView dataGridViewDados;
        private Button buttonSabores;
    }
}