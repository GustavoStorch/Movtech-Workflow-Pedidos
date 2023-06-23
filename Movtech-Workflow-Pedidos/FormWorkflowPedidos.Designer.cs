namespace Movtech_Workflow_Pedidos
{
    partial class FormWorkflowPedidos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkflowPedidos));
            this.lblDateDe = new System.Windows.Forms.Label();
            this.lblDataAte = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.dtpDataDe = new System.Windows.Forms.DateTimePicker();
            this.dtpDataAte = new System.Windows.Forms.DateTimePicker();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgDadosPedidos = new System.Windows.Forms.DataGridView();
            this.colPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdTipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaixarEtapa = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imgLoad = new System.Windows.Forms.PictureBox();
            this.btnBuscarPedidos = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dtgMostraTotaisPedidos = new System.Windows.Forms.DataGridView();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeTiposTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnitTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotalTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostraTotaisPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateDe
            // 
            this.lblDateDe.AutoSize = true;
            this.lblDateDe.Location = new System.Drawing.Point(8, 11);
            this.lblDateDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDe.Name = "lblDateDe";
            this.lblDateDe.Size = new System.Drawing.Size(48, 13);
            this.lblDateDe.TabIndex = 0;
            this.lblDateDe.Text = "Data de:";
            // 
            // lblDataAte
            // 
            this.lblDataAte.AutoSize = true;
            this.lblDataAte.Location = new System.Drawing.Point(155, 11);
            this.lblDataAte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAte.Name = "lblDataAte";
            this.lblDataAte.Size = new System.Drawing.Size(26, 13);
            this.lblDataAte.TabIndex = 1;
            this.lblDataAte.Text = "Até:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(8, 70);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(42, 13);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(443, 68);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produto:";
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(686, 11);
            this.lblDataAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(94, 13);
            this.lblDataAtual.TabIndex = 4;
            this.lblDataAtual.Text = "Data: 01/01/2001";
            // 
            // dtpDataDe
            // 
            this.dtpDataDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDe.Location = new System.Drawing.Point(59, 8);
            this.dtpDataDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataDe.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataDe.Name = "dtpDataDe";
            this.dtpDataDe.Size = new System.Drawing.Size(94, 20);
            this.dtpDataDe.TabIndex = 1;
            this.dtpDataDe.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDataAte
            // 
            this.dtpDataAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAte.Location = new System.Drawing.Point(185, 8);
            this.dtpDataAte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataAte.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataAte.Name = "dtpDataAte";
            this.dtpDataAte.Size = new System.Drawing.Size(94, 20);
            this.dtpDataAte.TabIndex = 2;
            this.dtpDataAte.Value = new System.DateTime(2020, 1, 21, 0, 0, 0, 0);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(59, 66);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(339, 20);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.Location = new System.Drawing.Point(493, 66);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProduto.MaxLength = 100;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(239, 20);
            this.txtProduto.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(614, 88);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 22);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(697, 88);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(77, 22);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgDadosPedidos
            // 
            this.dtgDadosPedidos.AllowUserToAddRows = false;
            this.dtgDadosPedidos.AllowUserToDeleteRows = false;
            this.dtgDadosPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedido,
            this.colDataEmissao,
            this.colDataEntrega,
            this.colNomeCliente,
            this.colNomeProduto,
            this.colQuantidade,
            this.colQtdTipos,
            this.colValorUnit,
            this.colValorTotal,
            this.colCodEmpresa});
            this.dtgDadosPedidos.Location = new System.Drawing.Point(11, 116);
            this.dtgDadosPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgDadosPedidos.Name = "dtgDadosPedidos";
            this.dtgDadosPedidos.ReadOnly = true;
            this.dtgDadosPedidos.RowHeadersWidth = 62;
            this.dtgDadosPedidos.RowTemplate.Height = 28;
            this.dtgDadosPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDadosPedidos.Size = new System.Drawing.Size(763, 307);
            this.dtgDadosPedidos.TabIndex = 11;
            this.dtgDadosPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosPedidos_CellDoubleClick_1);
            this.dtgDadosPedidos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDadosPedidos_CellMouseDoubleClick);
            // 
            // colPedido
            // 
            this.colPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPedido.FillWeight = 42.79435F;
            this.colPedido.HeaderText = "Pedido";
            this.colPedido.MinimumWidth = 8;
            this.colPedido.Name = "colPedido";
            this.colPedido.ReadOnly = true;
            this.colPedido.Width = 55;
            // 
            // colDataEmissao
            // 
            this.colDataEmissao.HeaderText = "Emissão";
            this.colDataEmissao.MinimumWidth = 8;
            this.colDataEmissao.Name = "colDataEmissao";
            this.colDataEmissao.ReadOnly = true;
            this.colDataEmissao.Visible = false;
            this.colDataEmissao.Width = 106;
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.FillWeight = 70.94281F;
            this.colDataEntrega.HeaderText = "Data Entrega";
            this.colDataEntrega.MinimumWidth = 8;
            this.colDataEntrega.Name = "colDataEntrega";
            this.colDataEntrega.ReadOnly = true;
            this.colDataEntrega.Width = 95;
            // 
            // colNomeCliente
            // 
            this.colNomeCliente.FillWeight = 150F;
            this.colNomeCliente.HeaderText = "Cliente";
            this.colNomeCliente.MinimumWidth = 8;
            this.colNomeCliente.Name = "colNomeCliente";
            this.colNomeCliente.ReadOnly = true;
            this.colNomeCliente.Width = 140;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.HeaderText = "Produto";
            this.colNomeProduto.MinimumWidth = 8;
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            this.colNomeProduto.Visible = false;
            this.colNomeProduto.Width = 101;
            // 
            // colQuantidade
            // 
            this.colQuantidade.FillWeight = 57.28085F;
            this.colQuantidade.HeaderText = "Qtd";
            this.colQuantidade.MinimumWidth = 8;
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.Width = 50;
            // 
            // colQtdTipos
            // 
            this.colQtdTipos.FillWeight = 106.2537F;
            this.colQtdTipos.HeaderText = "Qtde. Tipos";
            this.colQtdTipos.MinimumWidth = 8;
            this.colQtdTipos.Name = "colQtdTipos";
            this.colQtdTipos.ReadOnly = true;
            this.colQtdTipos.Width = 90;
            // 
            // colValorUnit
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colValorUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.colValorUnit.FillWeight = 110.8096F;
            this.colValorUnit.HeaderText = "Valor Unit";
            this.colValorUnit.MinimumWidth = 8;
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.ReadOnly = true;
            this.colValorUnit.Width = 80;
            // 
            // colValorTotal
            // 
            this.colValorTotal.FillWeight = 130.7119F;
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.MinimumWidth = 8;
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            this.colValorTotal.Width = 85;
            // 
            // colCodEmpresa
            // 
            this.colCodEmpresa.HeaderText = "CodEmpresa";
            this.colCodEmpresa.MinimumWidth = 8;
            this.colCodEmpresa.Name = "colCodEmpresa";
            this.colCodEmpresa.ReadOnly = true;
            this.colCodEmpresa.Visible = false;
            this.colCodEmpresa.Width = 138;
            // 
            // btnBaixarEtapa
            // 
            this.btnBaixarEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaixarEtapa.Location = new System.Drawing.Point(678, 474);
            this.btnBaixarEtapa.Name = "btnBaixarEtapa";
            this.btnBaixarEtapa.Size = new System.Drawing.Size(96, 22);
            this.btnBaixarEtapa.TabIndex = 12;
            this.btnBaixarEtapa.Text = "Baixar Etapa";
            this.btnBaixarEtapa.UseVisualStyleBackColor = true;
            this.btnBaixarEtapa.Click += new System.EventHandler(this.btnBaixarEtapa_Click);
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(59, 38);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPedido.MaxLength = 100;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(178, 20);
            this.txtPedido.TabIndex = 3;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(8, 38);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(43, 13);
            this.lblPedido.TabIndex = 22;
            this.lblPedido.Text = "Pedido:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imgLoad
            // 
            this.imgLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLoad.Image = global::Movtech_Workflow_Pedidos.Properties.Resources.ezgif_com_crop;
            this.imgLoad.Location = new System.Drawing.Point(352, 213);
            this.imgLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.Size = new System.Drawing.Size(67, 67);
            this.imgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLoad.TabIndex = 23;
            this.imgLoad.TabStop = false;
            // 
            // btnBuscarPedidos
            // 
            this.btnBuscarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPedidos.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarPedidos.Image = global::Movtech_Workflow_Pedidos.Properties.Resources.lupa__1_;
            this.btnBuscarPedidos.Location = new System.Drawing.Point(247, 38);
            this.btnBuscarPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPedidos.Name = "btnBuscarPedidos";
            this.btnBuscarPedidos.Size = new System.Drawing.Size(39, 17);
            this.btnBuscarPedidos.TabIndex = 4;
            this.btnBuscarPedidos.UseVisualStyleBackColor = true;
            this.btnBuscarPedidos.Click += new System.EventHandler(this.btnBuscarPedidos_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProduto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarProduto.Image = global::Movtech_Workflow_Pedidos.Properties.Resources.lupa__1_;
            this.btnBuscarProduto.Location = new System.Drawing.Point(735, 66);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(39, 17);
            this.btnBuscarProduto.TabIndex = 8;
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarCliente.Image = global::Movtech_Workflow_Pedidos.Properties.Resources.lupa__1_;
            this.btnBuscarCliente.Location = new System.Drawing.Point(401, 66);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(39, 17);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dtgMostraTotaisPedidos
            // 
            this.dtgMostraTotaisPedidos.AllowUserToAddRows = false;
            this.dtgMostraTotaisPedidos.AllowUserToDeleteRows = false;
            this.dtgMostraTotaisPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMostraTotaisPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostraTotaisPedidos.ColumnHeadersVisible = false;
            this.dtgMostraTotaisPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTotal,
            this.colQuantidadeTotal,
            this.colQuantidadeTiposTotal,
            this.colValorUnitTotal,
            this.colValorTotalTotal});
            this.dtgMostraTotaisPedidos.Location = new System.Drawing.Point(11, 421);
            this.dtgMostraTotaisPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgMostraTotaisPedidos.Name = "dtgMostraTotaisPedidos";
            this.dtgMostraTotaisPedidos.ReadOnly = true;
            this.dtgMostraTotaisPedidos.RowHeadersWidth = 62;
            this.dtgMostraTotaisPedidos.RowTemplate.Height = 28;
            this.dtgMostraTotaisPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMostraTotaisPedidos.Size = new System.Drawing.Size(763, 47);
            this.dtgMostraTotaisPedidos.TabIndex = 24;
            this.dtgMostraTotaisPedidos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dtgMostraTotaisPedidos_Scroll);
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 290;
            // 
            // colQuantidadeTotal
            // 
            this.colQuantidadeTotal.HeaderText = "Qtd";
            this.colQuantidadeTotal.MinimumWidth = 8;
            this.colQuantidadeTotal.Name = "colQuantidadeTotal";
            this.colQuantidadeTotal.ReadOnly = true;
            this.colQuantidadeTotal.Width = 50;
            // 
            // colQuantidadeTiposTotal
            // 
            this.colQuantidadeTiposTotal.HeaderText = "Qtde. Tipos";
            this.colQuantidadeTiposTotal.MinimumWidth = 8;
            this.colQuantidadeTiposTotal.Name = "colQuantidadeTiposTotal";
            this.colQuantidadeTiposTotal.ReadOnly = true;
            this.colQuantidadeTiposTotal.Width = 90;
            // 
            // colValorUnitTotal
            // 
            this.colValorUnitTotal.HeaderText = "Valor Unit";
            this.colValorUnitTotal.MinimumWidth = 8;
            this.colValorUnitTotal.Name = "colValorUnitTotal";
            this.colValorUnitTotal.ReadOnly = true;
            this.colValorUnitTotal.Width = 80;
            // 
            // colValorTotalTotal
            // 
            this.colValorTotalTotal.HeaderText = "Valor Total";
            this.colValorTotalTotal.MinimumWidth = 8;
            this.colValorTotalTotal.Name = "colValorTotalTotal";
            this.colValorTotalTotal.ReadOnly = true;
            this.colValorTotalTotal.Width = 85;
            // 
            // FormWorkflowPedidos
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 487);
            this.Controls.Add(this.dtgMostraTotaisPedidos);
            this.Controls.Add(this.imgLoad);
            this.Controls.Add(this.btnBuscarPedidos);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnBaixarEtapa);
            this.Controls.Add(this.dtgDadosPedidos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.dtpDataAte);
            this.Controls.Add(this.dtpDataDe);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblDataAte);
            this.Controls.Add(this.lblDateDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormWorkflowPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWorkflowPedidos_FormClosing);
            this.Load += new System.EventHandler(this.FormWorkflowPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostraTotaisPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateDe;
        private System.Windows.Forms.Label lblDataAte;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.DateTimePicker dtpDataDe;
        private System.Windows.Forms.DateTimePicker dtpDataAte;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        public System.Windows.Forms.DataGridView dtgDadosPedidos;
        private System.Windows.Forms.Button btnBaixarEtapa;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarPedidos;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox imgLoad;
        private System.Windows.Forms.DataGridView dtgMostraTotaisPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdTipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeTiposTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnitTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotalTotal;
    }
}

