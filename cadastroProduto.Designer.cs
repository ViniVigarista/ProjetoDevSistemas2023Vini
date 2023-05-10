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
            comboBoxQtdBebida = new ComboBox();
            labelTamanhoBebida = new Label();
            labelNomeBebida = new Label();
            textBoxNomeBebida = new TextBox();
            labelTipobebida = new Label();
            comboBoxTipoBebida = new ComboBox();
            textBoxOutraBebida = new TextBox();
            labelOutraBebida = new Label();
            textBoxValorBebida = new TextBox();
            labelValorBebida = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            SuspendLayout();
            // 
            // comboBoxQtdBebida
            // 
            comboBoxQtdBebida.FormattingEnabled = true;
            comboBoxQtdBebida.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            comboBoxQtdBebida.Location = new Point(126, 159);
            comboBoxQtdBebida.Name = "comboBoxQtdBebida";
            comboBoxQtdBebida.Size = new Size(121, 23);
            comboBoxQtdBebida.TabIndex = 4;
            comboBoxQtdBebida.Text = "Selecione";
            comboBoxQtdBebida.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelTamanhoBebida
            // 
            labelTamanhoBebida.AutoSize = true;
            labelTamanhoBebida.Location = new Point(64, 162);
            labelTamanhoBebida.Name = "labelTamanhoBebida";
            labelTamanhoBebida.Size = new Size(56, 15);
            labelTamanhoBebida.TabIndex = 1;
            labelTamanhoBebida.Text = "Tamanho";
            // 
            // labelNomeBebida
            // 
            labelNomeBebida.AutoSize = true;
            labelNomeBebida.Location = new Point(77, 35);
            labelNomeBebida.Name = "labelNomeBebida";
            labelNomeBebida.Size = new Size(43, 15);
            labelNomeBebida.TabIndex = 2;
            labelNomeBebida.Text = "Nome:";
            // 
            // textBoxNomeBebida
            // 
            textBoxNomeBebida.Location = new Point(126, 32);
            textBoxNomeBebida.Name = "textBoxNomeBebida";
            textBoxNomeBebida.Size = new Size(121, 23);
            textBoxNomeBebida.TabIndex = 0;
            // 
            // labelTipobebida
            // 
            labelTipobebida.AutoSize = true;
            labelTipobebida.Location = new Point(77, 85);
            labelTipobebida.Name = "labelTipobebida";
            labelTipobebida.Size = new Size(30, 15);
            labelTipobebida.TabIndex = 5;
            labelTipobebida.Text = "Tipo";
            // 
            // comboBoxTipoBebida
            // 
            comboBoxTipoBebida.FormattingEnabled = true;
            comboBoxTipoBebida.Items.AddRange(new object[] { "Refrigerante", "Cerveja", "Suco", "Água", "Outros" });
            comboBoxTipoBebida.Location = new Point(126, 82);
            comboBoxTipoBebida.Name = "comboBoxTipoBebida";
            comboBoxTipoBebida.Size = new Size(121, 23);
            comboBoxTipoBebida.TabIndex = 1;
            comboBoxTipoBebida.Text = "Selecione";
            // 
            // textBoxOutraBebida
            // 
            textBoxOutraBebida.Location = new Point(126, 111);
            textBoxOutraBebida.Name = "textBoxOutraBebida";
            textBoxOutraBebida.Size = new Size(121, 23);
            textBoxOutraBebida.TabIndex = 3;
            // 
            // labelOutraBebida
            // 
            labelOutraBebida.AutoSize = true;
            labelOutraBebida.Location = new Point(77, 114);
            labelOutraBebida.Name = "labelOutraBebida";
            labelOutraBebida.Size = new Size(41, 15);
            labelOutraBebida.TabIndex = 6;
            labelOutraBebida.Text = "Outro:";
            // 
            // textBoxValorBebida
            // 
            textBoxValorBebida.Location = new Point(126, 207);
            textBoxValorBebida.Name = "textBoxValorBebida";
            textBoxValorBebida.Size = new Size(121, 23);
            textBoxValorBebida.TabIndex = 5;
            // 
            // labelValorBebida
            // 
            labelValorBebida.AutoSize = true;
            labelValorBebida.Location = new Point(77, 210);
            labelValorBebida.Name = "labelValorBebida";
            labelValorBebida.Size = new Size(36, 15);
            labelValorBebida.TabIndex = 8;
            labelValorBebida.Text = "Valor:";
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
            // 
            // cadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(277, 333);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxValorBebida);
            Controls.Add(labelValorBebida);
            Controls.Add(textBoxOutraBebida);
            Controls.Add(labelOutraBebida);
            Controls.Add(labelTipobebida);
            Controls.Add(comboBoxTipoBebida);
            Controls.Add(textBoxNomeBebida);
            Controls.Add(labelNomeBebida);
            Controls.Add(labelTamanhoBebida);
            Controls.Add(comboBoxQtdBebida);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "cadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Produto";
            WindowState = FormWindowState.Maximized;
            Load += cadastroProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxQtdBebida;
        private Label labelTamanhoBebida;
        private Label labelNomeBebida;
        private TextBox textBoxNomeBebida;
        private Label labelTipobebida;
        private ComboBox comboBoxTipoBebida;
        private TextBox textBoxOutraBebida;
        private Label labelOutraBebida;
        private TextBox textBoxValorBebida;
        private Label labelValorBebida;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}