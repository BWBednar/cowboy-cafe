using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class OrderPropertyChangedTests
    {
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void AddingToOrderShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            var item = new AngryChicken();
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Add(item);
            });
        }

        [Fact]
        public void AddingToOrderShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            var item = new AngryChicken();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(item);
            });
        }

        [Fact]
        public void RemovingOrderShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            var item = new AngryChicken();
            order.Add(item);
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Remove(item);
            });
        }

        [Fact]
        public void RemovingOrderShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            var item = new AngryChicken();
            order.Add(item);
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(item);
            });
        }

        [Fact]
        public void CallingNotifyItemChangeShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.NotifyItemChange();
            });
        }

        [Fact]
        public void CallingNotifyItemChangeShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.NotifyItemChange();
            });
        }
    }
}
