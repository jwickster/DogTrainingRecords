using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Models;

public class Patrol
{
    
    //Scouting
    [Required, MaxLength(100)]
    public string ScoutLocation { get; set; } = "";

    [Required, MaxLength(100)]
    public string WindDirection { get; set; } = "";

    [Required, MaxLength(3)]
    public ushort WindSpeed { get; set; }

    [Required, MaxLength(5)]
    public ushort Temperature { get; set; }

    [Required, MaxLength(5)]
    public ushort Humidity { get; set; }

    [Required, MaxLength(5)]
    public ushort DecoySetTimeMinutes { get; set; }

    [Required, MaxLength(5)]
    public ushort DecoyFindTimeMinutes { get; set; }

    [Required]
    public bool SightScout { get; set; }

    [Required]
    public bool WindScout { get; set; }

    [Required]
    public bool SoundScout { get; set; }

    
    //Building Search
    [Required]
    public uint BuildingId { get; set; }

    [Required]
    public string BuildingName { get; set; } = "";

    [Required]
    public string BuildingType { get; set; } = "";

    [Required]
    public bool BuildingOccupied { get; set; }

    [Required]
    public string BuildingLocation { get; set; }

    
    //six phases of aggression
    
    [Required]
    public bool BiteAndHold { get; set; }
    
    [Required]
    public bool Standoff { get; set; }

    [Required]
    public bool Search { get; set; }

    [Required]
    public bool SearchAndReattack { get; set; }

    [Required]
    public bool OutOnCommand { get; set; }

    [Required]
    public bool SearchAndReattackEscort { get; set; }

    [Required]
    public bool FalseRun { get; set; }

    
    //Equipment
    [Required]
    public bool Bitesuit { get; set; }

    [Required]
    public bool HardSleeve { get; set; }

    [Required]
    public bool SoftSleeve { get; set; }

    [Required]
    public bool HiddenSleeve { get; set; }
    
    [Required]
    public bool Whip { get; set; }
    
    [Required]
    public bool AgitationStick { get; set; }
}