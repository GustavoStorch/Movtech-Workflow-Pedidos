using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_Workflow_Pedidos
{
    public class OperadorDAO
    {
        private SqlConnection Connection { get; }

        public OperadorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<WorkflowPedidosModel> GetOperadores(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> operadores = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codFuncionario, nomeFuncionario FROM MvtCadFuncionario WHERE nomeFuncionario LIKE '%' + @nomeFuncionario + '%' AND situacao = 'Trabalhando' ORDER BY codFuncionario");
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
            string codFuncionario = "";
            string nomeFuncionario = "";

            if (DBNull.Value != dr["codFuncionario"])
            {
                codFuncionario = dr["codFuncionario"] + "";
            }
            if (DBNull.Value != dr["nomeFuncionario"])
            {
                nomeFuncionario = dr["nomeFuncionario"] + "";
            }

            return new WorkflowPedidosModel()
            {
                CodOperador = codFuncionario,
                NomeOperador = nomeFuncionario
            };
        }
    }
}
