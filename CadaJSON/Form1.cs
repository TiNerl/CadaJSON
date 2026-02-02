namespace CadaJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)    //Opção "cadastro" da coluna "Ferramentas"
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0) //Verifica se a quantidade de instâncias é igual a zero
            {
            Form2 frm = new Form2();    //Abertura (Nova janela) do formulário dedicado a aba CADASTRO
            frm.MdiParent = this;   //Informa que o formulário aberto (frm.MdiParent) será filho do formulário principal ( = this)
            frm.Show();
            }
            else
            {
                Application.OpenForms.OfType<Form2>().First().WindowState = FormWindowState.Normal; //Restaura a tela
                Application.OpenForms.OfType<Form2>().First().BringToFront();   //Traz a aba para frente
            }
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)    //Opção "listagem" da coluna "Ferramentas"
        {

            if (Application.OpenForms.OfType<Form3>().Count() == 0) //Verifica se o formulário já está aberto
            {
            Form3 frm = new Form3();    //Abertura (Nova Janela) do formulário dedicado a aba LISTAGEM
            frm.MdiParent = this;   //Informa que o formulário aberto (frm.MdiParent) será filho do formulário principal ( = this)
            frm.Show();
            }
            else
            {
                Application.OpenForms.OfType<Form3>().First().WindowState = FormWindowState.Normal; //Restaura a tela
                Application.OpenForms.OfType<Form3>().First().BringToFront();   //Traz a aba para frente
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)    //Opção "sair" da coluna "Ferramentas"
        {
            Application.Exit(); //Encerra a aplicação.
        }
    }
}
