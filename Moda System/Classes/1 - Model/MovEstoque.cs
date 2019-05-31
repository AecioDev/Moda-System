
using System;

namespace Moda_System.Classes
{
    public class MovEstoque
    {
        public int MovEstId { get; set; }
        public string TipMovEst { get; set; }
        public DateTime DatMovEst { get; set; }
        public DateTime DigMovEst { get; set; }
        public int CodlocMovEst { get; set; }
        public int CodUserMovEst { get; set; }
        public string StatusMovEst { get; set; }
        public string ObsMovEst { get; set; }

        public virtual Estoque Estoque { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}