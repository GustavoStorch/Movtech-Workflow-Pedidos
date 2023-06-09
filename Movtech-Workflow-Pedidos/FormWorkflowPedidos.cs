﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public partial class FormWorkflowPedidos : Form
    {
        public DateTime dataSimulacao { get; set; }

        public string pedido { get; set; }

        public string empresa { get; set; }

        public string nomeProduto { get; set; }

        public string dtEntrega { get; set; }

        public string dtEmissao { get; set; }

        public string qtd { get; set; }

        public string valorUnit { get; set; }

        public string valorTotal { get; set; }

        public string nomeCliente { get ; set; }

        public string nomeUsuario { get; set; }

        public FormWorkflowPedidos(string NomeUsuario, DateTime DataSimulacao)
        {
            InitializeComponent();
            nomeUsuario = NomeUsuario;
            dataSimulacao = DataSimulacao;
        }

        private void FormWorkflowPedidos_Load(object sender, EventArgs e)
        {
            lblDataAtual.Text = "Data: " + dataSimulacao.ToShortDateString();
            InitializaColumnsTable();
            btnBaixarEtapa.Enabled = false;
            imgLoad.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLoad.Visible = false;
            imgLoad.Enabled = false;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            CarregaFormBuscarCliente();
        }

        public void CarregaFormBuscarCliente()
        {
            FormBuscarCliente formBuscarCliente = new FormBuscarCliente();
            formBuscarCliente.ShowDialog();
            txtNomeCliente.Text = formBuscarCliente.nomeCliente;
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            CarregaFormBuscarProduto();
        }

        public void CarregaFormBuscarProduto()
        {
            FormBuscarProdutos formBuscarProdutos = new FormBuscarProdutos();
            formBuscarProdutos.ShowDialog();
            txtProduto.Text = formBuscarProdutos.nomeProduto;
        }

        private void btnBuscarPedidos_Click(object sender, EventArgs e)
        {
            CarregaFormPedidos();
        }

        public void CarregaFormPedidos()
        {
            FormBuscarPedidos formBuscarPedidos = new FormBuscarPedidos();
            formBuscarPedidos.ShowDialog();
            txtPedido.Text = formBuscarPedidos.documento;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            dtpDataDe.Text = "2020-01-01";
            dtpDataAte.Text = "2020-01-21";
            txtNomeCliente.Text = string.Empty;
            txtPedido.Text = string.Empty;
            txtProduto.Text = string.Empty;
            dtgDadosPedidos.Rows.Clear();
            dtgMostraTotaisPedidos.Rows.Clear();
            btnBaixarEtapa.Enabled = false;
        }

        public void InitializeTable(DataGridView dataGridView)
        {
            int totalQuantidade = 0;
            int totalQuantidadeTipos = 0;
            double totalValorUnitario = 0;
            double totalValorTotal = 0;

            dataGridView.Invoke((MethodInvoker)delegate
            {
                dataGridView.Rows.Clear();
                dtgMostraTotaisPedidos.Rows.Clear();
                dataGridView.Columns["colDataEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.Columns["colValorTotal"].DefaultCellStyle.Format = "C2";
                dataGridView.Columns["colValorUnit"].DefaultCellStyle.Format = "C2";
                dataGridView.Columns["colQuantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["colValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["colValorUnit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["colQtdTipos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgMostraTotaisPedidos.Columns["colValorUnitTotal"].DefaultCellStyle.Format = "C2";
                dtgMostraTotaisPedidos.Columns["colValorTotalTotal"].DefaultCellStyle.Format = "C2";
                dtgMostraTotaisPedidos.Columns["colQuantidadeTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgMostraTotaisPedidos.Columns["colQuantidadeTiposTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgMostraTotaisPedidos.Columns["colValorUnitTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgMostraTotaisPedidos.Columns["colValorTotalTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            });
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                WorkflowDAO dao = new WorkflowDAO(connection);
                BaixaEtapaDAO baixadao = new BaixaEtapaDAO(connection);
                List<WorkflowPedidosModel> pedidos = dao.GetPedidos(new WorkflowPedidosModel()
                {
                    NomeCliente = txtNomeCliente.Text,
                    NomeProduto = txtProduto.Text,
                    Documento = txtPedido.Text,
                    DataDe = dtpDataDe.Text,
                    DataAte = dtpDataAte.Text
                });

                int LeadTime = dao.RecuperaLeadTime();

                foreach (WorkflowPedidosModel pedido in pedidos)
                {
                    dataGridView.Invoke((MethodInvoker)delegate
                    {
                        DataGridViewRow row = dataGridView.Rows[dataGridView.Rows.Add()];
                        row.Cells[colNomeCliente.Index].Value = pedido.NomeCliente;
                        row.Cells[colNomeProduto.Index].Value = pedido.NomeProduto;
                        row.Cells[colPedido.Index].Value = pedido.Documento;
                        row.Cells[colQuantidade.Index].Value = pedido.Quantidade;
                        row.Cells[colValorTotal.Index].Value = pedido.ValorTotal;
                        row.Cells[colValorUnit.Index].Value = pedido.ValorTotal / pedido.Quantidade;
                        row.Cells[colDataEntrega.Index].Value = pedido.DataEmissao.AddDays(LeadTime);
                        row.Cells[colCodEmpresa.Index].Value = pedido.CodEmpresa;
                        row.Cells[colDataEmissao.Index].Value = pedido.DataEmissao;
                        row.Cells[colQtdTipos.Index].Value = pedido.QuantidadeTipoProduto;

                        totalQuantidade += pedido.Quantidade;
                        totalQuantidadeTipos += pedido.QuantidadeTipoProduto;
                        totalValorUnitario += pedido.ValorUnitario;
                        totalValorTotal += pedido.ValorTotal;
                    });
                }
                dataGridView.Invoke((MethodInvoker)delegate
                {
                    dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    dataGridView.Columns[colValorTotal.Index].Frozen = true;
                });

                dtgMostraTotaisPedidos.Invoke((MethodInvoker)delegate
                {
                    if (totalQuantidade != 0)
                    {
                        totalValorUnitario = totalValorTotal / totalQuantidade;
                    } else
                    {
                        totalValorUnitario = totalValorTotal / 1;
                    }
                    
                    DataGridViewRow row2 = dtgMostraTotaisPedidos.Rows[dtgMostraTotaisPedidos.Rows.Add()];
                    row2.Cells[colTotal.Index].Value = "Total";
                    row2.Cells[colQuantidadeTotal.Index].Value = totalQuantidade;
                    row2.Cells[colQuantidadeTiposTotal.Index].Value = totalQuantidadeTipos;
                    row2.Cells[colValorUnitTotal.Index].Value = Convert.ToDouble(totalValorUnitario);
                    row2.Cells[colValorTotalTotal.Index].Value = totalValorTotal;

                    dtgMostraTotaisPedidos.ColumnHeadersVisible = false;
                    dtgMostraTotaisPedidos.Columns[colValorTotalTotal.Index].Frozen = true;
                    dtgMostraTotaisPedidos.ClearSelection();
                    dtgDadosPedidos.ClearSelection();
                });
            }
        }

        private void InitializaColumnsTable()
        {
            string query = "SELECT etapas FROM MvtCadEtapas ORDER BY seqOrdem";
            List<string> etapas = new List<string>();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string etapa = reader.GetString(0);
                    etapas.Add(etapa);
                }
            }

            foreach (string etapa in etapas)
            {
                dtgDadosPedidos.Columns.Add(etapa, etapa);
                dtgMostraTotaisPedidos.Columns.Add(etapa, etapa);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            imgLoad.Enabled = true;
            imgLoad.Visible = true;
            DesabilipaCampos();
            consultaWorker.RunWorkerAsync();
        }

        private void btnBaixarEtapa_Click(object sender, EventArgs e)
        {
            if (dtgDadosPedidos.CurrentCell != null)
            {
                DataGridViewCell selectedCell = dtgDadosPedidos.CurrentCell;

                if (selectedCell.Value == null)
                {
                    DataGridViewCell selectedCellAnterior = selectedCell.OwningRow.Cells[selectedCell.ColumnIndex - 1];
                    if (selectedCellAnterior.Value == null)
                    {
                        MessageBox.Show("A etapa anterior ainda não foi finalizada!", "Ops, algo inesperado aconteceu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        CarregaFormBaixaEtapa();
                    }
                }
                else
                {
                    MessageBox.Show("Célula inválida, por favor selecione uma etapa!", "Ops, algo inesperado aconteceu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dtgDadosPedidos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    pedido = dtgDadosPedidos.Rows[e.RowIndex].Cells[colPedido.Index].Value + "";
                    nomeProduto = dtgDadosPedidos.Rows[e.RowIndex].Cells[colNomeProduto.Index].Value + "";
                    nomeCliente = dtgDadosPedidos.Rows[e.RowIndex].Cells[colNomeCliente.Index].Value + "";
                    dtEntrega = dtgDadosPedidos.Rows[e.RowIndex].Cells[colDataEntrega.Index].Value + "";
                    qtd = dtgDadosPedidos.Rows[e.RowIndex].Cells[colQuantidade.Index].Value + "";
                    valorUnit = dtgDadosPedidos.Rows[e.RowIndex].Cells[colValorUnit.Index].Value + "";
                    valorTotal = dtgDadosPedidos.Rows[e.RowIndex].Cells[colValorTotal.Index].Value + "";
                    dtEmissao = dtgDadosPedidos.Rows[e.RowIndex].Cells[colDataEmissao.Index].Value + "";

                    FormDetalhaPedidos formDetalhaPedidos = new FormDetalhaPedidos(pedido, nomeCliente, dtEmissao, dtEntrega, qtd, valorUnit, valorTotal);
                    formDetalhaPedidos.ShowDialog();
                }
                else
                {
                    DataGridViewCell selectedCell = dtgDadosPedidos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    DataGridViewCell selectedCellAnterior = dtgDadosPedidos.Rows[e.RowIndex].Cells[e.ColumnIndex - 1];
                    if (selectedCell.Value == null)
                    {
                        if(selectedCellAnterior.Value == null)
                        {
                            MessageBox.Show("A etapa anterior ainda não foi finalizada!", "Ops, algo inesperado aconteceu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            pedido = dtgDadosPedidos.Rows[e.RowIndex].Cells[colPedido.Index].Value + "";
                            nomeCliente = dtgDadosPedidos.Rows[e.RowIndex].Cells[colNomeCliente.Index].Value + "";
                            using (SqlConnection connection = DaoConnection.GetConexao())
                            {
                                WorkflowDAO dao = new WorkflowDAO(connection);
                                empresa = dao.GetNomeEmpresa(new WorkflowPedidosModel()
                                {
                                    CodEmpresa = "1"
                                });
                            }
                            FormBaixaEtapa formBaixaEtapa = new FormBaixaEtapa(pedido, empresa, nomeCliente, nomeUsuario, dataSimulacao);
                            formBaixaEtapa.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Célula inválida, por favor selecione uma etapa!", "Ops, algo inesperado aconteceu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void CarregaFormBaixaEtapa()
        {
            if (dtgDadosPedidos.SelectedCells.Count > 0)
            {
                int rowIndex = dtgDadosPedidos.SelectedCells[0].RowIndex;
                pedido = dtgDadosPedidos.Rows[rowIndex].Cells[colPedido.Index].Value + "";
                nomeCliente = dtgDadosPedidos.Rows[rowIndex].Cells[colNomeCliente.Index].Value + "";
            }
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                WorkflowDAO dao = new WorkflowDAO(connection);
                empresa = dao.GetNomeEmpresa(new WorkflowPedidosModel()
                {
                    CodEmpresa = "1"
                });
            }
            FormBaixaEtapa formBaixaEtapa = new FormBaixaEtapa(pedido, empresa, nomeCliente, nomeUsuario, dataSimulacao);
            formBaixaEtapa.ShowDialog();
        }

        private void dtgDadosPedidos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                pedido = dtgDadosPedidos.Rows[e.RowIndex].Cells[colPedido.Index].Value + "";
                nomeProduto = dtgDadosPedidos.Rows[e.RowIndex].Cells[colNomeProduto.Index].Value + "";
                nomeCliente = dtgDadosPedidos.Rows[e.RowIndex].Cells[colNomeCliente.Index].Value + "";
                dtEntrega = dtgDadosPedidos.Rows[e.RowIndex].Cells[colDataEntrega.Index].Value + "";
                qtd = dtgDadosPedidos.Rows[e.RowIndex].Cells[colQuantidade.Index].Value + "";
                valorUnit = dtgDadosPedidos.Rows[e.RowIndex].Cells[colValorUnit.Index].Value + "";
                valorTotal = dtgDadosPedidos.Rows[e.RowIndex].Cells[colValorTotal.Index].Value + "";
                dtEmissao = dtgDadosPedidos.Rows[e.RowIndex].Cells[colDataEmissao.Index].Value + "";

                FormDetalhaPedidos formDetalhaPedidos = new FormDetalhaPedidos(pedido, nomeCliente, dtEmissao, dtEntrega, qtd, valorUnit, valorTotal);
                formDetalhaPedidos.ShowDialog();
            }
        }

        private void FormWorkflowPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);

                if(result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dtgMostraTotaisPedidos_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
             {
                 int scrollValue = e.NewValue;
                 dtgDadosPedidos.SuspendLayout();
                 dtgDadosPedidos.HorizontalScrollingOffset = scrollValue;
                 dtgDadosPedidos.ResumeLayout();
             }
        }

        private void consultaWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                WorkflowDAO dao = new WorkflowDAO(connection);
                BaixaEtapaDAO dao2 = new BaixaEtapaDAO(connection);

                InitializeTable(dtgDadosPedidos);
                List<WorkflowPedidosModel> etapasBaixas = dao.GetEtapasBaixas();

                foreach (WorkflowPedidosModel etapaBaixa in etapasBaixas)
                {
                    string columnName = etapaBaixa.Etapas;

                    if (dtgDadosPedidos.Columns.Contains(columnName))
                    {
                        DataGridViewCell cell = dtgDadosPedidos.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => row.Cells["colPedido"].Value.ToString() == etapaBaixa.Documento)
                            .Select(row => row.Cells[columnName])
                            .FirstOrDefault();

                        if (cell != null)
                        {
                            string dataBaixa = etapaBaixa.DataBaixa.ToString().Substring(0, 10);
                            cell.Value = dataBaixa;
                            cell.Style.BackColor = ColorTranslator.FromHtml(etapaBaixa.CorCelula);
                        }
                    }
                }

                int prazoNovaEtapa = 0;
                foreach (DataGridViewRow row in dtgDadosPedidos.Rows)
                {
                    prazoNovaEtapa = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Style.BackColor != Color.ForestGreen && cell.Style.BackColor != Color.Yellow && string.IsNullOrEmpty(cell.Value?.ToString()))
                        {
                            string columnName = cell.OwningColumn.Name;

                            int prazoEtapa = dao2.GetLeadTime(new WorkflowPedidosModel()
                            {
                                Etapas = columnName
                            });

                            DateTime dataEmissaoPedido = dao2.GetDataEmissao(new WorkflowPedidosModel()
                            {
                                Documento = row.Cells["colPedido"].Value.ToString()
                            });

                            prazoNovaEtapa = prazoNovaEtapa + prazoEtapa;
                            int duracaoEtapa = (dataSimulacao - dataEmissaoPedido).Days;

                            if (duracaoEtapa > prazoNovaEtapa)
                            {
                                cell.Style.BackColor = Color.Red;
                            }
                            else
                            {
                                prazoNovaEtapa = 0;
                                break;
                            }
                        }
                    }
                }

                List<WorkflowPedidosModel> pedidos = dao.GetPedidos(new WorkflowPedidosModel()
                {
                    NomeCliente = txtNomeCliente.Text,
                    NomeProduto = txtProduto.Text,
                    Documento = txtPedido.Text,
                    DataDe = dtpDataDe.Text,
                    DataAte = dtpDataAte.Text
                });

                e.Result = pedidos;
            }
        }

        private void consultaWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            imgLoad.Visible = false;
            imgLoad.Enabled = false;
            HabilitaComponentes();

            if (e.Error != null)
            {
                MessageBox.Show("Ocorreu um erro durante a consulta: " + e.Error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<WorkflowPedidosModel> pedidos = e.Result as List<WorkflowPedidosModel>;
            if (pedidos != null && pedidos.Count > 0)
            {
                btnBaixarEtapa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Não foi encontrado nenhum registro!", "Ops, algo inesperado aconteceu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBaixarEtapa.Enabled = false;
            }
        }

        public void HabilitaComponentes()
        {
            btnConsultar.Enabled = true;
            btnLimpar.Enabled = true;
            btnBuscarPedidos.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnBuscarProduto.Enabled = true;
            dtpDataDe.Enabled = true;
            dtpDataAte.Enabled = true;
            txtPedido.ReadOnly = false;
            txtNomeCliente.ReadOnly = false;
            txtProduto.ReadOnly = false;
            dtgDadosPedidos.Enabled = true;
            dtgMostraTotaisPedidos.Enabled = true;
        }

        public void DesabilipaCampos()
        {
            btnConsultar.Enabled = false;
            btnLimpar.Enabled = false;
            btnBuscarPedidos.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnBuscarProduto.Enabled = false;
            dtpDataDe.Enabled = false;
            dtpDataAte.Enabled = false;
            txtPedido.ReadOnly = true;
            txtNomeCliente.ReadOnly = true;
            txtProduto.ReadOnly = true;
            dtgDadosPedidos.Enabled = false;
            dtgMostraTotaisPedidos.Enabled = false;
        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dtgDadosPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}