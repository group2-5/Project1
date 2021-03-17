using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1
{
    //Data to autopopulate our times stuff
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            FormInfoContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<FormInfoContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Times.Any())
            {
                context.Times.AddRange(

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 08, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 09, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 10, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 11, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 12, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 13, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 14, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 15, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 16, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 17, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 18, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 22, 19, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 08, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 09, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 10, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 11, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 12, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 13, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 14, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 15, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 16, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 17, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 18, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 23, 19, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 08, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 09, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 10, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 11, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 12, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 13, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 14, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 15, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 16, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 17, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 18, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 24, 19, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 08, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 09, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 10, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 11, 00, 00)
                    },


                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 12, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 13, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 14, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 15, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 16, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 17, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 18, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 25, 19, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 08, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 09, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 10, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 11, 00, 00)
                    },


                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 12, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 13, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 14, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 15, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 16, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 17, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 18, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 26, 19, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 08, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 09, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 10, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 11, 00, 00)
                    },


                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 12, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 13, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 14, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 15, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 16, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 17, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 18, 00, 00)
                    },

                    new TimeInfo
                    {
                        Time = new DateTime(2021, 3, 27, 19, 00, 00)
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
