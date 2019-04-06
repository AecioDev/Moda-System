using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class TabPrecoConf : EntityTypeConfiguration<TabPreco>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public TabPrecoConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.SeqTabPre);
            Property(v => v.SeqTabPre).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.DescTabPre).IsRequired().HasMaxLength(150);            
            Property(v => v.PercLucro).IsOptional();
            Property(v => v.CalcPreCmp).IsRequired().HasMaxLength(1);
        }
    }
}