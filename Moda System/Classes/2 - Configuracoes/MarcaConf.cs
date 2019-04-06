using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class MarcaConf : EntityTypeConfiguration<Marca>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public MarcaConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.MarcaId);
            Property(v => v.MarcaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.DescMarca).IsRequired().HasMaxLength(150);
        }
    }
}