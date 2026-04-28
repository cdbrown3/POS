using Backend.Model;
using System;
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
    public partial class BaseOrderView : UserControl
    {
        MainWindow Instance;
        OrderInfo PotOrder;
        MenuItemInfo Menuitem;
        List<CustomerInfo> CustomerList;
        List<EmployeeInfo> EmployeeList;
        public BaseOrderView(MainWindow instance)
        {
            this.Instance = instance;
            InitializeComponent();
        }
        public BaseOrderView(MainWindow instance, List<MenuItem> menuitems) : this(instance) 
            // passes instance to be able to change fields within the mainWindow, passes List to add into the panel
        {
            foreach (MenuItem menuitem in menuitems)
            {
                flowLayoutPanel1.Controls.Add(menuitem);
            }
            this.Menuitem = Instance.SelectedMenuItem;
            this.CustomerList = Instance.CustomerList;
            this.EmployeeList = Instance.EmployeeList;
            this.PotOrder = Instance.PotOrder;
            if (Instance.ispressed == true)
            {
                label1.Visible = true;
                numericUpDown1.Visible = true;
            }
        }

        private void HamburgerButton_Click(object sender, EventArgs e)
        {
        }

        private void TacosButton_Click(object sender, EventArgs e)
        {
        }

        private void ConfirmOrderItemButton_Click(object sender, EventArgs e)
            // Button that confirms an item being added into a order
        {
            int value = ((int)numericUpDown1.Value);
            if (value > 0)
            {
                this.PotOrder.AddItem(new OrderItemInfo(this.Menuitem, value, new List<String>(0)));
                Instance.PotOrder = this.PotOrder;
                double ItemTotal = value * this.Menuitem.Price;
                foreach (OrderItemInfo item in Instance.PotOrder.Items) {
                    OrderTextBox.AppendText(item.MenuItem.Name + "(" + item.Quantity +"): " + item.LineTotal + '\n');
                }
                numericUpDown1.Value = 0;
                label1.Visible = false;
                numericUpDown1.Visible = false;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
            // button that finishes the order 
        {
            Instance.ispressed = false;
            Instance.ReloadListBox();
            if (this.PotOrder.Items.Count == 0)
            {

            }
            else
            {
                Instance.OrderList.Add(this.PotOrder);
                OrderConfirmationWindow window = new OrderConfirmationWindow(this.PotOrder);
                window.Show(); // a window showing confirmation of the order that was just made
            }
        }
    }
}
