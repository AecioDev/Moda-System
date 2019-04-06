
namespace Moda_System.Classes
{
    public class SaldoEstoque
    {
        public int SaldoEstId { get; set; }
        public int CodLocalEst { get; set; }
        public int CodProEst { get; set; }
        public decimal QntEntradas { get; set; }
        public decimal QntSaidas { get; set; }
        public decimal QntSaldo { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual Estoque Estoque { get; set; }
    }
}
