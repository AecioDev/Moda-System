
namespace Moda_System.Classes
{
    public class SubGrupo
    {
        public SubGrupo() { }
        
        public int SubGrupoId { get; set; }
        public int GrupoId { get; set; }
        public string DescSubGrupo { get; set; }

        public virtual Grupo Grupo { get; set; }
    }
}
