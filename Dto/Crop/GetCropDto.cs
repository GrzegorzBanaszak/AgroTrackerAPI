namespace AgroTrackerAPI.Dto.Crop;

public record GetCropDto(Guid Id, string CropType, int SeasonYear);
