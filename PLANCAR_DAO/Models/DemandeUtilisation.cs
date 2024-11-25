using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    public class DemandeUtilisation
    {
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

    }
}
