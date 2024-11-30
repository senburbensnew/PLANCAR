using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PLANCAR_DAO.Models
{
    public class Departement
    {
        public long Id { get; set; }
        public string Libelle { get; set; }

        public Departement() { }

        public Departement(string libelle)
        {
            Libelle = libelle;
        }
    }
}
