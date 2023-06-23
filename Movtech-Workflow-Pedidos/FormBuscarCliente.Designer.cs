namespace Movtech_Workflow_Pedidos
{
    partial class FormBuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarCliente));
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtgDadosCliente = new System.Windows.Forms.DataGridView();
            this.colCodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCliente.Location = new System.Drawing.Point(80, 12);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(613, 26);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // dtgDadosCliente
            // 
            this.dtgDadosCliente.AllowUserToAddRows = false;
            this.dtgDadosCliente.AllowUserToDeleteRows = false;
            this.dtgDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodCliente,
            this.colNomeCliente});
            this.dtgDadosCliente.Location = new System.Drawing.Point(16, 88);
            this.dtgDadosCliente.Name = "dtgDadosCliente";
            this.dtgDadosCliente.ReadOnly = true;
            this.dtgDadosCliente.RowHeadersVisible = false;
            this.dtgDadosCliente.RowHeadersWidth = 62;
            this.dtgDadosCliente.RowTemplate.Height = 28;
            this.dtgDadosCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosCliente.Size = new System.Drawing.Size(677, 309);
            this.dtgDadosCliente.TabIndex = 3;
            this.dtgDadosCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosCliente_CellDoubleClick);
            // 
            // colCodCliente
            // 
            this.colCodCliente.FillWeight = 15F;
            this.colCodCliente.HeaderText = "Código";
            this.colCodCliente.MinimumWidth = 8;
            this.colCodCliente.Name = "colCodCliente";
            this.colCodCliente.ReadOnly = true;
            // 
            // colNomeCliente
            // 
            this.colNomeCliente.HeaderText = "Cliente";
            this.colNomeCliente.MinimumWidth = 8;
            this.colNomeCliente.Name = "colNomeCliente";
            this.colNomeCliente.ReadOnly = true;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(0, 385);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(10, 26);
            this.txtCodCliente.TabIndex = 0;
            this.txtCodCliente.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(575, 46);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 34);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FormBuscarCliente
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 409);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.dtgDadosCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DataGridView dtgDadosCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCliente;
        private System.Windows.Forms.Button btnConsultar;
    }
}