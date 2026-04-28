using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Backend.Controller;
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
    public MainWindow MainView;
    public ServerController ServerController = new ServerController();
    public ObservableCollection<CustomerInfo> Customers { get; set; } = new ObservableCollection<CustomerInfo>();

    public EmployeeView()
    {
        InitializeComponent();

        //Customers = controller.getCustomers;
        Customers = new ObservableCollection<CustomerInfo>(ServerController.GetCustomers());
        ServerController.CreateCustomer("Carson", "Brown", "256-486-5343", "cdbrown3@gmail.com", new AddressInfo("181 Atwood Brown Rd", "Guntersville", "AL", "35976"), 0, "None");
        ServerController.CreateCustomer("Daisy", "Baker", "256-293-0049", "dgbaker0328@gmail.com", new AddressInfo("379 Columbus Ln", "Guntersville", "AL", "35976"), 1, "None");

    }

    public EmployeeView(MainWindow mainView) : this()
    {
        MainView = mainView;
    }

    public void OnCustomerTab_Click(object? sender, RoutedEventArgs e)
    {
        this.selectedUserType.Content = new CustomerListView(Customers);
    }

    public void LoadCustomer()
    {
        MainView.SelectedContent.Content = new SelectedCustomerView();
    }
}