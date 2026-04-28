using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Avalonia.Interactivity;
using System.Reflection.Metadata.Ecma335;

namespace AvaloniaUI;

public partial class KioskLoginView : UserControl
{
    //store a reference to the parent view so we can call methods inside the customer view.
    private CustomerLoginView customerLoginView;

    public KioskLoginView()
    {
        InitializeComponent();
    }
    public KioskLoginView(CustomerLoginView CustomerLoginView) : this()
    {
        //store the customerLoginView into the private memeber variable
        customerLoginView = CustomerLoginView;
    }

    public void OnSignInButtonClick(object? sender, RoutedEventArgs e)
    {
        //validate the login info and call load main window if successfull
        //when the sign in button is clicked we need to change the
        customerLoginView.LoadSignInWindow();
    }

    public void OnCreateAccountButtonClick(object? sender, RoutedEventArgs e)
    {
        //load sign up page
        customerLoginView.LoadSignUpUserInfoWindow();
    }
}