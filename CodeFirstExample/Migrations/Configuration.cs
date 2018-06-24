namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstExample.JupiterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstExample.JupiterContext context)
        {
            context.People.AddOrUpdate(p => p.Id,
            new Person
            {
                Id = 1,
                FirstName = "Aleksandra",
                LastName = "Thiel"
            },
            new Person
            {
                Id = 2,
                FirstName = "Filip",
                LastName = "Mularski"
            });

        }
    }
}
