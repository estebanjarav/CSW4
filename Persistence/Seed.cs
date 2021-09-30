using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
           if(context.Activities.Any()) return;

           var activities = new List<Activity>
           {
               new Activity
               {
                 Title = "Actividad 1",
                 Date = DateTime.Now.AddMonths(-2),
                 Description = "Actividad realizada hace 2 meses",
                 Category = "Sw4",
                 City = "Med",
                 Venue = "TdeA"
               },
               new Activity
               {
                 Title = "Actividad 2",
                 Date = DateTime.Now.AddMonths(-1),
                 Description = "Actividad realizada hace 1 mes",
                 Category = "Sw4",
                 City = "Med",
                 Venue = "TdeA"
               },
               new Activity
               {
                 Title = "Actividad 3",
                 Date = DateTime.Now.AddMonths(1),
                 Description = "Actividad para realizar en 1 mes",
                 Category = "Sw4",
                 City = "Med",
                 Venue = "TdeA"
               },
               new Activity
               {
                 Title = "Actividad 4",
                 Date = DateTime.Now.AddMonths(2),
                 Description = "Actividad para realizar en 2 meses",
                 Category = "Sw4",
                 City = "Med",
                 Venue = "TdeA"
               }
           };

           await context.Activities.AddRangeAsync(activities);
           await context.SaveChangesAsync();

        }
    }
}