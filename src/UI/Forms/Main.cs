using ControlePecas.Entities;
using ControlePecas.Repositories;
using ControlePecas.Features;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using ControlePecas.ViewModels;

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

        private CriarPecaRepo _criarPecaRepository;
        private AtualizarPecaRepo _atualizarPecaRepository;

        private GerarRelatorio _gerarRelatorio;
        private CarregarObras _carregarObras;
        private CarregarRegioesEstoques _carregarRegioesEstoques;
        private CarregarPecas _carregarPecas;
        private ObterPeca _obterPeca;
        public Main(
            GerarRelatorio gerarRelatorio, 
            CarregarObras carregarObras, 
            CarregarRegioesEstoques carregarRegioesEstoques,
            CarregarPecas carregarPecas,
            ObterPeca obterPeca
            )
        {
            InitializeComponent();

            _gerarRelatorio = gerarRelatorio;
            _carregarObras = carregarObras;
            _carregarRegioesEstoques = carregarRegioesEstoques;
            _carregarPecas = carregarPecas;
            _obterPeca = obterPeca;
        }

        private void Main_load(object sender, EventArgs e)
        {
            _criarPecaRepository = new CriarPecaRepo();
            _atualizarPecaRepository = new AtualizarPecaRepo();

            _regioesEstoques = _carregarRegioesEstoques.Executar();
            _obras = _carregarObras.Executar();

            ObrasFiltro.DataSource = _obras;
            ObrasFiltro.DisplayMember = "Nome";
            ObrasFiltro.ValueMember = "CodObra";

            RegiaoEstoqueFiltro.DataSource = _regioesEstoques;
            RegiaoEstoqueFiltro.DisplayMember = "Nome";
            RegiaoEstoqueFiltro.ValueMember = "Id";

            _selectedCodObra = _obras[0].CodObra;
            _selectedRegiaoEstoque = _regioesEstoques[0].Id;

            var pecas = _carregarPecas.Executar(_selectedCodObra, _selectedRegiaoEstoque);

            var pecasViewModel = pecas.Select(p => new PecaViewModel
            {
                CodControle = p.CodigoControle,
                Peca = p.Peca,
                Obra = p.Obra,
                StatusAcabamento = p.StatusAcabamento,
                RegiaoEstoque = p.RegiaoEstoque
            }).ToList();

            PecaObraView.DataSource = pecasViewModel;
            PecaObraView.Columns["CodControle"].HeaderText = "Cod.";
            PecaObraView.Columns["Peca"].HeaderText = "Peça";
            PecaObraView.Columns["StatusAcabamento"].HeaderText = "Status Acab.";
            PecaObraView.Columns["RegiaoEstoque"].HeaderText = "Região Est.";

            PecaObraView.Columns["CodControle"].Width = 50;

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
                var pecas = _carregarPecas.Executar(_selectedCodObra, _selectedRegiaoEstoque);

                var pecasViewModel = pecas.Select(p => new PecaViewModel
                {
                    CodControle = p.CodigoControle,
                    Peca = p.Peca,
                    Obra = p.Obra,
                    StatusAcabamento = p.StatusAcabamento,
                    RegiaoEstoque = p.RegiaoEstoque
                }).ToList();

                PecaObraView.DataSource = pecasViewModel;
                PecaObraView.Columns["CodControle"].HeaderText = "Cod.";
                PecaObraView.Columns["Peca"].HeaderText = "Peça";
                PecaObraView.Columns["StatusAcabamento"].HeaderText = "Status Acab.";
                PecaObraView.Columns["RegiaoEstoque"].HeaderText = "Região Est.";

                PecaObraView.Columns["CodControle"].Width = 50;
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
                var pecas = _carregarPecas.Executar(_selectedCodObra, _selectedRegiaoEstoque);

                var pecasViewModel = pecas.Select(p => new PecaViewModel
                {
                    CodControle = p.CodigoControle,
                    Peca = p.Peca,
                    Obra = p.Obra,
                    StatusAcabamento = p.StatusAcabamento,
                    RegiaoEstoque = p.RegiaoEstoque
                }).ToList();

                PecaObraView.DataSource = pecasViewModel;
                PecaObraView.Columns["CodControle"].HeaderText = "Cod.";
                PecaObraView.Columns["Peca"].HeaderText = "Peça";
                PecaObraView.Columns["StatusAcabamento"].HeaderText = "Status Acab.";
                PecaObraView.Columns["RegiaoEstoque"].HeaderText = "Região Est.";

                PecaObraView.Columns["CodControle"].Width = 50;
            }
        }

        private void LinhaSelecionada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _selectedRowIndex = e.RowIndex;
            var row = PecaObraView.Rows[e.RowIndex];
       
            var codControle = row.Cells["CodControle"].Value;

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

            var deletarService = new DeletarPeca(new DeletarPecaRepo());
            deletarService.Executar(_selectedPeca);

            var pecasViewModel = PecaObraView.DataSource as List<PecaViewModel>;
            if (pecasViewModel != null)
            {
                var itemToRemove = pecasViewModel.FirstOrDefault(p => p.CodControle == _selectedPeca);
                if (itemToRemove != null)
                {
                    pecasViewModel.Remove(itemToRemove);

                    PecaObraView.DataSource = null;
                    PecaObraView.DataSource = pecasViewModel;
                }
            }

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
                var controleAtualizacao = new ControleAtualizacao(_selectedPeca, _regioesEstoques, _obras, _obterPeca, _atualizarPecaRepository);
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
            _criarPecaRepository = new CriarPecaRepo();

            _regioesEstoques = _carregarRegioesEstoques.Executar();
            _obras = _carregarObras.Executar();

            ObrasFiltro.DataSource = _obras;
            ObrasFiltro.DisplayMember = "Nome";
            ObrasFiltro.ValueMember = "CodObra";

            RegiaoEstoqueFiltro.DataSource = _regioesEstoques;
            RegiaoEstoqueFiltro.DisplayMember = "Nome";
            RegiaoEstoqueFiltro.ValueMember = "Id";

            var pecas = _carregarPecas.Executar(_selectedCodObra, _selectedRegiaoEstoque);

            var pecasViewModel = pecas.Select(p => new PecaViewModel
            {
                CodControle = p.CodigoControle,
                Peca = p.Peca,
                Obra = p.Obra,
                StatusAcabamento = p.StatusAcabamento,
                RegiaoEstoque = p.RegiaoEstoque
            }).ToList();

            PecaObraView.DataSource = pecasViewModel;
            PecaObraView.Columns["CodControle"].HeaderText = "Cod.";
            PecaObraView.Columns["Peca"].HeaderText = "Peça";
            PecaObraView.Columns["StatusAcabamento"].HeaderText = "Status Acab.";
            PecaObraView.Columns["RegiaoEstoque"].HeaderText = "Região Est.";

            PecaObraView.Columns["CodControle"].Width = 50;

            _emReload = false;
        }

        private void BotaoGerarRelatorio_Click(object sender, EventArgs e)
        {
            var pecasViewModel = PecaObraView.DataSource as List<PecaViewModel>;
            if (pecasViewModel != null)
            {
                var dt = new DataTable();
                dt.Columns.Add("Cod.");
                dt.Columns.Add("Peça");
                dt.Columns.Add("Obra");
                dt.Columns.Add("Status Acab.");
                dt.Columns.Add("Região Est.");

                foreach (var p in pecasViewModel)
                {
                    dt.Rows.Add(p.CodControle, p.Peca, p.Obra, p.StatusAcabamento, p.RegiaoEstoque);
                }

                _gerarRelatorio.Executar(dt);
            }
        }
    }
}
