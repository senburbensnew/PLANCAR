using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    public class Institution
    {
        public int Adresse { get; set; }         
        public string Email { get; set; }    
        public string EmailResponsable { get; set; } 
        public decimal Nom { get; set; }    
        public int NomResponsable { get; set; }
        public int Telephone { get; set; }
        public int TelephoneResponsable { get; set; }
        public Ville Localisation { get; set; }

        public Institution(int adresse, string email, string emailResponsable, decimal nom, int nomResponsable, int telephone, int telephoneResponsable, Ville localisation)
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
