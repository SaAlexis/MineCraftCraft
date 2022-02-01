using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Mine2Craft.Test.ClientRequestApiData;
using Mine2Craft.Test.Dtos;
using Mine2Craft.Test.Models;
using Mine2Craft.Test.WPF.Utils;

namespace Mine2Craft.Test.WPF.MainUserControls
{
    /// <summary>
    /// Logique d'interaction pour ItemManagerUc.xaml
    /// </summary>
    public partial class ItemManagerUc : UserControl
    {

        private readonly IDataManager<ItemModel, ItemDto> _itemDataManager
                = ((App)Application.Current).ItemDataManager;

        public ItemListObservable ItemsList { get; set; } = new ItemListObservable();

        public ItemModel itemModel;

        public INavigator Navigator { get; set; } = ((App)Application.Current).Navigator;


        public ItemManagerUc()
        {
            InitializeComponent();
            DataContext = this;
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUser();
        }

        public async void LoadUser()
        {
            var itemModels = await _itemDataManager.GetAll();
            ItemsList.Items = new ObservableCollection<ItemModel>(itemModels);

            tbNameItem.Text = "New Item";
            tbDescItem.Text = "New Desc Item";
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(typeof(MainMenuUc));
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DELETE");
        }

        private async void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            var newItem = new ItemModel()
            {
                Name = tbNameItem.Text,
                Description = tbDescItem.Text,
                IsCombustible = 1,
                IsCooked = 0
            };

            ItemsList.Items.Add(newItem);
            await _itemDataManager.Add(newItem);

            //var itemModel = new ItemModel
            //{
            //    Name = "ItemTest",
            //    Description = "ItemDescription",
            //    isCombustible = 1
            //};

            //_itemDataManager.Add(itemModel);

        }
    }
}
