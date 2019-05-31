using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class MovEstProConf : EntityTypeConfiguration<MovEstoquePro>
    {
        public MovEstProConf()
        {
            HasKey(c => c.MovEstProId);
            Property(c => c.MovEstProId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.MovEstId).IsRequired();
            Property(c => c.CodProId).IsRequired();
            Property(c => c.QntMovPro).IsRequired();
            Property(c => c.SaldoAntPro).IsOptional();
            Property(c => c.CusProMov).IsOptional();
            
            //Relacionamento
            HasRequired(c => c.Produto).WithMany().HasForeignKey(v => v.CodProId).WillCascadeOnDelete(false);
           
        }
    }
}
