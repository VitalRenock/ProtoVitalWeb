using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VitalWeb.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string TagCategory { get; set; }
    }
}