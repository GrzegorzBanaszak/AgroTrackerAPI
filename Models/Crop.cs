namespace AgroTrackerAPI.Models;

public class Crop
{
    public Guid Id { get; private set; }
    public string CropType { get; private set; } = string.Empty;
    public int SeasonYear { get; private set; }

    // Klucz obcy do Pola
    public Guid FieldId { get; set; }
    public Field? Field { get; set; }

    public List<FieldworkTask> FieldworkTasks { get; set; } = new List<FieldworkTask>();

}