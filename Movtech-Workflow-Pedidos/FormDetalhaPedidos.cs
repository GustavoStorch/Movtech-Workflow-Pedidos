using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movtech_Workflow_Pedidos
{
    public partial class FormDetalhaPedidos : Form
    {
        public string pedido { get; set; }

        public string nomeCliente { get; set; }

        public string dtEntrega { get; set; }

        public string nomeProduto { get; set; }

        public string qtd { get; set; }

        public string valorUnit { get; set; }

        public string valorTotal { get; set; }


        public FormDetalhaPedidos(string Pedido, String NomeCliente, String DtEntrega, String NomeProduto, String Qtd, String ValorUnit, String ValorTotal)
        {
            InitializeComponent();
            txtPedido.Text = Pedido;
            txtNomeCliente.Text = NomeCliente;
            dtpDataEntrega.Text = DtEntrega;
            txtNomeProduto.Text = NomeProduto;
            txtQuantidade.Text = Qtd;
            txtValorUnitario.Text = ValorUnit;
            txtValorTotal.Text = ValorTotal;
        }

        private void FormDetalhaPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
