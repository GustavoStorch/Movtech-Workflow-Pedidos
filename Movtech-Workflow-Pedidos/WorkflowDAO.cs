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

        //realizar uma função para fazer uma consulta sql e gerar o leadTime para calcular a data de entrega do pedido e jogar na datagridview.

        public List<WorkflowPedidosModel> GetEtapas(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> etapas = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT c.nomeCliente, p.nomeProduto, pd.documento, pd.qtde, pd.valorFaturado, (pd.valorFaturado/pd.qtde) AS valorUnit,");
                sql.AppendLine("DATEADD(day, 45, pd.dataEmissao) AS dataEntrega FROM MvtCadCliente c");
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
            if (DBNull.Value != dr["qtde"])
            {
                model.Quantidade = dr["qtde"].ToString();
            }
            if (DBNull.Value != dr["valorFaturado"])
            {
                model.ValorTotal = dr["valorFaturado"].ToString();
            }
            if (DBNull.Value != dr["valorUnit"])
            {
                model.ValorUnitario = dr["valorUnit"].ToString();
            }
            if (DBNull.Value != dr["dataEntrega"])
            {
                model.DataEntrega = dr["dataEntrega"].ToString();
            }
            return model;
        }
    }
}
