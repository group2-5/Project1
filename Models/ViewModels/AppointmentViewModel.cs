﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public IEnumerable<FormInfo> Forms { get; set; }
        public IEnumerable<TimeInfo> Times { get; set; }
            
    }
}
