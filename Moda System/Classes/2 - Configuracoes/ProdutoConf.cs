using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class ProdutoConf : EntityTypeConfiguration<Produto>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public ProdutoConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.ProdutoId);
            Property(v => v.ProdutoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.CodRefPro).IsOptional().HasMaxLength(40);
            Property(v => v.StaProd).IsOptional().HasMaxLength(1);
            Property(v => v.DescProd).IsRequired().HasMaxLength(150);
            Property(v => v.CodMarca).IsOptional();
            Property(v => v.CodGrupo).IsOptional();
            Property(v => v.CodSubGrupo).IsOptional();
            Property(v => v.CodUniSai).IsOptional();
            Property(v => v.CodUniEnt).IsOptional();
            Property(v => v.QntEquiv).IsRequired();
            Property(v => v.PrecoVenda).IsOptional();
            Property(v => v.QtdMinima).IsOptional();
            Property(v => v.ObsProd).IsOptional().HasMaxLength(2048);
            Property(v => v.DataCadPro).IsOptional();
            Property(v => v.ControlaQnt).IsOptional();
            Property(v => v.CustoMedPro).IsOptional();
            Property(v => v.CustoRepPro).IsOptional();
            Property(v => v.DataCusPro).IsOptional();
            Property(v => v.UsaTabPre).IsOptional();
            //Property(v => v.ImagProd).IsRequired();
            Property(v => v.NomeImgPro).IsOptional();
                        
            // Relacionamento 1 : N
            HasMany(c => c.BarrasPro).WithRequired(c => c.Produto).HasForeignKey(c => c.ProCodBar);

            // Relacionamento 1 : 1
            HasRequired(v => v.Marca).WithMany().HasForeignKey(v => v.CodMarca).WillCascadeOnDelete(false);
            HasRequired(v => v.Grupo).WithMany().HasForeignKey(v => v.CodGrupo).WillCascadeOnDelete(false);
            HasRequired(v => v.SubGrupo).WithMany().HasForeignKey(v => v.CodSubGrupo).WillCascadeOnDelete(false);
            HasRequired(v => v.UniSai).WithMany().HasForeignKey(v => v.CodUniSai).WillCascadeOnDelete(false);
            HasRequired(v => v.UniEnt).WithMany().HasForeignKey(v => v.CodUniEnt).WillCascadeOnDelete(false);


        }
    }
}