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
    public partial class CustomerInfoView : UserControl
    {
        MainWindow Instance;
        public CustomerInfoView()
        {
            InitializeComponent();
        }
        public CustomerInfoView(MainWindow Instance)
        {
            InitializeComponent();
            this.Instance = Instance;
        }
        public CustomerInfoView(MainWindow Instance, CustomerInfo SelectedCustomer, bool iseditable)
        {
            InitializeComponent();
            this.Instance = Instance;

            NameTextBox.Clear();
            NameTextBox.Text = SelectedCustomer.GetFullName();
            PhoneTextBox.Clear();
            PhoneTextBox.Text = SelectedCustomer.GetPhoneNumber();
            OrderHistoryTextBox.Clear();
            OrderHistoryTextBox.Text = SelectedCustomer.GetOrderHistoryCount().ToString();
            IDTextBox.Text = SelectedCustomer.GetCustomerID().ToString();
            NotesTextBox.AppendText(SelectedCustomer.GetNotes());
            if (iseditable == true)
            {
                NameTextBox.ReadOnly = false; PhoneTextBox.ReadOnly = false; OrderHistoryTextBox.ReadOnly = false;
            }
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            Instance.EditUser();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Instance.SelectedUserValue = NameTextBox.Text;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    Instance.EditListFirst();
            //    e.Handled = true;
            //}
        }
    }
}
