using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var item = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForItems()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Items", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSubtotal()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Subtotal", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForToString()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = true;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ice = true;
            });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Decaf", () =>
            {
                item.Decaf = true;
            });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForItems()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Items", () =>
            {
                item.Decaf = true;
            });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForToString()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Decaf = true;
            });
        }
    }
}
