using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_Workflow_Pedidos
{
    public class BaixaEtapaDAO
    {
        private SqlConnection Connection { get; }

        public BaixaEtapaDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public DateTime GetDataEmissao(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT dataEmissao FROM MvtVendasEstruturaFaturamento WHERE documento = @documento");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@documento", workflow.Documento);
                DateTime result = Convert.ToDateTime(command.ExecuteScalar());
                return result;
            }
        }

        public int GetLeadTime(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT leadTime FROM MvtCadEtapas WHERE etapas = @etapas");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@etapas", workflow.Etapas);
                int result = Convert.ToInt32(command.ExecuteScalar());
                return result;
            }
        }
    }
}
