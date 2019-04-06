
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IBarrasProRepositorio : IRepositorioBase<BarrasPro>
    {
        List<BarrasPro> GetByPro(int codPro);
        BarrasPro GetByCod(int codPro, string codBar);
    }
}
