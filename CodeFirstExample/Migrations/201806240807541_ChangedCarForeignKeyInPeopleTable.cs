namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCarForeignKeyInPeopleTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.People", new[] { "_Car_Id" });
            DropColumn("dbo.People", "CarSuperId");
            RenameColumn(table: "dbo.People", name: "_Car_Id", newName: "CarSuperId");
            AlterColumn("dbo.People", "CarSuperId", c => c.Int());
            CreateIndex("dbo.People", "CarSuperId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.People", new[] { "CarSuperId" });
            AlterColumn("dbo.People", "CarSuperId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.People", name: "CarSuperId", newName: "_Car_Id");
            AddColumn("dbo.People", "CarSuperId", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "_Car_Id");
        }
    }
}
