namespace ProjetoDevSistemas2023Vini
{
    partial class Funcionarios
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
            components = new System.ComponentModel.Container();
            textBoxNome = new TextBox();
            labelNome = new Label();
            label1 = new Label();
            labelMatricula = new Label();
            textBoxMatricula = new TextBox();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            labelTel = new Label();
            labelFuncao = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBoxFuncao = new ComboBox();
            comboBoxCNH = new ComboBox();
            labelCNH = new Label();
            labelValidade = new Label();
            buttonValidade = new Button();
            toolTip1 = new ToolTip(components);
            textBoxEndereco = new TextBox();
            textBoxNumCasa = new TextBox();
            textBoxBairro = new TextBox();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            buttonLimpar = new Button();
            labelEndereco = new Label();
            labelNumCasa = new Label();
            labelBairro = new Label();
            maskedTextBoxCPF = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(91, 62);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(196, 23);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(39, 65);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 110);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(253, 110);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(57, 15);
            labelMatricula.TabIndex = 4;
            labelMatricula.Text = "Matricula";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(316, 107);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(140, 23);
            textBoxMatricula.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(316, 157);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(140, 23);
            textBoxSenha.TabIndex = 4;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(253, 160);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 8;
            labelSenha.Text = "Senha";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(39, 160);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(51, 15);
            labelTel.TabIndex = 6;
            labelTel.Text = "Telefone";
            labelTel.Click += labelTel_Click;
            // 
            // labelFuncao
            // 
            labelFuncao.AutoSize = true;
            labelFuncao.Location = new Point(39, 207);
            labelFuncao.Name = "labelFuncao";
            labelFuncao.Size = new Size(46, 15);
            labelFuncao.TabIndex = 10;
            labelFuncao.Text = "Função";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBoxFuncao
            // 
            comboBoxFuncao.FormattingEnabled = true;
            comboBoxFuncao.Location = new Point(91, 204);
            comboBoxFuncao.Name = "comboBoxFuncao";
            comboBoxFuncao.Size = new Size(121, 23);
            comboBoxFuncao.TabIndex = 5;
            // 
            // comboBoxCNH
            // 
            comboBoxCNH.FormattingEnabled = true;
            comboBoxCNH.Location = new Point(91, 243);
            comboBoxCNH.Name = "comboBoxCNH";
            comboBoxCNH.Size = new Size(121, 23);
            comboBoxCNH.TabIndex = 6;
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Location = new Point(39, 246);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(33, 15);
            labelCNH.TabIndex = 13;
            labelCNH.Text = "CNH";
            // 
            // labelValidade
            // 
            labelValidade.AutoSize = true;
            labelValidade.Location = new Point(218, 247);
            labelValidade.Name = "labelValidade";
            labelValidade.Size = new Size(51, 15);
            labelValidade.TabIndex = 15;
            labelValidade.Text = "Validade";
            // 
            // buttonValidade
            // 
            buttonValidade.Location = new Point(275, 243);
            buttonValidade.Name = "buttonValidade";
            buttonValidade.Size = new Size(114, 23);
            buttonValidade.TabIndex = 7;
            buttonValidade.Text = "Selecione";
            buttonValidade.UseVisualStyleBackColor = true;
            buttonValidade.Click += buttonValidade_Click;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(101, 287);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(186, 23);
            textBoxEndereco.TabIndex = 8;
            toolTip1.SetToolTip(textBoxEndereco, "True");
            // 
            // textBoxNumCasa
            // 
            textBoxNumCasa.Location = new Point(333, 287);
            textBoxNumCasa.Name = "textBoxNumCasa";
            textBoxNumCasa.Size = new Size(34, 23);
            textBoxNumCasa.TabIndex = 9;
            toolTip1.SetToolTip(textBoxNumCasa, "True");
            textBoxNumCasa.TextChanged += textBoxNumCasa_TextChanged;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(417, 287);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(118, 23);
            textBoxBairro.TabIndex = 10;
            toolTip1.SetToolTip(textBoxBairro, "True");
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(275, 411);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(437, 411);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 13;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(356, 411);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(75, 23);
            buttonLimpar.TabIndex = 12;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(39, 290);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(56, 15);
            labelEndereco.TabIndex = 19;
            labelEndereco.Text = "Endereço";
            // 
            // labelNumCasa
            // 
            labelNumCasa.AutoSize = true;
            labelNumCasa.Location = new Point(293, 290);
            labelNumCasa.Name = "labelNumCasa";
            labelNumCasa.Size = new Size(34, 15);
            labelNumCasa.TabIndex = 23;
            labelNumCasa.Text = "Num";
            labelNumCasa.Click += labelNumCasa_Click;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(373, 290);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 25;
            labelBairro.Text = "Bairro";
            labelBairro.Click += label2_Click;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(91, 107);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(134, 23);
            maskedTextBoxCPF.TabIndex = 1;
            maskedTextBoxCPF.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(96, 157);
            maskedTextBox1.Mask = "(00) 0 0000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(139, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(textBoxBairro);
            Controls.Add(labelBairro);
            Controls.Add(textBoxNumCasa);
            Controls.Add(labelNumCasa);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            Controls.Add(labelEndereco);
            Controls.Add(textBoxEndereco);
            Controls.Add(buttonValidade);
            Controls.Add(labelValidade);
            Controls.Add(comboBoxCNH);
            Controls.Add(labelCNH);
            Controls.Add(comboBoxFuncao);
            Controls.Add(labelFuncao);
            Controls.Add(textBoxSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelTel);
            Controls.Add(textBoxMatricula);
            Controls.Add(labelMatricula);
            Controls.Add(label1);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Funcionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionarios";
            WindowState = FormWindowState.Maximized;
            Load += Funcionarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label labelNome;
        private Label label1;
        private Label labelMatricula;
        private TextBox textBoxMatricula;
        private TextBox textBoxSenha;
        private Label labelSenha;
        private Label labelTel;
        private Label labelFuncao;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxFuncao;
        private ComboBox comboBoxCNH;
        private Label labelCNH;
        private Label labelValidade;
        private Button buttonValidade;
        private ToolTip toolTip1;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonLimpar;
        private Label labelEndereco;
        private TextBox textBoxEndereco;
        private Label labelNumCasa;
        private TextBox textBoxNumCasa;
        private Label labelBairro;
        private TextBox textBoxBairro;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBox1;
    }
}