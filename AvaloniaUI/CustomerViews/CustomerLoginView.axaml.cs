using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaUI;
using System.Data;
using System.Runtime.CompilerServices;

namespace AvaloniaUI;

public partial class CustomerLoginView : BaseWindow
{
    public CustomerLoginView()
    {
        InitializeComponent();
        LoadWelcomeWindow();
    }
        
    public void LoadWelcomeWindow()
    {
        this.MainContent.Content = new KioskLoginView(this);
    }
    
    public void LoadSignInWindow()
    {
        this.MainContent.Content = new SignInView(this);
    }

    public void LoadSignUpUserInfoWindow()
    {
        this.MainContent.Content = new SignUpUserInfoView(this);
    }

    public void LoadSignUpAddressInfoWindow()
    {
        this.MainContent.Content = new SignUpAddressView(this);
    }

    public void LoadMainWindow()
    {
        MainWindow mainView = new MainWindow(Backend.Models.UserRoles.Customer);

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

    public void OnButtonExit_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}