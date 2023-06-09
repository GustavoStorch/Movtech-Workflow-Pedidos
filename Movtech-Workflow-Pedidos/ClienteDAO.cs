﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public class ClienteDAO
    {
        private SqlConnection Connection { get; }

        public ClienteDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public bool VerificaCampos(WorkflowPedidosModel workflow)
        {
            if (string.IsNullOrEmpty(workflow.NomeCliente) || string.IsNullOrWhiteSpace(workflow.NomeCliente))
            {
                MessageBox.Show("Por favor, preencha o campo de pesquisa!");
                return false;
            }
            return true;
        }

        public List<WorkflowPedidosModel> GetClientes(WorkflowPedidosModel workflow)
        {
            List<WorkflowPedidosModel> clientes = new List<WorkflowPedidosModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codCliente, nomeCliente FROM vwMvtCadCliente WHERE nomeCliente LIKE '%' + @nomeCliente + '%' ORDER BY codCliente");
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
