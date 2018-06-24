using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            JupiterContext Context = new JupiterContext();
            var People = Context.People;
            var Cars = Context.Cars;

            People.Single(p => p.FirstName == "Aleksandra")._Car = Cars.SingleOrDefault(c => c.Brand == "Seat");
            People.Single(p => p.FirstName == "Filip")._Car = Cars.SingleOrDefault(c => c.Brand == "Deawoo");

            Context.SaveChanges();
        }
    }
}
