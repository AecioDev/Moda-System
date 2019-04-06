using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Moda_System.Classes
{
    public class SubGrupoConf : EntityTypeConfiguration<SubGrupo>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public SubGrupoConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.SubGrupoId);
            Property(v => v.SubGrupoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.GrupoId).IsRequired();
            Property(v => v.DescSubGrupo).IsRequired().HasMaxLength(150);

            //Relacionamento
            HasRequired(v => v.Grupo).WithMany().HasForeignKey(v => v.GrupoId).WillCascadeOnDelete(false);

        }
    }
}