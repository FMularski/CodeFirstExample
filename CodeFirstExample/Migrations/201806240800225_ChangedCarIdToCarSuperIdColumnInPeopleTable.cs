namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCarIdToCarSuperIdColumnInPeopleTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "CarId", "dbo.Cars");
            DropIndex("dbo.People", new[] { "CarId" });
            RenameColumn(table: "dbo.People", name: "CarId", newName: "_Car_Id");
            AddColumn("dbo.People", "CarSuperId", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "_Car_Id", c => c.Int());
            CreateIndex("dbo.People", "_Car_Id");
            AddForeignKey("dbo.People", "_Car_Id", "dbo.Cars", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "_Car_Id", "dbo.Cars");
            DropIndex("dbo.People", new[] { "_Car_Id" });
            AlterColumn("dbo.People", "_Car_Id", c => c.Int(nullable: false));
            DropColumn("dbo.People", "CarSuperId");
            RenameColumn(table: "dbo.People", name: "_Car_Id", newName: "CarId");
            CreateIndex("dbo.People", "CarId");
            AddForeignKey("dbo.People", "CarId", "dbo.Cars", "Id", cascadeDelete: true);
        }
    }
}
