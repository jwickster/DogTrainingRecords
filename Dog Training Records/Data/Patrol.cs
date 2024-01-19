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
    
    
}