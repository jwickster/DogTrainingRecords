namespace Dog_Training_Records.Data;

public class Patrol
{
    
    string ScoutLocation { get; set; }
    string WindDirection { get; set; }
    ushort WindSpeed { get; set; }
    ushort Temperature { get; set; }
    ushort Humidity { get; set; }
    ushort DecoySetTime { get; set; }
    ushort DecoyFindTime { get; set; }

    uint BuildingID { get; set; }
    string BuildingName { get; set; }
    string BuildingType { get; set; }
    string BuildingStatus { get; set; }
    string BuildingLocation { get; set; }
    string BuildingOwner { get; set; }
    string BuildingOwnerEmail { get; set; }
    string BuildingOwnerPhone { get; set; }
    string BuildingManager { get; set; }
    
    



}
