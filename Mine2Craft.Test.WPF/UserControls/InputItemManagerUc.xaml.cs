using System.Windows;
using System.Windows.Controls;
using Mine2Craft.Test.Models;

namespace Mine2Craft.Test.WPF.UserControls
{
    /// <summary>
    /// Logique d'interaction pour InputItemManagerUc.xaml
    /// </summary>
    public partial class InputItemManagerUc : UserControl
    {
        private static readonly DependencyProperty CurrentItemProperty =
            DependencyProperty.Register("CurrentItem", typeof(ItemModel), typeof(InputItemManagerUc));

        private ItemModel currentItem;
        public ItemModel CurrentItem
        {
            get { return GetValue(CurrentItemProperty) as ItemModel; }
            set
            {
                if (currentItem != value)
                {
                    SetValue(CurrentItemProperty, value);
                }
            }
        }

        public InputItemManagerUc()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
