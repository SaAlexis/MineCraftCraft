using AutoMapper;
using Mine2Craft.Test.Dtos;
using Mine2Craft.Test.Models;

namespace Mine2Craft.Test.WPF.Profile
{
    public class ModelProfile : AutoMapper.Profile
    {
        public ModelProfile()
        {
            CreateMap<ItemModel, ItemDto>().ReverseMap();
        }
    }
}
