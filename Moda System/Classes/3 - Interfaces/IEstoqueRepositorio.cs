
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IEstoqueRepositorio : IRepositorioBase<Estoque>
    {
        List<Estoque> GetByDesc(string desc);
    }
}
