using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moda_System.Classes
{
    public class UsuarioConf : EntityTypeConfiguration<Usuario>
    {
        //Utilizando o Fluente API para mapear comportamentos do dominio para modelar a tebela do banco de dados.
       
        public UsuarioConf() //Definições de comportamentos para o Cadastro de Clientes...
        {
            HasKey(v => v.UsuarioId);
            Property(v => v.UsuarioId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(v => v.StaUser).IsOptional().HasMaxLength(1);
            Property(v => v.NomeUser).IsOptional().HasMaxLength(150);
            Property(v => v.EmailUser).IsOptional().HasMaxLength(150);
            Property(v => v.LoginUser).IsOptional().HasMaxLength(20);
            Property(v => v.SenUser).IsOptional().HasMaxLength(256);
            Property(v => v.PerfilUser).IsOptional().HasMaxLength(1);
        }
    }
}