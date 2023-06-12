using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public class ProdutoDAO
    {
        private SqlConnection Connection { get; }

        public ProdutoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public bool VerificaCampos(WorkflowPedidosModel workflow)
        {
            if (string.IsNullOrEmpty(workflow.NomeProduto) || string.IsNullOrWhiteSpace(workflow.NomeProduto))
            {
                MessageBox.Show("Por favor, preencha o campo de pesquisa!");
                return false;
            }
            return true;
        }

        public List<WorkflowPedidosModel> GetProdutos(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> produtos = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codProduto, nomeProduto FROM vwMvtCadProduto WHERE nomeProduto LIKE '%' + @nomeProduto + '%' ORDER BY codProduto");
                command.Parameters.AddWithValue("@nomeProduto", workflow.NomeProduto);
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        produtos.Add(PopulateDrProduto(dr));
                    }
                }
            }
            return produtos;
        }

        public WorkflowPedidosModel PopulateDrProduto(SqlDataReader dr)
        {
            string codProduto = "";
            string nomeProduto = "";

            if (DBNull.Value != dr["codProduto"])
            {
                codProduto = dr["codProduto"] + "";
            }
            if (DBNull.Value != dr["nomeProduto"])
            {
                nomeProduto = dr["nomeProduto"] + "";
            }

            return new WorkflowPedidosModel()
            {
                CodProduto = codProduto,
                NomeProduto = nomeProduto
            };
        }
    }
}