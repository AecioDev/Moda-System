using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class PrecosProConf : EntityTypeConfiguration<PrecosPro>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public PrecosProConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.ProdutoId);
            HasKey(v => v.PrecoProId);
            Property(v => v.PrecoProId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.TabPreId).IsRequired();
            Property(v => v.ValProduto).IsRequired();
            Property(v => v.DescProg).IsRequired();
            Property(v => v.ValAntPro).IsRequired();

            // Relacionamento
            HasRequired(v => v.TabPreco).WithMany().HasForeignKey(v => v.TabPreId).WillCascadeOnDelete(false);

            // Relacionamento 1 : N
            HasRequired(v => v.Produto).WithMany(v => v.PrecosPro).HasForeignKey(p => p.ProdutoId);
        }
    }
}