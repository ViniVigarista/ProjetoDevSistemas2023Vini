namespace ProjetoDevSistemas2023Vini
{
    partial class Sabores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sabores));
            labelNomePizza = new Label();
            textBoxSabor = new TextBox();
            pictureBoxImagem = new PictureBox();
            labelFotoDaPizza = new Label();
            labelIngredientesPizza = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            checkedListBoxIngredientes = new CheckedListBox();
            listBoxCategoria = new ListBox();
            listBoxTipo = new ListBox();
            dataGridViewDados = new DataGridView();
            buttonLista = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // labelNomePizza
            // 
            labelNomePizza.AutoSize = true;
            labelNomePizza.Location = new Point(41, 15);
            labelNomePizza.Name = "labelNomePizza";
            labelNomePizza.Size = new Size(90, 15);
            labelNomePizza.TabIndex = 0;
            labelNomePizza.Text = "Nome do Sabor";
            // 
            // textBoxSabor
            // 
            textBoxSabor.Location = new Point(137, 12);
            textBoxSabor.Name = "textBoxSabor";
            textBoxSabor.Size = new Size(179, 23);
            textBoxSabor.TabIndex = 1;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Image = (Image)resources.GetObject("pictureBoxImagem.Image");
            pictureBoxImagem.Location = new Point(367, 109);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(177, 129);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 2;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxImagem_Click;
            // 
            // labelFotoDaPizza
            // 
            labelFotoDaPizza.AutoSize = true;
            labelFotoDaPizza.Location = new Point(413, 80);
            labelFotoDaPizza.Name = "labelFotoDaPizza";
            labelFotoDaPizza.Size = new Size(81, 15);
            labelFotoDaPizza.TabIndex = 3;
            labelFotoDaPizza.Text = "Foto do Sabor";
            // 
            // labelIngredientesPizza
            // 
            labelIngredientesPizza.AutoSize = true;
            labelIngredientesPizza.Location = new Point(41, 45);
            labelIngredientesPizza.Name = "labelIngredientesPizza";
            labelIngredientesPizza.Size = new Size(117, 15);
            labelIngredientesPizza.TabIndex = 4;
            labelIngredientesPizza.Text = "Ingredientes da Pizza";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(379, 314);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 20;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelarIngrediente_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(469, 314);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 19;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(41, 68);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(148, 184);
            checkedListBoxIngredientes.TabIndex = 21;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 15;
            listBoxCategoria.Location = new Point(41, 258);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(120, 34);
            listBoxCategoria.TabIndex = 22;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(196, 258);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(120, 34);
            listBoxTipo.TabIndex = 23;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(698, 45);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(651, 272);
            dataGridViewDados.TabIndex = 24;
            dataGridViewDados.CellFormatting += this.DataGridViewDados_CellFormatting;
            // 
            // buttonLista
            // 
            buttonLista.Location = new Point(563, 314);
            buttonLista.Name = "buttonLista";
            buttonLista.Size = new Size(75, 23);
            buttonLista.TabIndex = 25;
            buttonLista.Text = "Sabores";
            buttonLista.UseVisualStyleBackColor = true;
            buttonLista.Click += buttonLista_Click;
            // 
            // Sabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 354);
            Controls.Add(buttonLista);
            Controls.Add(dataGridViewDados);
            Controls.Add(listBoxTipo);
            Controls.Add(listBoxCategoria);
            Controls.Add(checkedListBoxIngredientes);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(labelIngredientesPizza);
            Controls.Add(labelFotoDaPizza);
            Controls.Add(pictureBoxImagem);
            Controls.Add(textBoxSabor);
            Controls.Add(labelNomePizza);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Sabores";
            Text = "Sabores de Pizza";
            WindowState = FormWindowState.Maximized;
            Load += Sabores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomePizza;
        private TextBox textBoxSabor;
        private PictureBox pictureBoxImagem;
        private Label labelFotoDaPizza;
        private Label labelIngredientesPizza;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private CheckedListBox checkedListBoxIngredientes;
        private ListBox listBoxCategoria;
        private ListBox listBoxTipo;
        private DataGridView dataGridViewDados;
        private Button buttonLista;
    }
}