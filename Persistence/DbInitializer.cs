﻿using Domain;

namespace Persistence;

public abstract class DbInitializer
{
    private const string _londonCity = "London";
    public static async Task SeedData(ApplicationDbContext context)
    {
        if (context.Activities.Any())
        {
            return;
        }

        var activities = new List<Activity>
        {
            new()
            {
                Title = "Past Activity 1",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 months ago",
                Category = "drinks",
                City = _londonCity,
                Vanue =
                    "The Lamb and Flag, 33, Rose Street, Seven Dials, Covent Garden, London, Greater London, England, WC2E 9EB, United Kingdom",
                Latitude = 51.51171665,
                Longitude = -0.1256611057818921,
            },
            new()
            {
                Title = "Past Activity 2",
                Date = DateTime.Now.AddMonths(-1),
                Description = "Activity 1 month ago",
                Category = "culture",
                City = "Paris",
                Vanue =
                    "Louvre Museum, Rue Saint-Honoré, Quartier du Palais Royal, 1st Arrondissement, Paris, Ile-de-France, Metropolitan France, 75001, France",
                Latitude = 48.8611473,
                Longitude = 2.33802768704666
            },
            new()
            {
                Title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(1),
                Description = "Activity 1 month in future",
                Category = "culture",
                City = _londonCity,
                Vanue = "Natural History Museum",
                Latitude = 51.496510900000004,
                Longitude = -0.17600190725447445
            },
            new()
            {
                Title = "Future Activity 2",
                Date = DateTime.Now.AddMonths(2),
                Description = "Activity 2 months in future",
                Category = "music",
                City = _londonCity,
                Vanue = "The O2",
                Latitude = 51.502936649999995,
                Longitude = 0.0032029278126681844
            },
            new()
            {
                Title = "Future Activity 3",
                Date = DateTime.Now.AddMonths(3),
                Description = "Activity 3 months in future",
                Category = "drinks",
                City = _londonCity,
                Vanue = "The Mayflower",
                Latitude = 51.501778,
                Longitude = -0.053577
            },
            new()
            {
                Title = "Future Activity 4",
                Date = DateTime.Now.AddMonths(4),
                Description = "Activity 4 months in future",
                Category = "drinks",
                City = _londonCity,
                Vanue = "The Blackfriar",
                Latitude = 51.512146650000005,
                Longitude = -0.10364680647106028
            },
            new()
            {
                Title = "Future Activity 5",
                Date = DateTime.Now.AddMonths(5),
                Description = "Activity 5 months in future",
                Category = "culture",
                City = _londonCity,
                Vanue =
                    "Sherlock Holmes Museum, 221b, Baker Street, Marylebone, London, Greater London, England, NW1 6XE, United Kingdom",
                Latitude = 51.5237629,
                Longitude = -0.1584743
            },
            new()
            {
                Title = "Future Activity 6",
                Date = DateTime.Now.AddMonths(6),
                Description = "Activity 6 months in future",
                Category = "music",
                City = _londonCity,
                Vanue =
                    "Roundhouse, Chalk Farm Road, Maitland Park, Chalk Farm, London Borough of Camden, London, Greater London, England, NW1 8EH, United Kingdom",
                Latitude = 51.5432505,
                Longitude = -0.15197608174931165
            },
            new()
            {
                Title = "Future Activity 7",
                Date = DateTime.Now.AddMonths(7),
                Description = "Activity 2 months ago",
                Category = "travel",
                City = _londonCity,
                Vanue = "River Thames, England, United Kingdom",
                Latitude = 51.5575525,
                Longitude = -0.781404
            },
            new()
            {
                Title = "Future Activity 8",
                Date = DateTime.Now.AddMonths(8),
                Description = "Activity 8 months in future",
                Category = "film",
                City = _londonCity,
                Vanue = "River Thames, England, United Kingdom",
                Latitude = 51.5575525,
                Longitude = -0.781404
            }
        };

        context.Activities.AddRange(activities);
        await context.SaveChangesAsync();
    }
}