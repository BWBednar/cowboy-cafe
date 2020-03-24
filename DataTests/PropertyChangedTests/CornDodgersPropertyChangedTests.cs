using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var item = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForItems()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Items", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSubtotal()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Subtotal", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForToString()
        {
            var item = new CornDodgers();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Size = Size.Large;
            });
        }
    }
}
