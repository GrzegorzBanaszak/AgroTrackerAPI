namespace AgroTrackerAPI.Dto.Crop;

public record CreateCropDto(Guid Id, string CropType, int SeasonYear);