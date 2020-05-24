using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1D_array
{
    class Order
    {
        public List<OrderLine> _orderLines = new List<OrderLine>();
        //private int nextID = 1;
        //private double DiscountMultiplier = 0.85;

        public Order()
        { 
        }
        public List<OrderLine> GetList()
        {
            return _orderLines;
        }


        public void AddOrderLine(OrderLine line)
        {
            _orderLines.Add(line);

        }

        public double OrderTotal()
        {
            double total = 0;
            foreach (OrderLine line in _orderLines)
            {
                total += line.OrderLineTotal(this);
            }
            return total;
        }

        // Nested class
        internal class OrderLine : IComparable<OrderLine>
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public double OrderLineTotal(Order order)
            {
                return Math.Round(Price * Quantity);
            }
            public int CompareTo(OrderLine other)
            {
                // Alphabetic sort if salary is equal. [A to Z]
               /* if (this.ProductName == other.ProductName)
                {
                    return this.ProductName.CompareTo(other.ProductName);
                }
                // Default to salary sort. [High to low]
                return other.ProductName.CompareTo(this.ProductName);*/
                return String.Compare(this.ProductName, other.ProductName);
            }

            /*public override string ToString()
            {
                // String representation.
                return this.ProductName.ToString() + "," + this.ProductName;
            }*/
        }
    }
}
