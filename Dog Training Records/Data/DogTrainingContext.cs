using System.Data.Common;
using System.Data.Entity;
using Dog_Training_Records.Models;

namespace Dog_Training_Records.Data;

public sealed class DogTrainingContext : DbContext
{
    public DogTrainingContext(DbConnection connection) : base(connection, false)
    {
        Database.SetInitializer<DogTrainingContext>(null);
        Configuration.LazyLoadingEnabled = false;
        Configuration.ProxyCreationEnabled = false;
        connection.ConnectionString = "Server=localhost;Database=DogTrainingRecords;Trusted_Connection=True;";
    }

    public DbSet<DogInfo> DogInfo { get; set; } = default!;
    public DbSet<HandlerInfo> HandlerInfo { get; set; } = default!;
    public DbSet<WeatherResponse> WeatherResponses { get; set; } = default!;
    public DbSet<Narcotics> Narcotics { get; set; } = default!;
    public DbSet<Explosives> Explosives { get; set; } = default!;
    public DbSet<Patrol> Patrol{ get; set; } = default!;
    public DbSet<TrainingAide> TrainingAide { get; set; } = default!;
}