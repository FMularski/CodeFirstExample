using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.EntitiesConfigurations
{
    class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50);

            HasOptional(p => p._Car)
                .WithMany(c => c.Owners)
                .HasForeignKey(p => p.CarSuperId);
        }
    }
}
