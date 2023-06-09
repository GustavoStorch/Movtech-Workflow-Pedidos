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
                sql.AppendLine($"SELECT data FROM MvtVendasEstruturaFaturamento WHERE documento = @documento AND codProduto = @codProduto");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@documento", workflow.Documento);
                command.Parameters.Add(new SqlParameter("@codProduto", workflow.CodProduto));
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

        public void AtualizaDataEtapa(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE MvtVendasEstruturaFaturamento SET data =  DATEADD(dd, @dataNova, data) WHERE documento = @documento AND codProduto = @codProduto");
                    command.Parameters.Add(new SqlParameter("@dataNova", workflow.LeadTime));
                    command.Parameters.Add(new SqlParameter("@documento", workflow.Documento));
                    command.Parameters.Add(new SqlParameter("@codProduto", workflow.CodProduto));
                    command.CommandText = sql.ToString();

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string GetCodProduto(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT codProduto FROM MvtCadProduto WHERE nomeProduto = @nomeProduto");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@nomeProduto", workflow.NomeProduto);
                string result = Convert.ToString(command.ExecuteScalar());
                return result;
            }
        }
    }
}
