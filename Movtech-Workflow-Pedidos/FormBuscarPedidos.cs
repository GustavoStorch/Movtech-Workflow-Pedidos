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
    public partial class FormBuscarPedidos : Form
    {
        public string documento { get; private set; }

        public FormBuscarPedidos()
        {
            InitializeComponent();
        }

        private void FormBuscarPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void CarregaTextBox()
        {
            documento = txtPedido.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosPedidos.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                PedidosDAO dao = new PedidosDAO(connection);
                List<WorkflowPedidosModel> pedidos = dao.GetPedidos(new WorkflowPedidosModel()
                {
                    Documento = txtPedido.Text
                });
                foreach (WorkflowPedidosModel pedido in pedidos)
                {
                    DataGridViewRow row = dtgDadosPedidos.Rows[dtgDadosPedidos.Rows.Add()];
                    row.Cells[colPedido.Index].Value = pedido.Documento;
                }
            }
        }

        private void dtgDadosPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtPedido.Text = dtgDadosPedidos.Rows[e.RowIndex].Cells[colPedido.Index].Value + "";
            }
            CarregaTextBox();
        }
    }
}
