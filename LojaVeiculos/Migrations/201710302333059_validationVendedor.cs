namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationVendedor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Veiculoes", "Marca", c => c.String(nullable: false));
            AlterColumn("dbo.Veiculoes", "Modelo", c => c.String(nullable: false));
            AlterColumn("dbo.Veiculoes", "Cor", c => c.String(nullable: false));
            AlterColumn("dbo.Veiculoes", "Descricao", c => c.String(nullable: false));
            AlterColumn("dbo.Vendedors", "Cpf", c => c.String(nullable: false));
            AlterColumn("dbo.Vendedors", "Telefone", c => c.String(nullable: false));
            AlterColumn("dbo.Vendedors", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendedors", "Email", c => c.String());
            AlterColumn("dbo.Vendedors", "Telefone", c => c.String());
            AlterColumn("dbo.Vendedors", "Cpf", c => c.String());
            AlterColumn("dbo.Veiculoes", "Descricao", c => c.String());
            AlterColumn("dbo.Veiculoes", "Cor", c => c.String());
            AlterColumn("dbo.Veiculoes", "Modelo", c => c.String());
            AlterColumn("dbo.Veiculoes", "Marca", c => c.String());
        }
    }
}
