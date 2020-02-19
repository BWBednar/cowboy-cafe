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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += AddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += AddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += AddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += AddAngryChickenButtonClicked;
        }

        /// <summary>
        /// Click event for the Cowpoke Chili entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Click event for the Rustlers Ribs entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Click event for the Pecos Pulled Pork entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Click event for the Trail Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Click event for the Dakota Double Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Click event for the Texas Triple Burger entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Click event for the Angry Chicken entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

    }
}
