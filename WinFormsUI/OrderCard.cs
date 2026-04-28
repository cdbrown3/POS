using System;
using Backend.Controller;
using Backend.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class OrderCard : UserControl
    {
        CookWindow Cook;
        List<OrderInfo> orders;
        List<OrderItemInfo> OrderItems;
        List<MenuItemInfo> Menu;
        List<MenuItemInfo> Items;
        MenuItemInfo menuItem;
        public OrderCard(CookWindow cook, OrderInfo order)
        {
            InitializeComponent();
            this.Cook = cook;
            OrderItems = Testing.LoadOrderItemsFromCSV("OrderItems.txt");
            OrderNumButton.Text = "Order Number:\n" + order.OrderID;
            foreach (OrderItemInfo item in order.Items)
            {
                string itemname = item.MenuItem.Name;
                listBox1.Items.Add(itemname);
                // String 
            }
        }
    }
}
