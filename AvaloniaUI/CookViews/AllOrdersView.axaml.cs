using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Backend.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace AvaloniaUI;

public partial class AllOrdersView : UserControl
{
    private MainWindow parentWindow;

    public AllOrdersView()
    {
        InitializeComponent();
    }
    public AllOrdersView(MainWindow main) : this()
    {
        //set the parent to the passed in main
        parentWindow = main;

        ordersItemControl.ItemsSource = Orders;

        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();
        AddNewOrder();

        LoadOrder(0);
    }

    //property for the orders... Stored in an observable Collection so it can update the ui as its size changes...
    public ObservableCollection<OrderInfo> Orders { get; set; } = new();
    public void AddNewOrder()
    {
        //increment order count 
        //get orders 
        CustomerInfo customer = new CustomerInfo("Daisy", "Baker", "256-293-0049", "dgbaker0328@gmail.com", new AddressInfo("379 Columbus Ln", "Guntersville", "AL", "35976"), 0, "None");
        EmployeeInfo employee = new EmployeeInfo("Carson", "Brown", "256-486-5343", "cdbrown3@uab.edu", new AddressInfo("181 Atwood Brown Rd", "Guntersville", "AL", "35976"), "Server", "cdbrown3", "1234", 12.96);
        OrderInfo order = new OrderInfo(customer,employee, "Active");
        
        MenuItemInfo MenuItem = new MenuItemInfo("Carnitas", "Tacos", 12.99, new List<String> { "Sour cream", "Lettuce", "Tomatoes", "Cheese" });
        OrderItemInfo item = new OrderItemInfo(MenuItem, 5, new List<String> { "Sour cream", "Lettuce", "Tomatoes", "Cheese" });
        order.AddItem(item);
        order.AddItem(item);
        Orders.Add(order);
    }

    public void OrderListBox_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        //when order has changed we can populate the main content of the parent with the selected order Content Control
        int index = ordersItemControl.SelectedIndex;
        LoadOrder(index);
    }

    private void LoadOrder(int index)
    {
        OrderInfo item = Orders[index];
        parentWindow.SelectedContent.Content = new SelectedOrderView(item);
    }
}