using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    [Table("DemandeUtilisation")]
    public class DemandeUtilisation
    {
        public long Id { get; set; }
        public string NoDemande { get; set; }
        public DateTime DateDemande { get; set; }
        public DateTime DebutUtilisation { get; set; }
        public DateTime FinUtilisation { get; set; }
        public Ville Destination { get; set; }
        public string DescriptionDestination { get; set; }
        public Institution Institution { get; set; }
        public Vehicule Vehicule { get; set; }
        public StatutDemande StatutDemande { get; set; }
        public string Commentaire { get; set; }

        public DemandeUtilisation() { }

    }
}
