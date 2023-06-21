using System;
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
        public string dataFake { get; } = "05/02/2020";

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

        public FormWorkflowPedidos(string NomeUsuario)
        {
            InitializeComponent();
            nomeUsuario = NomeUsuario;   
        }

        private void FormWorkflowPedidos_Load(object sender, EventArgs e)
        {
            lblDataAtual.Text = "Data: " + DateTime.Now.ToString(dataFake);
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
            btnBaixarEtapa.Enabled = false;
        }

        public void InitializeTable(DataGridView dataGridView)
        {
            dataGridView.Invoke((MethodInvoker)delegate
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns["colDataEntrega"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView.Columns["colValorTotal"].DefaultCellStyle.Format = "C2";
                dataGridView.Columns["colValorUnit"].DefaultCellStyle.Format = "C2";
                dataGridView.Columns["colQuantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["colValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["colValorUnit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridView.Columns["colQtdTipos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                    });
                }
                dataGridView.Invoke((MethodInvoker)delegate
                {
                    dataGridView.Columns[colValorTotal.Index].Frozen = true;
                });

                dtgMostraTotaisPedidos.Invoke((MethodInvoker)delegate
                {
                    dtgMostraTotaisPedidos.ColumnHeadersVisible = false;
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
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            imgLoad.Enabled = true;
            imgLoad.Visible = true;
            btnConsultar.Enabled = false;
            btnBaixarEtapa.Enabled = true;
            try
            {
                List<WorkflowPedidosModel> pedidos = await Task.Run(() =>
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        WorkflowDAO dao = new WorkflowDAO(connection);

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
                                        string dataBaixa = etapaBaixa.DataBaixa.ToString().Substring(0,10);
                                        dtgDadosPedidos.Invoke((MethodInvoker)delegate
                                        {
                                            cell.Value = dataBaixa;
                                            cell.Style.BackColor = ColorTranslator.FromHtml(etapaBaixa.CorCelula);
                                        });
                                    }
                            }
                        }
                        return dao.GetPedidos(new WorkflowPedidosModel()
                        {
                            NomeCliente = txtNomeCliente.Text,
                            NomeProduto = txtProduto.Text,
                            Documento = txtPedido.Text,
                            DataDe = dtpDataDe.Text,
                            DataAte = dtpDataAte.Text
                        });
                        
                    }
                });
                if (dtgDadosPedidos.RowCount == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum registro!", "Ops, algo inesperado aconteceu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBaixarEtapa.Enabled = false;
                }
            }
            finally
            {
                imgLoad.Visible = false;
                imgLoad.Enabled = false;
                btnConsultar.Enabled = true;
            }
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
                            FormBaixaEtapa formBaixaEtapa = new FormBaixaEtapa(pedido, empresa, nomeCliente, nomeUsuario);
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
            FormBaixaEtapa formBaixaEtapa = new FormBaixaEtapa(pedido, empresa, nomeCliente, nomeUsuario);
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
    }
}
