using ControlePecas.Domain;
using ControlePecas.Repository;
using ControlePecas.Repository.BuscarObrasRepository;
using ControlePecas.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ControlePecas
{
    public partial class Main : Form
    {
        private List<Regiao> _regioesEstoques;
        private List<Obra> _obras;
        private bool _carregouForm = false;

        private int _selectedPeca = 0;
        private int? _selectedRowIndex = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_load(object sender, EventArgs e)
        {
            var carregarObras = new CarregarObras(new BuscarObrasRepository());
            var carregarRegioesEstoques = new CarregarRegioesEstoques(new BuscarRegioesEstoquesRepository());

            _regioesEstoques = carregarRegioesEstoques.Executar();
            _obras = carregarObras.Executar();

            comboBox1.DataSource = _obras;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "CodObra";

            comboBox2.DataSource = _regioesEstoques;
            comboBox2.DisplayMember = "Nome";
            comboBox2.ValueMember = "Id";

            var carregarPecas = new CarregarPecas(new BuscarPecasRepository());

            var pecas = carregarPecas.Executar(_obras[0].CodObra, _regioesEstoques[0].Id);

            var tabela = new DataTable();
            tabela.Columns.Add("Cod.");
            tabela.Columns.Add("Peça");
            tabela.Columns.Add("Obra");
            tabela.Columns.Add("Status Acab.");
            tabela.Columns.Add("Região Est.");

            foreach (var p in pecas)
            {
                tabela.Rows.Add(
                    p.CodigoControle,
                    p.Peca,
                    p.Obra,
                    p.StatusAcabamento,
                    p.RegiaoEstoque
                );
            }

            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["Cod."].Width = 50;

            _carregouForm = true;
        }
       private void ObraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_carregouForm) return;

            var obraSelecionada = comboBox1.SelectedItem as Obra;
            var regiaoSelecionada = comboBox2.SelectedItem as Regiao;

            if (obraSelecionada != null && regiaoSelecionada != null)
            {
                var carregarPecas = new CarregarPecas(new BuscarPecasRepository());
                var pecas = carregarPecas.Executar(obraSelecionada.CodObra, regiaoSelecionada.Id);

                var tabela = new DataTable();
                tabela.Columns.Add("Cod.");
                tabela.Columns.Add("Peça");
                tabela.Columns.Add("Obra");
                tabela.Columns.Add("Status Acab.");
                tabela.Columns.Add("Região Est.");

                foreach (var p in pecas)
                {
                    tabela.Rows.Add(
                        p.CodigoControle,
                        p.Peca,
                        p.Obra,
                        p.StatusAcabamento,
                        p.RegiaoEstoque
                    );
                }

                dataGridView1.DataSource = tabela;
                dataGridView1.Columns["Cod."].Width = 50;
            }
        }

        private void RegiaoEstoqueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_carregouForm) return;

            var obraSelecionada = comboBox1.SelectedItem as Obra;
            var regiaoSelecionada = comboBox2.SelectedItem as Regiao;

            if (obraSelecionada != null && regiaoSelecionada != null)
            {
                var carregarPecas = new CarregarPecas(new BuscarPecasRepository());
                var pecas = carregarPecas.Executar(obraSelecionada.CodObra, regiaoSelecionada.Id);

                var tabela = new DataTable();
                tabela.Columns.Add("Cod.");
                tabela.Columns.Add("Peça");
                tabela.Columns.Add("Obra");
                tabela.Columns.Add("Status Acab.");
                tabela.Columns.Add("Região Est.");

                foreach (var p in pecas)
                {
                    tabela.Rows.Add(
                        p.CodigoControle,
                        p.Peca,
                        p.Obra,
                        p.StatusAcabamento,
                        p.RegiaoEstoque
                    );
                }

                dataGridView1.DataSource = tabela;
                dataGridView1.Columns["Cod."].Width = 50;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _selectedRowIndex = e.RowIndex;
            var row = dataGridView1.Rows[e.RowIndex];
       
            var codControle = row.Cells["Cod."].Value;

            if (codControle != null)
            {
                _selectedPeca = int.Parse(codControle.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_selectedPeca == 0 || _selectedRowIndex == null) return;
           var deletarService = new DeletarPecaService(new DeletarPecaRepository());

            deletarService.Executar(_selectedPeca);
            dataGridView1.Rows.RemoveAt(_selectedRowIndex.Value);

            _selectedPeca = 0;
            _selectedRowIndex = null;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var teste = e;
            var teste2 = teste;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
