using PLANCAR_DTO.Enums;

namespace PLANCAR_DTO.DTO
{
    public class Constat
    {
        public long Id { get; set; }
        public DemandeUtilisation DemandeUtilisation {  get; set; }
        public DateTime DateEffectue { get; set; }
        public string EffectuePar { get; set; }
        public string LocalisationPhotos { get; set; } 
        public TypeConstat TypeConstat { get; set; }
        public Dommage Dommage { get; set; }

        public Constat() { }
    }
}
