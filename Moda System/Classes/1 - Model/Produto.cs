using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Moda_System.Classes
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string CodRefPro { get; set; }
        public string StaProd { get; set; }
        public string DescProd { get; set; }
        public int CodMarca { get; set; }
        public int CodGrupo { get; set; }
        public int CodSubGrupo { get; set; }
        public int CodUniSai { get; set; }
        public int CodUniEnt { get; set; }
        public decimal QntEquiv { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal QtdMinima { get; set; }
        public string ObsProd { get; set; }
        public DateTime DataCadPro { get; set; }
        public string ControlaQnt { get; set; }
        public decimal CustoMedPro { get; set; }
        public decimal CustoRepPro { get; set; }
        public DateTime DataCusPro { get; set; }
        public string UsaTabPre { get; set; }

        [NotMapped]
        public byte[] ImagProd { get; set; }
        public string NomeImgPro { get; set; }

        [NotMapped]
        public string extimgpro { get; set; }

        [NotMapped] //Apenas para filtro na consulta
        public string CodBarras { get; set; }


        public virtual ICollection<BarrasPro> BarrasPro { get; set; }
        public virtual ICollection<PrecosPro> PrecosPro { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Grupo Grupo { get; set; }
        public virtual SubGrupo SubGrupo { get; set; }
        public virtual Unidade UniSai { get; set; }
        public virtual Unidade UniEnt { get; set; }
    }
}
