using System.Linq;

namespace HttpReplApi.Data
{
    public class SeedData
    {
        public static void Initialize(SampleContext context)
        {
            if (!context.People.Any())
            {
                context.People.AddRange(new Person(1, "Dave", "Brock"),
                                        new Person(2, "Carla", "Waters"),
                                        new Person(3, "Emma", "Johnston"),
                                        new Person(4, "Jenny", "Jennifer"),
                                        new Person(5, "Tony", "Stark")
                );

                context.SaveChanges();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie(1, "The Usual Suspects", 1995),
                    new Movie(2, "From Russia With Love", 1963),
                    new Movie(3, "Iron Man", 2008)
                );

                context.SaveChanges();
            }

            if (!context.Bands.Any())
            {
                context.Bands.AddRange(
                    new Band(1, "Led Zeppelin"),
                    new Band(2, "Arcade Fire"),
                    new Band(3, "The Who"),
                    new Band(4, "The Eagles, man")
                );

                context.SaveChanges();
            }
        }
    }
}
