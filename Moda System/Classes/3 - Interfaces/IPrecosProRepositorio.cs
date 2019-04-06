
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IPrecosProRepositorio : IRepositorioBase<PrecosPro>
    {
        List<PrecosPro> GetByPro(int codpro, int codtab);
    }
}
