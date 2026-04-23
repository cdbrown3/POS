using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaUI;

public partial class SignInView : UserControl
{
    //store a reference to the parent view so we can call methods inside the customer view.
    private CustomerLoginView customerLoginView;

    public SignInView()
    {
        InitializeComponent();
    }
    public SignInView(CustomerLoginView CustomerLoginView) : this()
    {
        customerLoginView = CustomerLoginView;
    }

    private void OnBackButtonClicked(object? sender, RoutedEventArgs e)
    {
        customerLoginView.LoadWelcomeWindow();
    }

    private void OnButtonLoginClicked(object? sender, RoutedEventArgs e)
    {
        customerLoginView.LoadMainWindow();
    }
}