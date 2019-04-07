
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IVendedorRepositorio : IRepositorioBase<Vendedor>
    {
        List<Vendedor> ConsultaVen(string status, string doc, string nome);
    }
}
