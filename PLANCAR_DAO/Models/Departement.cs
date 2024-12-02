using System.ComponentModel.DataAnnotations.Schema;

namespace PLANCAR_DAO.Models
{
    [Table("Departement")]
    public class Departement
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Ville> Villes { get; set; }

        public Departement() {
            Villes = new List<Ville>();
        }
    }
}
