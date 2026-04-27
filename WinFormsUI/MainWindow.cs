using Backend.Model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using WinFormsUI.UserControls_Views_;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WinFormsUI
{
    public partial class MainWindow : Form
    {
        public Title SelectedTitle;
        public int SelectedUserIndex;
        public String SelectedUserField;
        public String SelectedUserValue;
        public int SelectedUserNumber;
        public List<CustomerInfo> CustomerList = new List<CustomerInfo>();
        public List<EmployeeInfo> EmployeeList = new List<EmployeeInfo>();
        private bool isEditing = false;


        public List<CustomerInfo> ImportCustomersFromCSV(string filePath)
        {
            List<CustomerInfo> customers = new List<CustomerInfo>();

            if (!File.Exists(filePath))
                throw new FileNotFoundException("CSV file not found.");

            string[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines)
            {
                string[] values = line.Split(",");
                string first = values[0];
                string last = values[1];
                string phone = values[2];
                string email = values[3];

                // Address (adjust if your constructor is different)
                AddressInfo address = new AddressInfo(
                    values[4], // Street
                    values[5], // City
                    values[6], // State
                    values[7]  // Zip
                );

                // Customer-specific fields
                int orderHistoryCount = 0;
                int.TryParse(values[8], out orderHistoryCount);

                string notes = values[9];
                CustomerInfo customer = new CustomerInfo(
            first,
            last,
            phone,
            email,
            address,
            orderHistoryCount,
            notes);
                customers.Add(customer);
            }

            MessageBox.Show(customers.Count.ToString());
            return customers;
        }

        public static List<EmployeeInfo> ImportEmployeesFromCSV(string path)
        {
            List<EmployeeInfo> employees = new List<EmployeeInfo>();
            string[] lines = File.ReadAllLines(path);
            foreach (String line in lines)
            {
                string[] chunks = line.Split(",");
                string first = chunks[0];
                string last = chunks[1];
                string phone = chunks[2];
                string email = chunks[3];

                AddressInfo Address = new AddressInfo(chunks[4], chunks[5], chunks[6], chunks[7]);
                string positon = chunks[8];
                string username = chunks[9];
                string password = chunks[10];
                double wage;
                double.TryParse(chunks[11], out wage);
                bool active;
                bool.TryParse(chunks[12], out active);
                EmployeeInfo Employee = new EmployeeInfo(first, last, phone, email, Address, positon, username, password, wage);
                employees.Add(Employee);
            }
            return (employees);
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Title title) : this()
        {
            SelectedTitle = title;
            LoadViews();
        }
        public void ReloadListBox()
        {
            MainPanel.Controls.Clear();
            MainListView MainPanelAdd = new MainListView(this);
            MainPanel.Controls.Add(MainPanelAdd);
        }
        private void LoadViews()
        {
            if (SelectedTitle == Title.Employee)
            {
                CustomerList = ImportCustomersFromCSV("Customers.txt");
                // MessageBox.Show(CustomerList[0].GetFullName());
                MainListView MainPanelAdd = new MainListView(this);
                CustomerInfoView LeftDockPanelEmployee = new CustomerInfoView(this);
                EmployeeMethodPanel ButtonsPanelEmployee = new EmployeeMethodPanel(this);
                MainPanel.Controls.Add(MainPanelAdd);
                LeftDockPanel.Controls.Add(LeftDockPanelEmployee);
                LeftDockPanelEmployee.Dock = DockStyle.Left;
                ButtonsPanel.Controls.Add(ButtonsPanelEmployee);
            }
            else if (SelectedTitle == Title.Manager)
            {
                EmployeeList = ImportEmployeesFromCSV("Employees.txt");
                LoadLeftPanelManager();
                MainListView MainPanelAdd = new MainListView(this);
                MainPanel.Controls.Add(MainPanelAdd);
                LoadButtonsPanel(Title.Manager);

            }
        }
        public void LoadLeftPanelManager()
        {
            EmployeeInfoView LeftDockPanelManager = new EmployeeInfoView(this, EmployeeList[SelectedUserIndex], false);
            LeftDockPanel.Controls.Clear();
            LeftDockPanel.Controls.Add(LeftDockPanelManager);
            LoadButtonsPanel(Title.Manager);
        }
        public void LoadLeftPanelEmployee()
        {
            CustomerInfoView panel = new CustomerInfoView(this);
            LeftDockPanel.Controls.Clear();
            LeftDockPanel.Controls.Add(panel);
            LoadButtonsPanel(Title.Employee);
        }
        public void LoadButtonsPanel(Title title)
        {
            ButtonsPanel.Controls.Clear();
            if (title == Title.Manager)
            {
                ManagerMethodPanel buttons = new ManagerMethodPanel(this);
                buttons.Dock = DockStyle.Fill;
                ButtonsPanel.Controls.Add(buttons);
            }
            else if (title == Title.Employee)
            {
                EmployeeMethodPanel buttons = new EmployeeMethodPanel(this);
                buttons.Dock = DockStyle.Fill;
                ButtonsPanel.Controls.Add(buttons);
            }
        }

        public void NewOrder()
        {
            BaseOrderView OrderPanel = new BaseOrderView(this);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(OrderPanel);
        }
        public void EditUser()
        {
            MessageBox.Show("EditUser Called");
            if (SelectedTitle == Title.Employee)
            {
                LeftDockPanel.Controls.Clear();
                CustomerInfoView LeftPanel = new CustomerInfoView(this, CustomerList[SelectedUserIndex], true);
                LeftDockPanel.Controls.Add(LeftPanel);
            }
            else if (SelectedTitle == Title.Manager)
            {
                LeftDockPanel.Controls.Clear();
                EmployeeInfoView LeftPanel = new EmployeeInfoView(this, EmployeeList[SelectedUserIndex], true);
                LeftDockPanel.Controls.Add(LeftPanel);
            }

            ButtonsPanel.Visible = true;
            ButtonsPanel.Controls.Clear();

            SubmitChangesPanel user = new SubmitChangesPanel(this);

            ButtonsPanel.Controls.Add(user);
            user.Dock = DockStyle.Fill;
            ButtonsPanel.BringToFront();
            MessageBox.Show("EditUser END - controls: " + ButtonsPanel.Controls.Count);
            isEditing = false;
        }
        public void SubmitChanges()
        {
            ButtonsPanel.Visible = true;
            ButtonsPanel.Controls.Clear();
            if (SelectedTitle == Title.Employee)
            {
                LoadButtonsPanel(Title.Employee);
            }
            else if (SelectedTitle == Title.Manager)
            {
                LoadButtonsPanel(Title.Manager);
            }
            EditListFirst();
        }
        public void DeleteEmployee()
        {

        }
        public void EditListFirst()
        {
            if (SelectedTitle == Title.Employee)
            {
                CustomerList[SelectedUserIndex].SetFirstName(SelectedUserValue);
            }
            else if (SelectedTitle == Title.Manager)
            {
                EmployeeList[SelectedUserIndex].SetFirstName(SelectedUserValue);
            }
            ReloadListBox();
        }
        public void EditListLast()
        {
            CustomerList[SelectedUserIndex].SetLastName(SelectedUserValue);
        }
        public void EditListPhone()
        {
            CustomerList[SelectedUserIndex].SetPhoneNumber(SelectedUserValue);
        }
        public void EditListOrderHisttory()
        {
            CustomerList[SelectedUserIndex].SetOrderHistoryCount(SelectedUserNumber);
        }

        public void AddHamburger()
        {
            HamburgerOrderView RightPanel = new HamburgerOrderView(this);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(RightPanel);
        }
        public void AddTacos()
        {
            TacoOrderView RightPanel = new TacoOrderView(this);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(RightPanel);
        }
        public void PopulateTextBoxes()
        {
            if (SelectedTitle == Title.Employee)
            {
                LeftDockPanel.Controls.Clear();
                CustomerInfoView LeftPanel = new CustomerInfoView(this, CustomerList[SelectedUserIndex], false);
                LeftDockPanel.Controls.Add(LeftPanel);
            }
            else if (SelectedTitle == Title.Manager)
            {
                LeftDockPanel.Controls.Clear();
                EmployeeInfoView LeftPanel = new EmployeeInfoView(this, EmployeeList[SelectedUserIndex], false);
                LeftDockPanel.Controls.Add(LeftPanel);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var result =MessageBox.Show(
            "Are you sure you want to quit?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            ); 
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
