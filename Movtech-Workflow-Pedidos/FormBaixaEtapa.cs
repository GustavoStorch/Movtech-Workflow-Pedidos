using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public partial class FormBaixaEtapa : Form
    {
        public string codOperador { get; private set; }

        public string pedido { get; set; }

        public string empresa { get; set; }

        public string nomeProduto { get; set; }

        public FormBaixaEtapa(string Pedido, string Empresa, string NomeProduto)
        {
            InitializeComponent();
            pedido = Pedido;
            empresa = Empresa;
            nomeProduto = NomeProduto;
        }

        private void FormBaixaEtapa_Load(object sender, EventArgs e)
        {
            txtPedido.Text = pedido;
            txtNomeEmpresa.Text = empresa;
        }

        private void btnBaixarEtapa_Click(object sender, EventArgs e)
        {
            DateTime dataBaixa = dtpDataDaBaixa.Value;
            FormWorkflowPedidos formWorkflowPedidos = Application.OpenForms["FormWorkflowPedidos"] as FormWorkflowPedidos;
            DataGridViewCell selectedCell = formWorkflowPedidos.dtgDadosPedidos.CurrentCell;
            if (selectedCell != null)
            {
                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;
                string columnName = formWorkflowPedidos.dtgDadosPedidos.Columns[columnIndex].Name;
                DateTime dataEmissaoPedido;
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    BaixaEtapaDAO dao = new BaixaEtapaDAO(connection);

                    string auxiliarCodProduto = dao.GetCodProduto(new WorkflowPedidosModel()
                    {
                        NomeProduto = nomeProduto
                    });

                    dataEmissaoPedido = dao.GetDataEmissao(new WorkflowPedidosModel()
                    {
                        Documento = pedido,
                        CodProduto = auxiliarCodProduto
                    });

                    int prazoEtapa = dao.GetLeadTime(new WorkflowPedidosModel()
                    {
                        Etapas = columnName
                    });

                    int duracaoEtapa = (dataBaixa - dataEmissaoPedido).Days;
                    formWorkflowPedidos.dtgDadosPedidos.Rows[rowIndex].Cells[columnIndex].Value = dataBaixa.ToShortDateString();
                    if (duracaoEtapa <= prazoEtapa)
                    {
                        formWorkflowPedidos.dtgDadosPedidos.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Green;
                    } else
                    {
                        formWorkflowPedidos.dtgDadosPedidos.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
                    }

                    dao.AtualizaDataEtapa(new WorkflowPedidosModel()
                    {
                        Documento = txtPedido.Text,
                        CodProduto = auxiliarCodProduto,
                        LeadTime = prazoEtapa
                    });
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPedidos_Click(object sender, EventArgs e)
        {
            CarregaFormBuscarOperadores();
        }

        public void CarregaFormBuscarOperadores()
        {
            FormBuscarOperador formBuscarOperador = new FormBuscarOperador();
            formBuscarOperador.ShowDialog();
            txtNomeOperador.Text = formBuscarOperador.nomeOperador;
            codOperador = formBuscarOperador.codOperador;
        }
    }
}
