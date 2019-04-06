namespace Moda_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoProdutos : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.Produto", "ImagProd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "ImagProd", c => c.Binary(nullable: false, maxLength: 4000));
        }
    }
}
