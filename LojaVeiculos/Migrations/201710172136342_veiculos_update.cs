namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class veiculos_update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Veiculoes", "Tipo", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Veiculoes", "Tipo", c => c.String());
        }
    }
}
