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
        
        private void button1_Click(object sender, EventArgs e)  // Botão salvar
        {
            Class1 pessoas = new Class1
            {
                nome = textBox1.Text.Trim(),
                telefone = textBox2.Text.Trim(),
                identificador = textBox3.Text.Trim()
            };

            //Verifica se os espaços estão preenchidos
            if (string.IsNullOrEmpty(pessoas.nome) ||
                string.IsNullOrEmpty(pessoas.telefone) ||
                string.IsNullOrEmpty(pessoas.identificador))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            MessageBox.Show("Cadastro salvo com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e) // Botão excluir
        {

        }

        private void button3_Click(object sender, EventArgs e) // Botão Procurar
        {

        }
    }
}
