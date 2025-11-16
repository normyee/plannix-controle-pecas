using ControlePecas.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControlePecas
{
    public partial class ControleCriacao : Form
    {
        private List<Regiao> _regioesEstoques;
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

        public ControleCriacao(List<Regiao> regioesEstoques)
        {
            InitializeComponent();

            _regioesEstoques = regioesEstoques;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            comboBox1.DataSource = _regioesEstoques;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";

            comboBox2.DataSource = _acabamentoStatus;
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

            comboBox3.DataSource = _statusEstoque;
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
