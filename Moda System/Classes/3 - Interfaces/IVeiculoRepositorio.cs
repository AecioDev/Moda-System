
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IVeiculoRepositorio : IRepositorioBase<Veiculo>
    {
        List<Veiculo> ConsVeiculo(string status, string doc, string nome);
    }
}
