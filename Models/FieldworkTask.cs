namespace AgroTrackerAPI.Models;

public class FieldworkTask
{
    public Guid Id { get; set; }
    public string OperationType { get; set; } = string.Empty;
    public DateTime DatePerformed { get; set; }
    public string? Notes { get; set; }

    // Klucz obcy do Uprawy
    public Guid CropId { get; set; }
    public Crop? Crop { get; set; }
}