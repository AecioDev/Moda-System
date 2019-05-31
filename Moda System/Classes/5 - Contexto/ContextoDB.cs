using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Moda_System.Classes
{
    public class ContextoDB : DbContext
    {
        public ContextoDB() : base("ModaConnStr")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServerCompact.SqlCeProviderServices.Instance;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Definindo comportamentos para a manipulação do banco de dados:

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Remove Plural de Nomes automático
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Remove Cascateamento de um pra muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Remove Cascateamento de muitos pra muitos

            modelBuilder.Properties() //Informa pro BD que sempre q o nome tiver Id significa que é uma chave primária
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>() //Informa pro banco criar os tipos string como varchar e não nvarchar.
                .Configure(p => p.HasColumnType("nvarchar"));

            modelBuilder.Properties<decimal>() //Informa pro banco criar os tipos string como varchar e não nvarchar.
                .Configure(p => p.HasColumnType("money"));

            modelBuilder.Properties<string>() //Define o tamanho padrão de 100 se não for especificado.
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new BarrasConf());
            modelBuilder.Configurations.Add(new EmpresaConf());
            modelBuilder.Configurations.Add(new EstoqueConf());
            modelBuilder.Configurations.Add(new FornecedorConf());
            modelBuilder.Configurations.Add(new GrupoConf());
            modelBuilder.Configurations.Add(new MarcaConf());
            modelBuilder.Configurations.Add(new MovEstoqueConf());
            modelBuilder.Configurations.Add(new MovEstProConf());
            modelBuilder.Configurations.Add(new PrecosProConf());
            modelBuilder.Configurations.Add(new ProdutoConf());
            modelBuilder.Configurations.Add(new SaldoEstoqueConf());
            modelBuilder.Configurations.Add(new SubGrupoConf());
            modelBuilder.Configurations.Add(new SYS000Conf());
            modelBuilder.Configurations.Add(new TabPrecoConf());
            modelBuilder.Configurations.Add(new UnidadeConf());
            modelBuilder.Configurations.Add(new UsuarioConf());
            modelBuilder.Configurations.Add(new VendedorConf());
            modelBuilder.Configurations.Add(new VeiculoConf());
        }

        public DbSet<BarrasPro> Barras { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<MovEstoque> MovEstoque { get; set; }
        public DbSet<MovEstoquePro> MovEstoquePro { get; set; }
        public DbSet<PrecosPro> PrecosPro { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<SaldoEstoque> SaldoEstoque { get; set; }
        public DbSet<SubGrupo> SubGrupo { get; set; }
        public DbSet<SYS000> SYS000 { get; set; }
        public DbSet<TabPreco> TabPreco { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
    }
}
