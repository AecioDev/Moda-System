
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IMarcaRepositorio : IRepositorioBase<Marca>
    {
        List<Marca> GetByDesc(string desc);
    }
}
