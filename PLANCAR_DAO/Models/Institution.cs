using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    [Table("Institution")]
    public class Institution
    {
        public long Id { get; set; }
        public int Adresse { get; set; }         
        public string Email { get; set; }    
        public string EmailResponsable { get; set; } 
        public string Nom { get; set; }    
        public int NomResponsable { get; set; }
        public int Telephone { get; set; }
        public int TelephoneResponsable { get; set; }
        public Ville Localisation { get; set; }

        public Institution() { }

        public Institution(int adresse, string email, string emailResponsable, string nom, int nomResponsable, int telephone, int telephoneResponsable, Ville localisation)
        {
            Adresse = adresse;
            Email = email;
            EmailResponsable = emailResponsable;
            Nom = nom;
            NomResponsable = nomResponsable;
            Telephone = telephone;
            TelephoneResponsable = telephoneResponsable;
            Localisation = localisation;
        }
    }
}
