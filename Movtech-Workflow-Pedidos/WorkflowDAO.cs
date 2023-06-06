using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_Workflow_Pedidos
{
    public class WorkflowDAO
    {
        private SqlConnection Connection { get; }

        public WorkflowDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<WorkflowPedidosModel> GetEtapas(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> etapas = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT c.nomeCliente, p.nomeProduto, pd.documento FROM MvtCadCliente c");
                sql.AppendLine("JOIN MvtVendasEstruturaFaturamento pd ON c.codCliente = pd.codCliente");
                sql.AppendLine("JOIN MvtCadProduto p ON pd.codProduto = p.codProduto");
                sql.AppendLine("WHERE c.nomeCliente = @cliente AND p.nomeProduto = @produto AND pd.documento = @documento");
                command.Parameters.Add(new SqlParameter("@cliente", workflow.NomeCliente));
                command.Parameters.Add(new SqlParameter("@produto", workflow.NomeProduto));
                command.Parameters.Add(new SqlParameter("@documento", workflow.Documento));
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        etapas.Add(PopulateDrEtapas(dr));
                    }
                }
            }
            return etapas;
        }

        public WorkflowPedidosModel PopulateDrEtapas(SqlDataReader dr)
        {
            WorkflowPedidosModel model = new WorkflowPedidosModel();

            if (DBNull.Value != dr["nomeCliente"])
            {
                model.NomeCliente = dr["nomeCliente"].ToString();
            }
            if (DBNull.Value != dr["nomeProduto"])
            {
                model.NomeProduto = dr["nomeProduto"].ToString();
            }
            if (DBNull.Value != dr["documento"])
            {
                model.Documento = dr["documento"].ToString();
            }
            return model;
        }
    }
}
