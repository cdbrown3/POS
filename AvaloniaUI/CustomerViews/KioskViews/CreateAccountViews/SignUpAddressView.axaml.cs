using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaUI;

public partial class SignUpAddressView : UserControl
{
    private CustomerLoginView customerLoginView;

    public SignUpAddressView()
    {
        InitializeComponent();
    }
    public SignUpAddressView(CustomerLoginView cusLoginView) : this()
    {
        this.customerLoginView = cusLoginView;
    }

    public void OnButtonCreateClick(object? sender, RoutedEventArgs e)
    {
        //validate info and store the new user in the file system
        // take them back to the sign in screen to sign in with their new account...
        //Maybe turn all input fields green?
        this.customerLoginView.LoadWelcomeWindow();
    }

    public void OnButtonBackClick(object? sender, RoutedEventArgs e)
    {
        //figure out how to go back to and load the fields that were already there...
        this.customerLoginView.LoadSignUpUserInfoWindow();
    }
}