using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movtech_Workflow_Pedidos
{

    [Table("MvtVendasEstruturaFaturamento")]
    public class WorkflowPedidosModel
    {
        public string DataDe { get; set; }

        public string DataAte { get; set; }

        public string Documento { get; set; }

        public int Quantidade { get; set; }

        public double ValorTotal { get; set; }

        public double ValorUnitario { get; set; }

        public DateTime DataEntrega { get; set; }

        public DateTime DataEmissao { get; set; }

        public int QuantidadeTipoProduto { get; set; }

        [ForeignKey("MvtCadCliente")]
        [Column("codCliente")]
        public string NomeCliente { get; set; }

        public string CodCliente { get; set; }

        [ForeignKey("MvtCadProduto")]
        [Column("codProduto")]
        public string NomeProduto { get; set; }

        public string CodProduto { get; set; }

        [ForeignKey("MvtCadFuncionario")]
        [Column("codFuncionario")]
        public string CodOperador { get; set; }

        public string NomeOperador { get; set; }

        [ForeignKey("MvtMenuEmpresa")]
        [Column("codEmpresa")]
        public string CodEmpresa { get; set; }

        public string NomeEmpresa { get; set; }

        [ForeignKey("MvtCadEtapas")]
        [Column("codEtapas")]
        public string Etapas { get; set; }

        public int LeadTime { get; set; }

        public string CodEtapa { get; set; }

        [ForeignKey("MvtEtapasBaixas")]
        [Column("codEtapaBaixa")]
        public string DataBaixa { get; set;  }

        public string CorCelula { get; set; }
    }
}
