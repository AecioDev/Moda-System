using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class BarrasConf : EntityTypeConfiguration<BarrasPro>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public BarrasConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.CodBarId);
            Property(v => v.CodBarId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.ProCodBar).IsRequired();
            Property(v => v.ForCodBar).IsOptional();            
            Property(v => v.Codbarras).HasMaxLength(15).IsRequired();

            // Relacionamento 1 : N
            HasRequired(v => v.Produto).WithMany(v => v.BarrasPro).HasForeignKey(p => p.ProCodBar);
        }
    }
}