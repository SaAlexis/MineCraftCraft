using AutoMapper;
using System.Net.Http;
using System.Windows;
using Mine2Craft.Test.Dtos;
using Mine2Craft.Test.Models;
using Mine2Craft.Test.ClientRequestApiData;
using Mine2Craft.Test.WPF.MainUserControls;
using Mine2Craft.Test.WPF.Utils;


namespace Mine2Craft.Test.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string SERVER_URL = "https://localhost:7190"; 

        public HttpClient HttpClient { get; } = new HttpClient();

        public IDataManager<ItemModel, ItemDto> ItemDataManager { get; }

        public IMapper Mapper { get; }

        public INavigator Navigator { get; } = new Navigator();

        public App()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddMaps(typeof(App)));
            Mapper = new Mapper(configuration);
            ItemDataManager = new ItemDataManager(HttpClient, Mapper, SERVER_URL);
        }

        private void App_OnStartup(object sender, StartupEventArgs e) // bind le Startup="App_OnStartup" dans le fichier app.xaml 
        {
            Navigator.RegisterView(new ItemManagerUc());
            Navigator.RegisterView(new MainMenuUc());
        }
    }   
}
