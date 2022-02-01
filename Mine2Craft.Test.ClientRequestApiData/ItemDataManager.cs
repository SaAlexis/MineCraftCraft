using AutoMapper;
using Mine2Craft.Test.Dtos;
using Mine2Craft.Test.Models;

namespace Mine2Craft.Test.ClientRequestApiData
{
    public class ItemDataManager : ApiDataManager<ItemModel, ItemDto>
    {
        public ItemDataManager(HttpClient client, IMapper mapper, string serverUrl) 
            : base(client, mapper, serverUrl, "/api/item")
        {
        }
    }
}
