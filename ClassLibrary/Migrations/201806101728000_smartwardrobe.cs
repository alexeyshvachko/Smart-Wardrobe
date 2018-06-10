namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smartwardrobe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Songs", "Album_ID", "dbo.Albums");
            DropIndex("dbo.Songs", new[] { "Album_ID" });
            CreateTable(
                "dbo.Bottoms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Int(nullable: false),
                        Condition = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Int(nullable: false),
                        Condition = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Int(nullable: false),
                        Condition = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Albums");
            DropTable("dbo.Songs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.Int(nullable: false),
                        Album_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Tops");
            DropTable("dbo.Shoes");
            DropTable("dbo.Bottoms");
            CreateIndex("dbo.Songs", "Album_ID");
            AddForeignKey("dbo.Songs", "Album_ID", "dbo.Albums", "ID");
        }
    }
}
