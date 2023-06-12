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
    public partial class FormBuscarCliente : Form
    {
        public string nomeCliente { get; private set; }

        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            
        }

        public void CarregaTextBox()
        {
            nomeCliente = txtNomeCliente.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosCliente.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ClienteDAO dao = new ClienteDAO(connection);
                List<WorkflowPedidosModel> clientes = dao.GetClientes(new WorkflowPedidosModel()
                {
                    NomeCliente = txtNomeCliente.Text
                });
                foreach(WorkflowPedidosModel cliente in clientes)
                {
                    DataGridViewRow row = dtgDadosCliente.Rows[dtgDadosCliente.Rows.Add()];
                    row.Cells[colCodCliente.Index].Value = cliente.CodCliente;
                    row.Cells[colNomeCliente.Index].Value = cliente.NomeCliente;
                }
            }
        }

        private void dtgDadosCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodCliente.Text = dtgDadosCliente.Rows[e.RowIndex].Cells[colCodCliente.Index].Value + "";
                txtNomeCliente.Text = dtgDadosCliente.Rows[e.RowIndex].Cells[colNomeCliente.Index].Value + "";
            }
            CarregaTextBox();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ClienteDAO dao = new ClienteDAO(connection);

                bool verificaCampos = dao.VerificaCampos(new WorkflowPedidosModel()
                {
                    NomeCliente = txtNomeCliente.Text
                });

                if (verificaCampos)
                {
                    InitializeTable();
                }
            }
        }
    }
}
