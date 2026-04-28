using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Backend.Model;

namespace Backend.Controller
{
    public class ServerController
    {
        private List<OrderInfo> activeOrders;
        private List<CustomerInfo> customers;

        public ServerController()
        {
            this.activeOrders = new List<OrderInfo>();
            this.customers = new List<CustomerInfo>();
        }

        public List<CustomerInfo> GetCustomers()
        {
            return (this.customers);
        }

        public List<OrderInfo> GetAllActiveOrders()
        {
            return activeOrders;
        }

        public List<CustomerInfo> GetAllCustomers()
        {
            return customers;
        }

        // === CORE CREATION METHODS ===

        public bool CreateCustomer(string first, string last, string phone, string email, AddressInfo address, int historyCount, string notes)
        {
            bool isSuccessful = false;

            if (first == "")
            {
                Console.WriteLine("Error: First name was not provided for the customer.");
            }
            else if (last == "")
            {
                Console.WriteLine("Error: Last name was not provided for the customer.");
            }
            else if (address == null)
            {
                Console.WriteLine("Error: Address is missing for the customer.");
            }
            else
            {
                try
                {
                    CustomerInfo newCustomer = new CustomerInfo(first, last, phone, email, address, historyCount, notes);
                    customers.Add(newCustomer);
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                }
            }

            return isSuccessful;
        }

        public OrderInfo StartNewOrder(CustomerInfo customer, EmployeeInfo server)
        {
            OrderInfo createdOrder = null;

            if (customer == null)
            {
                Console.WriteLine("Error: Valid customer required to start order.");
            }
            else if (server == null)
            {
                Console.WriteLine("Error: Valid server employee required to start order.");
            }
            else
            {
                try
                {
                    createdOrder = new OrderInfo(customer, server, "New");
                    activeOrders.Add(createdOrder);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                }
            }

            return createdOrder;
        }

        public bool AddItemToOrder(OrderInfo order, MenuItemInfo item, int quantity, List<string> options)
        {
            bool isSuccessful = false;

            if (order == null)
            {
                Console.WriteLine("Error: The selected order does not exist.");
            }
            else if (item == null)
            {
                Console.WriteLine("Error: The selected menu item does not exist.");
            }
            else if (quantity <= 0)
            {
                Console.WriteLine("Error: Quantity must be at least 1.");
            }
            else
            {
                try
                {
                    OrderItemInfo orderItem = new OrderItemInfo(item, quantity, options);
                    order.AddItem(orderItem);
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                }
            }

            return isSuccessful;
        }

        public bool CheckoutOrder(OrderInfo order, string cardNumber)
        {
            bool isSuccessful = false;

            if (order == null)
            {
                Console.WriteLine("Error: Cannot checkout a null order.");
            }
            else if (cardNumber == "")
            {
                Console.WriteLine("Error: Card number is required for checkout.");
            }
            else
            {
                try
                {
                    PaymentInfo payment = new PaymentInfo(order, cardNumber);
                    payment.ProcessPayment();
                    order.SetStatusToPaid();
                    order.Customer.AddOrderToHistory();
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                }
            }

            return isSuccessful;
        }

        // === SAVING AND LOADING METHODS (CSV & XML) ===

        public bool SaveCustomers(string filePath, string format)
        {
            bool isSuccessful = false;

            if (filePath == "")
            {
                Console.WriteLine("Error: File path cannot be empty.");
            }
            else if (format.ToUpper() == "CSV")
            {
                try
                {
                    List<string> lines = new List<string>();
                    lines.Add("UserID,FirstName,LastName,Phone,Email,Street,City,State,Zip,CustomerID,OrderHistoryCount,Notes");

                    int index = 0;
                    while (index < customers.Count)
                    {
                        lines.Add(customers[index].ToCSV());
                        index++;
                    }

                    File.WriteAllLines(filePath, lines);
                    Console.WriteLine("Successfully saved " + customers.Count + " customers to CSV.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while saving customers to CSV: " + e.Message);
                }
            }
            else if (format.ToUpper() == "XML")
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                        writer.WriteLine("<Customers>");

                        int index = 0;
                        while (index < customers.Count)
                        {
                            writer.WriteLine("  <Customer>");
                            writer.WriteLine("    <UserID>" + customers[index].UserID + "</UserID>");
                            writer.WriteLine("    <FirstName>" + customers[index].FirstName + "</FirstName>");
                            writer.WriteLine("    <LastName>" + customers[index].LastName + "</LastName>");
                            writer.WriteLine("    <Phone>" + customers[index].PhoneNumber + "</Phone>");
                            writer.WriteLine("    <Email>" + customers[index].Email + "</Email>");
                            writer.WriteLine("    <Street>" + customers[index].Address.Street + "</Street>");
                            writer.WriteLine("    <City>" + customers[index].Address.City + "</City>");
                            writer.WriteLine("    <State>" + customers[index].Address.StateAbbreviation + "</State>");
                            writer.WriteLine("    <Zip>" + customers[index].Address.ZipCode + "</Zip>");
                            writer.WriteLine("    <CustomerID>" + customers[index].CustomerID + "</CustomerID>");
                            writer.WriteLine("    <OrderHistoryCount>" + customers[index].OrderHistoryCount + "</OrderHistoryCount>");
                            writer.WriteLine("    <Notes>" + customers[index].Notes + "</Notes>");
                            writer.WriteLine("  </Customer>");
                            index++;
                        }
                        writer.WriteLine("</Customers>");
                    }
                    Console.WriteLine("Successfully saved " + customers.Count + " customers to XML.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while saving customers to XML: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported format. Use 'CSV' or 'XML'.");
            }

            return isSuccessful;
        }

        public bool LoadCustomers(string filePath, string format)
        {
            bool isSuccessful = false;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: Customer file not found at " + filePath);
            }
            else if (format.ToUpper() == "CSV")
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    int index = 1;

                    while (index < lines.Length)
                    {
                        string[] parts = lines[index].Split(',');

                        if (parts.Length == 12)
                        {
                            AddressInfo address = new AddressInfo(parts[5], parts[6], parts[7], parts[8]);

                            int historyCount = 0;
                            int.TryParse(parts[10], out historyCount);

                            CustomerInfo loadedCustomer = new CustomerInfo(
                                parts[1], parts[2], parts[3], parts[4],
                                address, historyCount, parts[11]
                            );

                            customers.Add(loadedCustomer);
                        }
                        index++;
                    }

                    Console.WriteLine("Successfully loaded " + customers.Count + " customers from CSV.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while loading customers from CSV: " + e.Message);
                }
            }
            else if (format.ToUpper() == "XML")
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);
                    XmlNodeList nodes = doc.SelectNodes("/Customers/Customer");

                    int index = 0;
                    while (index < nodes.Count)
                    {
                        XmlNode node = nodes[index];
                        AddressInfo address = new AddressInfo(
                            node["Street"]?.InnerText,
                            node["City"]?.InnerText,
                            node["State"]?.InnerText,
                            node["Zip"]?.InnerText
                        );

                        int historyCount = 0;
                        int.TryParse(node["OrderHistoryCount"]?.InnerText, out historyCount);

                        CustomerInfo loadedCustomer = new CustomerInfo(
                            node["FirstName"]?.InnerText,
                            node["LastName"]?.InnerText,
                            node["Phone"]?.InnerText,
                            node["Email"]?.InnerText,
                            address,
                            historyCount,
                            node["Notes"]?.InnerText
                        );

                        customers.Add(loadedCustomer);
                        index++;
                    }

                    Console.WriteLine("Successfully loaded " + customers.Count + " customers from XML.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while loading customers from XML: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported format. Use 'CSV' or 'XML'.");
            }

            return isSuccessful;
        }
    }
}