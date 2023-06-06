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
        public string codCliente { get; private set; }

        public string codProduto { get; private set; }
    
        public FormWorkflowPedidos()
        {
            InitializeComponent();
        }

        private void FormWorkflowPedidos_Load(object sender, EventArgs e)
        {
            lblDataAtual.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
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

        private void InitializeTable()
        {
            dtgDadosPedidos.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                WorkflowDAO dao = new WorkflowDAO(connection);
                List<WorkflowPedidosModel> etapas = dao.GetEtapas();
                foreach (WorkflowPedidosModel etapa in etapas)
                {
                    DataGridViewColumn column1 = dtgDadosPedidos.Columns[dtgDadosPedidos.Columns.Add("colNome1", etapa.Etapas)];
                }
            }
        }
    }
}
