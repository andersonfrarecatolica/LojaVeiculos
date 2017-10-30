namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validateCliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Cpf", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Clientes", "DataNascimento", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Email", c => c.String());
            AlterColumn("dbo.Clientes", "DataNascimento", c => c.String());
            AlterColumn("dbo.Clientes", "Cpf", c => c.String());
        }
    }
}
