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

            FirstNameTextBox.Clear();
            FirstNameTextBox.Text = Employee.FirstName;
            LastNameTextBox.Clear();
            LastNameTextBox.Text= Employee.LastName;
            PhoneTextBox.Clear();
            PhoneTextBox.Text = Employee.PhoneNumber;
            PositionTextBox.Clear();
            PositionTextBox.Text = Employee.Position.ToString();
            IDTextBox.Text = Employee.EmployeeID.ToString();
            ActiveTextBox.Text = Employee.IsActive.ToString();
            if (iseditable == true)
            {
                FirstNameTextBox.ReadOnly = false; LastNameTextBox.ReadOnly = false; PhoneTextBox.ReadOnly = false; PositionTextBox.ReadOnly = false; ActiveTextBox.ReadOnly = false;
            }
        }
        private void EditEmployeeButton_Click(object sender, EventArgs e)
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
    }
}
