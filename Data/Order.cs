using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order
    {
        private static uint lastOrderNumber = 0;

        private List<IOrderItem> items;

        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public double Subtotal => 0;
        
        public uint OrderNumber { get => lastOrderNumber; }

        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }
    }
}
