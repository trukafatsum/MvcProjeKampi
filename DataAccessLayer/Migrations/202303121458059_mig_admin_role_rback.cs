namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_admin_role_rback : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Admins", new[] { "RoleID" });
            AddColumn("dbo.Admins", "AdminPassword", c => c.String(maxLength: 50));
            AddColumn("dbo.Admins", "AdminRole", c => c.String(maxLength: 1));
            AddColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            AlterColumn("dbo.Admins", "AdminUsername", c => c.String(maxLength: 50));
            CreateIndex("dbo.Admins", "RoleId");
            DropColumn("dbo.Admins", "AdminName");
            DropColumn("dbo.Admins", "AdminPasswordHash");
            DropColumn("dbo.Admins", "AdminPasswordSalt");
            DropColumn("dbo.Writers", "WriterPasswordHash");
            DropColumn("dbo.Writers", "WriterPasswordSalt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterPasswordSalt", c => c.Binary());
            AddColumn("dbo.Writers", "WriterPasswordHash", c => c.Binary());
            AddColumn("dbo.Admins", "AdminPasswordSalt", c => c.Binary());
            AddColumn("dbo.Admins", "AdminPasswordHash", c => c.Binary());
            AddColumn("dbo.Admins", "AdminName", c => c.String(maxLength: 50));
            DropIndex("dbo.Admins", new[] { "RoleId" });
            AlterColumn("dbo.Admins", "AdminUsername", c => c.Binary());
            DropColumn("dbo.Writers", "WriterPassword");
            DropColumn("dbo.Admins", "AdminRole");
            DropColumn("dbo.Admins", "AdminPassword");
            CreateIndex("dbo.Admins", "RoleID");
        }
    }
}
