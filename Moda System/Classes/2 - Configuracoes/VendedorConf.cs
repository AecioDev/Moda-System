using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class VendedorConf : EntityTypeConfiguration<Vendedor>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public VendedorConf()
        {
            HasKey(v => v.VendedorId);
            Property(v => v.VendedorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.NomeVendedor).IsRequired().HasMaxLength(150);
            Property(v => v.PerComissao).IsOptional();
            Property(v => v.CpfVend).IsOptional().HasMaxLength(11);
            Property(v => v.CnpjVend).IsOptional().HasMaxLength(14);
            Property(v => v.Tel1Vend).IsOptional().HasMaxLength(20);
            Property(v => v.Tel2Vend).IsOptional().HasMaxLength(20);
            Property(v => v.EmailVend).IsOptional().HasMaxLength(150);
            Property(v => v.StatusVend).IsOptional().HasMaxLength(1);
        }
    }
}