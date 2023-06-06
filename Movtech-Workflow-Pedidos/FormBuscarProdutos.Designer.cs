namespace Movtech_Workflow_Pedidos
{
    partial class FormBuscarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarProdutos));
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgDadosProduto = new System.Windows.Forms.DataGridView();
            this.colCodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.Location = new System.Drawing.Point(80, 12);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(613, 26);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(12, 15);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(69, 20);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(577, 46);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 34);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgDadosProduto
            // 
            this.dtgDadosProduto.AllowUserToAddRows = false;
            this.dtgDadosProduto.AllowUserToDeleteRows = false;
            this.dtgDadosProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodProduto,
            this.colNomeProduto});
            this.dtgDadosProduto.Location = new System.Drawing.Point(16, 88);
            this.dtgDadosProduto.Name = "dtgDadosProduto";
            this.dtgDadosProduto.ReadOnly = true;
            this.dtgDadosProduto.RowHeadersWidth = 62;
            this.dtgDadosProduto.RowTemplate.Height = 28;
            this.dtgDadosProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosProduto.Size = new System.Drawing.Size(677, 309);
            this.dtgDadosProduto.TabIndex = 16;
            this.dtgDadosProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosProduto_CellDoubleClick);
            // 
            // colCodProduto
            // 
            this.colCodProduto.FillWeight = 15F;
            this.colCodProduto.HeaderText = "Código";
            this.colCodProduto.MinimumWidth = 8;
            this.colCodProduto.Name = "colCodProduto";
            this.colCodProduto.ReadOnly = true;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.HeaderText = "Cliente";
            this.colNomeProduto.MinimumWidth = 8;
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(0, 383);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.ReadOnly = true;
            this.txtCodProduto.Size = new System.Drawing.Size(10, 26);
            this.txtCodProduto.TabIndex = 17;
            this.txtCodProduto.Visible = false;
            // 
            // FormBuscarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 403);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.dtgDadosProduto);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Produtos";
            this.Load += new System.EventHandler(this.FormBuscarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgDadosProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
    }
}