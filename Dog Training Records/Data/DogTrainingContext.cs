using System.Data.Common;
using System.Data.Entity;
using Dog_Training_Records.Models;

namespace Dog_Training_Records.Data;

public sealed class DogTrainingContext : DbContext
{
    public DogTrainingContext(DbConnection connection) : base(connection, false)
    {
    }

    public DbSet<DogInfo> DogInfo { get; set; } = default!;
    public DbSet<HandlerInfo> HandlerInfo { get; set; } = default!;
    public DbSet<WeatherResponse> WeatherResponses { get; set; } = default!;
}