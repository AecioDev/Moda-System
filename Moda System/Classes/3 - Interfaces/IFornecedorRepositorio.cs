
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IFornecedorRepositorio : IRepositorioBase<Fornecedor>
    {
        List<Fornecedor> ConsultaFor(string status, string doc, string nome);
    }
}
