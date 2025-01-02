
namespace PLANCAR_DTO.DTO
{
    public class Departement
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
        public List<Ville> Villes { get; set; }

        public Departement() {
            Villes = new List<Ville>();
        }
    }
}
