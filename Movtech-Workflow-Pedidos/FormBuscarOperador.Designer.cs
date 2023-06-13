namespace Movtech_Workflow_Pedidos
{
    partial class FormBuscarOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarOperador));
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgDadosOperador = new System.Windows.Forms.DataGridView();
            this.colCodOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodOperador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosOperador)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeOperador.Location = new System.Drawing.Point(98, 12);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.Size = new System.Drawing.Size(613, 26);
            this.txtNomeOperador.TabIndex = 3;
            this.txtNomeOperador.TextChanged += new System.EventHandler(this.txtNomeOperador_TextChanged);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(12, 15);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(80, 20);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.Text = "Operador:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(595, 46);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 34);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgDadosOperador
            // 
            this.dtgDadosOperador.AllowUserToAddRows = false;
            this.dtgDadosOperador.AllowUserToDeleteRows = false;
            this.dtgDadosOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosOperador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodOperador,
            this.colNomeOperador});
            this.dtgDadosOperador.Location = new System.Drawing.Point(16, 88);
            this.dtgDadosOperador.Name = "dtgDadosOperador";
            this.dtgDadosOperador.ReadOnly = true;
            this.dtgDadosOperador.RowHeadersWidth = 62;
            this.dtgDadosOperador.RowTemplate.Height = 28;
            this.dtgDadosOperador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosOperador.Size = new System.Drawing.Size(695, 309);
            this.dtgDadosOperador.TabIndex = 16;
            this.dtgDadosOperador.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosOperador_CellDoubleClick);
            // 
            // colCodOperador
            // 
            this.colCodOperador.FillWeight = 15F;
            this.colCodOperador.HeaderText = "Código";
            this.colCodOperador.MinimumWidth = 8;
            this.colCodOperador.Name = "colCodOperador";
            this.colCodOperador.ReadOnly = true;
            // 
            // colNomeOperador
            // 
            this.colNomeOperador.HeaderText = "Operador";
            this.colNomeOperador.MinimumWidth = 8;
            this.colNomeOperador.Name = "colNomeOperador";
            this.colNomeOperador.ReadOnly = true;
            // 
            // txtCodOperador
            // 
            this.txtCodOperador.Enabled = false;
            this.txtCodOperador.Location = new System.Drawing.Point(0, 386);
            this.txtCodOperador.Name = "txtCodOperador";
            this.txtCodOperador.ReadOnly = true;
            this.txtCodOperador.Size = new System.Drawing.Size(10, 26);
            this.txtCodOperador.TabIndex = 17;
            this.txtCodOperador.Visible = false;
            // 
            // FormBuscarOperador
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 409);
            this.Controls.Add(this.txtCodOperador);
            this.Controls.Add(this.dtgDadosOperador);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtNomeOperador);
            this.Controls.Add(this.lblOperador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Operador";
            this.Load += new System.EventHandler(this.FormBuscarOperador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosOperador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgDadosOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeOperador;
        private System.Windows.Forms.TextBox txtCodOperador;
    }
}