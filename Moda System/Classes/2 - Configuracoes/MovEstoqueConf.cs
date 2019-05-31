using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class MovEstoqueConf : EntityTypeConfiguration<MovEstoque>
    {
        public MovEstoqueConf()
        {
            HasKey(c => c.MovEstId);
            Property(c => c.MovEstId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.TipMovEst).HasMaxLength(1).IsRequired();
            Property(c => c.DatMovEst).IsRequired();
            Property(c => c.DigMovEst).IsRequired();
            Property(c => c.CodlocMovEst).IsOptional();
            Property(c => c.CodUserMovEst).IsOptional();
            Property(c => c.StatusMovEst).HasMaxLength(1).IsOptional();
            Property(c => c.ObsMovEst).HasMaxLength(1000).IsOptional();

            //Relacionamento
            HasRequired(c => c.Estoque).WithMany().HasForeignKey(v => v.CodlocMovEst).WillCascadeOnDelete(false);
            HasRequired(c => c.Usuario).WithMany().HasForeignKey(v => v.CodUserMovEst).WillCascadeOnDelete(false);
        }
    }
}
