namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationVeiculo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Veiculoes", "Placa", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Veiculoes", "Placa", c => c.String());
        }
    }
}
