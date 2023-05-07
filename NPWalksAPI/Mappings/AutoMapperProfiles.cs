using AutoMapper;
using HidaaiAPI.Models.Domain;
using HidaaiAPI.Models.DTO;

namespace HidaaiAPI.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto,Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto,Region>().ReverseMap();
        }
    }
}
