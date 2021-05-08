using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VitalWeb.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Le titre ne peut pas exéder les 50 caractères.")]
        public string PostTitle { get; set; }

        [Required]
        public string PostContent { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PostDate { get; set; }
    }
}