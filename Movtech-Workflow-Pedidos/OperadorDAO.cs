using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public class OperadorDAO
    {
        private SqlConnection Connection { get; }

        public OperadorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public bool VerificaCampos(WorkflowPedidosModel workflow)
        {
            if (string.IsNullOrEmpty(workflow.NomeOperador) || string.IsNullOrWhiteSpace(workflow.NomeOperador))
            {
                MessageBox.Show("Por favor, preencha o campo de pesquisa!");
                return false;
            }
            return true;
        }

        public List<WorkflowPedidosModel> GetOperadores(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> operadores = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT usuario FROM MvtAcessoUsuario WHERE usuario LIKE '%' + @nomeFuncionario + '%' ORDER BY usuario");
                command.Parameters.AddWithValue("@nomeFuncionario", workflow.NomeOperador);
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
            string usuario = "";

            if (DBNull.Value != dr["usuario"])
            {
                usuario = dr["usuario"] + "";
            }

            return new WorkflowPedidosModel()
            {
                NomeOperador = usuario
            };
        }
    }
}
