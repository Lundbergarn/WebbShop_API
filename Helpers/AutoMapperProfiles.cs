using AutoMapper;
using WebbShop_API.Dtos;
using WebbShop_API.Models;

namespace WebbShop_API.Helpers
{
  public class AutoMapperProfiles : Profile
  {
    public AutoMapperProfiles()
    {
      CreateMap<Customer, CustomerDto>();

    }
  }
}