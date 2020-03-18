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
    /// Interaction logic for CustomizeCornDodgers.xaml
    /// </summary>
    public partial class CustomizeCornDodgers : UserControl
    {
        public CustomizeCornDodgers()
        {
            InitializeComponent();

            Confirm.Click += ChangeItemSize;
        }

        /// <summary>
        /// Click event for when the size of the item has been confirmed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChangeItemSize(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();
            if (ancestor is OrderControl)
            {
                ancestor.ItemEnumChange();
            }
        }
    }
}
