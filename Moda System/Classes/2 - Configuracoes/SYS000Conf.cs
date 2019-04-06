using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class SYS000Conf : EntityTypeConfiguration<SYS000>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public SYS000Conf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.SysId);
            Property(v => v.SysId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.VersaoSistema).IsOptional();
            Property(v => v.ScriptBD).IsOptional();
        }
    }
}