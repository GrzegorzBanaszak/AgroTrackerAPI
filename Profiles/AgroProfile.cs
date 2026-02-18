using AgroTrackerAPI.Dto.Crop;
using AgroTrackerAPI.Models;
using AutoMapper;

namespace AgroTrackerAPI.Profiles;


public class AgroProfile : Profile
{
    public AgroProfile()
    {
        CreateMap<Crop, GetCropDto>();
        CreateMap<CreateCropDto, Crop>();
        CreateMap<UpdateCropDto, Crop>();

    }
}