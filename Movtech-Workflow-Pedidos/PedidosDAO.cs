using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public class PedidosDAO
    {
        private SqlConnection Connection { get; }

        public PedidosDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public bool VerificaCampos(WorkflowPedidosModel workflow)
        {
            if (string.IsNullOrEmpty(workflow.Documento) || string.IsNullOrWhiteSpace(workflow.Documento))
            {
                MessageBox.Show("Por favor, preencha o campo de pesquisa!");
                return false;
            }
            return true;
        }

        public List<WorkflowPedidosModel> GetPedidos(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> pedidos = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT DISTINCT(documento) FROM vwMvtVendasEstruturaFaturamento WHERE codEmpresa = 1 AND tipo = 'F' AND documento LIKE '%' + @documento + '%'");
                command.Parameters.AddWithValue("@documento", workflow.Documento);
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        pedidos.Add(PopulateDrPedido(dr));
                    }
                }
            }
            return pedidos;
        }

        public WorkflowPedidosModel PopulateDrPedido(SqlDataReader dr)
        {
            string documento = "";

            if (DBNull.Value != dr["documento"])
            {
                documento = dr["documento"] + "";
            }

            return new WorkflowPedidosModel()
            {
                Documento = documento
            };
        }
    }
}
