using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    public class Utilisateur
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Privilege Privilege { get; set; }
        public StatutCompte StatutCompte { get; set; }
        public Institution Institution { get; set; }
    }
}
