using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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

        public int RecuperaLeadTime()
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT SUM(leadTime) AS prazoEntrega From MvtCadEtapas");
                command.CommandText = sql.ToString();
                int prazoEntrega = Convert.ToInt32(command.ExecuteScalar());
                return prazoEntrega;
            }
        }

        public List<WorkflowPedidosModel> GetPedidos(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> pedidos = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT pd.documento, c.nomeCliente, SUM(pd.qtde) AS qtdeTotal,COUNT(p.nomeProduto) AS qtdeTipoProd,");
                sql.AppendLine("SUM(pd.valorFaturado) AS valorTotal, AVG(pd.valorFaturado / NULLIF(pd.qtde, 0)) AS valorUnit, pd.dataProjecao, pd.codEmpresa, pd.dataEmissao");
                sql.AppendLine("FROM MvtCadCliente c");
                sql.AppendLine("JOIN MvtVendasEstruturaFaturamento pd ON c.codCliente = pd.codCliente");
                sql.AppendLine("JOIN MvtCadProduto p ON pd.codProduto = p.codProduto");
                sql.AppendLine("WHERE 1 = 1");
                if (!string.IsNullOrEmpty(workflow.NomeCliente))
                {
                    sql.AppendLine($"AND c.nomeCliente LIKE '%' + @cliente + '%'");
                    command.Parameters.AddWithValue("@cliente", workflow.NomeCliente);
                }
                if (!string.IsNullOrEmpty(workflow.NomeProduto))
                {
                    if (string.IsNullOrEmpty(workflow.Documento) && string.IsNullOrEmpty(workflow.NomeCliente))
                    {
                        sql.AppendLine($"AND EXISTS (SELECT 1 FROM MvtVendasEstruturaFaturamento pd2 JOIN MvtCadProduto p2 ON pd2.codProduto = p2.codProduto WHERE pd2.documento = pd.documento AND p2.nomeProduto LIKE '%' + @produto + '%')");
                    } else
                    {
                        sql.AppendLine($"AND p.nomeProduto LIKE '%' + @produto + '%'");
                    }
                    command.Parameters.AddWithValue("@produto", workflow.NomeProduto);
                }
                if (!string.IsNullOrEmpty(workflow.Documento))
                {
                    sql.AppendLine($"AND pd.documento LIKE '%' + @documento + '%' AND pd.codEmpresa = 1 AND pd.tipo = 'F'");
                    command.Parameters.AddWithValue("@documento", workflow.Documento);
                }
                if (!string.IsNullOrEmpty(workflow.DataDe) && !string.IsNullOrEmpty(workflow.DataAte))
                {
                    sql.AppendLine($"AND pd.dataEmissao BETWEEN @dataDe AND @dataAte");
                    command.Parameters.AddWithValue("@dataDe", workflow.DataDe);
                    command.Parameters.AddWithValue("@dataAte", workflow.DataAte);
                }
                sql.AppendLine($"GROUP BY pd.documento, c.nomeCliente, pd.valorFaturado, pd.qtde, pd.dataProjecao, pd.codEmpresa, pd.dataEmissao");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        WorkflowPedidosModel pedido = PopulateDrPedidos(dr);

                        // Verifica se o pedido já existe na lista
                        WorkflowPedidosModel pedidoExistente = pedidos.FirstOrDefault(p => p.Documento == pedido.Documento);
                        if (pedidoExistente != null)
                        {
                            // Se o pedido já existe, adiciona os valores do produto ao pedido existente
                            pedidoExistente.Quantidade += pedido.Quantidade;
                            pedidoExistente.ValorTotal += pedido.ValorTotal;
                            pedidoExistente.ValorUnitario = pedido.ValorUnitario;
                            pedidoExistente.QuantidadeTipoProduto += pedido.QuantidadeTipoProduto;
                        }
                        else
                        {
                            // Se o pedido não existe, adiciona o pedido à lista
                            pedidos.Add(pedido);
                        }
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
            if (DBNull.Value != dr["documento"])
            {
                model.Documento = dr["documento"].ToString();
            }
            if (DBNull.Value != dr["qtdeTotal"])
            {
                model.Quantidade = Convert.ToInt32(dr["qtdeTotal"]);
            }
            if (DBNull.Value != dr["valorTotal"])
            {
                model.ValorTotal = Convert.ToDouble(dr["valorTotal"]);
            }
            if (DBNull.Value != dr["valorUnit"])
            {
                model.ValorUnitario = Convert.ToDouble(dr["valorUnit"]);
            }
            if (DBNull.Value != dr["dataProjecao"])
            {
                model.DataEntrega = Convert.ToDateTime(dr["dataProjecao"]);
            }
            if (DBNull.Value != dr["codEmpresa"])
            {
                model.CodEmpresa = dr["codEmpresa"].ToString();
            }
            if (DBNull.Value != dr["dataEmissao"])
            {
                model.DataEmissao = Convert.ToDateTime(dr["dataEmissao"]);
            }
            if (DBNull.Value != dr["qtdeTipoProd"])
            {
                model.QuantidadeTipoProduto = Convert.ToInt32(dr["qtdeTipoProd"]);
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
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("SELECT documento, nomeEtapa, dataBaixa, corCelula FROM MvtEtapasBaixas");
                    command.CommandText = sql.ToString();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WorkflowPedidosModel etapaBaixa = new WorkflowPedidosModel();
                            etapaBaixa.Documento = reader["documento"].ToString();
                            etapaBaixa.Etapas = reader["nomeEtapa"].ToString();
                            etapaBaixa.DataBaixa = Convert.ToString(reader["dataBaixa"]);
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
