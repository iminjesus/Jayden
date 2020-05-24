//*********************************************************************
// Programmer: Jusuk Bang
// Date: 05 May 2020
// Software: Microsoft Visual Studio 2019 Version 16.4.5
// Platform: Microsoft Windows 10 Professional 64‐bit 
// Purpose:Develop 1D array with different data type
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
        Order order = new Order();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            List<string> _orderLines = new List<string>();

            //Order.OrderLine line1 = new Order.OrderLine();
            Order.OrderLine newItem = new Order.OrderLine();
            newItem.ProductName = txtName.Text;
            newItem.Quantity = int.Parse(txtQuantity.Text);
            newItem.Price = double.Parse(txtPrice.Text);
            order.AddOrderLine(newItem);
            txtTotal.Text = newItem.OrderLineTotal(order).ToString();
          

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = order.OrderTotal().ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> _orderLines = new List<string>();
            order._orderLines.Sort();
                foreach(var i in order._orderLines)
                { 
                sb.AppendFormat(i.ProductName +"\t"+ i.Price + "\t" + i.Quantity + "\r\n"); 
                }
            txtSort.Text = sb.ToString();
        }
    }
    
}
