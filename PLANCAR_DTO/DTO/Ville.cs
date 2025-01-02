
namespace PLANCAR_DTO.DTO
{
    public class Ville
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
        public List<Institution> Institutions { get; set; }

        public Ville() {
            Institutions = new List<Institution>();
        }
    }
}
