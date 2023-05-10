namespace ProjetoDevSistemas2023Vini
{
    partial class Idioma
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
            comboBoxIdioma = new ComboBox();
            labelSelIdioma = new Label();
            buttonSalvarIdioma = new Button();
            checkBoxAplicar = new CheckBox();
            labelProvider = new Label();
            labelBD = new Label();
            labelstringconexao = new Label();
            comboBoxProvider = new ComboBox();
            textBoxStringConexao = new TextBox();
            SuspendLayout();
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxIdioma.Location = new Point(26, 49);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(121, 23);
            comboBoxIdioma.TabIndex = 0;
            comboBoxIdioma.Text = "Selecione";
            // 
            // labelSelIdioma
            // 
            labelSelIdioma.AutoSize = true;
            labelSelIdioma.Location = new Point(26, 21);
            labelSelIdioma.Name = "labelSelIdioma";
            labelSelIdioma.Size = new Size(107, 15);
            labelSelIdioma.TabIndex = 1;
            labelSelIdioma.Text = "Selecione o Idioma";
            // 
            // buttonSalvarIdioma
            // 
            buttonSalvarIdioma.Location = new Point(97, 139);
            buttonSalvarIdioma.Name = "buttonSalvarIdioma";
            buttonSalvarIdioma.Size = new Size(75, 23);
            buttonSalvarIdioma.TabIndex = 2;
            buttonSalvarIdioma.Text = "Salvar";
            buttonSalvarIdioma.UseVisualStyleBackColor = true;
            buttonSalvarIdioma.Click += buttonSalvarIdioma_Click;
            // 
            // checkBoxAplicar
            // 
            checkBoxAplicar.AutoSize = true;
            checkBoxAplicar.Location = new Point(26, 87);
            checkBoxAplicar.Name = "checkBoxAplicar";
            checkBoxAplicar.Size = new Size(96, 19);
            checkBoxAplicar.TabIndex = 3;
            checkBoxAplicar.Text = "Aplicar agora";
            checkBoxAplicar.UseVisualStyleBackColor = true;
            checkBoxAplicar.CheckedChanged += checkBoxAplicar_CheckedChanged;
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.Location = new Point(340, 49);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(51, 15);
            labelProvider.TabIndex = 4;
            labelProvider.Text = "Provider";
            labelProvider.Click += label1_Click;
            // 
            // labelBD
            // 
            labelBD.AutoSize = true;
            labelBD.Location = new Point(322, 9);
            labelBD.Name = "labelBD";
            labelBD.Size = new Size(92, 15);
            labelBD.TabIndex = 5;
            labelBD.Text = "Banco de Dados";
            // 
            // labelstringconexao
            // 
            labelstringconexao.AutoSize = true;
            labelstringconexao.Location = new Point(340, 104);
            labelstringconexao.Name = "labelstringconexao";
            labelstringconexao.Size = new Size(104, 15);
            labelstringconexao.TabIndex = 6;
            labelstringconexao.Text = "String de Conexão";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Location = new Point(340, 67);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(121, 23);
            comboBoxProvider.TabIndex = 7;
            comboBoxProvider.Text = "Selecione";
            // 
            // textBoxStringConexao
            // 
            textBoxStringConexao.Location = new Point(340, 122);
            textBoxStringConexao.Name = "textBoxStringConexao";
            textBoxStringConexao.Size = new Size(331, 23);
            textBoxStringConexao.TabIndex = 8;
            // 
            // Idioma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 174);
            Controls.Add(textBoxStringConexao);
            Controls.Add(comboBoxProvider);
            Controls.Add(labelstringconexao);
            Controls.Add(labelBD);
            Controls.Add(labelProvider);
            Controls.Add(checkBoxAplicar);
            Controls.Add(buttonSalvarIdioma);
            Controls.Add(labelSelIdioma);
            Controls.Add(comboBoxIdioma);
            KeyPreview = true;
            Name = "Idioma";
            Text = "Form1";
            Load += Idioma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxIdioma;
        private Label labelSelIdioma;
        private Button buttonSalvarIdioma;
        private CheckBox checkBoxAplicar;
        private Label labelProvider;
        private Label labelBD;
        private Label labelstringconexao;
        private ComboBox comboBoxProvider;
        private TextBox textBoxStringConexao;
    }
}