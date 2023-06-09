using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_Workflow_Pedidos
{
    public class WorkflowPedidosModel
    {
        public string DataDe { get; set; }

        public string DataAte { get; set; }

        public string NomeCliente { get; set; }

        public string CodCliente { get; set; }

        public string NomeProduto { get; set; }

        public string CodProduto { get; set; }

        public string Documento { get; set; }

        public string Etapas { get; set; }

        public string Quantidade { get; set; }

        public string ValorTotal { get; set; }

        public string ValorUnitario { get; set; }

        public string DataEntrega { get; set; }

        public string CodOperador { get; set; }

        public string NomeOperador { get; set; }

        public string CodEmpresa { get; set; }

        public string NomeEmpresa { get; set; }

        public int LeadTime { get; set; }

        public string Date { get; set;  }
    
        public string CodEtapa { get; set; }

        public string CorCelula { get; set; }
    }
}
