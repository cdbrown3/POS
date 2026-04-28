using Backend.Controller;
using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI
{
    public enum Title
    {
        Employee,
        Manager
    }
    public enum ChangedProperty
    {
        First, Last, Phone, IsActive, Notes
    }

    public class Testing
    {
        List<MenuItemInfo> menuItems = new List<MenuItemInfo>();
        List<EmployeeInfo> employees = new List<EmployeeInfo>();
        List<CustomerInfo> customers = new List<CustomerInfo>();
        List<OrderItemInfo> orderItems = new List<OrderItemInfo>();
        ServerController serverController = new ServerController();
        ManagerController managerController = new ManagerController();
        List<OrderInfo> orders = new List<OrderInfo>();

        // ========================================
        // LOAD ORDER ITEMS FROM CSV
        // ========================================

        public static List<OrderItemInfo> LoadOrderItemsFromCSV(string filePath)
        {
            List<MenuItemInfo> menuItems = new List<MenuItemInfo>();
            List<EmployeeInfo> employees = new List<EmployeeInfo>();
            List<CustomerInfo> customers = new List<CustomerInfo>();
            List<OrderItemInfo> orderItems = new List<OrderItemInfo>();
            ServerController serverController = new ServerController();
            ManagerController managerController = new ManagerController();
            List<OrderInfo> orders = new List<OrderInfo>();
            managerController.LoadMenu("Menu.txt", "CSV");
            menuItems = managerController.GetAllMenuItems();
            
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine("Error: Order Item CSV file not found at " + filePath);
            }

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                int index = 1;

                while (index < lines.Length)
                {
                    string[] parts = lines[index].Split(',');

                    if (parts.Length >= 5)
                    {
                        // Find matching MenuItemInfo using ItemID
                        MenuItemInfo foundMenuItem = null;

                        foreach (MenuItemInfo menuItem in menuItems)
                        {
                            if (menuItem.ItemID == parts[1])
                            {
                                foundMenuItem = menuItem;
                                break;
                            }
                        }

                        // Skip if menu item wasn't found
                        if (foundMenuItem == null)
                        {
                            Console.WriteLine("Menu item not found for OrderItem: " + parts[1]);
                            index++;
                            continue;
                        }

                        // Parse quantity
                        int quantity = 0;
                        int.TryParse(parts[2], out quantity);

                        // Parse selected options
                        List<string> selectedOptions = new List<string>();

                        if (parts[4] != "")
                        {
                            string[] optionArray = parts[4].Split('|');

                            int optIndex = 0;

                            while (optIndex < optionArray.Length)
                            {
                                if (optionArray[optIndex] != "")
                                {
                                    selectedOptions.Add(optionArray[optIndex]);
                                }

                                optIndex++;
                            }
                        }

                        // Create OrderItemInfo object
                        OrderItemInfo loadedOrderItem = new OrderItemInfo(
                            foundMenuItem,
                            quantity,
                            selectedOptions
                        );

                        orderItems.Add(loadedOrderItem);
                    }

                    index++;
                }

                Console.WriteLine("Successfully loaded " + orderItems.Count + " order items.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while loading order items: " + e.Message);
            }
            return orderItems;
        }
        // ========================================
        // LOAD ORDERS FROM CSV
        // ========================================

        public static List<OrderInfo> LoadOrdersFromCSV(string filePath)
        {
            List<MenuItemInfo> menuItems = new List<MenuItemInfo>();
            List<EmployeeInfo> employees = new List<EmployeeInfo>();
            List<CustomerInfo> customers = new List<CustomerInfo>();
            List<OrderItemInfo> orderItems = LoadOrderItemsFromCSV("OrderItems.txt");
            ServerController serverController = new ServerController();
            ManagerController managerController = new ManagerController();
            List<OrderInfo> orders = new List<OrderInfo>();
            managerController.LoadEmployees("Employees2.txt", "CSV");
            serverController.LoadCustomers("Customers2.txt", "CSV");
            customers = serverController.GetAllCustomers();
            employees = managerController.GetAllEmployees();
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine("Error: Orders CSV file not found at " + filePath);
            }

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                int index = 1;

                while (index < lines.Length)
                {
                    string[] parts = lines[index].Split(',');

                    if (parts.Length >= 8)
                    {
                        // ========================================
                        // Find Customer
                        // ========================================

                        CustomerInfo foundCustomer = null;

                        foreach (CustomerInfo customer in customers)
                        {
                            if (customer.CustomerID == parts[1])
                            {
                                foundCustomer = customer;
                                break;
                            }
                        }

                        // ========================================
                        // Find Employee
                        // ========================================

                        EmployeeInfo foundEmployee = null;

                        foreach (EmployeeInfo employee in employees)
                        {
                            if (employee.EmployeeID == parts[2])
                            {
                                foundEmployee = employee;
                                break;
                            }
                        }

                        // Skip invalid rows
                        if (foundCustomer == null || foundEmployee == null)
                        {
                            Console.WriteLine("Customer or Employee not found for Order.");
                            index++;
                            continue;
                        }

                        // ========================================
                        // Create OrderInfo object
                        // ========================================

                        OrderInfo loadedOrder = new OrderInfo(
                            foundCustomer,
                            foundEmployee,
                            parts[3]
                        );

                        // ========================================
                        // Load Order Items
                        // ========================================

                        string[] itemIDs = parts[7].Split('|');

                        int itemIndex = 0;

                        while (itemIndex < itemIDs.Length)
                        {
                            if (itemIDs[itemIndex] != "")
                            {
                                foreach (OrderItemInfo orderItem in orderItems)
                                {
                                    if (orderItem.OrderItemID == itemIDs[itemIndex])
                                    {
                                        loadedOrder.AddItem(orderItem);
                                        break;
                                    }
                                }
                            }

                            itemIndex++;
                        }

                        orders.Add(loadedOrder);
                    }

                    index++;
                }

                Console.WriteLine("Successfully loaded " + orders.Count + " orders.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while loading orders: " + e.Message);
            }
            return orders;
        }
    }
}
