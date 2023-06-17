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
            maskedTextBoxCPF = new MaskedTextBox();
            maskedTextBoxtelefone = new MaskedTextBox();
            textBoxNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            buttonClientes = new Button();
            panel1 = new Panel();
            buttonCancelar = new Button();
            buttonCadastrar = new Button();
            comboBoxtamanho = new ComboBox();
            label12 = new Label();
            label8 = new Label();
            textBoxObservação = new TextBox();
            label11 = new Label();
            checkedListBoxIngredientes = new CheckedListBox();
            label6 = new Label();
            listBoxML = new ListBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            listBoxTipo = new ListBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            buttonEditar = new Button();
            panel1.SuspendLayout();
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
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(67, 68);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(134, 23);
            maskedTextBoxCPF.TabIndex = 4;
            // 
            // maskedTextBoxtelefone
            // 
            maskedTextBoxtelefone.Location = new Point(295, 68);
            maskedTextBoxtelefone.Mask = "(00) 0 0000-0000";
            maskedTextBoxtelefone.Name = "maskedTextBoxtelefone";
            maskedTextBoxtelefone.Size = new Size(139, 23);
            maskedTextBoxtelefone.TabIndex = 6;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(67, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(196, 23);
            textBoxNome.TabIndex = 5;
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
            // textBox1
            // 
            textBox1.Location = new Point(67, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 9;
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
            // textBox2
            // 
            textBox2.Location = new Point(316, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(55, 23);
            textBox2.TabIndex = 11;
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
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(comboBoxtamanho);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxObservação);
            panel1.Controls.Add(checkedListBoxIngredientes);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(33, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 323);
            panel1.TabIndex = 14;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(611, 285);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 28;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(530, 285);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 27;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastro_Click;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(221, 564);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 21;
            label12.Text = "Tamanho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 287);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 16;
            label8.Text = "Observação";
            label8.Click += label8_Click;
            // 
            // textBoxObservação
            // 
            textBoxObservação.Location = new Point(91, 284);
            textBoxObservação.Multiline = true;
            textBoxObservação.Name = "textBoxObservação";
            textBoxObservação.Size = new Size(268, 24);
            textBoxObservação.TabIndex = 15;
            textBoxObservação.TextChanged += textBoxObservação_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(61, 564);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 26;
            label11.Text = "Bebidas";
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(20, 76);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(148, 148);
            checkedListBoxIngredientes.TabIndex = 22;
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
            // listBoxML
            // 
            listBoxML.FormattingEnabled = true;
            listBoxML.ItemHeight = 15;
            listBoxML.Location = new Point(190, 582);
            listBoxML.Name = "listBoxML";
            listBoxML.Size = new Size(120, 94);
            listBoxML.TabIndex = 20;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Não", "Catupiry", "Chocolate Branco", "Cheddar", "Chocolate Preto" });
            comboBox1.Location = new Point(20, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 24;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(33, 582);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(120, 94);
            listBoxTipo.TabIndex = 20;
            listBoxTipo.SelectedIndexChanged += listBoxTipo_SelectedIndexChanged;
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
            // textBox3
            // 
            textBox3.Location = new Point(453, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
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
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 883);
            Controls.Add(buttonEditar);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(buttonClientes);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(listBoxML);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxTipo);
            Controls.Add(maskedTextBoxtelefone);
            Controls.Add(textBoxNome);
            Controls.Add(maskedTextBoxCPF);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxtelefone;
        private TextBox textBoxNome;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Button buttonClientes;
        private Panel panel1;
        private Label label6;
        private ComboBox comboBoxtamanho;
        private Label label7;
        private CheckedListBox checkedListBoxIngredientes;
        private TextBox textBoxObservação;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private Button buttonEditar;
        private Label label10;
        private ComboBox comboBox1;
        private Label label11;
        private ListBox listBoxTipo;
        private Label label12;
        private ListBox listBoxML;
        private Button buttonCancelar;
        private Button buttonCadastrar;
    }
}