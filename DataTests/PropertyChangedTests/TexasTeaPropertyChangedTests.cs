using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var item = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Size", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Price", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Calories", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForToString()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Sweet", () =>
            {
                item.Sweet = false;
            });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForToString()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "ToString", () =>
            {
                item.Sweet = false;
            });
        }


        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Lemon", () =>
            {
                item.Lemon = false;
            });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Lemon = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Ice", () =>
            {
                item.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ice = false;
            });
        }
    }
}

