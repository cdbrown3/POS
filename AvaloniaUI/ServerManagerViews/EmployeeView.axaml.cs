using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Backend.Model;
using POS.Backend;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AvaloniaUI;

public partial class EmployeeView : UserControl
{
    //need observable list for the views to update...
    public ObservableCollection<CustomerInfo> Customers { get; set; } = new ObservableCollection<CustomerInfo>();
    public EmployeeView()
    {
        InitializeComponent();

        //Customers = controller.getCustomers;
        AddCustomer();
        AddCustomer();
    }

    public void AddCustomer()
    {
        CustomerInfo customer = new CustomerInfo("Carson", "Brown", "256-486-5343", "cdbrown3@gmail.com", new AddressInfo("181 Atwood Brown Rd", "Guntersville", "AL", "35976"), 0, "None");
        Customers.Add(customer);
    }

    public void OnCustomerTab_Click(object? sender, RoutedEventArgs e)
    {
        this.selectedUserType.Content = new CustomerListView(Customers);
    }
}