using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class GrupoConf : EntityTypeConfiguration<Grupo>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public GrupoConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.GrupoId);
            Property(v => v.GrupoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.DescGrupo).IsRequired().HasMaxLength(150);
            Property(v => v.CorFundoGrd).IsOptional();
            Property(v => v.CorFonteGrd).IsOptional();
            Property(v => v.UsarGrade).IsOptional().HasMaxLength(1);
        }
    }
}