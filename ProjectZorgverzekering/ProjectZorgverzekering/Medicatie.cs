using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZorgverzekering
{
    class Medicatie
    {
        public int MedicatieId { get; set; }
        public string MedicatieNaam { get; set; }
        public virtual List<Klant> Klanten { get; set; }
    }
}
