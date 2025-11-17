using ControlePecas.Domain;
using ControlePecas.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ControlePecas
{
    public partial class ControleCriacao : Form
    {
        private readonly List<Regiao> _regioesEstoques;
        private readonly List<Obra> _obras;
        private readonly CriarPecaRepository _criarPecaRepository;

        private readonly List<KeyValuePair<string, string>> _acabamentoStatus =
            new List<KeyValuePair<string, string>>
            {
        new KeyValuePair<string, string>("EM_PRODUCAO", "Em produção"),
        new KeyValuePair<string, string>("PENDENTE", "Pendente"),
        new KeyValuePair<string, string>("FINALIZADO", "Finalizado")
            };
        private readonly List<KeyValuePair<string, string>> _statusEstoque =
    new List<KeyValuePair<string, string>>
    {
        new KeyValuePair<string, string>("EM_ACABAMENNTO", "Em acabamento"),
        new KeyValuePair<string, string>("AGUARDANDO_ACABAMENTO", "Aguardando acabamento"),
        new KeyValuePair<string, string>("DISPONIVEL", "Disponível")
    };

        private readonly List<KeyValuePair<string, string>> _statusPeca =
new List<KeyValuePair<string, string>>
{
        new KeyValuePair<string, string>("ATIVA", "Ativa"),
        new KeyValuePair<string, string>("INATIVA", "Inativa"),
};

        public ControleCriacao(List<Regiao> regioesEstoques, List<Obra> obras, CriarPecaRepository criarPecaRepository)
        {
            InitializeComponent();

            _criarPecaRepository = criarPecaRepository;
            _regioesEstoques = regioesEstoques;
            _obras = obras;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            RegiaoEstoque.DataSource = _regioesEstoques;
            RegiaoEstoque.DisplayMember = "Nome";
            RegiaoEstoque.ValueMember = "Id";

            Obra.DataSource = _obras;
            Obra.DisplayMember = "Nome";
            Obra.ValueMember = "CodObra";

            StatusAcabamento.DataSource = _acabamentoStatus;
            StatusAcabamento.DisplayMember = "Value";
            StatusAcabamento.ValueMember = "Key";

            StatusEstoque.DataSource = _statusEstoque;
            StatusEstoque.DisplayMember = "Value";
            StatusEstoque.ValueMember = "Key";

            PecaStatus.DataSource = _statusPeca;
            PecaStatus.DisplayMember = "Value";
            PecaStatus.ValueMember = "Key";

            SetorAcabamento.DataSource = _regioesEstoques;
            SetorAcabamento.DisplayMember = "Nome";
            SetorAcabamento.ValueMember = "Id";

            _obras = obras;
        }

        private bool ValidatePecaObra()
        {
            if (!string.IsNullOrWhiteSpace(PecaNome.Text) &&
                PecaNome.Text != "Nome da peça..." &&
                PesoKg.Value > 0 &&
                VolumeM3.Value > 0 &&
                Total.Value > 0 &&
                RegiaoEstoque.SelectedIndex >= 0 &&
                StatusAcabamento.SelectedIndex >= 0 &&
                StatusEstoque.SelectedIndex >= 0 &&
                Obra.SelectedIndex >= 0 &&
                PecaStatus.SelectedIndex >= 0 &&
                SetorAcabamento.SelectedIndex >= 0
                )
            {
                return true;
            }
            return false;
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotaoInserir_Click(object sender, EventArgs e)
        {
            if (!ValidatePecaObra())
            {
                AvisoErro.Visible = true;
                SystemSounds.Exclamation.Play();

                return;
            }

            var obraSelected = Obra.SelectedItem as Obra;

            var codObra = obraSelected.CodObra;

            PecaObra pecaObra = new PecaObra()
            {
                NomePeca = PecaNome.Text,
                DataPeca = PecaData.Value,
                PecaStatus = PecaStatus.SelectedValue.ToString(),
                PesoKg = PesoKg.Value,
                VolumeM3 = VolumeM3.Value,
                RegiaoEstoque = (int)RegiaoEstoque.SelectedValue,
                AcabamentoStatus = StatusAcabamento.SelectedValue.ToString(),
                AcabamentoDataInicio = DataInicioAcab.Value,
                AcabamentoDataFim = DataFimAcab.Value,
                SetorAcabamento = (int)SetorAcabamento.SelectedValue,
                EstoqueTotal = (int)Total.Value,
                DataEstoque = DataEstoque.Value,
                EstoqueStatus = PecaStatus.SelectedValue.ToString(),
                CodObra = codObra
            };

            _criarPecaRepository.Executar(pecaObra);
            Close();
        }

        private void PecaNome_Enter(object sender, EventArgs e)
        {
            if (PecaNome.Text == "Nome da peça...")
            {
                PecaNome.Text = "";
                PecaNome.ForeColor = Color.Black;
            }
        }

        private void PecaNome_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PecaNome.Text))
            {
                PecaNome.Text = "Nome da peça...";
                PecaNome.ForeColor = Color.Gray;
            }
        }

    }
}
