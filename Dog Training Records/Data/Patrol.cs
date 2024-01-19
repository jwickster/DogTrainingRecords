namespace Dog_Training_Records.Data;

public class Patrol
{

    //Scouting
    string ScoutLocation { get; set; }
    string WindDirection { get; set; }
    ushort WindSpeed { get; set; }
    ushort Temperature { get; set; }
    ushort Humidity { get; set; }
    ushort DecoySetTime { get; set; }
    ushort DecoyFindTime { get; set; }
    //sight scout
    bool SightScout { get; set; }
    //wind scout
    bool WindScout { get; set; }
    //sound scout
    bool SoundScout { get; set; }

    //Building Search
    uint BuildingID { get; set; }
    string BuildingName { get; set; }
    string BuildingType { get; set; }
    bool BuildingOccupied { get; set; }
    string BuildingLocation { get; set; }

    //6 phases of controlled aggregation

    //standoff
    bool Standoff { get; set; }
    //search
    bool Search { get; set; }
    //Search and reattack
    bool SearchAndReattack { get; set; }
    //out on command
    bool OutOnCommand { get; set; }
    //escort
    bool SearchAndReattackEscort { get; set; }
    //false run
    bool FalseRun { get; set; }

    //Decoy
    bool Bitesuit { get; set; }

    //hard sleeve
    bool HardSleeve { get; set; }

    //soft sleeve
    bool SoftSleeve { get; set; }

    //hidden sleeve
    bool HiddenSleeve { get; set; }



}
