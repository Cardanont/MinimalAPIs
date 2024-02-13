using AutoMapper;
using RPG_MinAPI.Models;
using RPG_MinAPI.Models.DTOs;

namespace RPG_MinAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Champion, ChampionCreateDTO>().ReverseMap();
        }
    }
}
