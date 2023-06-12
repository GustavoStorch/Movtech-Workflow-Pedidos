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
    public partial class FormBuscarProdutos : Form
    {
        public string nomeProduto { get; private set; }

        public FormBuscarProdutos()
        {
            InitializeComponent();
        }

        private void FormBuscarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ProdutoDAO dao = new ProdutoDAO(connection);

                bool verificaCampos = dao.VerificaCampos(new WorkflowPedidosModel()
                {
                    NomeProduto = txtNomeProduto.Text
                });

                if (verificaCampos)
                {
                    InitializeTable();
                }
            }
        }

        public void CarregaTextBox()
        {
            nomeProduto = txtNomeProduto.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosProduto.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ProdutoDAO dao = new ProdutoDAO(connection);
                List<WorkflowPedidosModel> clientes = dao.GetProdutos(new WorkflowPedidosModel()
                {
                    NomeProduto = txtNomeProduto.Text
                });
                foreach (WorkflowPedidosModel cliente in clientes)
                {
                    DataGridViewRow row = dtgDadosProduto.Rows[dtgDadosProduto.Rows.Add()];
                    row.Cells[colCodProduto.Index].Value = cliente.CodProduto;
                    row.Cells[colNomeProduto.Index].Value = cliente.NomeProduto;
                }
            }
        }

        private void dtgDadosProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodProduto.Text = dtgDadosProduto.Rows[e.RowIndex].Cells[colCodProduto.Index].Value + "";
                txtNomeProduto.Text = dtgDadosProduto.Rows[e.RowIndex].Cells[colNomeProduto.Index].Value + "";
            }
            CarregaTextBox();
        }   
    }
}
