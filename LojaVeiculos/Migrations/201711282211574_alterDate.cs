namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "DataNascimento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vendas", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendas", "Data", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "DataNascimento", c => c.String(nullable: false));
        }
    }
}
