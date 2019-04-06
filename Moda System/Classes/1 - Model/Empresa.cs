using System;
using System.Drawing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string cnpjEmp { get; set; }
        public string statEmp { get; set; }
        public string tipoEmp { get; set; }
        public int codMatriz { get; set; }
        public string razaoEmp { get; set; }
        public string fantEmp { get; set; }
        public string inscEstEmp { get; set; }
        public string inscMunEmp { get; set; }
        public string tel1Emp { get; set; }
        public string tel2Emp { get; set; }
        public string endEmp { get; set; }
        public int nroEndEmp { get; set; }
        public string compEndEmp { get; set; }
        public string bairroEmp { get; set; }
        public string cidadeEmp { get; set; }
        public DateTime dataCadEmp { get; set; }

        [NotMapped]
        public byte[] logoEmp { get; set; }

        public string CEPEmp { get; set; }
        public string UFEmp { get; set; }
        public string empPadrao { get; set; }
        public string tipoData { get; set; }
        public int versaoEmp { get; set; }
        public string nomImglogo { get; set; }
        public string extimglogo { get; set; }
    }
}
