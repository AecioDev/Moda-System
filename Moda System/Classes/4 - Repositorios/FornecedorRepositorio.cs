
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class FornecedorRepositorio : RepositorioBase<Fornecedor>, IFornecedorRepositorio
    {
        public List<Fornecedor> ConsultaFor(string status, string doc, string nome)
        {
            var forn = Db.Fornecedor.AsQueryable();

            if (!string.IsNullOrEmpty(status))
                forn = forn.Where(f => f.StatusFor == status);

            if (!string.IsNullOrEmpty(doc))
                forn = forn.Where(f => f.CnpjForn.Contains(doc) || f.CpfForn.Contains(doc));

            if (!string.IsNullOrEmpty(nome))
                forn = forn.Where(f => f.NomeForn.Contains(nome));

            return forn.ToList();
        }
    }
}
