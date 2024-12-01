using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    [Table("Utilisateur")]
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
