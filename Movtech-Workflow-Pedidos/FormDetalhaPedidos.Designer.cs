﻿namespace Movtech_Workflow_Pedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalhaPedidos));
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblDatePrevEntrega = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.dtgDadosDetalhados = new System.Windows.Forms.DataGridView();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            this.dtgMostraTotais = new System.Windows.Forms.DataGridView();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnitTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotalTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosDetalhados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostraTotais)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(12, 51);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(62, 20);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido:";
            // 
            // lblDatePrevEntrega
            // 
            this.lblDatePrevEntrega.AutoSize = true;
            this.lblDatePrevEntrega.Location = new System.Drawing.Point(300, 17);
            this.lblDatePrevEntrega.Name = "lblDatePrevEntrega";
            this.lblDatePrevEntrega.Size = new System.Drawing.Size(154, 20);
            this.lblDatePrevEntrega.TabIndex = 1;
            this.lblDatePrevEntrega.Text = "Previsão de entrega:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(252, 51);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(62, 20);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(113, 48);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(133, 26);
            this.txtPedido.TabIndex = 3;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(320, 48);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(471, 26);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Enabled = false;
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(460, 12);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(151, 26);
            this.dtpDataEntrega.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(648, 499);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(145, 35);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(12, 17);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(125, 20);
            this.lblDataPedido.TabIndex = 9;
            this.lblDataPedido.Text = "Início do Pedido:";
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
            this.dtgDadosDetalhados.Location = new System.Drawing.Point(16, 91);
            this.dtgDadosDetalhados.Name = "dtgDadosDetalhados";
            this.dtgDadosDetalhados.ReadOnly = true;
            this.dtgDadosDetalhados.RowHeadersVisible = false;
            this.dtgDadosDetalhados.RowHeadersWidth = 62;
            this.dtgDadosDetalhados.RowTemplate.Height = 28;
            this.dtgDadosDetalhados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosDetalhados.Size = new System.Drawing.Size(777, 360);
            this.dtgDadosDetalhados.TabIndex = 5;
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
            this.dtpDataPedido.Location = new System.Drawing.Point(143, 12);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(151, 26);
            this.dtpDataPedido.TabIndex = 1;
            // 
            // dtgMostraTotais
            // 
            this.dtgMostraTotais.AllowUserToAddRows = false;
            this.dtgMostraTotais.AllowUserToDeleteRows = false;
            this.dtgMostraTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMostraTotais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMostraTotais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostraTotais.ColumnHeadersVisible = false;
            this.dtgMostraTotais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTotal,
            this.colQtdeTotal,
            this.colValorUnitTotal,
            this.colValorTotalTotal});
            this.dtgMostraTotais.Location = new System.Drawing.Point(16, 448);
            this.dtgMostraTotais.MultiSelect = false;
            this.dtgMostraTotais.Name = "dtgMostraTotais";
            this.dtgMostraTotais.ReadOnly = true;
            this.dtgMostraTotais.RowHeadersVisible = false;
            this.dtgMostraTotais.RowHeadersWidth = 62;
            this.dtgMostraTotais.RowTemplate.Height = 28;
            this.dtgMostraTotais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMostraTotais.Size = new System.Drawing.Size(777, 45);
            this.dtgMostraTotais.TabIndex = 6;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colQtdeTotal
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtdeTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.colQtdeTotal.FillWeight = 30F;
            this.colQtdeTotal.HeaderText = "Qtde";
            this.colQtdeTotal.MinimumWidth = 8;
            this.colQtdeTotal.Name = "colQtdeTotal";
            this.colQtdeTotal.ReadOnly = true;
            // 
            // colValorUnitTotal
            // 
            this.colValorUnitTotal.FillWeight = 65F;
            this.colValorUnitTotal.HeaderText = "Valor Unitário";
            this.colValorUnitTotal.MinimumWidth = 8;
            this.colValorUnitTotal.Name = "colValorUnitTotal";
            this.colValorUnitTotal.ReadOnly = true;
            // 
            // colValorTotalTotal
            // 
            this.colValorTotalTotal.FillWeight = 60F;
            this.colValorTotalTotal.HeaderText = "Valor Total";
            this.colValorTotalTotal.MinimumWidth = 8;
            this.colValorTotalTotal.Name = "colValorTotalTotal";
            this.colValorTotalTotal.ReadOnly = true;
            // 
            // FormDetalhaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(802, 544);
            this.Controls.Add(this.dtgMostraTotais);
            this.Controls.Add(this.dtgDadosDetalhados);
            this.Controls.Add(this.dtpDataPedido);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblDatePrevEntrega);
            this.Controls.Add(this.lblPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetalhaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Pedido";
            this.Load += new System.EventHandler(this.FormDetalhaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosDetalhados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostraTotais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblDatePrevEntrega;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.DataGridView dtgDadosDetalhados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DateTimePicker dtpDataPedido;
        private System.Windows.Forms.DataGridView dtgMostraTotais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnitTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotalTotal;
    }
}