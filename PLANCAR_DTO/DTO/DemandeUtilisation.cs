using PLANCAR_DTO.Enums;

namespace PLANCAR_DTO.DTO
{
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
