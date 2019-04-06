using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class UnidadeConf : EntityTypeConfiguration<Unidade>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public UnidadeConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.UnidadeId);
            Property(v => v.UnidadeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.DescUnidade).IsOptional().HasMaxLength(50);
            Property(v => v.SiglaUnidade).IsOptional().HasMaxLength(4);
        }
    }
}