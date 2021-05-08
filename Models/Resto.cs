using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VitalWeb.Models
{
    public class Resto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
    }
}