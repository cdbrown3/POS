using Backend.Model;
using Backend.Controller;
using POS.Backend;
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
        public EmployeeInfo LoggedInEmployee;
        public EmployeeInfo LoggedInManager;
        public MenuItemInfo SelectedMenuItem;
        public OrderInfo PotOrder;
        public ServerController serverController = new ServerController();
        public ManagerController ManagerController = new ManagerController();
        public List<CustomerInfo> CustomerList = new List<CustomerInfo>();
        public List<EmployeeInfo> EmployeeList = new List<EmployeeInfo>();
        public List<MenuItemInfo> Menu = new List<MenuItemInfo>();
        public List<OrderInfo> OrderList = new List<OrderInfo>();
        List<MenuItem> items = new List<MenuItem>();
        private bool isEditing = false;
        public static String SpecialInstructions;
        public ChangedProperty Prop;
        public bool ispressed = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Title title, EmployeeInfo employee) : this() // employee that just logged in and their Title(Employee/Manager) 
        {
            LoggedInEmployee = employee;
            LoadSigninName(); // sets top line ("signed in")
            SelectedTitle = title;
            LoadViews(); // loads main views
        }
        public void ReloadListBox() // reloads the MainPanel, mainly the listbox within the main panel
        {
            MainPanel.Controls.Clear();
            MainListView MainPanelAdd = new MainListView(this);
            MainPanel.Controls.Add(MainPanelAdd);
        }
        private void LoadViews()
        {
            if (SelectedTitle == Title.Employee)
            {
                // CustomerList = ImportCustomersFromCSV("Customers.txt");
                serverController.LoadCustomers("Customers2.txt", "CSV"); // creating a customers list
                ManagerController.LoadEmployees("Employees2.txt", "CSV"); // creating an employee list
                EmployeeList = ManagerController.GetAllEmployees();
                CustomerList = serverController.GetAllCustomers();
                // MessageBox.Show(CustomerList[0].GetFullName());
                MainListView MainPanelAdd = new MainListView(this);
                MainPanel.Controls.Add(MainPanelAdd);
                LoadLeftPanelEmployee();
                LoadButtonsPanel(Title.Employee);
            }
            else if (SelectedTitle == Title.Manager)
            {
                serverController.LoadCustomers("Customers2.txt", "CSV");
                ManagerController.LoadEmployees("Employees2.txt", "CSV");
                EmployeeList = ManagerController.GetAllEmployees();
                CustomerList = serverController.GetAllCustomers();
                LoadLeftPanelManager();
                MainListView MainPanelAdd = new MainListView(this);
                MainPanel.Controls.Add(MainPanelAdd);
                LoadButtonsPanel(Title.Manager);

            }
        }
        public void LoadLeftPanelManager() // ManagerView LeftPanel
        {
            EmployeeInfoView LeftDockPanelManager = new EmployeeInfoView(this, EmployeeList[SelectedUserIndex], false);
            LeftDockPanel.Controls.Clear();
            LeftDockPanel.Controls.Add(LeftDockPanelManager);
            LoadButtonsPanel(Title.Manager);
        }
        public void LoadLeftPanelEmployee() // EmployeeView LeftPanel
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
                ManagerMethodPanel buttons = new ManagerMethodPanel(this); // manager buttons (archive and editemployee)
                buttons.Dock = DockStyle.Fill;
                ButtonsPanel.Controls.Add(buttons);
            }
            else if (title == Title.Employee)
            {
                EmployeeMethodPanel buttons = new EmployeeMethodPanel(this); // Employee buttons (new order and editcustomer)
                buttons.Dock = DockStyle.Fill;
                ButtonsPanel.Controls.Add(buttons);
            }
        }

        public void NewOrder()
        {
            MainPanel.Controls.Clear();
            // passes the customer that is selected and the logged in employee so the order is created with accurate values already
            this.PotOrder = new OrderInfo(CustomerList[SelectedUserIndex], LoggedInEmployee, "New");
            LoadMenu(); // loading the menu of MenuItemInfo
        }
        public void EditUser() // called when button edit(employee or manager) is pressed
        {
            // MessageBox.Show("EditUser Called");
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
            // MessageBox.Show("EditUser END - controls: " + ButtonsPanel.Controls.Count);
            isEditing = false;
        }
        public void SubmitChanges() 
            //called when submit changes is pressed after editing a user, resets the panel and calls editlist()
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
            EditList();
        }
        public void DeleteEmployee()
        {
            EmployeeList[SelectedUserIndex].IsActive = false;
            LoadLeftPanelManager();
        }
        public void EditList()
            // edits the property that was changed during the instance of editing the user
            //***IMPROVE*** 
            // only one property can be changed during a button click
        {
            if (SelectedTitle == Title.Employee)
            {
                if (Prop == ChangedProperty.First)
                {
                    CustomerList[SelectedUserIndex].FirstName = SelectedUserValue;
                }
                else if (Prop == ChangedProperty.Last)
                {
                    CustomerList[SelectedUserIndex].LastName = SelectedUserValue;
                }
                else if (Prop == ChangedProperty.Phone)
                {
                    CustomerList[SelectedUserIndex].PhoneNumber = SelectedUserValue;
                }
                else if (Prop == ChangedProperty.Notes)
                {
                    string[] notes = SelectedUserValue.Split(": ");
                    CustomerList[SelectedUserIndex].Notes = notes[1];
                }
            }
            else if (SelectedTitle == Title.Manager)
            {
                if (Prop == ChangedProperty.First)
                {
                    EmployeeList[SelectedUserIndex].FirstName = SelectedUserValue;
                }
                else if (Prop == ChangedProperty.Last)
                {
                    EmployeeList[SelectedUserIndex].LastName = SelectedUserValue;
                }
                else if (Prop == ChangedProperty.Phone)
                {
                    EmployeeList[SelectedUserIndex].PhoneNumber = SelectedUserValue;
                }
            }
        }
        public void PopulateTextBoxes()
            //when the selected user changes the Leftpanel populates with their properties
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
        public void AddMenuItem()
        {
            //MenuItem menuItem = new MenuItem(this, SelectedMenuItem);
            //BaseOrderView MenuView = new BaseOrderView(this, menuItem);
            //MainPanel.Controls.Add(MenuView);
        }
        public void LoadMenu()
            //Loads our menu for our orders
        {
            ManagerController managerController = new ManagerController();
            managerController.LoadMenu("Menu.txt", "CSV");
            Menu = managerController.GetAllMenuItems();
            MainPanel.Controls.Clear();
            foreach (MenuItemInfo item in Menu) {
                MenuItem menuItem = new MenuItem(this, item);
                this.items.Add(menuItem);
            }
                BaseOrderView MenuView = new BaseOrderView(this, items);
                MainPanel.Controls.Add(MenuView);
        }
        public void LoadOrderPanel()
            //loads orderview when New Order is pressed
        {
            MainPanel.Controls.Clear();
            MenuItem menuItem = new MenuItem(this, SelectedMenuItem);
            BaseOrderView MenuView = new BaseOrderView(this, this.items);
            MainPanel.Controls.Add(MenuView);
        }
        public void LoadSigninName()
        {
            label1.Text = "Signed In As: " + LoggedInEmployee.Username; 
        }

        private void ExitButton_Click(object sender, EventArgs e)
            // When the Exit button is pressed the dialog box makes a confirmation question to close the form
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
                string[] strings = new string[this.OrderList.Count];
                for (int i = 0; i < this.OrderList.Count; i++)
                {
                    strings[i] = OrderList[i].ToCSV();
                }
                System.IO.File.WriteAllLines("OrderList.txt", strings);
            }

        }
    }
}
