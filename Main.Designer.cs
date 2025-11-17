using System.Drawing;
using System.Windows.Forms;

namespace ControlePecas
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FiltrosLabel = new System.Windows.Forms.Label();
            this.LogoFrase = new System.Windows.Forms.Label();
            this.ObrasFiltro = new System.Windows.Forms.ComboBox();
            this.RegiaoEstoqueFiltro = new System.Windows.Forms.ComboBox();
            this.BotaoGerarRelatorio = new System.Windows.Forms.Button();
            this.BotaoInserir = new System.Windows.Forms.Button();
            this.PecaObraView = new System.Windows.Forms.DataGridView();
            this.BotaoRemover = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotaoAtualizar = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AvisoErroEditar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PecaObraView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrosLabel
            // 
            this.FiltrosLabel.AutoSize = true;
            this.FiltrosLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrosLabel.Location = new System.Drawing.Point(52, 198);
            this.FiltrosLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FiltrosLabel.Name = "FiltrosLabel";
            this.FiltrosLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FiltrosLabel.Size = new System.Drawing.Size(94, 24);
            this.FiltrosLabel.TabIndex = 0;
            this.FiltrosLabel.Text = "Filtros";
            // 
            // LogoFrase
            // 
            this.LogoFrase.AutoSize = true;
            this.LogoFrase.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoFrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            this.LogoFrase.Location = new System.Drawing.Point(258, 131);
            this.LogoFrase.Name = "LogoFrase";
            this.LogoFrase.Size = new System.Drawing.Size(233, 28);
            this.LogoFrase.TabIndex = 2;
            this.LogoFrase.Text = "Controle de Peças";
            // 
            // ObrasFiltro
            // 
            this.ObrasFiltro.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObrasFiltro.FormattingEnabled = true;
            this.ObrasFiltro.Location = new System.Drawing.Point(56, 237);
            this.ObrasFiltro.Name = "ObrasFiltro";
            this.ObrasFiltro.Size = new System.Drawing.Size(653, 30);
            this.ObrasFiltro.TabIndex = 3;
            this.ObrasFiltro.Text = "Obra:";
            this.ObrasFiltro.SelectedIndexChanged += new System.EventHandler(this.ObraComboBox_SelectedIndexChanged);
            // 
            // RegiaoEstoqueFiltro
            // 
            this.RegiaoEstoqueFiltro.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegiaoEstoqueFiltro.FormattingEnabled = true;
            this.RegiaoEstoqueFiltro.Location = new System.Drawing.Point(56, 287);
            this.RegiaoEstoqueFiltro.Name = "RegiaoEstoqueFiltro";
            this.RegiaoEstoqueFiltro.Size = new System.Drawing.Size(653, 30);
            this.RegiaoEstoqueFiltro.TabIndex = 4;
            this.RegiaoEstoqueFiltro.Text = "Região de Estoque:";
            this.RegiaoEstoqueFiltro.SelectedIndexChanged += new System.EventHandler(this.RegiaoEstoqueComboBox_SelectedIndexChanged);
            // 
            // BotaoGerarRelatorio
            // 
            this.BotaoGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoGerarRelatorio.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoGerarRelatorio.Location = new System.Drawing.Point(56, 340);
            this.BotaoGerarRelatorio.Name = "BotaoGerarRelatorio";
            this.BotaoGerarRelatorio.Size = new System.Drawing.Size(652, 57);
            this.BotaoGerarRelatorio.TabIndex = 6;
            this.BotaoGerarRelatorio.Text = "GERAR RELATÓRIO";
            this.BotaoGerarRelatorio.UseVisualStyleBackColor = true;
            this.BotaoGerarRelatorio.Click += new System.EventHandler(this.BotaoGerarRelatorio_Click);
            // 
            // BotaoInserir
            // 
            this.BotaoInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(171)))));
            this.BotaoInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoInserir.ForeColor = System.Drawing.Color.White;
            this.BotaoInserir.Location = new System.Drawing.Point(583, 577);
            this.BotaoInserir.Name = "BotaoInserir";
            this.BotaoInserir.Size = new System.Drawing.Size(125, 58);
            this.BotaoInserir.TabIndex = 7;
            this.BotaoInserir.Text = " INSERIR";
            this.BotaoInserir.UseVisualStyleBackColor = false;
            this.BotaoInserir.Click += new System.EventHandler(this.InserirItem_Click);
            // 
            // PecaObraView
            // 
            this.PecaObraView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PecaObraView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PecaObraView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PecaObraView.Location = new System.Drawing.Point(56, 418);
            this.PecaObraView.Name = "PecaObraView";
            this.PecaObraView.Size = new System.Drawing.Size(652, 153);
            this.PecaObraView.TabIndex = 8;
            this.PecaObraView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LinhaSelecionada_CellClick);
            // 
            // BotaoRemover
            // 
            this.BotaoRemover.BackColor = System.Drawing.Color.Crimson;
            this.BotaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoRemover.ForeColor = System.Drawing.Color.White;
            this.BotaoRemover.Location = new System.Drawing.Point(56, 577);
            this.BotaoRemover.Name = "BotaoRemover";
            this.BotaoRemover.Size = new System.Drawing.Size(125, 58);
            this.BotaoRemover.TabIndex = 9;
            this.BotaoRemover.Text = "REMOVER";
            this.BotaoRemover.UseVisualStyleBackColor = false;
            this.BotaoRemover.Click += new System.EventHandler(this.BotaoDeletarPeca_Click);
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            this.BotaoEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoEditar.ForeColor = System.Drawing.Color.White;
            this.BotaoEditar.Location = new System.Drawing.Point(302, 577);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(125, 58);
            this.BotaoEditar.TabIndex = 10;
            this.BotaoEditar.Text = "EDITAR";
            this.BotaoEditar.UseVisualStyleBackColor = false;
            this.BotaoEditar.Click += new System.EventHandler(this.BotaoModalEditar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BotaoAtualizar);
            this.panel1.Controls.Add(this.BotaoEditar);
            this.panel1.Controls.Add(this.BotaoRemover);
            this.panel1.Controls.Add(this.PecaObraView);
            this.panel1.Controls.Add(this.BotaoInserir);
            this.panel1.Controls.Add(this.BotaoGerarRelatorio);
            this.panel1.Controls.Add(this.RegiaoEstoqueFiltro);
            this.panel1.Controls.Add(this.ObrasFiltro);
            this.panel1.Controls.Add(this.LogoFrase);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.FiltrosLabel);
            this.panel1.Location = new System.Drawing.Point(34, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 665);
            this.panel1.TabIndex = 11;
            // 
            // BotaoAtualizar
            // 
            this.BotaoAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(171)))));
            this.BotaoAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoAtualizar.Image = global::ControlePecas.Properties.Resources.recarregarIcone;
            this.BotaoAtualizar.Location = new System.Drawing.Point(658, 186);
            this.BotaoAtualizar.Name = "BotaoAtualizar";
            this.BotaoAtualizar.Size = new System.Drawing.Size(50, 45);
            this.BotaoAtualizar.TabIndex = 12;
            this.BotaoAtualizar.UseVisualStyleBackColor = false;
            this.BotaoAtualizar.Click += new System.EventHandler(this.BotaoAtualizarTabela_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ControlePecas.Properties.Resources.plannix_logo;
            this.Logo.Location = new System.Drawing.Point(163, 20);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(441, 154);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // AvisoErroEditar
            // 
            this.AvisoErroEditar.AutoSize = true;
            this.AvisoErroEditar.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisoErroEditar.ForeColor = System.Drawing.Color.Goldenrod;
            this.AvisoErroEditar.Location = new System.Drawing.Point(31, 684);
            this.AvisoErroEditar.Name = "AvisoErroEditar";
            this.AvisoErroEditar.Size = new System.Drawing.Size(288, 18);
            this.AvisoErroEditar.TabIndex = 12;
            this.AvisoErroEditar.Text = "[!] Você deve selecionar uma linha!";
            this.AvisoErroEditar.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 711);
            this.Controls.Add(this.AvisoErroEditar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.Text = "Controle Peças";
            this.Load += new System.EventHandler(this.Main_load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PecaObraView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FiltrosLabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LogoFrase;
        private System.Windows.Forms.ComboBox ObrasFiltro;
        private System.Windows.Forms.ComboBox RegiaoEstoqueFiltro;
        private System.Windows.Forms.Button BotaoGerarRelatorio;
        private Button BotaoInserir;
        private DataGridView PecaObraView;
        private Button BotaoRemover;
        private Button BotaoEditar;
        private Panel panel1;
        private Button BotaoAtualizar;
        private Label AvisoErroEditar;
    }
}

