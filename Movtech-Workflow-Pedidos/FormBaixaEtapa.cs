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

        public string nomeCliente { get; set; }

        public Color corCelula { get; set; }

        public FormBaixaEtapa(string Pedido, string Empresa, string NomeCliente)
        {
            InitializeComponent();
            pedido = Pedido;
            empresa = Empresa;
            nomeCliente = NomeCliente;
        }

        private void FormBaixaEtapa_Load(object sender, EventArgs e)
        {
            FormWorkflowPedidos formWorkflowPedidos2 = Application.OpenForms["FormWorkflowPedidos"] as FormWorkflowPedidos;
            DataGridViewCell selectedCell2 = formWorkflowPedidos2.dtgDadosPedidos.CurrentCell;
            int columnIndex2 = selectedCell2.ColumnIndex;
            string columnName2 = formWorkflowPedidos2.dtgDadosPedidos.Columns[columnIndex2].Name;
            txtPedido.Text = pedido;
            txtNomeEmpresa.Text = empresa;
            txtNomeEtapa.Text = columnName2;
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

                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    BaixaEtapaDAO dao = new BaixaEtapaDAO(connection);

                    bool verificaCampos = dao.VerificaCampos(new WorkflowPedidosModel()
                    {
                        NomeOperador = txtNomeOperador.Text
                    });

                    if (verificaCampos)
                    {
                        string auxiliarCodCliente = dao.GetCodCliente(new WorkflowPedidosModel()
                        {
                            NomeCliente = nomeCliente
                        });

                        DateTime dataEmissaoPedido = dao.GetDataEmissao(new WorkflowPedidosModel()
                        {
                            Documento = pedido,
                            CodCliente = auxiliarCodCliente
                        });

                        int prazoEtapa = dao.GetLeadTime(new WorkflowPedidosModel()
                        {
                            Etapas = columnName
                        });

                        int duracaoEtapa = (dataBaixa - dataEmissaoPedido).Days;
                        formWorkflowPedidos.dtgDadosPedidos.Rows[rowIndex].Cells[columnIndex].Value = dataBaixa.ToShortDateString();

                        if (duracaoEtapa <= prazoEtapa)
                        {
                            formWorkflowPedidos.dtgDadosPedidos.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.ForestGreen;
                            corCelula = Color.ForestGreen;
                        }
                        else
                        {
                            formWorkflowPedidos.dtgDadosPedidos.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.IndianRed;
                            corCelula = Color.IndianRed;
                        }

                        dao.AtualizaDataEtapa(new WorkflowPedidosModel()
                        {
                            Documento = txtPedido.Text,
                            CodCliente = auxiliarCodCliente,
                            LeadTime = prazoEtapa
                        });

                        dao.SalvarEtapas(new WorkflowPedidosModel()
                        {
                            CodEmpresa = "1",
                            NomeEmpresa = txtNomeEmpresa.Text,
                            Documento = txtPedido.Text,
                            DataBaixa = dtpDataDaBaixa.Text,
                            CodOperador = codOperador,
                            NomeOperador = txtNomeOperador.Text,
                            Etapas = txtNomeEtapa.Text,
                            CodEtapa = dao.GetCodEtapa(new WorkflowPedidosModel()
                            {
                                Etapas = txtNomeEtapa.Text
                            }),
                            CorCelula = ColorTranslator.ToHtml(corCelula)
                        });
                    }
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