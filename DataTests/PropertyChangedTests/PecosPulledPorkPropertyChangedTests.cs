using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var item = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var item = new AngryChicken();
            Assert.PropertyChanged(item, "Bread", () =>
            {
                item.Bread = false;
            });
        }

        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new AngryChicken();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Bread = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var item = new AngryChicken();
            Assert.PropertyChanged(item, "Pickle", () =>
            {
                item.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new AngryChicken();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Pickle = false;
            });
        }
    }
}
