namespace ProjetoDevSistemas2023Vini
{
    partial class Pedidos
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
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxRua = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxNum = new TextBox();
            buttonClientes = new Button();
            panel1 = new Panel();
            comboBoxtamanho = new ComboBox();
            label8 = new Label();
            buttonInserirPizza = new Button();
            textBoxObservação = new TextBox();
            checkedListBoxSabores = new CheckedListBox();
            label6 = new Label();
            label7 = new Label();
            comboBoxBorda = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            textBoxbairro = new TextBox();
            label9 = new Label();
            buttonEditar = new Button();
            textBoxId = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            radioButtonEntrega = new RadioButton();
            radioButtonRetirada = new RadioButton();
            textBoxCPF = new TextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            panel2 = new Panel();
            checkedListBoxProduto = new CheckedListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 71);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "CPF";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(67, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(196, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.Leave += textBoxNome_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 30);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(67, 109);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(182, 23);
            textBoxRua.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 112);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 10;
            label4.Text = "Rua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 112);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 12;
            label5.Text = "Num";
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(316, 109);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(55, 23);
            textBoxNum.TabIndex = 11;
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(562, 22);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(134, 23);
            buttonClientes.TabIndex = 13;
            buttonClientes.Text = "Cadastrar Cliente";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(comboBoxtamanho);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonInserirPizza);
            panel1.Controls.Add(textBoxObservação);
            panel1.Controls.Add(checkedListBoxSabores);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBoxBorda);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(33, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 323);
            panel1.TabIndex = 14;
            // 
            // comboBoxtamanho
            // 
            comboBoxtamanho.FormattingEnabled = true;
            comboBoxtamanho.Items.AddRange(new object[] { "P - 1", "M - 2 ", "G - 3", "F - 4" });
            comboBoxtamanho.Location = new Point(20, 32);
            comboBoxtamanho.Name = "comboBoxtamanho";
            comboBoxtamanho.Size = new Size(148, 23);
            comboBoxtamanho.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 76);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 16;
            label8.Text = "Observação";
            label8.Click += label8_Click;
            // 
            // buttonInserirPizza
            // 
            buttonInserirPizza.Location = new Point(376, 285);
            buttonInserirPizza.Name = "buttonInserirPizza";
            buttonInserirPizza.Size = new Size(75, 23);
            buttonInserirPizza.TabIndex = 27;
            buttonInserirPizza.Text = "Inserir";
            buttonInserirPizza.UseVisualStyleBackColor = true;
            buttonInserirPizza.Click += buttonInserirPizza_Click;
            // 
            // textBoxObservação
            // 
            textBoxObservação.Location = new Point(262, 94);
            textBoxObservação.Multiline = true;
            textBoxObservação.Name = "textBoxObservação";
            textBoxObservação.Size = new Size(171, 96);
            textBoxObservação.TabIndex = 15;
            textBoxObservação.TextChanged += textBoxObservação_TextChanged;
            // 
            // checkedListBoxSabores
            // 
            checkedListBoxSabores.FormattingEnabled = true;
            checkedListBoxSabores.Location = new Point(20, 76);
            checkedListBoxSabores.Name = "checkedListBoxSabores";
            checkedListBoxSabores.Size = new Size(170, 148);
            checkedListBoxSabores.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 14);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 1;
            label6.Text = "Tamanho Pizza";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 58);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 23;
            label7.Text = "Sabores Pizza";
            // 
            // comboBoxBorda
            // 
            comboBoxBorda.FormattingEnabled = true;
            comboBoxBorda.Items.AddRange(new object[] { "Não", "Catupiry", "Chocolate Branco", "Cheddar", "Chocolate Preto" });
            comboBoxBorda.Location = new Point(20, 246);
            comboBoxBorda.Name = "comboBoxBorda";
            comboBoxBorda.Size = new Size(148, 23);
            comboBoxBorda.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 228);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 25;
            label10.Text = "Borda";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(206, 14);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 21;
            label12.Text = "Tamanho";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 14);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 26;
            label11.Text = "Bebidas";
            // 
            // textBoxbairro
            // 
            textBoxbairro.Location = new Point(453, 109);
            textBoxbairro.Name = "textBoxbairro";
            textBoxbairro.Size = new Size(100, 23);
            textBoxbairro.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(409, 112);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 18;
            label9.Text = "Bairro";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(562, 51);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(134, 23);
            buttonEditar.TabIndex = 19;
            buttonEditar.Text = "Editar Cliente";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(33, 152);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 29;
            textBoxId.Visible = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(686, 466);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 30;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(767, 466);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 31;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // radioButtonEntrega
            // 
            radioButtonEntrega.AutoSize = true;
            radioButtonEntrega.Location = new Point(523, 386);
            radioButtonEntrega.Name = "radioButtonEntrega";
            radioButtonEntrega.Size = new Size(65, 19);
            radioButtonEntrega.TabIndex = 32;
            radioButtonEntrega.TabStop = true;
            radioButtonEntrega.Text = "Entrega";
            radioButtonEntrega.UseVisualStyleBackColor = true;
            // 
            // radioButtonRetirada
            // 
            radioButtonRetirada.AutoSize = true;
            radioButtonRetirada.Location = new Point(523, 411);
            radioButtonRetirada.Name = "radioButtonRetirada";
            radioButtonRetirada.Size = new Size(68, 19);
            radioButtonRetirada.TabIndex = 33;
            radioButtonRetirada.TabStop = true;
            radioButtonRetirada.Text = "Retirada";
            radioButtonRetirada.UseVisualStyleBackColor = true;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(67, 68);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(156, 23);
            textBoxCPF.TabIndex = 34;
            textBoxCPF.Leave += textBoxCPF_Leave;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(295, 68);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(152, 23);
            maskedTextBoxTelefone.TabIndex = 36;
            maskedTextBoxTelefone.Leave += maskedTextBoxTelefone_Leave;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(562, 436);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(523, 439);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 38;
            label13.Text = "Valor";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(checkedListBoxProduto);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(523, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 190);
            panel2.TabIndex = 39;
            // 
            // checkedListBoxProduto
            // 
            checkedListBoxProduto.FormattingEnabled = true;
            checkedListBoxProduto.Location = new Point(19, 32);
            checkedListBoxProduto.Name = "checkedListBoxProduto";
            checkedListBoxProduto.Size = new Size(120, 94);
            checkedListBoxProduto.TabIndex = 29;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 581);
            Controls.Add(panel2);
            Controls.Add(label13);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(textBoxCPF);
            Controls.Add(radioButtonRetirada);
            Controls.Add(radioButtonEntrega);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxId);
            Controls.Add(buttonEditar);
            Controls.Add(label9);
            Controls.Add(textBoxbairro);
            Controls.Add(panel1);
            Controls.Add(buttonClientes);
            Controls.Add(label5);
            Controls.Add(textBoxNum);
            Controls.Add(label4);
            Controls.Add(textBoxRua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Pedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            WindowState = FormWindowState.Maximized;
            Load += Pedidos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private Label label3;
        private TextBox textBoxRua;
        private Label label4;
        private Label label5;
        private TextBox textBoxNum;
        private Button buttonClientes;
        private Panel panel1;
        private Label label6;
        private ComboBox comboBoxtamanho;
        private Label label7;
        private CheckedListBox checkedListBoxSabores;
        private TextBox textBoxObservação;
        private Label label8;
        private TextBox textBoxbairro;
        private Label label9;
        private Button buttonEditar;
        private Label label10;
        private ComboBox comboBoxBorda;
        private Label label11;
        private Label label12;
        private Button buttonInserirPizza;
        private TextBox textBoxId;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private RadioButton radioButtonEntrega;
        private RadioButton radioButtonRetirada;
        private TextBox textBoxCPF;
        private MaskedTextBox maskedTextBoxTelefone;
        private TextBox textBox1;
        private Label label13;
        private Panel panel2;
        private CheckedListBox checkedListBoxProduto;
    }
}