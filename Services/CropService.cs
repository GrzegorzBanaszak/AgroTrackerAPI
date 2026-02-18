using AgroTrackerAPI.Abstractions;
using AgroTrackerAPI.Data;
using AgroTrackerAPI.Dto.Crop;
using AgroTrackerAPI.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AgroTrackerAPI.Service;


public class CropService : ICropService
{

    private readonly AgroDbContext _context;
    private readonly IMapper _mapper;

    public CropService(AgroDbContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<IEnumerable<GetCropDto>> GetAll()
    {
        return _mapper.Map<IEnumerable<GetCropDto>>(await _context.Crops.ToListAsync());
    }

    public async Task<GetCropDto?> GetById(Guid id)
    {
        var crop = await _context.Crops.FirstOrDefaultAsync(c => c.Id == id);

        if (crop == null)
            return null;
        return _mapper.Map<GetCropDto>(crop);


    }
    public async Task<GetCropDto> Create(CreateCropDto cropDto)
    {
        var crop = _mapper.Map<Crop>(cropDto);
        _context.Crops.Add(crop);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetCropDto>(crop);
    }

    public async Task<GetCropDto?> Update(Guid id, UpdateCropDto cropDto)
    {
        var crop = await _context.Crops.FirstOrDefaultAsync(c => c.Id == id);

        if (crop == null)
            return null;

        _mapper.Map(cropDto, crop);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetCropDto>(crop);
    }
    public async Task<bool> Delete(Guid id)
    {
        var crop = await _context.Crops.FirstOrDefaultAsync(c => c.Id == id);
        if (crop == null)
            return false;
        _context.Crops.Remove(crop);
        await _context.SaveChangesAsync();
        return true;
    }

}