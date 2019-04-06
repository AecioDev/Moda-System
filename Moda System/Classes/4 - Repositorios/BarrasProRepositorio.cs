
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class BarrasProRepositorio : RepositorioBase<BarrasPro>, IBarrasProRepositorio
    {
        public BarrasPro GetByCod(int codPro, string codBar)
        {
            return Db.Barras.Where(b => b.ProCodBar == codPro && b.Codbarras == codBar).FirstOrDefault();
        }

        public List<BarrasPro> GetByPro(int codPro)
        {
            return Db.Barras.Where(b => b.ProCodBar == codPro).ToList();
        }
    }
}
