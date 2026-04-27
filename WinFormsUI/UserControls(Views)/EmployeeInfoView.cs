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
using WinFormsUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsUI.UserControls_Views_
{
    public partial class EmployeeInfoView : UserControl
    {
        MainWindow Instance;
        List<EmployeeInfo> EmployeeList = new List<EmployeeInfo>();
        public EmployeeInfoView()
        {
            InitializeComponent();
        }
        public EmployeeInfoView(MainWindow Instance, EmployeeInfo Employee, bool iseditable)
        {
            InitializeComponent();
            this.Instance = Instance;

            NameTextBox.Clear();
            NameTextBox.Text = Employee.GetFullName();
            PhoneTextBox.Clear();
            PhoneTextBox.Text = Employee.GetPhoneNumber();
            PositionTextBox.Clear();
            PositionTextBox.Text = Employee.GetPosition().ToString();
            IDTextBox.Text = Employee.GetEmployeeID().ToString();
            ActiveTextBox.Text = Employee.GetIsActive().ToString();
            if (iseditable == false)
            {
                NameTextBox.ReadOnly = true; PhoneTextBox.ReadOnly = true; PositionTextBox.ReadOnly = true; ActiveTextBox.ReadOnly = true;
            }
        }
        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (Instance == null)
            {
                MessageBox.Show("Instance is NULL");
                return;
            }
            Instance.EditUser();
            MessageBox.Show("Instance Hash: " + Instance.GetHashCode());
            MessageBox.Show("CLICKED");
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Instance.SelectedUserValue = NameTextBox.Text;
        }
    }
}
