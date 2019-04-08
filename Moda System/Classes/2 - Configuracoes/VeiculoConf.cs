using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class VeiculoConf : EntityTypeConfiguration<Veiculo>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.

        public VeiculoConf()
        {
            HasKey(v => v.VeiculoId);
            Property(v => v.VeiculoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.DescVeiculo).IsRequired().HasMaxLength(150);
            Property(v => v.PlacaVeiculo).IsRequired().HasMaxLength(10);
            Property(v => v.CodLocal).IsOptional();
            Property(v => v.CodMotorista).IsOptional();

            HasRequired(v => v.Estoque).WithMany().HasForeignKey(v => v.CodLocal).WillCascadeOnDelete(false);
            HasRequired(v => v.Motorista).WithMany().HasForeignKey(v => v.CodMotorista).WillCascadeOnDelete(false);

        }
    }
}
