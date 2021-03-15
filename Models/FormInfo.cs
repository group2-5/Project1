using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    //These are the properties for Sign Up Form
    public class FormInfo
    {
        [Key]
        [Required]
        public int TourId {get; set;}
        [Required]
        public string NameOfGroup { get; set; }
        [Required]
        public int SizeOfGroup { get; set; }
        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
