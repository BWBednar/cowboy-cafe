﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var item = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Ketchup", () =>
            {
                item.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Mustard", () =>
            {
                item.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Pickle", () =>
            {
                item.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Cheese", () =>
            {
                item.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Cheese = false;
            });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Bun", () =>
            {
                item.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Bun = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Tomato", () =>
            {
                item.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Lettuce", () =>
            {
                item.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Mayo", () =>
            {
                item.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Mayo = false;
            });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Bacon", () =>
            {
                item.Bacon = false;
            });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Egg", () =>
            {
                item.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () =>
            {
                item.Egg = false;
            });
        }
    }
}
