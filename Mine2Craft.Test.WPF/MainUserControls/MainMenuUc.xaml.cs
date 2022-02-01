using Mine2Craft.Test.WPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Mine2Craft.Test.WPF.Utils;
using Mine2Craft.Test.WPF.MainUserControls;
using System.Windows;
using System.Windows.Controls;

namespace Mine2Craft.Test.WPF.MainUserControls
{
    /// <summary>
    /// Logique d'interaction pour MainMenuUc.xaml
    /// </summary>
    public partial class MainMenuUc : UserControl
    {
        public INavigator Navigator { get; set; } = ((App)Application.Current).Navigator;


        public MainMenuUc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(typeof(ItemManagerUc));
        }
    }
}
