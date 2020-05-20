namespace Laboratoriska_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FriendID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Hometown = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FriendModels");
        }
    }
}
