
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface ISaldoEstoqueRepositorio : IRepositorioBase<SaldoEstoque>
    {
        List<SaldoEstoque> GetByPro(int codpro);
    }
}
