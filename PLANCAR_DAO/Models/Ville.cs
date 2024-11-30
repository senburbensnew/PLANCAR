using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    public class Ville
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
        public Departement Departement { get; set; }

        public Ville(string libelle, Departement departement)
        {
            Libelle = libelle;
            Departement = departement;
        }
    }
}
