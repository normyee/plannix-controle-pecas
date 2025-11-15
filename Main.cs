using ControlePecas.Services;
using System;
using System.Windows.Forms;
using ControlePecas.Repository.BuscarObrasRepository;

namespace ControlePecas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var carregarObras = new CarregarObras(new BuscarObrasRepository());
            var carregarRegioesEstoques = new CarregarRegioesEstoques(new Repository.BuscarRegioesEstoquesRepository());

            var regioesEstoques = carregarRegioesEstoques.Executar();
            var obras = carregarObras.Executar();

            comboBox1.DataSource = obras;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "CodObra";

            comboBox2.DataSource = regioesEstoques;
            comboBox2.DisplayMember = "Nome";
            comboBox2.ValueMember = "Id";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
