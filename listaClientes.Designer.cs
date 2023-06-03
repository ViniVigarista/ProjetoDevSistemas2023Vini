using ProjetoDevSistemas2023Vini.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoDevSistemas2023Vini
{
    partial class listaClientes
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
            dataGridViewDadoCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDadoCliente).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDadoCliente
            // 
            dataGridViewDadoCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDadoCliente.Location = new Point(12, 12);
            dataGridViewDadoCliente.Name = "dataGridViewDadoCliente";
            dataGridViewDadoCliente.RowTemplate.Height = 25;
            dataGridViewDadoCliente.Size = new Size(776, 413);
            dataGridViewDadoCliente.TabIndex = 0;
           
            // 
            // listaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewDadoCliente);
            Name = "listaClientes";
            Text = "listaClientes";
            Load += listaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDadoCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDadoCliente;
    }
}