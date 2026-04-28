using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Reflection.Metadata.Ecma335;

namespace AvaloniaUI;

public partial class SignUpUserInfoView : UserControl
{
    private CustomerLoginView customerLoginView;

    public SignUpUserInfoView()
    {
        InitializeComponent();
    }
    public SignUpUserInfoView(CustomerLoginView cusLoginView) : this()
    {
        customerLoginView = cusLoginView;
    }

    public void OnContinueButtonClick(object? sender, RoutedEventArgs e)
    {
        //need to validate all fields...
        customerLoginView.LoadSignUpAddressInfoWindow();
    }

    public void OnBackButtonClicked(object? sender, RoutedEventArgs e)
    {
        customerLoginView.LoadWelcomeWindow();
    }
}