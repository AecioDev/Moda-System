using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class VeiculoRepositorio : RepositorioBase<Veiculo>, IVeiculoRepositorio
    {

        public List<Veiculo> ConsVeiculo(string status, string doc, string nome)
        {
            var Veic = Db.Veiculo.AsQueryable();

            //if (!string.IsNullOrEmpty(status))
            //    Veic = Veic.Where(v => v.StatusVend == status);

            //if (!string.IsNullOrEmpty(doc))
            //    Veic = Veic.Where(f => f.CnpjVend.Contains(doc) || f.CpfVend.Contains(doc));

            //if (!string.IsNullOrEmpty(nome))
            //    Veic = Veic.Where(f => f.NomeVendedor.Contains(nome));

            return Veic.ToList();
        }

    }
}
