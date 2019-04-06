using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moda_System.Classes
{
    public class PrecosPro
    {
        public PrecosPro() { }        

        public int ProdutoId { get; set; }
        public int PrecoProId { get; set; }
        public int TabPreId { get; set; }
        public string DesTabPre { get; set; }
        public decimal ValProduto { get; set; }
        public decimal DescProg { get; set; }
        public decimal ValAntPro { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual TabPreco TabPreco { get; set; }
    }
}
