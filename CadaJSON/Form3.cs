using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadaJSON
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //
        private void Form3_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dataGridView1.DataSource = null;           // clear
            dataGridView1.DataSource = DadosPessoas.Lista;  // bind list
            // Optional: improve columns
            if (dataGridView1.Columns.Count > 0)
            {
            dataGridView1.Columns["Identificador"]?.HeaderText = "ID";
            dataGridView1.Columns["Nome"]?.HeaderText = "Nome";
            dataGridView1.Columns["Telefone"]?.HeaderText = "Telefone";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
