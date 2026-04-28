using Backend.Controller;
using Backend.Model;
using POS.Backend;

namespace WinFormsUI
{
    public partial class MainLoginWindow : Form
    {
        Title SelectedTitle;
        EmployeeInfo SelectedEmployee;
        EmployeeInfo SelectedManager;
        List<EmployeeInfo> employees;
        EmployeeInfo test;
        string pass;
        string user;
        public MainLoginWindow()
        {
            InitializeComponent();
            this.employees = new List<EmployeeInfo>();
            this.user = UsernameTextBox.Text = "Username";
        }

        private void EmployeeViewButton_click(object sender, EventArgs e)
        {
            SelectedTitle = Title.Employee;
            ManagerController controller = new ManagerController();
            controller.LoadEmployeesFromCSV("employees2.txt");
            employees = controller.GetAllEmployees();
            AddressInfo address = employees[0].Address;
            test = new EmployeeInfo("C", "D", "555", "123@gmail.com", address, "Manager", "Username", "1234", 18.50);
            employees.Add(test);
            foreach (EmployeeInfo employee in employees)
            {
                if (employee.ValidateLogin(user, pass) == true)
                {
                    this.SelectedEmployee = employee;
                }
            }
            if (this.SelectedEmployee != null)
            {
                new MainWindow(SelectedTitle, SelectedEmployee).Show();
            }
        }

        private void ManagerViewButton_Click(object sender, EventArgs e)
        {
            SelectedTitle = Title.Manager;
            ManagerController controller = new ManagerController();
            controller.LoadEmployeesFromCSV("employees2.txt");
            employees = controller.GetAllEmployees();
            AddressInfo address = employees[1].Address;
            test = new EmployeeInfo("C", "D", "555", "123@gmail.com", address, "Manager", "Username", "1234", 18.50);
            employees.Add(test);
            foreach (EmployeeInfo employee in employees)
            {
                if (employee.ValidateLogin(user, pass) == true)
                {
                    this.SelectedEmployee = employee;
                }
            }
            if (this.SelectedEmployee != null && this.SelectedEmployee.Position == "Manager")
            {
                new MainWindow(SelectedTitle, SelectedEmployee).Show();
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.pass = PasswordTextBox.Text;
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = String.Empty;
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.user = UsernameTextBox.Text;
        }

        private void UsernameTextBox_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = String.Empty;
        }
    }
}
