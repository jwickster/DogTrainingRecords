using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Models;

/// <summary>
/// This class represents the training aide data in the database.
/// </summary>
public class TrainingAide
{
    /// <summary>
    /// This property represents the training aid plant time.
    /// </summary>
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantTime { get; set; } = default!;

    /// <summary>
    /// This property represents the training aid plant height.
    /// </summary>
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantHeight { get; set; } = default!;

    /// <summary>
    /// This property represents the training aid plant depth.
    /// </summary>
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantDepth { get; set; } = default!;

    /// <summary>
    /// This property represents the training aide plant set time.
    /// </summary>
    [Required, MaxLength(5)]
    public decimal TrainingAidPlantSetTime { get; set; } = default!;

}