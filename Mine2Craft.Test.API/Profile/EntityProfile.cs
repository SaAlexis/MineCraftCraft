using AutoMapper;
using Mine2Craft.Test.Dtos;
using Mine2Craft.Test.Entities;

namespace Mine2Craft.Test.API.Profile
{
    public class EntityProfile : AutoMapper.Profile
    {
        public EntityProfile()
        {
            CreateMap<ItemEntity, ItemDto>().ReverseMap();
        }
    }
}
