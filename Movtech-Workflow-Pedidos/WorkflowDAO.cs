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

        public List<WorkflowPedidosModel> GetEtapas()
        {
            List<WorkflowPedidosModel> etapas = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT etapas FROM MvtCadEtapas ORDER BY seqOrdem");
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
            string etapas = "";

            if (DBNull.Value != dr["etapas"])
            {
                etapas = dr["etapas"] + "";
            }

            return new WorkflowPedidosModel()
            {
                Etapas = etapas
            };
        }
    }
}
