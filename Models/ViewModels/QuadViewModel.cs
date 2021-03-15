using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models.ViewModels
{
    public class QuadViewModel
    {
        public IEnumerable<FormInfo> Quad1 { get; set; }
        public IEnumerable<FormInfo> Quad2 { get; set; }
        public IEnumerable<FormInfo> Quad3 { get; set; }
        public IEnumerable<FormInfo> Quad4 { get; set; }

    }
}
