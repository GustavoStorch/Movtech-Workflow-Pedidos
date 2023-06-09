using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public class WorkflowDAO
    {
        private SqlConnection Connection { get; }

        public WorkflowDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public string GetNomeEmpresa (WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nome FROM MvtMenuEmpresa WHERE codEmpresa = @codEmpresa");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codEmpresa", workflow.CodEmpresa);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }

        //realizar uma função para fazer uma consulta sql e gerar o leadTime para calcular a data de entrega do pedido e jogar na datagridview.
        /*public int RecuperaLeadTime()
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT SUM(leadTime) AS prazoEntrega From MvtCadEtapas");
                command.CommandText = sql.ToString();
                int prazoEntrega = Convert.ToInt32(command.ExecuteScalar());
                return prazoEntrega;
            }
        }*/

        public List<WorkflowPedidosModel> GetPedidos(WorkflowPedidosModel workflow)
        {
            //int prazoEntrega = RecuperaLeadTime();
            List<WorkflowPedidosModel> pedidos = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT c.nomeCliente, p.nomeProduto, pd.documento, pd.qtde, pd.valorFaturado, (pd.valorFaturado/pd.qtde) AS valorUnit,");
                //sql.AppendLine("DATEADD(day, @prazoEntrega, pd.dataEmissao) AS dataEntrega FROM MvtCadCliente c");
                sql.AppendLine("pd.dataProjecao, pd.codEmpresa FROM vwMvtCadCliente c");
                sql.AppendLine("JOIN vwMvtVendasEstruturaFaturamento pd ON c.codCliente = pd.codCliente");
                sql.AppendLine("JOIN vwMvtCadProduto p ON pd.codProduto = p.codProduto");
                sql.AppendLine("WHERE c.nomeCliente = @cliente AND p.nomeProduto = @produto AND pd.documento = @documento");
                command.Parameters.Add(new SqlParameter("@cliente", workflow.NomeCliente));
                command.Parameters.Add(new SqlParameter("@produto", workflow.NomeProduto));
                command.Parameters.Add(new SqlParameter("@documento", workflow.Documento));
                //command.Parameters.Add(new SqlParameter("@prazoEntrega", prazoEntrega));
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        pedidos.Add(PopulateDrPedidos(dr));
                    }
                }
            }
            return pedidos;
        }

        public WorkflowPedidosModel PopulateDrPedidos(SqlDataReader dr)
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
            if (DBNull.Value != dr["dataProjecao"])
            {
                model.DataEntrega = dr["dataProjecao"].ToString();
            }
            if (DBNull.Value != dr["codEmpresa"])
            {
                model.CodEmpresa = dr["codEmpresa"].ToString();
            }

            return model;
        }

        public List<WorkflowPedidosModel> GetEtapasBaixas()
        {
            List<WorkflowPedidosModel> etapasBaixas = new List<WorkflowPedidosModel>();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT documento, nomeEtapa, dataBaixa, corCelula FROM MvtEtapasBaixas";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WorkflowPedidosModel etapaBaixa = new WorkflowPedidosModel();
                            etapaBaixa.Documento = reader["documento"].ToString();
                            etapaBaixa.Etapas = reader["nomeEtapa"].ToString();
                            etapaBaixa.Date = Convert.ToString(reader["dataBaixa"]);
                            etapaBaixa.CorCelula = reader["corCelula"].ToString();

                            etapasBaixas.Add(etapaBaixa);
                        }
                    }
                }
            }

            return etapasBaixas;
        }
    }
}
