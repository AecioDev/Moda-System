using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class EmpresaConf : EntityTypeConfiguration<Empresa>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public EmpresaConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.EmpresaId);
            Property(v => v.EmpresaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.cnpjEmp).IsOptional().HasMaxLength(18);
            Property(v => v.statEmp).IsOptional().HasMaxLength(1);
            Property(v => v.tipoEmp).IsOptional().HasMaxLength(1);
            Property(v => v.codMatriz).IsOptional();
            Property(v => v.razaoEmp).IsRequired().HasMaxLength(150);
            Property(v => v.fantEmp).IsOptional().HasMaxLength(150);
            Property(v => v.inscEstEmp).IsOptional().HasMaxLength(20);
            Property(v => v.inscMunEmp).IsOptional().HasMaxLength(20);
            Property(v => v.tel1Emp).IsOptional().HasMaxLength(20);
            Property(v => v.tel2Emp).IsOptional().HasMaxLength(20);
            Property(v => v.endEmp).IsOptional().HasMaxLength(150);
            Property(v => v.nroEndEmp).IsOptional();
            Property(v => v.compEndEmp).IsOptional().HasMaxLength(150);
            Property(v => v.bairroEmp).IsOptional().HasMaxLength(150);
            Property(v => v.cidadeEmp).IsOptional().HasMaxLength(100);
            Property(v => v.dataCadEmp).IsOptional();            
            //Property(v => v.logoEmp).HasColumnType("image").IsOptional();
            Property(v => v.CEPEmp).IsOptional().HasMaxLength(8);
            Property(v => v.UFEmp).IsOptional().HasMaxLength(2);
            Property(v => v.empPadrao).IsOptional().HasMaxLength(1);
            Property(v => v.tipoData).IsOptional().HasMaxLength(10);
            Property(v => v.nomImglogo).IsOptional().HasMaxLength(150);
        }
    }
}