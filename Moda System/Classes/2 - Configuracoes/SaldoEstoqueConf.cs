using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class SaldoEstoqueConf : EntityTypeConfiguration<SaldoEstoque>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public SaldoEstoqueConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.SaldoEstId);
            Property(v => v.SaldoEstId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.CodLocalEst).IsRequired();
            Property(v => v.CodProEst).IsRequired();
            Property(v => v.QntEntradas).IsRequired();
            Property(v => v.QntSaidas).IsOptional();
            Property(v => v.QntSaldo).IsOptional();

            //Relacionamento
            HasRequired(v => v.Produto).WithMany().HasForeignKey(v => v.CodProEst).WillCascadeOnDelete(false);
            HasRequired(v => v.Estoque).WithMany().HasForeignKey(v => v.CodLocalEst).WillCascadeOnDelete(false);

        }
    }
}