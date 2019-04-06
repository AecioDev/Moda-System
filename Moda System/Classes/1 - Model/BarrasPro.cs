
namespace Moda_System.Classes
{
    public class BarrasPro
    {
        public int CodBarId { get; set; }
        public int ProCodBar { get; set; }
        public int ForCodBar { get; set; }
        public string Codbarras { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
