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
            comboBoxTamanho = new ComboBox();
            comboBoxCategoria = new ComboBox();
            labelTamanhoPizza = new Label();
            labelCategoriaPizza = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            labelValorBorda = new Label();
            textBoxValor = new TextBox();
            textBoxvalorBorda = new TextBox();
            SuspendLayout();
            // 
            // IDpizza
            // 
            IDpizza.AutoSize = true;
            IDpizza.Location = new Point(45, 60);
            IDpizza.Name = "IDpizza";
            IDpizza.Size = new Size(18, 15);
            IDpizza.TabIndex = 0;
            IDpizza.Text = "ID";
            // 
            // textBoxIDpizza
            // 
            textBoxIDpizza.Location = new Point(69, 57);
            textBoxIDpizza.Name = "textBoxIDpizza";
            textBoxIDpizza.Size = new Size(100, 23);
            textBoxIDpizza.TabIndex = 1;
            textBoxIDpizza.TextChanged += textBoxIDpizza_TextChanged;
            // 
            // labelValorPizza
            // 
            labelValorPizza.AutoSize = true;
            labelValorPizza.Location = new Point(46, 214);
            labelValorPizza.Name = "labelValorPizza";
            labelValorPizza.Size = new Size(33, 15);
            labelValorPizza.TabIndex = 2;
            labelValorPizza.Text = "Valor";
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "Pequena", "Media", "Grande", "Familia" });
            comboBoxTamanho.Location = new Point(107, 109);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(121, 23);
            comboBoxTamanho.TabIndex = 2;
            comboBoxTamanho.Text = "Selecione";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            comboBoxCategoria.Location = new Point(107, 157);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(121, 23);
            comboBoxCategoria.TabIndex = 3;
            comboBoxCategoria.Text = "Selecione";
            // 
            // labelTamanhoPizza
            // 
            labelTamanhoPizza.AutoSize = true;
            labelTamanhoPizza.Location = new Point(45, 112);
            labelTamanhoPizza.Name = "labelTamanhoPizza";
            labelTamanhoPizza.Size = new Size(56, 15);
            labelTamanhoPizza.TabIndex = 6;
            labelTamanhoPizza.Text = "Tamanho";
            // 
            // labelCategoriaPizza
            // 
            labelCategoriaPizza.AutoSize = true;
            labelCategoriaPizza.Location = new Point(43, 157);
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
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Location = new Point(47, 262);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(67, 15);
            labelValorBorda.TabIndex = 21;
            labelValorBorda.Text = "Valor Borda";
            labelValorBorda.Click += label4_Click;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(85, 211);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(100, 23);
            textBoxValor.TabIndex = 4;
            textBoxValor.TextChanged += textBox1_TextChanged_1;
            // 
            // textBoxvalorBorda
            // 
            textBoxvalorBorda.Location = new Point(120, 259);
            textBoxvalorBorda.Name = "textBoxvalorBorda";
            textBoxvalorBorda.Size = new Size(100, 23);
            textBoxvalorBorda.TabIndex = 5;
            textBoxvalorBorda.TextChanged += textBoxvalorBorda_TextChanged;
            // 
            // cadastroValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 350);
            Controls.Add(textBoxvalorBorda);
            Controls.Add(textBoxValor);
            Controls.Add(labelValorBorda);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(labelCategoriaPizza);
            Controls.Add(labelTamanhoPizza);
            Controls.Add(comboBoxCategoria);
            Controls.Add(comboBoxTamanho);
            Controls.Add(labelValorPizza);
            Controls.Add(textBoxIDpizza);
            Controls.Add(IDpizza);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "cadastroValores";
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            Load += cadastroValores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDpizza;
        private TextBox textBoxIDpizza;
        private Label labelValorPizza;
        private ComboBox comboBoxTamanho;
        private ComboBox comboBoxCategoria;
        private Label labelTamanhoPizza;
        private Label labelCategoriaPizza;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label labelValorBorda;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBoxValor;
        private TextBox textBoxvalorBorda;
    }
}