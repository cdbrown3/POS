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

namespace AvaloniaUI
{
    //all windows will inherit MainWindow
    public partial class MainWindow : Window
    {

        //Temporary variables
        private Boolean _manager = false;
        private Boolean _employee = true;
        private String _name = "Carson";

        //System Time in top bar
        private DispatcherTimer _clockTimer;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Icon = new WindowIcon("resources/app_icon.ico");
            
            //sets up the timer for displaying time to the user.
            IntializeTimer();
        }


        //When the exit button is pressed this method creates a new login windows and closes the current main window.
        private void OnButtonExitClick(object? sender, RoutedEventArgs e)
        {
            //Go back to the login Screen
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

        public String GetLoggedInAsMessage
        {
            get 
            {
                if (_manager)
                {
                    return "Hello " + _name + ". You are logged in as a Manager with elevated privelidges.";
                }
                else if (_employee)
                {
                    return "Hello " + _name + ". You are logged in as an employee.";

                }
                else
                {
                    return "Error: Could not identify user logged in... Automatically loggin out!";
                }
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
    }
}