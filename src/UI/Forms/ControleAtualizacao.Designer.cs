namespace ControlePecas
{
    partial class ControleAtualizacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleAtualizacao));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.FraseLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetorAcabLabel = new System.Windows.Forms.Label();
            this.SetorAcabamento = new System.Windows.Forms.ComboBox();
            this.ErroAviso = new System.Windows.Forms.Label();
            this.StatusPecaLabel = new System.Windows.Forms.Label();
            this.StatusPeca = new System.Windows.Forms.ComboBox();
            this.Obra = new System.Windows.Forms.ComboBox();
            this.ObraLabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.NumericUpDown();
            this.StatusEstoqueLabel = new System.Windows.Forms.Label();
            this.StatusEstoque = new System.Windows.Forms.ComboBox();
            this.DataEstoqueLabel = new System.Windows.Forms.Label();
            this.DataEstoque = new System.Windows.Forms.DateTimePicker();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.EstoqueTitulo = new System.Windows.Forms.Label();
            this.StatusAcabamentoLabel = new System.Windows.Forms.Label();
            this.StatusAcabamento = new System.Windows.Forms.ComboBox();
            this.AcabDataFimLabel = new System.Windows.Forms.Label();
            this.AcabDataFim = new System.Windows.Forms.DateTimePicker();
            this.AcabDataInicioLabel = new System.Windows.Forms.Label();
            this.AcabDataInicio = new System.Windows.Forms.DateTimePicker();
            this.AcabamentoTitulo = new System.Windows.Forms.Label();
            this.RegiaoEstoqueLabel = new System.Windows.Forms.Label();
            this.RegiaoEstoque = new System.Windows.Forms.ComboBox();
            this.VolumeM3Label = new System.Windows.Forms.Label();
            this.VolumeM3 = new System.Windows.Forms.NumericUpDown();
            this.PesoKgLabel = new System.Windows.Forms.Label();
            this.PesoKg = new System.Windows.Forms.NumericUpDown();
            this.DataPeca = new System.Windows.Forms.DateTimePicker();
            this.PecaNome = new System.Windows.Forms.TextBox();
            this.BotaoAtualizar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesoKg)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::ControlePecas.Properties.Resources.plannix_logo;
            this.Logo.Location = new System.Drawing.Point(14, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(389, 139);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // FraseLogo
            // 
            this.FraseLogo.AutoSize = true;
            this.FraseLogo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FraseLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            this.FraseLogo.Location = new System.Drawing.Point(75, 124);
            this.FraseLogo.Name = "FraseLogo";
            this.FraseLogo.Size = new System.Drawing.Size(233, 28);
            this.FraseLogo.TabIndex = 2;
            this.FraseLogo.Text = "Controle de Peças";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SetorAcabLabel);
            this.panel1.Controls.Add(this.SetorAcabamento);
            this.panel1.Controls.Add(this.ErroAviso);
            this.panel1.Controls.Add(this.StatusPecaLabel);
            this.panel1.Controls.Add(this.StatusPeca);
            this.panel1.Controls.Add(this.Obra);
            this.panel1.Controls.Add(this.ObraLabel);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.StatusEstoqueLabel);
            this.panel1.Controls.Add(this.StatusEstoque);
            this.panel1.Controls.Add(this.DataEstoqueLabel);
            this.panel1.Controls.Add(this.DataEstoque);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.EstoqueTitulo);
            this.panel1.Controls.Add(this.StatusAcabamentoLabel);
            this.panel1.Controls.Add(this.StatusAcabamento);
            this.panel1.Controls.Add(this.AcabDataFimLabel);
            this.panel1.Controls.Add(this.AcabDataFim);
            this.panel1.Controls.Add(this.AcabDataInicioLabel);
            this.panel1.Controls.Add(this.AcabDataInicio);
            this.panel1.Controls.Add(this.AcabamentoTitulo);
            this.panel1.Controls.Add(this.RegiaoEstoqueLabel);
            this.panel1.Controls.Add(this.RegiaoEstoque);
            this.panel1.Controls.Add(this.VolumeM3Label);
            this.panel1.Controls.Add(this.VolumeM3);
            this.panel1.Controls.Add(this.PesoKgLabel);
            this.panel1.Controls.Add(this.PesoKg);
            this.panel1.Controls.Add(this.DataPeca);
            this.panel1.Controls.Add(this.PecaNome);
            this.panel1.Controls.Add(this.BotaoAtualizar);
            this.panel1.Controls.Add(this.BotaoCancelar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FraseLogo);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 627);
            this.panel1.TabIndex = 13;
            // 
            // SetorAcabLabel
            // 
            this.SetorAcabLabel.AutoSize = true;
            this.SetorAcabLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetorAcabLabel.Location = new System.Drawing.Point(11, 352);
            this.SetorAcabLabel.Name = "SetorAcabLabel";
            this.SetorAcabLabel.Size = new System.Drawing.Size(127, 13);
            this.SetorAcabLabel.TabIndex = 43;
            this.SetorAcabLabel.Text = "Setor de Acabamento:";
            // 
            // SetorAcabamento
            // 
            this.SetorAcabamento.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetorAcabamento.FormattingEnabled = true;
            this.SetorAcabamento.Location = new System.Drawing.Point(144, 348);
            this.SetorAcabamento.Name = "SetorAcabamento";
            this.SetorAcabamento.Size = new System.Drawing.Size(259, 21);
            this.SetorAcabamento.TabIndex = 42;
            // 
            // ErroAviso
            // 
            this.ErroAviso.AutoSize = true;
            this.ErroAviso.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErroAviso.ForeColor = System.Drawing.Color.Red;
            this.ErroAviso.Location = new System.Drawing.Point(11, 487);
            this.ErroAviso.Name = "ErroAviso";
            this.ErroAviso.Size = new System.Drawing.Size(319, 13);
            this.ErroAviso.TabIndex = 41;
            this.ErroAviso.Text = "Ocorreu um erro na validação ou atualização de dado!";
            this.ErroAviso.Visible = false;
            // 
            // StatusPecaLabel
            // 
            this.StatusPecaLabel.AutoSize = true;
            this.StatusPecaLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPecaLabel.Location = new System.Drawing.Point(263, 246);
            this.StatusPecaLabel.Name = "StatusPecaLabel";
            this.StatusPecaLabel.Size = new System.Drawing.Size(49, 13);
            this.StatusPecaLabel.TabIndex = 40;
            this.StatusPecaLabel.Text = "Status:";
            // 
            // StatusPeca
            // 
            this.StatusPeca.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPeca.FormattingEnabled = true;
            this.StatusPeca.Location = new System.Drawing.Point(318, 242);
            this.StatusPeca.Name = "StatusPeca";
            this.StatusPeca.Size = new System.Drawing.Size(85, 21);
            this.StatusPeca.TabIndex = 39;
            // 
            // Obra
            // 
            this.Obra.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obra.FormattingEnabled = true;
            this.Obra.Location = new System.Drawing.Point(54, 453);
            this.Obra.Name = "Obra";
            this.Obra.Size = new System.Drawing.Size(349, 21);
            this.Obra.TabIndex = 38;
            // 
            // ObraLabel
            // 
            this.ObraLabel.AutoSize = true;
            this.ObraLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObraLabel.Location = new System.Drawing.Point(11, 457);
            this.ObraLabel.Name = "ObraLabel";
            this.ObraLabel.Size = new System.Drawing.Size(37, 13);
            this.ObraLabel.TabIndex = 37;
            this.ObraLabel.Text = "Obra:";
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(66, 416);
            this.Total.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(70, 20);
            this.Total.TabIndex = 35;
            // 
            // StatusEstoqueLabel
            // 
            this.StatusEstoqueLabel.AutoSize = true;
            this.StatusEstoqueLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusEstoqueLabel.Location = new System.Drawing.Point(253, 418);
            this.StatusEstoqueLabel.Name = "StatusEstoqueLabel";
            this.StatusEstoqueLabel.Size = new System.Drawing.Size(49, 13);
            this.StatusEstoqueLabel.TabIndex = 34;
            this.StatusEstoqueLabel.Text = "Status:";
            // 
            // StatusEstoque
            // 
            this.StatusEstoque.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusEstoque.FormattingEnabled = true;
            this.StatusEstoque.Location = new System.Drawing.Point(308, 416);
            this.StatusEstoque.Name = "StatusEstoque";
            this.StatusEstoque.Size = new System.Drawing.Size(95, 21);
            this.StatusEstoque.TabIndex = 33;
            // 
            // DataEstoqueLabel
            // 
            this.DataEstoqueLabel.AutoSize = true;
            this.DataEstoqueLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEstoqueLabel.Location = new System.Drawing.Point(141, 418);
            this.DataEstoqueLabel.Name = "DataEstoqueLabel";
            this.DataEstoqueLabel.Size = new System.Drawing.Size(37, 13);
            this.DataEstoqueLabel.TabIndex = 32;
            this.DataEstoqueLabel.Text = "Data:";
            // 
            // DataEstoque
            // 
            this.DataEstoque.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEstoque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataEstoque.Location = new System.Drawing.Point(179, 416);
            this.DataEstoque.Name = "DataEstoque";
            this.DataEstoque.Size = new System.Drawing.Size(68, 20);
            this.DataEstoque.TabIndex = 31;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(11, 418);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(43, 13);
            this.TotalLabel.TabIndex = 30;
            this.TotalLabel.Text = "Total:";
            // 
            // EstoqueTitulo
            // 
            this.EstoqueTitulo.AutoSize = true;
            this.EstoqueTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstoqueTitulo.ForeColor = System.Drawing.Color.Gray;
            this.EstoqueTitulo.Location = new System.Drawing.Point(168, 382);
            this.EstoqueTitulo.Name = "EstoqueTitulo";
            this.EstoqueTitulo.Size = new System.Drawing.Size(72, 19);
            this.EstoqueTitulo.TabIndex = 28;
            this.EstoqueTitulo.Text = "Estoque";
            // 
            // StatusAcabamentoLabel
            // 
            this.StatusAcabamentoLabel.AutoSize = true;
            this.StatusAcabamentoLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusAcabamentoLabel.Location = new System.Drawing.Point(253, 316);
            this.StatusAcabamentoLabel.Name = "StatusAcabamentoLabel";
            this.StatusAcabamentoLabel.Size = new System.Drawing.Size(49, 13);
            this.StatusAcabamentoLabel.TabIndex = 27;
            this.StatusAcabamentoLabel.Text = "Status:";
            // 
            // StatusAcabamento
            // 
            this.StatusAcabamento.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusAcabamento.FormattingEnabled = true;
            this.StatusAcabamento.Location = new System.Drawing.Point(308, 312);
            this.StatusAcabamento.Name = "StatusAcabamento";
            this.StatusAcabamento.Size = new System.Drawing.Size(95, 21);
            this.StatusAcabamento.TabIndex = 26;
            // 
            // AcabDataFimLabel
            // 
            this.AcabDataFimLabel.AutoSize = true;
            this.AcabDataFimLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcabDataFimLabel.Location = new System.Drawing.Point(142, 316);
            this.AcabDataFimLabel.Name = "AcabDataFimLabel";
            this.AcabDataFimLabel.Size = new System.Drawing.Size(31, 13);
            this.AcabDataFimLabel.TabIndex = 25;
            this.AcabDataFimLabel.Text = "Fim:";
            // 
            // AcabDataFim
            // 
            this.AcabDataFim.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcabDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AcabDataFim.Location = new System.Drawing.Point(179, 312);
            this.AcabDataFim.Name = "AcabDataFim";
            this.AcabDataFim.Size = new System.Drawing.Size(68, 20);
            this.AcabDataFim.TabIndex = 24;
            // 
            // AcabDataInicioLabel
            // 
            this.AcabDataInicioLabel.AutoSize = true;
            this.AcabDataInicioLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcabDataInicioLabel.Location = new System.Drawing.Point(11, 316);
            this.AcabDataInicioLabel.Name = "AcabDataInicioLabel";
            this.AcabDataInicioLabel.Size = new System.Drawing.Size(49, 13);
            this.AcabDataInicioLabel.TabIndex = 23;
            this.AcabDataInicioLabel.Text = "Início:";
            // 
            // AcabDataInicio
            // 
            this.AcabDataInicio.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcabDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AcabDataInicio.Location = new System.Drawing.Point(66, 312);
            this.AcabDataInicio.Name = "AcabDataInicio";
            this.AcabDataInicio.Size = new System.Drawing.Size(70, 20);
            this.AcabDataInicio.TabIndex = 22;
            // 
            // AcabamentoTitulo
            // 
            this.AcabamentoTitulo.AutoSize = true;
            this.AcabamentoTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcabamentoTitulo.ForeColor = System.Drawing.Color.Gray;
            this.AcabamentoTitulo.Location = new System.Drawing.Point(153, 282);
            this.AcabamentoTitulo.Name = "AcabamentoTitulo";
            this.AcabamentoTitulo.Size = new System.Drawing.Size(99, 19);
            this.AcabamentoTitulo.TabIndex = 21;
            this.AcabamentoTitulo.Text = "Acabamento";
            // 
            // RegiaoEstoqueLabel
            // 
            this.RegiaoEstoqueLabel.AutoSize = true;
            this.RegiaoEstoqueLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegiaoEstoqueLabel.Location = new System.Drawing.Point(11, 246);
            this.RegiaoEstoqueLabel.Name = "RegiaoEstoqueLabel";
            this.RegiaoEstoqueLabel.Size = new System.Drawing.Size(115, 13);
            this.RegiaoEstoqueLabel.TabIndex = 20;
            this.RegiaoEstoqueLabel.Text = "Região de Estoque:";
            // 
            // RegiaoEstoque
            // 
            this.RegiaoEstoque.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegiaoEstoque.FormattingEnabled = true;
            this.RegiaoEstoque.Location = new System.Drawing.Point(126, 242);
            this.RegiaoEstoque.Name = "RegiaoEstoque";
            this.RegiaoEstoque.Size = new System.Drawing.Size(131, 21);
            this.RegiaoEstoque.TabIndex = 19;
            // 
            // VolumeM3Label
            // 
            this.VolumeM3Label.AutoSize = true;
            this.VolumeM3Label.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeM3Label.Location = new System.Drawing.Point(204, 219);
            this.VolumeM3Label.Name = "VolumeM3Label";
            this.VolumeM3Label.Size = new System.Drawing.Size(67, 13);
            this.VolumeM3Label.TabIndex = 18;
            this.VolumeM3Label.Text = "Volume M3:";
            // 
            // VolumeM3
            // 
            this.VolumeM3.DecimalPlaces = 3;
            this.VolumeM3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeM3.Location = new System.Drawing.Point(271, 216);
            this.VolumeM3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.VolumeM3.Name = "VolumeM3";
            this.VolumeM3.Size = new System.Drawing.Size(132, 20);
            this.VolumeM3.TabIndex = 17;
            // 
            // PesoKgLabel
            // 
            this.PesoKgLabel.AutoSize = true;
            this.PesoKgLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoKgLabel.Location = new System.Drawing.Point(11, 219);
            this.PesoKgLabel.Name = "PesoKgLabel";
            this.PesoKgLabel.Size = new System.Drawing.Size(55, 13);
            this.PesoKgLabel.TabIndex = 16;
            this.PesoKgLabel.Text = "Peso KG:";
            // 
            // PesoKg
            // 
            this.PesoKg.DecimalPlaces = 3;
            this.PesoKg.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoKg.Location = new System.Drawing.Point(66, 216);
            this.PesoKg.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PesoKg.Name = "PesoKg";
            this.PesoKg.Size = new System.Drawing.Size(131, 20);
            this.PesoKg.TabIndex = 15;
            // 
            // DataPeca
            // 
            this.DataPeca.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPeca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataPeca.Location = new System.Drawing.Point(314, 190);
            this.DataPeca.Name = "DataPeca";
            this.DataPeca.Size = new System.Drawing.Size(89, 20);
            this.DataPeca.TabIndex = 12;
            // 
            // PecaNome
            // 
            this.PecaNome.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PecaNome.ForeColor = System.Drawing.Color.Gray;
            this.PecaNome.Location = new System.Drawing.Point(14, 190);
            this.PecaNome.Name = "PecaNome";
            this.PecaNome.Size = new System.Drawing.Size(294, 20);
            this.PecaNome.TabIndex = 11;
            this.PecaNome.Text = "Nome da peça...";
            this.PecaNome.Enter += new System.EventHandler(this.PecaNome_Enter);
            this.PecaNome.Leave += new System.EventHandler(this.PecaNome_Leave);
            // 
            // BotaoAtualizar
            // 
            this.BotaoAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(171)))));
            this.BotaoAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoAtualizar.ForeColor = System.Drawing.Color.White;
            this.BotaoAtualizar.Location = new System.Drawing.Point(287, 566);
            this.BotaoAtualizar.Name = "BotaoAtualizar";
            this.BotaoAtualizar.Size = new System.Drawing.Size(125, 58);
            this.BotaoAtualizar.TabIndex = 10;
            this.BotaoAtualizar.Text = "ATUALIZAR";
            this.BotaoAtualizar.UseVisualStyleBackColor = false;
            this.BotaoAtualizar.Click += new System.EventHandler(this.AtualizarPeca_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BotaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoCancelar.ForeColor = System.Drawing.Color.White;
            this.BotaoCancelar.Location = new System.Drawing.Point(3, 566);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(125, 58);
            this.BotaoCancelar.TabIndex = 9;
            this.BotaoCancelar.Text = "CANCELAR";
            this.BotaoCancelar.UseVisualStyleBackColor = false;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(171)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(537, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "INSERIR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ControleAtualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 651);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(455, 690);
            this.Name = "ControleAtualizacao";
            this.Text = "Atualizar peça";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesoKg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label FraseLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SetorAcabLabel;
        private System.Windows.Forms.ComboBox SetorAcabamento;
        private System.Windows.Forms.Label ErroAviso;
        private System.Windows.Forms.Label StatusPecaLabel;
        private System.Windows.Forms.ComboBox StatusPeca;
        private System.Windows.Forms.ComboBox Obra;
        private System.Windows.Forms.Label ObraLabel;
        private System.Windows.Forms.NumericUpDown Total;
        private System.Windows.Forms.Label StatusEstoqueLabel;
        private System.Windows.Forms.ComboBox StatusEstoque;
        private System.Windows.Forms.Label DataEstoqueLabel;
        private System.Windows.Forms.DateTimePicker DataEstoque;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label EstoqueTitulo;
        private System.Windows.Forms.Label StatusAcabamentoLabel;
        private System.Windows.Forms.ComboBox StatusAcabamento;
        private System.Windows.Forms.Label AcabDataFimLabel;
        private System.Windows.Forms.DateTimePicker AcabDataFim;
        private System.Windows.Forms.Label AcabDataInicioLabel;
        private System.Windows.Forms.DateTimePicker AcabDataInicio;
        private System.Windows.Forms.Label AcabamentoTitulo;
        private System.Windows.Forms.Label RegiaoEstoqueLabel;
        private System.Windows.Forms.ComboBox RegiaoEstoque;
        private System.Windows.Forms.Label VolumeM3Label;
        private System.Windows.Forms.NumericUpDown VolumeM3;
        private System.Windows.Forms.Label PesoKgLabel;
        private System.Windows.Forms.NumericUpDown PesoKg;
        private System.Windows.Forms.DateTimePicker DataPeca;
        private System.Windows.Forms.TextBox PecaNome;
        private System.Windows.Forms.Button BotaoAtualizar;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Button button1;
    }
}