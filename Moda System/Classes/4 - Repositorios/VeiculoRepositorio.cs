using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class VeiculoRepositorio : RepositorioBase<Veiculo>, IVeiculoRepositorio
    {

        public List<Veiculo> ConsVeiculo(string placa, int codMoto, string descVei)
        {
            var Veic = Db.Veiculo.AsQueryable();

            if (!string.IsNullOrEmpty(placa))
                Veic = Veic.Where(v => v.PlacaVeiculo == placa);

            if (!string.IsNullOrEmpty(descVei))
                Veic = Veic.Where(v => v.DescVeiculo.Contains(descVei));

            if (codMoto > 0)
                Veic = Veic.Where(v => v.CodMotorista == codMoto);

            return Veic.ToList();
        }
    }
}