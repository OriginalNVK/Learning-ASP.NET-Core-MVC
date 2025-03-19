using AutoMapper;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTOs;

namespace NZWalks.API.Mappings
{
    public class AutomapperProfilie : Profile
    {
        public AutomapperProfilie() { 
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDTO, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDTO, Region>().ReverseMap(); 
            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();
            CreateMap<DifficultyDto, Difficulty>().ReverseMap();
            CreateMap<UpdateWalkRequestDTO, Walk>().ReverseMap();
        }

    }
}
