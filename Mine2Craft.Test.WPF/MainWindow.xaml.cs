using Mine2Craft.Test.WPF.Utils;
using Mine2Craft.Test.WPF.MainUserControls;
using System.Windows;

namespace Mine2Craft.Test.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public INavigator Navigator { get; set; } = ((App)Application.Current).Navigator;


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Navigator.NavigateTo(typeof(MainMenuUc));
        }

        private void GoBackClick(object sender, RoutedEventArgs e)
        {
            if (Navigator.CanGoBack())
            {
                Navigator.Back();
            }
        }


    }
}
