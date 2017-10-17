namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vendedor_update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendedors", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendedors", "Nome", c => c.String());
        }
    }
}
