using System;
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
    public partial class FormWorkflowPedidos : Form
    {
        public string dataFake { get; } = "02/02/2020";

        public string codCliente { get; private set; }

        public string codProduto { get; private set; }
    
        public FormWorkflowPedidos()
        {
            InitializeComponent();
        }

        private void FormWorkflowPedidos_Load(object sender, EventArgs e)
        {
            lblDataAtual.Text = "Data: " + DateTime.Now.ToString(dataFake);
            InitializaColumnsTable();
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
            codCliente = formBuscarCliente.codCliente;
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            CarregaFormBuscar();
        }

        public void CarregaFormBuscar()
        {
            FormBuscarProdutos formBuscarProdutos = new FormBuscarProdutos();
            formBuscarProdutos.ShowDialog();
            txtProduto.Text = formBuscarProdutos.nomeProduto;
            codProduto = formBuscarProdutos.codProduto;
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

        private void btnBaixarEtapa_Click(object sender, EventArgs e)
        {
            CarregaFormBaixaEtapa(); 
        }

        public void CarregaFormBaixaEtapa()
        {
            FormBaixaEtapa formBaixaEtapa = new FormBaixaEtapa();
            formBaixaEtapa.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            dtpDataDe.Text = string.Empty;
            dtpDataAte.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            txtPedido.Text = string.Empty;
            txtProduto.Text = string.Empty;
        }

        public void InitializeTable(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                WorkflowDAO dao = new WorkflowDAO(connection);
                List<WorkflowPedidosModel> pedidos = dao.GetPedidos(new WorkflowPedidosModel()
                {
                    NomeCliente = txtNomeCliente.Text,
                    NomeProduto = txtProduto.Text,
                    Documento = txtPedido.Text
                });

                foreach (WorkflowPedidosModel pedido in pedidos)
                {
                    DataGridViewRow row = dataGridView.Rows[dataGridView.Rows.Add()];
                    row.Cells[colNomeCliente.Index].Value = pedido.NomeCliente;
                    row.Cells[colPedido.Index].Value = pedido.Documento;
                    row.Cells[colQuantidade.Index].Value = pedido.Quantidade;
                    row.Cells[colValorTotal.Index].Value = pedido.ValorTotal;
                    row.Cells[colValorUnit.Index].Value = pedido.ValorUnitario;
                    row.Cells[colDataEntrega.Index].Value = pedido.DataEntrega.Substring(0, 10);
                }
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            InitializeTable(dtgDadosPedidos);
        }

        private void dtgDadosPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void dtgDadosPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaFormBaixaEtapa();
        }*/
    }
}
