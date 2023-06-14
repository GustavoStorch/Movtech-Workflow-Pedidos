using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_Workflow_Pedidos
{
    public class DetalhesPedidoDAO
    {
        private SqlConnection Connection { get; }

        public DetalhesPedidoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<WorkflowPedidosModel> GetProdutos(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> operadores = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT nomeProduto, qtde, valorFaturado, (valorFaturado / NULLIF(qtde, 0)) AS valorUnit FROM MvtVendasEstruturaFaturamento WHERE documento = @documento AND nomeCliente = @nomeCliente ORDER BY nomeProduto");
                command.Parameters.AddWithValue("@documento", workflow.Documento);
                command.Parameters.AddWithValue("@nomeCliente", workflow.NomeCliente);
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        operadores.Add(PopulateDrOperador(dr));
                    }
                }
            }
            return operadores;
        }

        public WorkflowPedidosModel PopulateDrOperador(SqlDataReader dr)
        {
            string nomeProduto = "";
            string qtde = "";
            string valorFaturado = "";
            string valorUnit = "";

            if (DBNull.Value != dr["nomeProduto"])
            {
                nomeProduto = dr["nomeProduto"] + "";
            }
            if (DBNull.Value != dr["qtde"])
            {
                qtde = dr["qtde"] + "";
            }
            if (DBNull.Value != dr["valorFaturado"])
            {
                valorFaturado = dr["valorFaturado"] + "";
            }
            if (DBNull.Value != dr["valorUnit"])
            {
                valorUnit = dr["valorUnit"] + "";
            }

            return new WorkflowPedidosModel()
            {
                NomeProduto = nomeProduto,
                Quantidade = Convert.ToInt32(qtde),
                ValorTotal = Convert.ToDouble(valorFaturado),
                ValorUnitario = Convert.ToDouble(valorUnit)
            };
        }
    }
}
