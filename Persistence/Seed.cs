using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public  static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;   

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Act 1",
                    Date = System.DateTime.Now.AddMonths(-2),
                    Description = "Act Rea Hace Dos Meses",
                    Category = "Sodt 4",
                    City = "Med",
                    Venue = "TdeA"
                },

                                new Activity
                {
                    Title = "Act 2",
                    Date = System.DateTime.Now.AddMonths(-1),
                    Description = "Act Rea Hace 1 Meses",
                    Category = "Sodt 4",
                    City = "Med",
                    Venue = "TdeA"
                },

                                new Activity
                {
                    Title = "Act 3",
                    Date = System.DateTime.Now.AddMonths(+2),
                    Description = "Act Rea Hace Dos Meses",
                    Category = "Sodt 4",
                    City = "Med",
                    Venue = "TdeA"
                }

            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync(); 
        }
    }
}