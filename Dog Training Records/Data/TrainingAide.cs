using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class TrainingAide
{
    //training aid plant time
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantTime { get; set; } = default!;
    
    //training aid plant height
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantHeight { get; set; } = default!;
    
    //training aid plant depth
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantDepth { get; set; } = default!;
    
    //training aide plant set time
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantSetTime { get; set; } = default!;
    

}