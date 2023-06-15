﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public partial class FormDetalhaPedidos : Form
    {
        public FormDetalhaPedidos(string Pedido, String NomeCliente, String DtEmissao, String DtEntrega, String Qtd, String ValorUnit, String ValorTotal)
        {
            InitializeComponent();
            txtPedido.Text = Pedido;
            txtNomeCliente.Text = NomeCliente;
            dtpDataEntrega.Text = DtEntrega;
            txtQuantidade.Text = Qtd;
            txtValorUnitario.Text = Convert.ToDouble(ValorUnit).ToString("C2");
            txtValorTotal.Text = Convert.ToDouble(ValorTotal).ToString("C2");
            dtpDataPedido.Text = DtEmissao;
        }

        private void FormDetalhaPedidos_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeTable()
        {
            dtgDadosDetalhados.Rows.Clear();
            dtgDadosDetalhados.Columns["colValorTotal"].DefaultCellStyle.Format = "C2";
            dtgDadosDetalhados.Columns["colValorUnit"].DefaultCellStyle.Format = "C2";
            dtgDadosDetalhados.Columns["colQuantidadeProduto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDadosDetalhados.Columns["colValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDadosDetalhados.Columns["colValorUnit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                DetalhesPedidoDAO dao = new DetalhesPedidoDAO(connection);
                List<WorkflowPedidosModel> detalhes = dao.GetProdutos(new WorkflowPedidosModel()
                {
                    Documento = txtPedido.Text,
                    NomeCliente = txtNomeCliente.Text
                });
                foreach (WorkflowPedidosModel detalhe in detalhes)
                {
                    DataGridViewRow row = dtgDadosDetalhados.Rows[dtgDadosDetalhados.Rows.Add()];
                    row.Cells[colNomeProduto.Index].Value = detalhe.NomeProduto;
                    row.Cells[colQuantidadeProduto.Index].Value = detalhe.Quantidade;
                    row.Cells[colValorUnit.Index].Value = detalhe.ValorUnitario;
                    row.Cells[colValorTotal.Index].Value = detalhe.ValorTotal;
                }
            }
        }
    }
}
