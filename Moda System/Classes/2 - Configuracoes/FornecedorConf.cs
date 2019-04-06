using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class FornecedorConf : EntityTypeConfiguration<Fornecedor>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public FornecedorConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.FornecedorId);
            Property(v => v.FornecedorId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.NomeForn).IsRequired().HasMaxLength(150);
            Property(v => v.CpfForn).IsOptional().HasMaxLength(11);
            Property(v => v.CnpjForn).IsOptional().HasMaxLength(14);
            Property(v => v.ContatoForn).IsOptional().HasMaxLength(50);
            Property(v => v.Tel1Forn).IsOptional().HasMaxLength(20);
            Property(v => v.Tel2Forn).IsOptional().HasMaxLength(20);
            Property(v => v.EmailForn).IsOptional().HasMaxLength(150);
            Property(v => v.StatusFor).IsOptional().HasMaxLength(1);
        }
    }
}