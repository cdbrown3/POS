using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using AvaloniaUI;
using System;

namespace AvaloniaUI;

public partial class LoginWindow : BaseWindow
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void OnButtonExitClick(object? sender, RoutedEventArgs e)
    {
        //For now when button exit is closed...
        Close();
    }

    private void ManagerLoginButton_Click(object? sender, RoutedEventArgs e)
    {
        Backend.Models.UserRoles userRole = Backend.Models.UserRoles.Manager;
        CreateMainFromLogin(userRole);
    }

    private void EmployeeLoginButton_Click(object? sender, RoutedEventArgs e)
    {
        Backend.Models.UserRoles userRole = Backend.Models.UserRoles.Employee;
        CreateMainFromLogin(userRole);
    }

    private bool ValidatePasswordEntry()
    {
        Boolean retData = false;   
        //validate password
        string passwordEntered = passwordTextBox.Text;
        if ((passwordEntered == null) || (passwordEntered.Length < 6))
        {
            retData = false;
        }
        else
        {
            retData = true;
        }
        return retData;
    }

    private void CreateMainFromLogin(Backend.Models.UserRoles role)
    {
        //reset color choice once the user enters a proper value
        passwordTextBox.ClearValue(TextBox.BackgroundProperty);

        if (!ValidatePasswordEntry())
        {
            if ((Application.Current?.TryFindResource("InvalidInputColor", out object? resource) == true) && (resource is SolidColorBrush brush))
            {
                passwordTextBox.Background = brush;
            }
        }
        else
        {
            //successfully validated password

            //if valid password entry then open main window

            MainWindow mainView = new MainWindow(role);

            //copy the windows current size and position on the screen and window state like fullscreen etc...
            mainView.Width = this.Bounds.Width;
            mainView.Height = this.Bounds.Height;
            mainView.Position = this.Position;
            mainView.WindowState = this.WindowState;

            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = mainView;
            }

            mainView.Show();
            this.Close();
        }
    }
}