
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class PrecosProRepositorio : RepositorioBase<PrecosPro>, IPrecosProRepositorio
    {
        public List<PrecosPro> GetByPro(int codpro, int codpre)
        {
            var pre = Db.PrecosPro.AsQueryable();

            //Descrição
            if (codpro > 0)
                pre = pre.Where(p => p.ProdutoId == codpro);

            if (codpre > 0)
                pre = pre.Where(p => p.PrecoProId == codpre);


            return pre.ToList();
        }
    }
}
