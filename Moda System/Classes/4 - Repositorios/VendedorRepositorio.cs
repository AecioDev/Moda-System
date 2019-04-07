using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class VendedorRepositorio : RepositorioBase<Vendedor>, IVendedorRepositorio
    {

        public List<Vendedor> ConsultaVen(string status, string doc, string nome)
        {
            var Vend = Db.Vendedor.AsQueryable();

            if (!string.IsNullOrEmpty(status))
                Vend = Vend.Where(f => f.StatusVend == status);

            if (!string.IsNullOrEmpty(doc))
                Vend = Vend.Where(f => f.CnpjVend.Contains(doc) || f.CpfVend.Contains(doc));

            if (!string.IsNullOrEmpty(nome))
                Vend = Vend.Where(f => f.NomeVendedor.Contains(nome));

            return Vend.ToList();
        }

    }
}
