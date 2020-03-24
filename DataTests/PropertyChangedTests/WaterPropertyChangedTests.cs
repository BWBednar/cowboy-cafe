using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var item = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForItems()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Items", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSubtotal()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Subtotal", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForToString()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Lemon", () =>
            {
                item.Lemon = false;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Lemon = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ice = false;
            });
        }
    }
}
