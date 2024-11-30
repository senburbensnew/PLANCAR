﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLANCAR_DAO.Models
{
    public class Constat
    {
        public long Id { get; set; }
        public DemandeUtilisation DemandeUtilisation {  get; set; }
        public DateTime DateEffectue { get; set; }
        public string EffectuePar { get; set; }
        public string LocalisationPhotos { get; set; } 
        public TypeConstat TypeConstat { get; set; }
        public Dommage Dommage { get; set; }
    }
}
