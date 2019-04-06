
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IEmpresaRepositorio : IRepositorioBase<Empresa>
    {
        string Add_and_Update(Empresa Emp);
        Empresa GetPadrao();
    }
}
