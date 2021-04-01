using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCrud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudActorContext(serviceProvider.GetRequiredService<DbContextOptions<RazorCrudActorContext>>()))
            {
                // Look for any actors.
                if (context.Actor.Any())
                {
                    return;   // DB has been seeded
                }

                context.Actor.AddRange(
                    new Actor
                    {
                        Name = "Philip Seymour Hoffman",
                        Movie = "Happiness",
                        ReleaseDate = DateTime.Parse("1998-10-16"),
                    },

                    new Actor
                    {
                        Name = "Jack Nicholson",
                        Movie = "One Flew Over the Cuckoo's Nest",
                        ReleaseDate = DateTime.Parse("1975-11-19"),
                    },

                    new Actor
                    {
                        Name = "Ethan Hawke",
                        Movie = "Gattaca",
                        ReleaseDate = DateTime.Parse("1997-10-24"),
                    },

                    new Actor
                    {
                        Name = "Kevin Bacon",
                        Movie = "Flatliners",
                        ReleaseDate = DateTime.Parse("1990-8-10"),
                    }
                );
                context.SaveChanges();
            }


        }
    }
}
