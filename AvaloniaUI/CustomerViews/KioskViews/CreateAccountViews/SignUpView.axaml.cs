using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaUI;

public partial class SignUpView : UserControl
{
    private CustomerLoginView customerLoginView;

    public SignUpView()
    {
        InitializeComponent();
    }
    public SignUpView(CustomerLoginView customerLoginView) : this()
    {
        customerLoginView = customerLoginView;
    }
}