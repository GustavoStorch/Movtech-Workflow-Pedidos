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
    public partial class FormBaixaEtapa : Form
    {
        public string codOperador { get; private set; }

        public string pedido { get; set; }

        public string empresa { get; set; }

        public FormBaixaEtapa(string Pedido, string Empresa)
        {
            InitializeComponent();
            pedido = Pedido;
            empresa = Empresa;
        }

        private void FormBaixaEtapa_Load(object sender, EventArgs e)
        {
            txtPedido.Text = pedido;
            txtNomeEmpresa.Text = empresa;
        }

        private void btnBaixarEtapa_Click(object sender, EventArgs e)
        {
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
