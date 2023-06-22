namespace Movtech_Workflow_Pedidos
{
    partial class FormBaixaEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaixaEtapa));
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblDataDaBaixa = new System.Windows.Forms.Label();
            this.lblNomeOperador = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.dtpDataDaBaixa = new System.Windows.Forms.DateTimePicker();
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBaixarEtapa = new System.Windows.Forms.Button();
            this.lblNomeEtapa = new System.Windows.Forms.Label();
            this.txtNomeEtapa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(12, 15);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(77, 20);
            this.lblNomeEmpresa.TabIndex = 0;
            this.lblNomeEmpresa.Text = "Empresa:";
            // 
            // lblPedido
            // 
            this.lblPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(508, 15);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(62, 20);
            this.lblPedido.TabIndex = 1;
            this.lblPedido.Text = "Pedido:";
            // 
            // lblDataDaBaixa
            // 
            this.lblDataDaBaixa.AutoSize = true;
            this.lblDataDaBaixa.Location = new System.Drawing.Point(12, 62);
            this.lblDataDaBaixa.Name = "lblDataDaBaixa";
            this.lblDataDaBaixa.Size = new System.Drawing.Size(111, 20);
            this.lblDataDaBaixa.TabIndex = 2;
            this.lblDataDaBaixa.Text = "Data da baixa:";
            // 
            // lblNomeOperador
            // 
            this.lblNomeOperador.AutoSize = true;
            this.lblNomeOperador.Location = new System.Drawing.Point(278, 62);
            this.lblNomeOperador.Name = "lblNomeOperador";
            this.lblNomeOperador.Size = new System.Drawing.Size(80, 20);
            this.lblNomeOperador.TabIndex = 3;
            this.lblNomeOperador.Text = "Operador:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(129, 12);
            this.txtNomeEmpresa.MaxLength = 50;
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.ReadOnly = true;
            this.txtNomeEmpresa.Size = new System.Drawing.Size(373, 26);
            this.txtNomeEmpresa.TabIndex = 5;
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedido.Location = new System.Drawing.Point(576, 12);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(154, 26);
            this.txtPedido.TabIndex = 6;
            // 
            // dtpDataDaBaixa
            // 
            this.dtpDataDaBaixa.Enabled = false;
            this.dtpDataDaBaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDaBaixa.Location = new System.Drawing.Point(129, 57);
            this.dtpDataDaBaixa.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataDaBaixa.Name = "dtpDataDaBaixa";
            this.dtpDataDaBaixa.Size = new System.Drawing.Size(144, 26);
            this.dtpDataDaBaixa.TabIndex = 8;
            this.dtpDataDaBaixa.Value = new System.DateTime(2020, 2, 5, 0, 0, 0, 0);
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeOperador.Location = new System.Drawing.Point(364, 58);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.ReadOnly = true;
            this.txtNomeOperador.Size = new System.Drawing.Size(366, 26);
            this.txtNomeOperador.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(489, 92);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 34);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBaixarEtapa
            // 
            this.btnBaixarEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaixarEtapa.Location = new System.Drawing.Point(614, 92);
            this.btnBaixarEtapa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaixarEtapa.Name = "btnBaixarEtapa";
            this.btnBaixarEtapa.Size = new System.Drawing.Size(116, 34);
            this.btnBaixarEtapa.TabIndex = 27;
            this.btnBaixarEtapa.Text = "Baixar Etapa";
            this.btnBaixarEtapa.UseVisualStyleBackColor = true;
            this.btnBaixarEtapa.Click += new System.EventHandler(this.btnBaixarEtapa_Click);
            // 
            // lblNomeEtapa
            // 
            this.lblNomeEtapa.AutoSize = true;
            this.lblNomeEtapa.Location = new System.Drawing.Point(12, 99);
            this.lblNomeEtapa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEtapa.Name = "lblNomeEtapa";
            this.lblNomeEtapa.Size = new System.Drawing.Size(56, 20);
            this.lblNomeEtapa.TabIndex = 28;
            this.lblNomeEtapa.Text = "Etapa:";
            // 
            // txtNomeEtapa
            // 
            this.txtNomeEtapa.Location = new System.Drawing.Point(129, 96);
            this.txtNomeEtapa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeEtapa.Name = "txtNomeEtapa";
            this.txtNomeEtapa.ReadOnly = true;
            this.txtNomeEtapa.Size = new System.Drawing.Size(148, 26);
            this.txtNomeEtapa.TabIndex = 29;
            // 
            // FormBaixaEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 138);
            this.Controls.Add(this.txtNomeEtapa);
            this.Controls.Add(this.lblNomeEtapa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBaixarEtapa);
            this.Controls.Add(this.txtNomeOperador);
            this.Controls.Add(this.dtpDataDaBaixa);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.lblNomeOperador);
            this.Controls.Add(this.lblDataDaBaixa);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBaixaEtapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixar Etapa";
            this.Load += new System.EventHandler(this.FormBaixaEtapa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblDataDaBaixa;
        private System.Windows.Forms.Label lblNomeOperador;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.DateTimePicker dtpDataDaBaixa;
        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBaixarEtapa;
        private System.Windows.Forms.Label lblNomeEtapa;
        private System.Windows.Forms.TextBox txtNomeEtapa;
    }
}