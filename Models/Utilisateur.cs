using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VitalWeb.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
    }
}