using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadaJSON
{
    public partial class Form2 : Form
    {
        public Form2()  //Formulario dedicado a aba CADASTRO
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)   //label título Cadastro
        {

        }

        private void label2_Click(object sender, EventArgs e) //label Nome
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)   //Caixa input texto nome
        {
            textBox1.MaxLength = 50; // Define o limite máximo de caracteres para o campo 
        }

        private void label3_Click(object sender, EventArgs e)   //label Número de telefone
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Caixa input texto número de telefone
        {
            textBox2.MaxLength = 15; // Define o limite máximo de caracteres para o campo
        }

        private void label4_Click(object sender, EventArgs e)   //label Identificador
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Caixa input texto identificador
        {

        }

        private void button1_Click(object sender, EventArgs e)  // Salvar
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||   // Identificador
                string.IsNullOrWhiteSpace(textBox1.Text) ||   // Nome
                string.IsNullOrWhiteSpace(textBox2.Text))     // Telefone
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pessoa = new Pessoa
            {
                Identificador = textBox3.Text.Trim(),
                Nome = textBox1.Text.Trim(),
                Telefone = textBox2.Text.Trim()
            };

            DadosPessoas.AdicionarOuAtualizar(pessoa);
            MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optional: clear fields after save
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)  // Excluir
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Digite o Identificador para excluir.", "Atenção");
                return;
            }

            string id = textBox3.Text.Trim();

            if (DadosPessoas.Excluir(id))
            {
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Identificador não encontrado.", "Erro");
            }
        }

        private void button3_Click(object sender, EventArgs e)  // Procurar
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Digite o Identificador para buscar.", "Atenção");
                return;
            }

            string id = textBox3.Text.Trim();
            var encontrado = DadosPessoas.Buscar(id);

            if (encontrado != null)
            {
                textBox1.Text = encontrado.Nome;
                textBox2.Text = encontrado.Telefone;
                // textBox3 stays with the ID
                MessageBox.Show("Registro encontrado!", "Informação");
            }
            else
            {
                MessageBox.Show("Identificador não encontrado.", "Não encontrado");
            }
        }
    }
}
