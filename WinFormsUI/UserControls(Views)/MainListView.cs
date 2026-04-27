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
using System.Windows.Forms.Design;

namespace WinFormsUI
{
    public partial class MainListView : UserControl
    {
        MainWindow Instance;
        List<CustomerInfo> CustomerList = new List<CustomerInfo>();
        List<EmployeeInfo> EmployeeList = new List<EmployeeInfo>();
        CustomerInfo Customer;
        public MainListView()
        {
            InitializeComponent();
        }
        public MainListView(MainWindow Instance)
        {
            InitializeComponent();
            this.Instance = Instance;
            this.CustomerList = Instance.CustomerList;
            this.EmployeeList = Instance.EmployeeList;
            if (Instance.SelectedTitle == Title.Manager)
            {
                foreach (EmployeeInfo employee in EmployeeList)
                {
                    CustomerListBox.Items.Add(employee.GetFullName());
                }
                EmployeesLabel.Visible = true;
            }
            else if (Instance.SelectedTitle == Title.Employee)
            {
                foreach (CustomerInfo Customer in CustomerList)
                {
                    CustomerListBox.Items.Add(Customer.GetFullName());
                }
                EmployeesLabel.Visible = false;
                CustomersLabel.Enabled = false;
            }
        }

        private void CustomersLabel_Click(object sender, EventArgs e)
        {
            //'if (EmployeesLabel.Visible == true)
            //{
            Instance.LoadLeftPanelEmployee();
            //}
            //else
            //{

            //}
        }

        private void EmployeesLabel_Click(object sender, EventArgs e)
        {
            Instance.LoadLeftPanelManager();
            Instance.SelectedTitle = Title.Manager;
        }

        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomerListBox.SelectedIndex;
            Instance.SelectedUserIndex = index;
            MessageBox.Show(index.ToString());
            Instance.PopulateTextBoxes();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddressInfo Address = new AddressInfo("123 N/A", "NA", "AL", "00000");
            this.Customer = new CustomerInfo("A", "B", "000-000-0000", "abc@123.com", Address, 0, "N/A");
            CustomerList.Add(Customer);
            Instance.ReloadListBox(); 
        }
    }
}
