namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_FirstNam_To_FirstName_InPeopleTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.People", "FirstNam", "FirstName");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.People", "FirstName", "FirstNam");
        }
    }
}
