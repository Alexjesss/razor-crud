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
                if (!context.Actor.Any())
                {
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

            using (var context = new RazorCrudActriceContext(serviceProvider.GetRequiredService<DbContextOptions<RazorCrudActriceContext>>()))
            {
                // Look for any actors.
                if (!context.Actrice.Any())
                {

                    context.Actrice.AddRange(
                    new Actrice
                    {
                        Name = "Alison Brie",
                        Movie = "Glow",
                        ReleaseDate = DateTime.Parse("2017-06-23"),
                    },

                    new Actrice
                    {
                        Name = "Vera Farmiga",
                        Movie = "Bates Motel",
                        ReleaseDate = DateTime.Parse("2013-03-18"),
                    },

                    new Actrice
                    {
                        Name = "Jenifer Aniston",
                        Movie = "Friends",
                        ReleaseDate = DateTime.Parse("1994-09-22"),
                    }
                    );
                context.SaveChanges();
            }
        }

            using (var context = new RazorCrudDirectorContext(serviceProvider.GetRequiredService<DbContextOptions<RazorCrudDirectorContext>>()))
            {
                // Look for any actors.
                if (!context.Director.Any())
                {

                    context.Director.AddRange(
                    new Director
                    {
                        Name = "Darren Aronofsky ",
                        Movie = "Requiem for a dream",
                        ReleaseDate = DateTime.Parse("2000-10-06"),
                    },

                    new Director
                    {
                        Name = "Alfred Hitchcock",
                        Movie = "Psycho",
                        ReleaseDate = DateTime.Parse("1960-09-08"),
                    },

                    new Director
                    {
                        Name = "Stanley Kubrick",
                        Movie = "The Shining",
                        ReleaseDate = DateTime.Parse("1980-06-13"),
                    }
                    );
                    context.SaveChanges();
                }
            }


        }
    }
}
