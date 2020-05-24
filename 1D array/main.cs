//*********************************************************************
// Programmer: Jusuk Bang
// Date: 24 May 2020
// Software: Microsoft Visual Studio 2019 Version 16.4.5
// Platform: Microsoft Windows 10 Professional 64‐bit 
// Purpose:Develop Nested Array and implement a comparator
//*********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1D_array
{
    class Order
    {
        public List<OrderLine> _orderLines = new List<OrderLine>();//create orderLine array

        public Order()
        { 
        }
        public List<OrderLine> GetList() //Get product details
        {
            return _orderLines;
        }


        public void AddOrderLine(OrderLine line) //Add new Item
        {
            _orderLines.Add(line);
        }

        public double OrderTotal()//Calculate all order price by adding each line order amount
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
            public string ProductName { get; set; }//Define valiables of Orderline class
            public int Quantity { get; set; }
            public double Price { get; set; }

            public double OrderLineTotal(Order order)//calculate each line order amount
            {
                return Math.Round(Price * Quantity);
            }
            public int CompareTo(OrderLine other) // Alphabetic sort by using comparator
            {
                return String.Compare(this.ProductName, other.ProductName);
            }
        }
    }
}
