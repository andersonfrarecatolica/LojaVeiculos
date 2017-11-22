namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRoleName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE AspNetRoles SET Name='CanManageData' where Id='bbf917d7-48b9-44f5-a620-92de2b5646f4'");
        }
        
        public override void Down()
        {
        }
    }
}
