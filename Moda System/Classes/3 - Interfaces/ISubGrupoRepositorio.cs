
using System.Collections.Generic;

namespace Moda_System.Classes
{
    public interface ISubGrupoRepositorio : IRepositorioBase<SubGrupo>
    {
        SubGrupo GetSubById(int grupo, int sgrupo);
        List<SubGrupo> GetByGrupo(int grupo);
    }
}
