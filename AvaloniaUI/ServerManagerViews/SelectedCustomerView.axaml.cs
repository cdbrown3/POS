using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Backend.Model;

namespace AvaloniaUI;

public partial class SelectedCustomerView : UserControl
{
    private CustomerInfo customer;
    public SelectedCustomerView()
    {
        InitializeComponent();
    }

    public SelectedCustomerView(CustomerInfo selectedCustomer) : this()
    {
        customer = selectedCustomer;
    }

    public void LoadSelectedCustomer()
    {
        this.selectedCustomerTextBlock.Text = customer.CustomerID;
        this.selectedCustomerTextBlock.Text = customer.ToString();
    }
}