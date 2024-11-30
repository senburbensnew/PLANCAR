using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    public class Vehicule
    {
        public long Id { get; set; }
        public string Couleur { get; set; }
        public DateTime DateService { get; set; }
        public string Immatriculation { get; set; }
        public bool IsAssuranceEnRegle { get; set; }
        public bool IsVehiculeVole { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string NumeroSerie { get; set; }
        public StatutVehicule StatutVehicule { get; set; }
    }
}
