using AgroTrackerAPI.Dto.Crop;

namespace AgroTrackerAPI.Abstractions;


public interface ICropService
{
    public Task<IEnumerable<GetCropDto>> GetAll();
    public Task<GetCropDto?> GetById(Guid id);
    public Task<GetCropDto> Create(CreateCropDto cropDto);
    public Task<GetCropDto?> Update(Guid id, UpdateCropDto cropDto);
    public Task<bool> Delete(Guid id);
}