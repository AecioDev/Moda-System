
using System;

namespace Moda_System.Classes
{
    public class MovEstoquePro
    {
        public int MovEstProId { get; set; }
        public int MovEstId { get; set; }   //Cabeçalho        
        public int CodProId { get; set; }
        public string QntMovPro { get; set; }
        public decimal SaldoAntPro { get; set; }
        public decimal CusProMov { get; set; }

        public virtual Produto Produto { get; set; }
    }
}