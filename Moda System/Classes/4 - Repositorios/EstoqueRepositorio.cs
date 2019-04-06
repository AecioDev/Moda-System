
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class EstoqueRepositorio : RepositorioBase<Estoque>, IEstoqueRepositorio
    {
        public List<Estoque> GetByDesc(string desc)
        {
            if (!string.IsNullOrEmpty(desc))
                return Db.Estoque.Where(e => e.DescEstoque.Contains(desc)).ToList();
            else
                return Db.Estoque.ToList();
        }
    }
}
