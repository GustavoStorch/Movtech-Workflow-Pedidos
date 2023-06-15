namespace Movtech_Workflow_Pedidos
{
    partial class FormDetalhaPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalhaPedidos));
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblDatePrevEntrega = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.dtgDadosDetalhados = new System.Windows.Forms.DataGridView();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosDetalhados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(12, 54);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(62, 20);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido:";
            // 
            // lblDatePrevEntrega
            // 
            this.lblDatePrevEntrega.AutoSize = true;
            this.lblDatePrevEntrega.Location = new System.Drawing.Point(298, 18);
            this.lblDatePrevEntrega.Name = "lblDatePrevEntrega";
            this.lblDatePrevEntrega.Size = new System.Drawing.Size(154, 20);
            this.lblDatePrevEntrega.TabIndex = 1;
            this.lblDatePrevEntrega.Text = "Previsão de entrega:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(252, 54);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(62, 20);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 100);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(219, 100);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(83, 20);
            this.lblValorUnitario.TabIndex = 5;
            this.lblValorUnitario.Text = "Valor Unit:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(465, 100);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(89, 20);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(113, 51);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(133, 26);
            this.txtPedido.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(353, 51);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(360, 26);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(113, 97);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(306, 97);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.Size = new System.Drawing.Size(153, 26);
            this.txtValorUnitario.TabIndex = 6;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Location = new System.Drawing.Point(560, 97);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(153, 26);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Enabled = false;
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(458, 15);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(151, 26);
            this.dtpDataEntrega.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(568, 457);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(145, 35);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(12, 18);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(123, 20);
            this.lblDataPedido.TabIndex = 9;
            this.lblDataPedido.Text = "Data do Pedido:";
            // 
            // dtgDadosDetalhados
            // 
            this.dtgDadosDetalhados.AllowUserToAddRows = false;
            this.dtgDadosDetalhados.AllowUserToDeleteRows = false;
            this.dtgDadosDetalhados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosDetalhados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosDetalhados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosDetalhados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeProduto,
            this.colQuantidadeProduto,
            this.colValorUnit,
            this.colValorTotal});
            this.dtgDadosDetalhados.Location = new System.Drawing.Point(12, 129);
            this.dtgDadosDetalhados.Name = "dtgDadosDetalhados";
            this.dtgDadosDetalhados.ReadOnly = true;
            this.dtgDadosDetalhados.RowHeadersWidth = 62;
            this.dtgDadosDetalhados.RowTemplate.Height = 28;
            this.dtgDadosDetalhados.Size = new System.Drawing.Size(701, 322);
            this.dtgDadosDetalhados.TabIndex = 11;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.HeaderText = "Produto";
            this.colNomeProduto.MinimumWidth = 8;
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            // 
            // colQuantidadeProduto
            // 
            this.colQuantidadeProduto.FillWeight = 30F;
            this.colQuantidadeProduto.HeaderText = "Qtde";
            this.colQuantidadeProduto.MinimumWidth = 8;
            this.colQuantidadeProduto.Name = "colQuantidadeProduto";
            this.colQuantidadeProduto.ReadOnly = true;
            // 
            // colValorUnit
            // 
            this.colValorUnit.FillWeight = 65F;
            this.colValorUnit.HeaderText = "Valor Unitário";
            this.colValorUnit.MinimumWidth = 8;
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.ReadOnly = true;
            // 
            // colValorTotal
            // 
            this.colValorTotal.FillWeight = 60F;
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.MinimumWidth = 8;
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.Enabled = false;
            this.dtpDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPedido.Location = new System.Drawing.Point(141, 13);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(151, 26);
            this.dtpDataPedido.TabIndex = 10;
            // 
            // FormDetalhaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(724, 504);
            this.Controls.Add(this.dtgDadosDetalhados);
            this.Controls.Add(this.dtpDataPedido);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblDatePrevEntrega);
            this.Controls.Add(this.lblPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetalhaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Pedido";
            this.Load += new System.EventHandler(this.FormDetalhaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosDetalhados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblDatePrevEntrega;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.DataGridView dtgDadosDetalhados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DateTimePicker dtpDataPedido;
    }
}