namespace ProjetoDevSistemas2023Vini
{
    partial class Ingredientes
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
            labelIDingredientes = new Label();
            labelNomeIngrediente = new Label();
            textBoxIDIngrediente = new TextBox();
            textBoxNomeIngrediente = new TextBox();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            dataGridViewDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // labelIDingredientes
            // 
            labelIDingredientes.AutoSize = true;
            labelIDingredientes.Location = new Point(49, 52);
            labelIDingredientes.Name = "labelIDingredientes";
            labelIDingredientes.Size = new Size(81, 15);
            labelIDingredientes.TabIndex = 0;
            labelIDingredientes.Text = "ID Ingrediente";
            // 
            // labelNomeIngrediente
            // 
            labelNomeIngrediente.AutoSize = true;
            labelNomeIngrediente.Location = new Point(158, 52);
            labelNomeIngrediente.Name = "labelNomeIngrediente";
            labelNomeIngrediente.Size = new Size(120, 15);
            labelNomeIngrediente.TabIndex = 1;
            labelNomeIngrediente.Text = "Nome do Ingrediente";
            // 
            // textBoxIDIngrediente
            // 
            textBoxIDIngrediente.Location = new Point(49, 70);
            textBoxIDIngrediente.Name = "textBoxIDIngrediente";
            textBoxIDIngrediente.Size = new Size(81, 23);
            textBoxIDIngrediente.TabIndex = 2;
            // 
            // textBoxNomeIngrediente
            // 
            textBoxNomeIngrediente.Location = new Point(158, 70);
            textBoxNomeIngrediente.Name = "textBoxNomeIngrediente";
            textBoxNomeIngrediente.Size = new Size(120, 23);
            textBoxNomeIngrediente.TabIndex = 3;
            textBoxNomeIngrediente.TextChanged += textBoxNomeIngrediente_TextChanged;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(113, 146);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelarIngrediente_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(203, 146);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 17;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(347, -2);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(410, 392);
            dataGridViewDados.TabIndex = 19;
            // 
            // Ingredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 402);
            Controls.Add(dataGridViewDados);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxNomeIngrediente);
            Controls.Add(textBoxIDIngrediente);
            Controls.Add(labelNomeIngrediente);
            Controls.Add(labelIDingredientes);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Ingredientes";
            ShowIcon = false;
            Text = "Cadastro Ingrediente";
            WindowState = FormWindowState.Maximized;
            Load += Ingredientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIDingredientes;
        private Label labelNomeIngrediente;
        private TextBox textBoxIDIngrediente;
        private TextBox textBoxNomeIngrediente;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private DataGridView dataGridViewDados;
    }
}