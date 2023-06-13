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
    public partial class FormBuscarOperador : Form
    {
        public string nomeOperador { get; private set; }

        public string codOperador { get; private set; }

        public FormBuscarOperador()
        {
            InitializeComponent();
        }

        private void FormBuscarOperador_Load(object sender, EventArgs e)
        {
            InitializeTable(); 
        }

        public void CarregaTextBox()
        {
            nomeOperador = txtNomeOperador.Text;
            codOperador = txtCodOperador.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosOperador.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                OperadorDAO dao = new OperadorDAO(connection);
                List<WorkflowPedidosModel> operadores = dao.GetOperadores(new WorkflowPedidosModel()
                {
                    NomeOperador = txtNomeOperador.Text
                });
                foreach (WorkflowPedidosModel operador in operadores)
                {
                    DataGridViewRow row = dtgDadosOperador.Rows[dtgDadosOperador.Rows.Add()];
                    row.Cells[colCodOperador.Index].Value = operador.CodOperador;
                    row.Cells[colNomeOperador.Index].Value = operador.NomeOperador;
                }
            }
        }

        private void dtgDadosOperador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodOperador.Text = dtgDadosOperador.Rows[e.RowIndex].Cells[colCodOperador.Index].Value + "";
                txtNomeOperador.Text = dtgDadosOperador.Rows[e.RowIndex].Cells[colNomeOperador.Index].Value + "";
            }
            CarregaTextBox();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                OperadorDAO dao = new OperadorDAO(connection);

                bool verificaCampos = dao.VerificaCampos(new WorkflowPedidosModel()
                {
                    NomeOperador = txtNomeOperador.Text
                });

                if (verificaCampos)
                {
                    InitializeTable();
                }
            }
        }

        private void txtNomeOperador_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeOperador.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosOperador.Rows)
            {
                string nomeAutor = row.Cells[colNomeOperador.Index].Value.ToString().Trim();

                // Verifica se o nome do autor contém o filtro
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;

                // Define a visibilidade da linha com base no resultado do filtro
                row.Visible = exibir;
            }
        }
    }
}
