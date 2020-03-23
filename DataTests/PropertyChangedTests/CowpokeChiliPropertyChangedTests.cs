using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        [Fact]
        public void CowpokeChiliShoulImplementINotifyPropertyChanged()
        {
            var item = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "Cheese", () =>
            {
                item.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Cheese = false;
            });
        }

        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SourCream", () =>
            {
                item.SourCream = false;
            });
        }

        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.SourCream = false;
            });
        }

        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "GreenOnions", () =>
            {
                item.GreenOnions = false;
            });
        }

        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.GreenOnions = false;
            });
        }

        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "TortillaStrips", () =>
            {
                item.TortillaStrips = false;
            });
        }

        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new CowpokeChili();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.TortillaStrips = false;
            });
        }
    }
}
