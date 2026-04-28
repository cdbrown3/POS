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

            FirstNameTextBox.Clear();
            FirstNameTextBox.Text = SelectedCustomer.FirstName;
            LastNameTextBox.Clear();
            LastNameTextBox.Text = SelectedCustomer.LastName;
            PhoneTextBox.Clear();
            PhoneTextBox.Text = SelectedCustomer.PhoneNumber;
            OrderHistoryTextBox.Clear();
            OrderHistoryTextBox.Text = SelectedCustomer.OrderHistoryCount.ToString();
            IDTextBox.Text = SelectedCustomer.CustomerID;
            NotesTextBox.AppendText(SelectedCustomer.Notes);
            if (iseditable == true)
            {
                FirstNameTextBox.ReadOnly = false; LastNameTextBox.ReadOnly = false; PhoneTextBox.ReadOnly = false; OrderHistoryTextBox.ReadOnly = false; NotesTextBox.ReadOnly = false;
            }
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            Instance.EditUser();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length != 0)
            {
                Instance.SelectedUserValue = FirstNameTextBox.Text;
                Instance.Prop = ChangedProperty.First;
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    Instance.EditListFirst();
            //    e.Handled = true;
            //}
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length != 0)
            {
                Instance.SelectedUserValue = LastNameTextBox.Text;
                Instance.Prop = ChangedProperty.Last;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text.Length != 0)
            {
                Instance.SelectedUserValue = PhoneTextBox.Text;
                Instance.Prop = ChangedProperty.Phone;
            }
        }

        private void NotesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NotesTextBox.Text.Length != 0)
            {
                Instance.SelectedUserValue = NotesTextBox.Text;
                Instance.Prop = ChangedProperty.Notes;
            }
        }
    }
}
