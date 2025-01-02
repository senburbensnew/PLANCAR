using PLANCAR_DTO.Enums;

namespace PLANCAR_DTO.DTO
{
    public class Utilisateur
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Privilege Privilege { get; set; }
        public StatutCompte StatutCompte { get; set; }
        public Institution Institution { get; set; }

        public Utilisateur() { }
    }
}
