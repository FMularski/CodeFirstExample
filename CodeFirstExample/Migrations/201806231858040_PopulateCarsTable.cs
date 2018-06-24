namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Cars (Brand, Model) VALUES ( 'Seat', 'Altea') ");
            Sql("INSERT INTO dbo.Cars (Brand, Model) VALUES ( 'Deawoo', 'Matiz') ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM dbo.Cars WHERE Brand = Seat");
            Sql("DELETE FROM dbo.Cars WHERE Brand = Deawoo");
        }
    }
}
