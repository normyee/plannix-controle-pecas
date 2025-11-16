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
        private List<Regiao> _regioesEstoques;
        private List<Obra> _obras;
        private CriarPecaRepository _criarPecaRepository;

        private List<KeyValuePair<string, string>> _acabamentoStatus =
            new List<KeyValuePair<string, string>>
            {
        new KeyValuePair<string, string>("EM_PRODUCAO", "Em produção"),
        new KeyValuePair<string, string>("PENDENTE", "Pendente"),
        new KeyValuePair<string, string>("FINALIZADO", "Finalizado")
            };
        private List<KeyValuePair<string, string>> _statusEstoque =
    new List<KeyValuePair<string, string>>
    {
        new KeyValuePair<string, string>("EM_ACABAMENNTO", "Em acabamento"),
        new KeyValuePair<string, string>("AGUARDANDO_ACABAMENTO", "Aguardando acabamento"),
        new KeyValuePair<string, string>("DISPONIVEL", "Disponível")
    };

        private List<KeyValuePair<string, string>> _statusPeca =
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

            comboBox1.DataSource = _regioesEstoques;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";

            comboBox4.DataSource = _obras;
            comboBox4.DisplayMember = "Nome";
            comboBox4.ValueMember = "CodObra";

            comboBox2.DataSource = _acabamentoStatus;
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

            comboBox3.DataSource = _statusEstoque;
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";

            comboBox5.DataSource = _statusPeca;
            comboBox5.DisplayMember = "Value";
            comboBox5.ValueMember = "Key";

            comboBox6.DataSource = _regioesEstoques;
            comboBox6.DisplayMember = "Nome";
            comboBox6.ValueMember = "Id";

            _obras = obras;
        }

        private bool ValidatePecaObra()
        {
            if (!string.IsNullOrWhiteSpace(PecaNome.Text) &&
                PecaNome.Text != "Nome da peça..." &&
                numericUpDown2.Value > 0 &&
                numericUpDown1.Value > 0 &&
                numericUpDown3.Value > 0 &&
                comboBox1.SelectedIndex >= 0 &&
                comboBox2.SelectedIndex >= 0 &&
                comboBox3.SelectedIndex >= 0 &&
                comboBox4.SelectedIndex >= 0 &&
                comboBox5.SelectedIndex >= 0 &&
                comboBox6.SelectedIndex >= 0 
                )
            {
                return true;
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidatePecaObra())
            {
                label15.Visible = true;
                SystemSounds.Exclamation.Play();

                return;
            }

            var obraSelected = comboBox4.SelectedItem as Obra;

            var codObra = obraSelected.CodObra;

            PecaObra pecaObra = new PecaObra() { 
                NomePeca = PecaNome.Text,
                DataPeca = dateTimePicker1.Value,
                PecaStatus = comboBox5.SelectedValue.ToString(),
                PesoKg = numericUpDown2.Value,
                VolumeM3 = numericUpDown1.Value,
                RegiaoEstoque = (int)comboBox1.SelectedValue,
                AcabamentoStatus = comboBox2.SelectedValue.ToString(),
                AcabamentoDataInicio = dateTimePicker2.Value,
                AcabamentoDataFim = dateTimePicker3.Value,
                SetorAcabamento = (int)comboBox6.SelectedValue,
                EstoqueTotal = (int)numericUpDown3.Value,
                DataEstoque = dateTimePicker4.Value,
                EstoqueStatus = comboBox5.SelectedValue.ToString(),
                CodObra = codObra
            };

            _criarPecaRepository.Executar(pecaObra);
            Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void ControleCriacao_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
