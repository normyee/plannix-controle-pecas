namespace ControlePecas
{
    partial class ControleCriacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleCriacao));
            this.LogoFrase = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetorAcabamentoLabel = new System.Windows.Forms.Label();
            this.SetorAcabamento = new System.Windows.Forms.ComboBox();
            this.AvisoErro = new System.Windows.Forms.Label();
            this.PecaStatusLabel = new System.Windows.Forms.Label();
            this.PecaStatus = new System.Windows.Forms.ComboBox();
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
            this.DataFimAcabLabel = new System.Windows.Forms.Label();
            this.DataFimAcab = new System.Windows.Forms.DateTimePicker();
            this.DataInicioAcabLabel = new System.Windows.Forms.Label();
            this.DataInicioAcab = new System.Windows.Forms.DateTimePicker();
            this.AcabamentoTitulo = new System.Windows.Forms.Label();
            this.RegiaoEstoqueLabel = new System.Windows.Forms.Label();
            this.RegiaoEstoque = new System.Windows.Forms.ComboBox();
            this.VolumeM3Label = new System.Windows.Forms.Label();
            this.VolumeM3 = new System.Windows.Forms.NumericUpDown();
            this.PesoKgLabel = new System.Windows.Forms.Label();
            this.PesoKg = new System.Windows.Forms.NumericUpDown();
            this.PecaData = new System.Windows.Forms.DateTimePicker();
            this.PecaNome = new System.Windows.Forms.TextBox();
            this.BotaoInserir = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesoKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoFrase
            // 
            this.LogoFrase.AutoSize = true;
            this.LogoFrase.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoFrase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            this.LogoFrase.Location = new System.Drawing.Point(75, 124);
            this.LogoFrase.Name = "LogoFrase";
            this.LogoFrase.Size = new System.Drawing.Size(233, 28);
            this.LogoFrase.TabIndex = 2;
            this.LogoFrase.Text = "Controle de Peças";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.SetorAcabamentoLabel);
            this.panel1.Controls.Add(this.SetorAcabamento);
            this.panel1.Controls.Add(this.AvisoErro);
            this.panel1.Controls.Add(this.PecaStatusLabel);
            this.panel1.Controls.Add(this.PecaStatus);
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
            this.panel1.Controls.Add(this.DataFimAcabLabel);
            this.panel1.Controls.Add(this.DataFimAcab);
            this.panel1.Controls.Add(this.DataInicioAcabLabel);
            this.panel1.Controls.Add(this.DataInicioAcab);
            this.panel1.Controls.Add(this.AcabamentoTitulo);
            this.panel1.Controls.Add(this.RegiaoEstoqueLabel);
            this.panel1.Controls.Add(this.RegiaoEstoque);
            this.panel1.Controls.Add(this.VolumeM3Label);
            this.panel1.Controls.Add(this.VolumeM3);
            this.panel1.Controls.Add(this.PesoKgLabel);
            this.panel1.Controls.Add(this.PesoKg);
            this.panel1.Controls.Add(this.PecaData);
            this.panel1.Controls.Add(this.PecaNome);
            this.panel1.Controls.Add(this.BotaoInserir);
            this.panel1.Controls.Add(this.BotaoCancelar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LogoFrase);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 627);
            this.panel1.TabIndex = 12;
            // 
            // SetorAcabamentoLabel
            // 
            this.SetorAcabamentoLabel.AutoSize = true;
            this.SetorAcabamentoLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetorAcabamentoLabel.Location = new System.Drawing.Point(11, 352);
            this.SetorAcabamentoLabel.Name = "SetorAcabamentoLabel";
            this.SetorAcabamentoLabel.Size = new System.Drawing.Size(127, 13);
            this.SetorAcabamentoLabel.TabIndex = 43;
            this.SetorAcabamentoLabel.Text = "Setor de Acabamento:";
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
            // AvisoErro
            // 
            this.AvisoErro.AutoSize = true;
            this.AvisoErro.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvisoErro.ForeColor = System.Drawing.Color.Red;
            this.AvisoErro.Location = new System.Drawing.Point(11, 487);
            this.AvisoErro.Name = "AvisoErro";
            this.AvisoErro.Size = new System.Drawing.Size(301, 13);
            this.AvisoErro.TabIndex = 41;
            this.AvisoErro.Text = "Ocorreu um erro na validação ou inserção de dado!";
            this.AvisoErro.Visible = false;
            // 
            // PecaStatusLabel
            // 
            this.PecaStatusLabel.AutoSize = true;
            this.PecaStatusLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PecaStatusLabel.Location = new System.Drawing.Point(263, 246);
            this.PecaStatusLabel.Name = "PecaStatusLabel";
            this.PecaStatusLabel.Size = new System.Drawing.Size(49, 13);
            this.PecaStatusLabel.TabIndex = 40;
            this.PecaStatusLabel.Text = "Status:";
            // 
            // PecaStatus
            // 
            this.PecaStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PecaStatus.FormattingEnabled = true;
            this.PecaStatus.Location = new System.Drawing.Point(318, 242);
            this.PecaStatus.Name = "PecaStatus";
            this.PecaStatus.Size = new System.Drawing.Size(85, 21);
            this.PecaStatus.TabIndex = 39;
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
            // DataFimAcabLabel
            // 
            this.DataFimAcabLabel.AutoSize = true;
            this.DataFimAcabLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFimAcabLabel.Location = new System.Drawing.Point(142, 316);
            this.DataFimAcabLabel.Name = "DataFimAcabLabel";
            this.DataFimAcabLabel.Size = new System.Drawing.Size(31, 13);
            this.DataFimAcabLabel.TabIndex = 25;
            this.DataFimAcabLabel.Text = "Fim:";
            // 
            // DataFimAcab
            // 
            this.DataFimAcab.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFimAcab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFimAcab.Location = new System.Drawing.Point(179, 312);
            this.DataFimAcab.Name = "DataFimAcab";
            this.DataFimAcab.Size = new System.Drawing.Size(68, 20);
            this.DataFimAcab.TabIndex = 24;
            // 
            // DataInicioAcabLabel
            // 
            this.DataInicioAcabLabel.AutoSize = true;
            this.DataInicioAcabLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicioAcabLabel.Location = new System.Drawing.Point(11, 316);
            this.DataInicioAcabLabel.Name = "DataInicioAcabLabel";
            this.DataInicioAcabLabel.Size = new System.Drawing.Size(49, 13);
            this.DataInicioAcabLabel.TabIndex = 23;
            this.DataInicioAcabLabel.Text = "Início:";
            // 
            // DataInicioAcab
            // 
            this.DataInicioAcab.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicioAcab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicioAcab.Location = new System.Drawing.Point(66, 312);
            this.DataInicioAcab.Name = "DataInicioAcab";
            this.DataInicioAcab.Size = new System.Drawing.Size(70, 20);
            this.DataInicioAcab.TabIndex = 22;
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
            // PecaData
            // 
            this.PecaData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PecaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PecaData.Location = new System.Drawing.Point(314, 190);
            this.PecaData.Name = "PecaData";
            this.PecaData.Size = new System.Drawing.Size(89, 20);
            this.PecaData.TabIndex = 12;
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
            // BotaoInserir
            // 
            this.BotaoInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(171)))));
            this.BotaoInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoInserir.ForeColor = System.Drawing.Color.White;
            this.BotaoInserir.Location = new System.Drawing.Point(287, 566);
            this.BotaoInserir.Name = "BotaoInserir";
            this.BotaoInserir.Size = new System.Drawing.Size(125, 58);
            this.BotaoInserir.TabIndex = 10;
            this.BotaoInserir.Text = " INSERIR";
            this.BotaoInserir.UseVisualStyleBackColor = false;
            this.BotaoInserir.Click += new System.EventHandler(this.BotaoInserir_Click);
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
            // ControleCriacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 651);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControleCriacao";
            this.Text = "ControleCriacao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesoKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LogoFrase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotaoInserir;
        private System.Windows.Forms.TextBox PecaNome;
        private System.Windows.Forms.DateTimePicker PecaData;
        private System.Windows.Forms.Label PesoKgLabel;
        private System.Windows.Forms.NumericUpDown PesoKg;
        private System.Windows.Forms.Label VolumeM3Label;
        private System.Windows.Forms.NumericUpDown VolumeM3;
        private System.Windows.Forms.Label RegiaoEstoqueLabel;
        private System.Windows.Forms.ComboBox RegiaoEstoque;
        private System.Windows.Forms.Label AcabamentoTitulo;
        private System.Windows.Forms.Label StatusAcabamentoLabel;
        private System.Windows.Forms.ComboBox StatusAcabamento;
        private System.Windows.Forms.Label DataFimAcabLabel;
        private System.Windows.Forms.DateTimePicker DataFimAcab;
        private System.Windows.Forms.Label DataInicioAcabLabel;
        private System.Windows.Forms.DateTimePicker DataInicioAcab;
        private System.Windows.Forms.Label StatusEstoqueLabel;
        private System.Windows.Forms.ComboBox StatusEstoque;
        private System.Windows.Forms.Label DataEstoqueLabel;
        private System.Windows.Forms.DateTimePicker DataEstoque;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label EstoqueTitulo;
        private System.Windows.Forms.NumericUpDown Total;
        private System.Windows.Forms.Label ObraLabel;
        private System.Windows.Forms.ComboBox Obra;
        private System.Windows.Forms.Label PecaStatusLabel;
        private System.Windows.Forms.ComboBox PecaStatus;
        private System.Windows.Forms.Label AvisoErro;
        private System.Windows.Forms.Label SetorAcabamentoLabel;
        private System.Windows.Forms.ComboBox SetorAcabamento;
    }
}