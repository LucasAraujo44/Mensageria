using AutoMapper;
using ItemService.Dtos;
using ItemService.Models;
using System.Security;

namespace ItemService.Profiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<RestauranteReadDto, Restaurante>().
                ForMember(dest => dest.IdExterno, opt => opt.MapFrom(src => src.Id));
            CreateMap<Restaurante, RestauranteReadDto>();
            CreateMap<ItemCreateDto, Item>();
            CreateMap<Item, ItemCreateDto>();
        }
    }
}