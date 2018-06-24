using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.EntitiesConfigurations
{
    class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            Property(c => c.Brand)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Model)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
