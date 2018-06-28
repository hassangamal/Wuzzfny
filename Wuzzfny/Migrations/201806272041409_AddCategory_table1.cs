namespace Wuzzfny.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory_table1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.Int(nullable: false));
        }
    }
}
