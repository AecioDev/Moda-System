
using System.Collections.Generic;
using System.Linq;

namespace Moda_System.Classes
{
    public class SubGrupoRepositorio : RepositorioBase<SubGrupo>, ISubGrupoRepositorio
    {
        public List<SubGrupo> GetByGrupo(int grupo)
        {
            return Db.SubGrupo.Where(s => s.GrupoId == grupo).ToList();
        }

        public SubGrupo GetSubById(int grupo, int sgrupo)
        {
            return Db.SubGrupo.Where(s => s.GrupoId == grupo && s.SubGrupoId == sgrupo).FirstOrDefault();
        }
    }
}
