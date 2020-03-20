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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBakedBeans.xaml
    /// </summary>
    public partial class CustomizeBakedBeans : UserControl
    {
        /// <summary>
        /// Initialize the CustomizeBakedBeans control
        /// </summary>
        public CustomizeBakedBeans()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for when the size of the item has been changed
        /// </summary>
        /// <param name="sender">The item being selected</param>
        /// <param name="e">The event args</param>
        void ChangeItemSize(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();
            if (ancestor is OrderControl)
            {
                ancestor.ItemChange();
            }
        }
    }
}
