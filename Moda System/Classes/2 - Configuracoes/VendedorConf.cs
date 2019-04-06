using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class VendedorConf : EntityTypeConfiguration<Vendedor>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public VendedorConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.VendedorId);
            Property(v => v.VendedorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.NomeVendedor).IsRequired().HasMaxLength(150);
            Property(v => v.PerComissao).IsOptional();
        }
    }
}