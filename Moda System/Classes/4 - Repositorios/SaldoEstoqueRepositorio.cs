
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class SaldoEstoqueRepositorio : RepositorioBase<SaldoEstoque>, ISaldoEstoqueRepositorio
    {
        public List<SaldoEstoque> GetByPro(int codpro)
        {
            return Db.SaldoEstoque.Where(s => s.CodProEst == codpro).ToList();
        }
    }
}
