
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class MarcaRepositorio : RepositorioBase<Marca>, IMarcaRepositorio
    {
        public List<Marca> GetByDesc(string desc)
        {
            if (!string.IsNullOrEmpty(desc))
                return Db.Marca.Where(e => e.DescMarca.Contains(desc)).ToList();
            else
                return Db.Marca.ToList();
        }
    }
}
