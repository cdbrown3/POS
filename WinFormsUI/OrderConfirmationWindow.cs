using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsUI
{
    public partial class OrderConfirmationWindow : Form
    {
        public OrderConfirmationWindow(Backend.Model.OrderInfo order)
        {
            InitializeComponent();
            TotalTextBox.Text = order.Total.ToString("0.00");
            OrderNumTextBox.Text = order.OrderID;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
