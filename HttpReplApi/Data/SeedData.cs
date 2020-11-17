using HttpReplApi.Models;
using System.Linq;

namespace HttpReplApi.Data
{
    public class SeedData
    {
        public static void Initialize(SampleContext context)
        {
            if (!context.People.Any())
            {
                context.People.AddRange(
                    new Person { FirstName = "Dave", LastName = "Brock" },
                    new Person { FirstName = "Carla", LastName = "Waters" },
                    new Person { FirstName = "Emma", LastName = "Johnston" },
                    new Person { FirstName = "Jenny", LastName = "Jennifer"},
                    new Person { FirstName = "Tony", LastName = "Stark" }
                );

                context.SaveChanges();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie { Name = "The Usual Suspects", ReleaseYear = 1995 },
                    new Movie { Name = "From Russia With Love", ReleaseYear = 1963 },
                    new Movie { Name = "Iron Man", ReleaseYear = 2008 }
                );

                context.SaveChanges();
            }

            if (!context.Bands.Any())
            {
                context.Bands.AddRange(
                    new Band { Name = "Led Zeppelin" },
                    new Band { Name = "Arcade Fire" },
                    new Band { Name = "The Who" },
                    new Band { Name = "The Eagles, man" }
                );

                context.SaveChanges();
            }
        }
    }
}
