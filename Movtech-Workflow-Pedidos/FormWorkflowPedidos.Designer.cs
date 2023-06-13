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
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaixarEtapa = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnBuscarPedidos = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosPedidos)).BeginInit();
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
            this.lblNomeCliente.Location = new System.Drawing.Point(8, 37);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(42, 13);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(443, 35);
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
            this.lblDataAtual.Location = new System.Drawing.Point(815, 6);
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
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(59, 33);
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
            this.txtProduto.Location = new System.Drawing.Point(493, 33);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProduto.MaxLength = 100;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(368, 20);
            this.txtProduto.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpar.Location = new System.Drawing.Point(743, 55);
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
            this.btnConsultar.Location = new System.Drawing.Point(825, 55);
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
            this.dtgDadosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDadosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedido,
            this.colDataEntrega,
            this.colNomeCliente,
            this.colNomeProduto,
            this.colQuantidade,
            this.colValorUnit,
            this.colValorTotal,
            this.colCodEmpresa});
            this.dtgDadosPedidos.Location = new System.Drawing.Point(11, 83);
            this.dtgDadosPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgDadosPedidos.Name = "dtgDadosPedidos";
            this.dtgDadosPedidos.ReadOnly = true;
            this.dtgDadosPedidos.RowHeadersWidth = 62;
            this.dtgDadosPedidos.RowTemplate.Height = 28;
            this.dtgDadosPedidos.Size = new System.Drawing.Size(892, 337);
            this.dtgDadosPedidos.TabIndex = 11;
            this.dtgDadosPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosPedidos_CellDoubleClick_1);
            this.dtgDadosPedidos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDadosPedidos_CellMouseDoubleClick);
            // 
            // colPedido
            // 
            this.colPedido.FillWeight = 40F;
            this.colPedido.HeaderText = "Pedido";
            this.colPedido.MinimumWidth = 8;
            this.colPedido.Name = "colPedido";
            this.colPedido.ReadOnly = true;
            this.colPedido.Width = 65;
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.HeaderText = "Data Entrega";
            this.colDataEntrega.MinimumWidth = 8;
            this.colDataEntrega.Name = "colDataEntrega";
            this.colDataEntrega.ReadOnly = true;
            this.colDataEntrega.Width = 95;
            // 
            // colNomeCliente
            // 
            this.colNomeCliente.HeaderText = "Cliente";
            this.colNomeCliente.MinimumWidth = 8;
            this.colNomeCliente.Name = "colNomeCliente";
            this.colNomeCliente.ReadOnly = true;
            this.colNomeCliente.Width = 64;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.HeaderText = "Produto";
            this.colNomeProduto.MinimumWidth = 8;
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            this.colNomeProduto.Width = 69;
            // 
            // colQuantidade
            // 
            this.colQuantidade.FillWeight = 40F;
            this.colQuantidade.HeaderText = "Qtd";
            this.colQuantidade.MinimumWidth = 8;
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.Width = 49;
            // 
            // colValorUnit
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colValorUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.colValorUnit.HeaderText = "Valor Unit";
            this.colValorUnit.MinimumWidth = 8;
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.ReadOnly = true;
            this.colValorUnit.Width = 78;
            // 
            // colValorTotal
            // 
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.MinimumWidth = 8;
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            this.colValorTotal.Width = 83;
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
            this.btnBaixarEtapa.Location = new System.Drawing.Point(807, 425);
            this.btnBaixarEtapa.Name = "btnBaixarEtapa";
            this.btnBaixarEtapa.Size = new System.Drawing.Size(96, 22);
            this.btnBaixarEtapa.TabIndex = 12;
            this.btnBaixarEtapa.Text = "Baixar Etapa";
            this.btnBaixarEtapa.UseVisualStyleBackColor = true;
            this.btnBaixarEtapa.Click += new System.EventHandler(this.btnBaixarEtapa_Click);
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedido.Location = new System.Drawing.Point(327, 9);
            this.txtPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPedido.MaxLength = 100;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(113, 20);
            this.txtPedido.TabIndex = 3;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(282, 11);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(43, 13);
            this.lblPedido.TabIndex = 22;
            this.lblPedido.Text = "Pedido:";
            // 
            // btnBuscarPedidos
            // 
            this.btnBuscarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPedidos.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarPedidos.Image = global::Movtech_Workflow_Pedidos.Properties.Resources.lupa__1_;
            this.btnBuscarPedidos.Location = new System.Drawing.Point(446, 9);
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
            this.btnBuscarProduto.Location = new System.Drawing.Point(864, 33);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(401, 33);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(39, 17);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // FormWorkflowPedidos
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLimpar;
            this.ClientSize = new System.Drawing.Size(911, 451);
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
            this.Text = "WorkFlow - Pedidos";
            this.Load += new System.EventHandler(this.FormWorkflowPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosPedidos)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEmpresa;
    }
}

