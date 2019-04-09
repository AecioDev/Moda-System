
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface IVeiculoRepositorio : IRepositorioBase<Veiculo>
    {
        List<Veiculo> ConsVeiculo(string placa, int codMoto, string decMoto);
    }
}
