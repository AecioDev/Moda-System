using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moda_System.Classes
{
    public class ModelUser
    {
        public int CodUser { get; set; }
        public string StaUser { get; set; }
        public string NomeUser { get; set; }
        public string EmailUser { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string PerfUser { get; set; }

        //public Image ImgUser { get; set; }
        //public string foneUser { get; set; }
        //public string cepUser { get; set; }
        //public string ruaEndUser { get; set; }
        //public string numEndUser { get; set; }
        //public string bairroUser { get; set; }
        //public string complUser { get; set; }
        //public string cidadeUser { get; set; }
        //public string ufEndUser { get; set; }
        //public string codCaixa { get; set; }
        //public string nomeimguser { get; set; }

        //public string extimg { get; set; }
        //public Image LogoEmp { get; set; }
        //public int tipBusca { get; set; }

    } //public class ModelUSer

    public class ModelEmpresa
    {
        public int codEmp { get; set; }
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
        public Image logoEmp { get; set; }
        public string CEPEmp { get; set; }
        public string UFEmp { get; set; }
        public string empPadrao { get; set; }
        public string tipoData { get; set; }
        public int versaoEmp { get; set; }
        public string nomImglogo { get; set; }
        public string extimglogo { get; set; }

    } //public class ModelEmpresa

    public class ModelEndereco
    {
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Resultado { get; set; }

    } //public class ModelEndereco

    public class ModelFornecedor
    {
        public int CodForn { get; set; }
        public string StatusFor { get; set; }
        public string NomeForn { get; set; }
        public string CpfForn { get; set; }
        public string CnpjForn { get; set; }
        public string ContatoForn { get; set; }
        public string Tel1Forn { get; set; }
        public string Tel2Forn { get; set; }
        public string EmailForn { get; set; }

        public string DocForn { get; set; }

        //public string RazaoFor { get; set; }
        //public string TipPesFor { get; set; }
        //public string InscEstFor { get; set; }
        //public string InscMunFor { get; set; }
        //public string CEPFor { get; set; }
        //public string EndFor { get; set; }
        //public string NumEndFor { get; set; }
        //public string BairroFor { get; set; }
        //public string ComplFor { get; set; }
        //public string CidadeFor { get; set; }
        //public string UFFor { get; set; }
        //public string TelCelFor { get; set; }
        //public string DatCadFor { get; set; }
        //public string statusFor { get; set; }
        //public string ObsFor { get; set; }
    }

    public class ModelDiversos  //Estoque, Marca, Unidades, Grupo, SubGrupo
    {
        public int DivID { get; set; }
        public string DivDesc { get; set; }
        public string DivSigla { get; set; }

    } //Estoque, Marca, Unidades, Grupo, SubGrupo

    public class ModelProdutos  //Produtos
    {
        public int CodPro { get; set; }
        public string RefPro { get; set; }
        public string StaPro { get; set; }
        public string Descpro { get; set; }
        public Image ImagProd { get; set; }
        public int MarcaPro { get; set; }
        public int GrupoPro { get; set; }
        public int SGrupoPro { get; set; }
        public int CodUniS { get; set; }
        public int CodUniE { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal QtdMinima { get; set; }
        public string ObsProd { get; set; }
        public DateTime DataCad { get; set; }
        public string ControlaQnt { get; set; }
        public Image ImgMinipro { get; set; }
        public decimal CustoMed { get; set; }
        public decimal CustoRep { get; set; }
        public DateTime DataCusto { get; set; }
        public string Usatabpre { get; set; }
        public string Extimg { get; set; }
        public string Nomeimgpro { get; set; }
        public decimal QntEquiv { get; set; }
    }

    public class ModelCodBar
    {
        public int Seqcodbar { get; set; }
        public int Procodbar { get; set; }
        public int Forcodbar { get; set; }
        public string Codbarras { get; set; }
    }

    public class ModelPreco
    {
        public int Codpropre { get; set; }
        public int Codtabpre { get; set; }
        public string Destabpre { get; set; }
        public decimal Valproduto { get; set; }
        public decimal Descprog { get; set; }
        public decimal Valantprod { get; set; }
    }

    public class ModelTabPreco
    {
        public int Seqtabpre { get; set; }
        public string Desctabpre { get; set; }
        public decimal Perclucro { get; set; }
        public string Calcprecmp { get; set; }
    }

    public class ModelSGrupo
    {
        public int CodSGrupo { get; set; }
        public int CodGrupo { get; set; }
        public string DescSGrupo { get; set; }
    }

    public class ModelSaldoEst
    {
        public int IdSaldoEst { get; set; }
        public int CodLocal { get; set; }
        public int CodPro { get; set; }
        public decimal QntEntrada { get; set; }
        public decimal QntSaidas { get; set; }
        public decimal QntSaldo { get; set; }
    }
}
