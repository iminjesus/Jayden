//*********************************************************************
// Programmer: Jusuk Bang
// Date: 24 May 2020
// Software: Microsoft Visual Studio 2019 Version 16.4.5
// Platform: Microsoft Windows 10 Professional 64‐bit 
// Purpose:Develop Nested Array and implement a comparator
//*********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1D_array
{
    public partial class FrmMain : Form
    {
        Order order = new Order();//create new class object
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e) //create button that adds product
        {
            List<string> _orderLines = new List<string>();
            Order.OrderLine newItem = new Order.OrderLine();//create object newItem
            newItem.ProductName = txtName.Text; //insert newItem details
            newItem.Quantity = int.Parse(txtQuantity.Text);
            newItem.Price = double.Parse(txtPrice.Text);
            order.AddOrderLine(newItem);
            //check line total works well in nested class orderLIne
            txtTotal.Text = "Total order price of your new item is $" + newItem.OrderLineTotal(order).ToString();
        }

        private void displayitems()//display all ordered items
        {
            StringBuilder sb = new StringBuilder();//make object to display each array
            foreach (var i in order._orderLines)//Display sorted item
            {
                sb.AppendFormat(i.ProductName + "\t" + i.Price + "\t" + i.Quantity + "\r\n");
            }
            txtSort.Text = sb.ToString();
        }
        private void btnTotal_Click(object sender, EventArgs e)//Total order price of all products
        {
            txtDisplay.Text = "Total order price of your new item is $"+ order.OrderTotal().ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)//Sort items by alpabetical order
        {
            StringBuilder sb = new StringBuilder();//make object to display each array
            order._orderLines.Sort();//using comparator to sort
            displayitems();
        }
    }  
}
