namespace Dog_Training_Records.Data;

public class DogDetection
{
    
    public string DetectionType { get; set; }
    string DetectionAid { get; set; }
    string DetectionLocation { get; set; }
    string DetectionNotes { get; set; }
    DateTime DetectionDate { get; set; }
    string DetectionTime { get; set; }
    bool ActualFind { get; set; }
    bool FalseAlert { get; set; }
    bool MissedFind { get; set; }
    bool OtherExplosive { get; set; }
    string ExplosiveAide { get; set; }
    string ExplosiveLocation { get; set; }
    string ExplosiveOdor { get; set; }
    string NarcocticAide { get; set; }
    string NarcoticLocation { get; set; }
    string NarcoticOdor { get; set; }
    string OtherNarcoticAide { get; set; }
    
}