namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_vendas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendas", "NotaFiscal", c => c.String(nullable: false));
            AlterColumn("dbo.Vendas", "Data", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendas", "Data", c => c.String());
            AlterColumn("dbo.Vendas", "NotaFiscal", c => c.String());
        }
    }
}
