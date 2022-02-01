using AutoMapper;
using System.Net.Http.Json; 

namespace Mine2Craft.Test.ClientRequestApiData
{
    public abstract class ApiDataManager<TModel, TDto> : IDataManager<TModel, TDto> where TModel : class where TDto : class
    {
        private HttpClient HttpClient { get; }
        private IMapper Mapper { get; }
        private string ServerUrl { get; }
        private string ResourceUrl { get; }

        private Uri Uri { get; }

        public ApiDataManager(HttpClient client, IMapper mapper, string serverUrl, string resourceUrl)
        {
            HttpClient = client;
            Mapper = mapper;
            ServerUrl = serverUrl;
            ResourceUrl = resourceUrl;
            Uri = new Uri(ServerUrl + ResourceUrl); 
        }


        public async Task<IEnumerable<TModel>> GetAll()
        {
            var result = await HttpClient.GetFromJsonAsync<IEnumerable<TDto>>(Uri);
            return Mapper.Map<IEnumerable<TModel>>(result);
        }

        public async Task Add(TModel model)
        {
            var dto = Mapper.Map<TDto>(model); 
            await HttpClient.PostAsJsonAsync(Uri,dto);
        }

        public async Task Delete(Guid guid)
        {
            string sguid = "/" + guid.ToString();
            var uriDelete = new Uri(Uri + sguid);
            await HttpClient.DeleteAsync(uriDelete);
        }

        public async Task Update(TModel model, Guid guid)
        {
            
            var dto = Mapper.Map<TDto>(model);


            string sguid = "/" + guid.ToString();
            var uriUpdate = new Uri(Uri + sguid);

            await HttpClient.PutAsJsonAsync(uriUpdate, dto);
        }
    }
}