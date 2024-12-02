﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PLANCAR_DAO.Models
{
    [Table("Ville")]
    public class Ville
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
        public ICollection<Institution> Institutions { get; set; }

        public Ville() {
            Institutions = new List<Institution>();
        }
    }
}
