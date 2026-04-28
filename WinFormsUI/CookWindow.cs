using Backend.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsUI
{
    public partial class CookWindow : Form
    {
        List<OrderInfo> OrderList = new List<OrderInfo>();
        OrderInfo item;

        public CookWindow()
        {
            InitializeComponent();
            CustomerInfo customer = new CustomerInfo("Daisy", "Baker", "256-293-0049", "dgbaker0328@gmail.com", new AddressInfo("379 Columbus Ln", "Guntersville", "AL", "35976"), 0, "None");
            EmployeeInfo employee = new EmployeeInfo("Carson", "Brown", "256-486-5343", "cdbrown3@uab.edu", new AddressInfo("181 Atwood Brown Rd", "Guntersville", "AL", "35976"), "Server", "cdbrown3", "1234", 12.96);
            OrderInfo order = new OrderInfo(customer, employee, "Active");

            MenuItemInfo MenuItem = new MenuItemInfo("Carnitas", "Tacos", 12.99, new List<String> { "Sour cream", "Lettuce", "Tomatoes", "Cheese" });
            OrderItemInfo item = new OrderItemInfo(MenuItem, 5, new List<String> { "Sour cream", "Lettuce", "Tomatoes", "Cheese" });
            order.AddItem(item);
            order.AddItem(item);
            List<OrderCard> ordercards = LoadOrders();
            foreach (OrderCard ordercard in ordercards)
            {
                flowLayoutPanel1.Controls.Add(ordercard);
            }
        }
        public void LoadSelectedOrder()
        {

        }

        private void LeftDockPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedOrderLabel.Text = "Selected Order: ";
        }
        public List<OrderCard> LoadOrders()
        {
            OrderList = Testing.LoadOrdersFromCSV("Orders.txt");
            List<OrderCard> cards = new List<OrderCard>();
            foreach (OrderInfo item in OrderList)
            {
                OrderCard ordercard = new OrderCard(this, item);
                cards.Add(ordercard);
            }
            return cards;
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
