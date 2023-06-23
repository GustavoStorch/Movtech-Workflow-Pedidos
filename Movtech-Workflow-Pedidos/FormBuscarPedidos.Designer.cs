namespace Movtech_Workflow_Pedidos
{
    partial class FormBuscarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarPedidos));
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgDadosPedidos = new System.Windows.Forms.DataGridView();
            this.colPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedido.Location = new System.Drawing.Point(80, 12);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(312, 26);
            this.txtPedido.TabIndex = 1;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(12, 15);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(62, 20);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Pedido:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(276, 46);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 34);
            this.btnConsultar.TabIndex = 2;
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
            this.dtgDadosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPedido});
            this.dtgDadosPedidos.Location = new System.Drawing.Point(16, 88);
            this.dtgDadosPedidos.Name = "dtgDadosPedidos";
            this.dtgDadosPedidos.ReadOnly = true;
            this.dtgDadosPedidos.RowHeadersVisible = false;
            this.dtgDadosPedidos.RowHeadersWidth = 62;
            this.dtgDadosPedidos.RowTemplate.Height = 28;
            this.dtgDadosPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosPedidos.Size = new System.Drawing.Size(376, 471);
            this.dtgDadosPedidos.TabIndex = 3;
            this.dtgDadosPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosPedidos_CellDoubleClick);
            // 
            // colPedido
            // 
            this.colPedido.HeaderText = "Pedido";
            this.colPedido.MinimumWidth = 8;
            this.colPedido.Name = "colPedido";
            this.colPedido.ReadOnly = true;
            // 
            // FormBuscarPedidos
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 571);
            this.Controls.Add(this.dtgDadosPedidos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pedidos";
            this.Load += new System.EventHandler(this.FormBuscarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgDadosPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedido;
    }
}