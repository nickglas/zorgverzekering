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
            public DbSet<Arts> Artsen { get; set; }
            public DbSet<Medicatie> Medicijnen { get; set; }
            public DbSet<Contract> Contracten { get; set; }
        }

        public class Arts
        {

            public int ArtsId { get; set; }
            public string Naam { get; set; }
            public string Adresgegevens { get; set; }
            public string Email { get; set; }
            public string Telefoon { get; set; }
        }

       

        public class Medicatie
        {
            public int MedicatieId { get; set; }
            public string Naam { get; set; }
            public string Beschrijving { get; set; }
            public string Bijwerking { get; set; }
        }

       public class Contract
        {
            public int ContractId { get; set; }
            public string Dokter { get; set; }
            public string Functie { get; set; }
            public DateTime Afloopdatum { get; set; }
        }

    }
}

