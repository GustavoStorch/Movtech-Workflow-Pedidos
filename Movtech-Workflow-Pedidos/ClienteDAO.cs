using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_Workflow_Pedidos
{
    public class ClienteDAO
    {
        private SqlConnection Connection { get; }

        public ClienteDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<WorkflowPedidosModel> GetClientes(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> clientes = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codCliente, nomeCliente FROM MvtCadCliente WITH(INDEX(idxNomeCliente)) WHERE nomeCliente LIKE '%' + @nomeCliente + '%' ORDER BY codCliente");
                command.Parameters.AddWithValue("@nomeCliente", workflow.NomeCliente);
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        clientes.Add(PopulateDrCliente(dr));
                    }
                }
            }
            return clientes;
        }

        public WorkflowPedidosModel PopulateDrCliente(SqlDataReader dr)
        {
            string codCliente = "";
            string nomeCliente = "";

            if (DBNull.Value != dr["codCliente"])
            {
                codCliente = dr["codCliente"] + "";
            }
            if (DBNull.Value != dr["nomeCliente"])
            {
                nomeCliente = dr["nomeCliente"] + "";
            }

            return new WorkflowPedidosModel()
            {
                CodCliente = codCliente,
                NomeCliente = nomeCliente
            };
        }
    }
}
