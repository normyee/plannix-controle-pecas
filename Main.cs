using ControlePecas.Domain;
using ControlePecas.Repository;
using ControlePecas.Repository.BuscarObrasRepository;
using ControlePecas.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace ControlePecas
{
    public partial class Main : Form
    {
        private List<Regiao> _regioesEstoques;
        private List<Obra> _obras;
        private bool _carregouForm = false;
        private bool _emReload = false;

        private int _selectedPeca = 0;
        private int? _selectedRowIndex = null;
        private int _selectedCodObra = 0;
        private int _selectedRegiaoEstoque = 0;

        private CriarPecaRepository _criarPecaRepository;
        private ObterPecaRepository _obterPecaRepository;
        private AtualizarPecaRepository _atualizarPecaRepository;
        private GerarRelatorioService _gerarRelatorioService;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_load(object sender, EventArgs e)
        {
            var carregarObras = new CarregarObras(new BuscarObrasRepository());
            var carregarRegioesEstoques = new CarregarRegioesEstoques(new BuscarRegioesEstoquesRepository());
            _obterPecaRepository = new ObterPecaRepository();
            _criarPecaRepository = new CriarPecaRepository();
            _atualizarPecaRepository = new AtualizarPecaRepository();

            _regioesEstoques = carregarRegioesEstoques.Executar();
            _obras = carregarObras.Executar();

            ObrasFiltro.DataSource = _obras;
            ObrasFiltro.DisplayMember = "Nome";
            ObrasFiltro.ValueMember = "CodObra";

            RegiaoEstoqueFiltro.DataSource = _regioesEstoques;
            RegiaoEstoqueFiltro.DisplayMember = "Nome";
            RegiaoEstoqueFiltro.ValueMember = "Id";

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

            PecaObraView.DataSource = tabela;
            PecaObraView.Columns["Cod."].Width = 50;


            _gerarRelatorioService = new GerarRelatorioService();
            _carregouForm = true;
        }
       private void ObraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_emReload || !_carregouForm) return;

            var obraSelecionada = ObrasFiltro.SelectedItem as Obra;
            var regiaoSelecionada = RegiaoEstoqueFiltro.SelectedItem as Regiao;

            _selectedCodObra = obraSelecionada.CodObra;
            _selectedRegiaoEstoque = regiaoSelecionada.Id;

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

                PecaObraView.DataSource = tabela;
                PecaObraView.Columns["Cod."].Width = 50;
            }
        }

        private void RegiaoEstoqueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_emReload || !_carregouForm) return;

            var obraSelecionada = ObrasFiltro.SelectedItem as Obra;
            var regiaoSelecionada = RegiaoEstoqueFiltro.SelectedItem as Regiao;

            _selectedCodObra = obraSelecionada.CodObra;
            _selectedRegiaoEstoque = regiaoSelecionada.Id;

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

                PecaObraView.DataSource = tabela;
                PecaObraView.Columns["Cod."].Width = 50;
            }
        }

        private void LinhaSelecionada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _selectedRowIndex = e.RowIndex;
            var row = PecaObraView.Rows[e.RowIndex];
       
            var codControle = row.Cells["Cod."].Value;

            if (codControle != null)
            {
                _selectedPeca = int.Parse(codControle.ToString());
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }

        private void BotaoDeletarPeca_Click(object sender, EventArgs e)
        {
            if (_selectedPeca == 0 || _selectedRowIndex == null) return;
           var deletarService = new DeletarPecaService(new DeletarPecaRepository());

            deletarService.Executar(_selectedPeca);
            PecaObraView.Rows.RemoveAt(_selectedRowIndex.Value);

            _selectedPeca = 0;
            _selectedRowIndex = null;
        }

        private void InserirItem_Click(object sender, EventArgs e)
        {
            var controleCriacao = new ControleCriacao(_regioesEstoques, _obras, _criarPecaRepository);
            controleCriacao.ShowDialog();
        }

        private void BotaoModalEditar_Click(object sender, EventArgs e)
        {
            if (_selectedPeca != 0)
            {
                AvisoErroEditar.Visible = false;
                var controleAtualizacao = new ControleAtualizacao(_selectedPeca, _regioesEstoques, _obras, _obterPecaRepository, _atualizarPecaRepository);
                controleAtualizacao.ShowDialog();
            } 
            if(_selectedPeca == 0)
            {
                SystemSounds.Exclamation.Play();
                AvisoErroEditar.Visible = true;
            }
        }

        private void BotaoAtualizarTabela_Click(object sender, EventArgs e)
        {
            _emReload = true;
            var carregarObras = new CarregarObras(new BuscarObrasRepository());
            var carregarRegioesEstoques = new CarregarRegioesEstoques(new BuscarRegioesEstoquesRepository());
            _criarPecaRepository = new CriarPecaRepository();

            _regioesEstoques = carregarRegioesEstoques.Executar();
            _obras = carregarObras.Executar();

            ObrasFiltro.DataSource = _obras;
            ObrasFiltro.DisplayMember = "Nome";
            ObrasFiltro.ValueMember = "CodObra";

            RegiaoEstoqueFiltro.DataSource = _regioesEstoques;
            RegiaoEstoqueFiltro.DisplayMember = "Nome";
            RegiaoEstoqueFiltro.ValueMember = "Id";

            var carregarPecas = new CarregarPecas(new BuscarPecasRepository());

            var pecas = carregarPecas.Executar(_selectedCodObra, _selectedRegiaoEstoque);

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

            PecaObraView.DataSource = tabela;
            PecaObraView.Columns["Cod."].Width = 50;

            _emReload = false;
        }

        private void BotaoGerarRelatorio_Click(object sender, EventArgs e)
        {
            DataTable relatorio = (DataTable)PecaObraView.DataSource;
            _gerarRelatorioService.Executar(relatorio);
        }
    }
}
