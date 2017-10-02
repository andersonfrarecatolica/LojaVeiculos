namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criacaoChaveEstrangeiraVenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendas", "VeiculoId", c => c.Int(nullable: false));
            AddColumn("dbo.Vendas", "ClienteId", c => c.Int(nullable: false));
            AddColumn("dbo.Vendas", "VendedorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vendas", "VeiculoId");
            CreateIndex("dbo.Vendas", "ClienteId");
            CreateIndex("dbo.Vendas", "VendedorId");
            AddForeignKey("dbo.Vendas", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Vendas", "VeiculoId", "dbo.Veiculoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Vendas", "VendedorId", "dbo.Vendedors", "Id", cascadeDelete: true);
            DropColumn("dbo.Vendas", "IdVeiculo");
            DropColumn("dbo.Vendas", "IdCliente");
            DropColumn("dbo.Vendas", "IdVendedor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vendas", "IdVendedor", c => c.Int(nullable: false));
            AddColumn("dbo.Vendas", "IdCliente", c => c.Int(nullable: false));
            AddColumn("dbo.Vendas", "IdVeiculo", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vendas", "VendedorId", "dbo.Vendedors");
            DropForeignKey("dbo.Vendas", "VeiculoId", "dbo.Veiculoes");
            DropForeignKey("dbo.Vendas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Vendas", new[] { "VendedorId" });
            DropIndex("dbo.Vendas", new[] { "ClienteId" });
            DropIndex("dbo.Vendas", new[] { "VeiculoId" });
            DropColumn("dbo.Vendas", "VendedorId");
            DropColumn("dbo.Vendas", "ClienteId");
            DropColumn("dbo.Vendas", "VeiculoId");
        }
    }
}
