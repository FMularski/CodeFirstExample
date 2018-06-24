namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GiveCars : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.People SET CarSuperId = 1 WHERE FirstName = 'Aleksandra'");
            Sql("UPDATE dbo.People SET CarSuperId = 2 WHERE FirstName = 'Filip'");
        }
        
        public override void Down()
        {
            Sql("UPDATE dbo.People SET CarSuperId = NULL WHERE FirstName = 'Aleksandra'");
            Sql("UPDATE dbo.People SET CarSuperId = NULL WHERE FirstName = 'Filip'");
        }
    }
}
