namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Car_Id", c => c.Int());
            CreateIndex("dbo.People", "Car_Id");
            AddForeignKey("dbo.People", "Car_Id", "dbo.Cars", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Car_Id", "dbo.Cars");
            DropIndex("dbo.People", new[] { "Car_Id" });
            DropColumn("dbo.People", "Car_Id");
            DropTable("dbo.Cars");
        }
    }
}
