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
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        public CustomizeJerkedSoda()
        {
            InitializeComponent();
            Small.Click += ChangeSize;
            Medium.Click += ChangeSize;
            Large.Click += ChangeSize;

            CreamSoda.Click += ChangeFlavor;
            OrangeSoda.Click += ChangeFlavor;
            Sarsparilla.Click += ChangeFlavor;
            BirchBeer.Click += ChangeFlavor;
            RootBeer.Click += ChangeFlavor;
        }

        /// <summary>
        /// Method to communicate which size the user selects for the item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSize(object sender, RoutedEventArgs e)
        {
            var item = DataContext as Drink;
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

        /// <summary>
        /// Method to communicate which flavor the user selects for the Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeFlavor(object sender, RoutedEventArgs e)
        {
            var item = DataContext as JerkedSoda;
            if (sender is RadioButton button)
            {
                switch (button.Name)
                {
                    case "CreamSoda":
                        item.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
                        break;
                    case "OrangeSoda":
                        item.Flavor = CowboyCafe.Data.SodaFlavor.OrangeSoda;
                        break;
                    case "Sarsparilla":
                        item.Flavor = CowboyCafe.Data.SodaFlavor.Sarsparilla;
                        break;
                    case "BirchBeer":
                        item.Flavor = CowboyCafe.Data.SodaFlavor.BirchBeer;
                        break;
                    case "RootBeer":
                        item.Flavor = CowboyCafe.Data.SodaFlavor.RootBeer;
                        break;
                    default:
                        item.Flavor = CowboyCafe.Data.SodaFlavor.CreamSoda;
                        break;
                }
            }
        }
    }
}
