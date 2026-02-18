namespace AgroTrackerAPI.Models;

public class Field
{
    public Guid Id { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public double AreaInHectares { get; private set; }

    public List<Crop> Crops { get; set; } = new List<Crop>();

}