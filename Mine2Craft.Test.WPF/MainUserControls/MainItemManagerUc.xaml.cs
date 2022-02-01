using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Mine2Craft.Test.ClientRequestApiData;
using Mine2Craft.Test.Dtos;
using Mine2Craft.Test.Models;

namespace Mine2Craft.Test.WPF.MainUserControls
{
    /// <summary>
    /// Logique d'interaction pour MainItemManagerUc.xaml
    /// </summary>
    public partial class MainItemManagerUc : UserControl
    {
        private readonly IDataManager<ItemModel, ItemDto> _itemDataManager
                = ((App)Application.Current).ItemDataManager;

        public ItemListObservable ItemsList { get; set; } = new ItemListObservable();

        public ItemModel itemModel;


        public MainItemManagerUc()
        {
            InitializeComponent();
        }


        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUser();
        }

        public async void LoadUser()
        {
            var userModels = await _itemDataManager.GetAll();
            ItemsList.Items = new ObservableCollection<ItemModel>(userModels);
            // x:Name="LbElement" ItemsSource="{Binding listItems}"
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var itemModel = new ItemModel
            {
                Name = "ItemTest",
                Description = "ItemDescription",
                IsCombustible = 1,
                IsCooked = 0
            };

            _itemDataManager.Add(itemModel);
        }

    }
}
