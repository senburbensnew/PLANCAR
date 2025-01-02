
namespace PLANCAR_DTO.DTO
{
    public class Institution
    {
        public long Id { get; set; }
        public string Adresse { get; set; }         
        public string Email { get; set; }    
        public string EmailResponsable { get; set; } 
        public string Nom { get; set; }    
        public string NomResponsable { get; set; }
        public string Telephone { get; set; }
        public string TelephoneResponsable { get; set; }
        public Ville Localisation { get; set; }
        public int LocalisationId { get; set; } // Foreign Key to Ville

        public Institution() { }
    }
}
