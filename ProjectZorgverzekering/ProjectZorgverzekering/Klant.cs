using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectZorgverzekering
{
    class Klant
    {
        public int KlantId { get; set; }
        public int ArtsId { get; set; }
        public int ZorgverzekeringId {get; set;}
        public string Naam { get; set; }
        public string Adresgegevens { get; set; }
        public string Email { get; set; }

        public virtual List<Medicatie> Medicaties { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public int ArtsId { get; set; }
        public int ZorgverzekeringId { get; set; }
        public string Naam { get; set; }
        public string Adresgegevens { get; set; }
        public string Email { get; set; }
    }

    public class DataContext : DbContext
    {
        DbSet<Klant> Klant { get; set; }
    }
    

       

    
}
