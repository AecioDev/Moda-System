using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class EstoqueConf : EntityTypeConfiguration<Estoque>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public EstoqueConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.EstoqueId);
            Property(v => v.EstoqueId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.DescEstoque).IsRequired().HasMaxLength(150);
        }
    }
}