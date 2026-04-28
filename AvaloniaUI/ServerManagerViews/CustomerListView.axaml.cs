using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Backend.Model;
using System.Collections.ObjectModel;

namespace AvaloniaUI;

public partial class CustomerListView : UserControl
{
    public ObservableCollection<CustomerInfo> Customers { get; set; } = new ObservableCollection<CustomerInfo>();

    public CustomerListView()
    {
        InitializeComponent();
    }
    public CustomerListView(ObservableCollection<CustomerInfo> customers) : this()
    {
        Customers = customers;
        customersListBox.ItemsSource = Customers;
        
    }

    public void Customer_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        
    }
}