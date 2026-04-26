using Avalonia;
using Avalonia.Automation;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Logging;
using Avalonia.Threading;
using POS.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Backend.Models;
using AvaloniaUI;
using System.Runtime.CompilerServices;

namespace AvaloniaUI
{
    //Both login window and main window inherit base window. It sets default size and gives icons.
    public partial class MainWindow : BaseWindow
    {
        //default to employee
        private UserRoles role;
        

        //Temporary variables
        private Boolean _employee = true;
        private String _name = "Carson";

        //System Time in top bar
        private DispatcherTimer _clockTimer;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            //sets up the timer for displaying time to the user.
            IntializeTimer();
        }

        public MainWindow(UserRoles roleAtLogin) : this()
        {
            //set the role (specifically for manager
            role = roleAtLogin;

            //open the pages for the content zones
            LoadPagesByRole();

            //set logged in as message 
            SetLoggedInAsMessage();
        }

        //When the exit button is pressed this method creates a new login windows and closes the current main window.
        private void OnButtonExit_Click(object? sender, RoutedEventArgs e)
        {
            //Go back to the login Screen / kiosk login
            if (role == UserRoles.Customer)
            {
                CreateKioskLoginWindow();
            }
            else if (role == UserRoles.Cook)
            {
                CreateCookLoginWindow();
            }
            else
            {
                CreateServerLoginWindow();
            }

        }
        
        public void SetLoggedInAsMessage()
        {
            if (role == UserRoles.Manager)
            {
                loggedInMessageTextBox.Text = "Hello " + _name + ". You are logged in as a Manager with elevated privelidges.";
            }
            else if (role == UserRoles.Employee)
            {
                loggedInMessageTextBox.Text = "Hello " + _name + ". You are logged in as an employee.";
            }
            else if (role == UserRoles.Customer)
            {
                loggedInMessageTextBox.Text = "Hello " + _name + "!";
            }
            else if (role == UserRoles.Cook)
            {
                loggedInMessageTextBox.Text = "Hello " + _name + "! You are logged in as a Cook!";
            }
            else
            {
                loggedInMessageTextBox.Text = "Error: Could not identify user logged in... Automatically loggin out!";
            }
        }

        private void ClockTimer_Tick(object? sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString();
        }

        //Methods for initializing the timer to display to the user.
        private void IntializeTimer()
        {
            //set the time intially to current time
            TimeTextBox.Text = DateTime.Now.ToString();

            //now initalize the timer to fire every second and update the display
            _clockTimer = new DispatcherTimer();
            _clockTimer.Interval = TimeSpan.FromSeconds(1);
            _clockTimer.Tick += ClockTimer_Tick;
            _clockTimer.Start();
        }

        private void LoadPagesByRole()
        {
            if (role == Backend.Models.UserRoles.Manager)
            {
                MainContent.Content = new ManagerView();
                SelectedContent.Content = new SelectedEmployeeView();
            }
            else if (role == Backend.Models.UserRoles.Employee)
            {
                MainContent.Content = new EmployeeView();
                SelectedContent.Content = new SelectedCustomerView();
            }
            else if (role == Backend.Models.UserRoles.Customer)
            {
                //show the different views that a customer should see.
            }
            else if (role == Backend.Models.UserRoles.Cook)
            {
                //show the cook branches.
                MainContent.Content = new AllOrdersView(this);
            }
            else
            {
                //go back to login if no role is assigned but this SHOULD never happen
                if (role == UserRoles.Customer)
                {
                    CreateKioskLoginWindow();
                }
                else if (role == UserRoles.Cook)
                {
                    CreateCookLoginWindow();
                }
                else
                {
                    CreateServerLoginWindow();
                }
            }
        }

        private void CreateServerLoginWindow()
        {
            //Create a new loginWindow since the old one was closed
            LoginWindow loginView = new LoginWindow();

            //preserve size, state, and position
            loginView.Width = this.Bounds.Width;
            loginView.Height = this.Bounds.Height;
            loginView.Position = this.Position;
            loginView.WindowState = this.WindowState;

            //check if we are running on a desktop...
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = loginView;
            }

            //show login and close this main window view
            loginView.Show();
            this.Close();
        }

        private void CreateKioskLoginWindow()
        {
            //Create a new loginWindow since the old one was closed
            CustomerLoginView customerLoginView = new CustomerLoginView();

            //preserve size, state, and position
            customerLoginView.Width = this.Bounds.Width;
            customerLoginView.Height = this.Bounds.Height;
            customerLoginView.Position = this.Position;
            customerLoginView.WindowState = this.WindowState;

            //check if we are running on a desktop...
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = customerLoginView;
            }

            //show login and close this main window view
            customerLoginView.Show();
            this.Close();
        }

        private void CreateCookLoginWindow()
        {
            //Create a new loginWindow since the old one was closed
            CookLoginWindow cookLoginView = new CookLoginWindow();

            //preserve size, state, and position
            cookLoginView.Width = this.Bounds.Width;
            cookLoginView.Height = this.Bounds.Height;
            cookLoginView.Position = this.Position;
            cookLoginView.WindowState = this.WindowState;

            //check if we are running on a desktop...
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = cookLoginView;
            }

            //show login and close this main window view
            cookLoginView.Show();
            this.Close();
        }
    }
}