using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeChiliCheeseFries.xaml
    /// </summary>
    public partial class CustomizeChiliCheeseFries : UserControl
    {
        public CustomizeChiliCheeseFries()
        {
            InitializeComponent();
            Small.Click += ChangeSize;
            Medium.Click += ChangeSize;
            Large.Click += ChangeSize;
        }

        /// <summary>
        /// Method to communicate which size the user selects for the item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSize(object sender, RoutedEventArgs e)
        {
            var item = DataContext as Side;
            if (sender is RadioButton button)
            {
                switch (button.Name)
                {
                    case "Small":
                        item.Size = CowboyCafe.Data.Size.Small;
                        break;
                    case "Medium":
                        item.Size = CowboyCafe.Data.Size.Medium;
                        break;
                    case "Large":
                        item.Size = CowboyCafe.Data.Size.Large;
                        break;
                    default:
                        item.Size = CowboyCafe.Data.Size.Small;
                        break;
                }

            }
        }
    }
}
