namespace Classes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clothes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clothes", "Type", c => c.String());
            AddColumn("dbo.Clothes", "Name", c => c.String());
            AddColumn("dbo.Clothes", "Size", c => c.Int(nullable: false));
            AddColumn("dbo.Clothes", "Condition", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clothes", "Condition");
            DropColumn("dbo.Clothes", "Size");
            DropColumn("dbo.Clothes", "Name");
            DropColumn("dbo.Clothes", "Type");
        }
    }
}
