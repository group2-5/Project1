using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class TimeInfo
    {
        [Key]
        public int TimeID { get; set; }
        public DateTime Time { get; set; }
        public int? TourId { get; set; }
    }
}
