using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class FormInfoContext : DbContext
    {
        //constructor, bring the options into the context file
        //DbContexOptions of type FormInfoContext
        //Inherients from the base option
        public FormInfoContext (DbContextOptions<FormInfoContext> options) : base (options)
        {
            
        }

        //Import a table, and the type is FormInfo
        public DbSet<TimeInfo> Times { get; set; }
        public DbSet<FormInfo> Forms { get; set; }

    }
}
