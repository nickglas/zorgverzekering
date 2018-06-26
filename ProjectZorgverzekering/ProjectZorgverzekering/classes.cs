using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectZorgverzekering
{
    public class Classes
    {

        public class Klant
        {

            public int KlantId { get; set; }
            public string Naam { get; set; }
            public string Adresgegevens { get; set; }
            public string Email { get; set; }
            public string Verzekering { get; set; }
        }

        public class KlantContext : DbContext
        {
            public DbSet<Klant> Klanten { get; set; }
        }

       
    }
}

