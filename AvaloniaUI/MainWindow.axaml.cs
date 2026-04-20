using Avalonia.Automation;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Logging;
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

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Icon = new WindowIcon("resources/app_icon.ico");

            //this.SizeChanged += MainWindow_SizeChanged;
        }

        //private void MainWindow_SizeChanged(object? sender, SizeChangedEventArgs e)
        //{
        //    String result = "";
        //    //get current window size
        //    double currentWidth = Bounds.Width;
        //    double currentHeight = Bounds.Height;

        //    result += "Width: " + currentWidth + " Height: " + currentHeight;
        //    WindowSizeTextBlock.Text = result;
        //}

        private void OnButtonExitClick(object? sender, RoutedEventArgs e)
        {
            //For now when button exit is closed...
            Close();
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
    }
}