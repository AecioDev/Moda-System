namespace Moda_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteracao_02042019_0 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PrecosPro", "ProdutoId", c => c.Int(nullable: false));
            CreateIndex("dbo.PrecosPro", "ProdutoId");
            AddForeignKey("dbo.PrecosPro", "ProdutoId", "dbo.Produto", "ProdutoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrecosPro", "ProdutoId", "dbo.Produto");
            DropIndex("dbo.PrecosPro", new[] { "ProdutoId" });
            DropColumn("dbo.PrecosPro", "ProdutoId");
        }
    }
}
