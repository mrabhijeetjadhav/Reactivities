using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var MyActivities = new List<Activity>(){
            new Activity(){
                Id=1,
                Title="Title 1",
                Category = "category 1",
                Description = "description 1",
                City = "pune",
                Date=new DateTime(2023,4,4),
                Venue="venue 1",
            },
            new Activity(){
                Id=2,
                Title="Title 2",
                Category = "category 2",
                Description = "description 2",
                City = "banglore",
                Date=new DateTime(2023,4,4),
                Venue="venue 2",
            },
            new Activity(){
                Id=3,
                Title="Title 3",
                Category = "category 3",
                Description = "description 3",
                City = "pune",
                Date=new DateTime(2023,4,4),
                Venue="venue 3",
            },
            new Activity(){
                Id=4,
                Title="Title 4",
                Category = "category 4",
                Description = "description 4",
                City = "nashik",
                Date=new DateTime(2023,4,4),
                Venue="venue 4",
            },
            new Activity(){
                Id=5,
                Title="Title 5",
                Category = "category 5",
                Description = "description 5",
                City = "pune",
                Date=new DateTime(2023,4,4),
                Venue="venue 5",
            }
        };
            await context.Activities.AddRangeAsync(MyActivities);
            await context.SaveChangesAsync();
        }
    }
}