﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public class BaixaEtapaDAO
    {
        private SqlConnection Connection { get; }

        public BaixaEtapaDAO(SqlConnection connection)
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

        public void SalvarEtapas(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO MvtEtapasBaixas(codEmpresa, nomeEmpresa, documento, dataBaixa, codFuncionario, nomeFuncionario, codEtapas, nomeEtapa, corCelula) "); 
                    sql.AppendLine($"VALUES(@codEmpresa, @nomeEmpresa, @documento, @dataBaixa, @codFuncionario, @nomeFuncionario, @codEtapas, @nomeEtapa, @corCelula)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codEmpresa", workflow.CodEmpresa));
                    command.Parameters.Add(new SqlParameter("@nomeEmpresa", workflow.NomeEmpresa));
                    command.Parameters.Add(new SqlParameter("@documento", workflow.Documento));
                    command.Parameters.Add(new SqlParameter("@dataBaixa", workflow.DataBaixa));
                    command.Parameters.Add(new SqlParameter("@codFuncionario", workflow.CodOperador));
                    command.Parameters.Add(new SqlParameter("@nomeFuncionario", workflow.NomeOperador));
                    command.Parameters.Add(new SqlParameter("@codEtapas", workflow.CodEtapa));
                    command.Parameters.Add(new SqlParameter("@nomeEtapa", workflow.Etapas));
                    command.Parameters.Add(new SqlParameter("@corCelula", workflow.CorCelula));
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DateTime GetDataEmissao(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT data FROM MvtVendasEstruturaFaturamento WHERE documento = @documento AND codCliente = @codCliente");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@documento", workflow.Documento);
                command.Parameters.Add(new SqlParameter("@codCliente", workflow.CodCliente));
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
                    sql.AppendLine($"UPDATE MvtVendasEstruturaFaturamento SET data =  DATEADD(day, @dataNova, data) WHERE documento = @documento AND codCliente = @codCliente");
                    command.Parameters.Add(new SqlParameter("@dataNova", workflow.LeadTime));
                    command.Parameters.Add(new SqlParameter("@documento", workflow.Documento));
                    command.Parameters.Add(new SqlParameter("@codCliente", workflow.CodCliente));
                    command.CommandText = sql.ToString();

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string GetCodCliente(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT codCliente FROM vwMvtCadCliente WHERE nomeCliente = @nomeCliente");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@nomeCliente", workflow.NomeCliente);
                string result = Convert.ToString(command.ExecuteScalar());
                return result;
            }
        }

        public string GetCodEtapa(WorkflowPedidosModel workflow)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT codEtapas FROM MvtCadEtapas WHERE etapas = @etapas");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@etapas", workflow.Etapas);
                string result = Convert.ToString(command.ExecuteScalar());
                return result;
            }
        }
    }
}
