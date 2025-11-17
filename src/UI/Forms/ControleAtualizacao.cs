using ControlePecas.Entities;
using ControlePecas.Repositories;
using ControlePecas.Features;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ControlePecas
{
    public partial class ControleAtualizacao : Form
    {
        private readonly int _codControle;
        private readonly List<Regiao> _regioesEstoques;
        private readonly List<Obra> _obras;
        private readonly ObterPeca _obterPeca;
        private readonly AtualizarPeca _atualizarPeca;

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

        public ControleAtualizacao(int codControle, List<Regiao> regioesEstoques, List<Obra> obras, ObterPeca obterPeca, AtualizarPeca atualizarPeca)
        {
            InitializeComponent();

            _codControle = codControle;
            _regioesEstoques = regioesEstoques;
            _obras = obras;
            _obterPeca = obterPeca;
            _atualizarPeca = atualizarPeca;

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

            StatusPeca.DataSource = _statusPeca;
            StatusPeca.DisplayMember = "Value";
            StatusPeca.ValueMember = "Key";

            SetorAcabamento.DataSource = _regioesEstoques;
            SetorAcabamento.DisplayMember = "Nome";
            SetorAcabamento.ValueMember = "Id";

            _obras = obras;

          PecaObra pecaObra = _obterPeca.Executar(_codControle);

            PecaNome.Text = pecaObra.NomePeca;
            PecaNome.ForeColor = Color.Black;
            DataPeca.Value = pecaObra.DataPeca;
            PesoKg.Value = pecaObra.PesoKg;
            VolumeM3.Value = pecaObra.VolumeM3;
            RegiaoEstoque.SelectedValue = pecaObra.RegiaoEstoque;
            StatusPeca.SelectedValue = pecaObra.PecaStatus;
            AcabDataInicio.Value = pecaObra.AcabamentoDataInicio;
            AcabDataFim.Value = pecaObra.AcabamentoDataFim;
            StatusAcabamento.SelectedValue = pecaObra.AcabamentoStatus;
            SetorAcabamento.SelectedValue = pecaObra.SetorAcabamento;
            Total.Value = pecaObra.EstoqueTotal;
            DataEstoque.Value = pecaObra.DataEstoque;
            Obra.SelectedValue = pecaObra.CodObra;


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
                StatusPeca.SelectedIndex >= 0 &&
                SetorAcabamento.SelectedIndex >= 0
                )
            {
                return true;
            }
            return false;
        }

        private void AtualizarPeca_Click(object sender, EventArgs e)
        {
            if (!ValidatePecaObra())
            {
                ErroAviso.Visible = true;
                SystemSounds.Exclamation.Play();

                return;
            }

            var obraSelected = Obra.SelectedItem as Obra;

            var codObra = obraSelected.CodObra;

            PecaObra pecaObra = new PecaObra()
            {
                NomePeca = PecaNome.Text,
                DataPeca = DataPeca.Value,
                PecaStatus = StatusPeca.SelectedValue.ToString(),
                PesoKg = PesoKg.Value,
                VolumeM3 = VolumeM3.Value,
                RegiaoEstoque = (int)RegiaoEstoque.SelectedValue,
                AcabamentoStatus = StatusAcabamento.SelectedValue.ToString(),
                AcabamentoDataInicio = AcabDataInicio.Value,
                AcabamentoDataFim = AcabDataFim.Value,
                SetorAcabamento = (int)SetorAcabamento.SelectedValue,
                EstoqueTotal = (int)Total.Value,
                DataEstoque = DataEstoque.Value,
                EstoqueStatus = StatusPeca.SelectedValue.ToString(),
                CodObra = codObra
            };
            _atualizarPeca.Executar(_codControle, pecaObra);
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

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
