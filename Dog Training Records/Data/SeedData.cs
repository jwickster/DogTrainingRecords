using Dog_Training_Records.Models;

namespace Dog_Training_Records.Data;

internal static class SeedData
{
    internal static Task InitializeAsync(DogTrainingContext db)
    {
        DogInfo[] dogTeam =

                new()
                {
                    Tattoo = "S354",
                    DogName = "Athos",
                    Breed = "Belgium Malinois",
                    Age = 10,
                    Gender = "Male",
                    WhelpDateTime  = new DateTime(2014, 01, 19),
                },
                new()
                {
                    Tattoo = "X388",
                    Name = "Barco",
                    Breed = "Belgium Malinois",
                    Age = 8,
                    Gender = "Male",
                    WhelpDate = new DateTime(2016, 03, 12),
                },
                new()
                {
                    Tattoo = "B663",
                    Name = "Cody",
                    Breed = "German Shepherd",
                    Age = 6,
                    Gender = "Male",
                    WhelpDate = new DateTime(2018, 05, 23),
                },
                new()
                {
                    Tattoo = "F443",
                    Name = "Lilly",
                    Breed = "German Shepherd",
                    Age = 2,
                    Gender = "Female",
                    WhelpDate = new DateTime(2022, 01, 04),
                }
                
            

        
    }
}