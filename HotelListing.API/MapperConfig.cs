using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.DTO_s;

namespace HotelListing.API
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Country,CountryDTO>().ReverseMap();   
        }
    }
}
