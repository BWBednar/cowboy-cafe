using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var item = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForItems()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Items", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSubtotal()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Subtotal", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForToString()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForItems()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Items", () =>
            {
                item.Flavor = SodaFlavor.OrangeSoda;
            });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForFlavor()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Flavor", () =>
            {
                item.Flavor = SodaFlavor.OrangeSoda;
            });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForToString()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Flavor = SodaFlavor.OrangeSoda;
            });
        }
    }
}
