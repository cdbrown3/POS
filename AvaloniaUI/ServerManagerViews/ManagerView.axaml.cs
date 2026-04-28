using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Backend.Model;
using System.Collections.ObjectModel;

namespace AvaloniaUI;

public partial class ManagerView : UserControl
{
    public ObservableCollection<CustomerInfo> Customers { get; set; } = new ObservableCollection<CustomerInfo>();
    public ObservableCollection<EmployeeInfo> Employees { get; set; } = new ObservableCollection<EmployeeInfo>();
    public ManagerView()
    {
        InitializeComponent();
    }

   
    public void OnCustomerTab_Click(object? sender, RoutedEventArgs e)
    {
        this.selectedUserType.Content = new CustomerListView(Customers);
    }

    public void OnEmployeeTab_Click(object? sender, RoutedEventArgs e)
    {
        this.selectedUserType.Content = new ListEmployeeView(Employees);
    }
}