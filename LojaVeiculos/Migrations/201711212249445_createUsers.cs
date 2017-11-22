namespace LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'37cebf8d-31b2-476a-ad67-1afc4b89a3d8', N'andersonfrare@hotmail.com', 0, N'AAItPh2G/aQRaQSed3vgaN7T8N8qsHMsLjWmaM2zg6FlLJb+5mgIacS1pM5jacX6eg==', N'f800104f-eec9-4ab6-9f96-5865db253f60', NULL, 0, 0, NULL, 1, 0, N'andersonfrare@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f98e2dd7-9fb9-4d41-9bfa-626a83e93283', N'anderson@wadvice.com.br', 0, N'ABfrSJ2TAlU0nyitZuCfQwW/VfOt3uAUxU2dKMBSgPT/nJ8N1e58O9JkgaGoiQde+A==', N'5f5c7dab-c9df-4398-b74a-99357d345ab8', NULL, 0, 0, NULL, 1, 0, N'anderson@wadvice.com.br')
");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bbf917d7-48b9-44f5-a620-92de2b5646f4', N'CanManageCustomers')
");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'37cebf8d-31b2-476a-ad67-1afc4b89a3d8', N'bbf917d7-48b9-44f5-a620-92de2b5646f4')
");

        }
        
        public override void Down()
        {
        }
    }
}
