using System;
using System.Collections.Generic;
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

        // --- CORE CREATION & ORDER METHODS ---

        public bool CreateCustomer(string first, string last, string phone, string email, AddressInfo address, int historyCount, string notes)
        {
            if (first == "")
            {
                Console.WriteLine("Error: First name was not provided for the customer.");
                return false;
            }

            if (last == "")
            {
                Console.WriteLine("Error: Last name was not provided for the customer.");
                return false;
            }

            if (address == null)
            {
                Console.WriteLine("Error: Address is missing for the customer.");
                return false;
            }

            try
            {
                CustomerInfo newCustomer = new CustomerInfo(first, last, phone, email, address, historyCount, notes);
                customers.Add(newCustomer);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return false;
            }
        }

        public OrderInfo StartNewOrder(CustomerInfo customer, EmployeeInfo server)
        {
            if (customer == null)
            {
                Console.WriteLine("Error: Valid customer required to start order.");
                return null;
            }

            if (server == null)
            {
                Console.WriteLine("Error: Valid server employee required to start order.");
                return null;
            }

            try
            {
                OrderInfo newOrder = new OrderInfo(customer, server, "New");
                activeOrders.Add(newOrder);
                return newOrder;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return null;
            }
        }

        public bool AddItemToOrder(OrderInfo order, MenuItemInfo item, int quantity, List<string> options)
        {
            if (order == null)
            {
                Console.WriteLine("Error: The selected order does not exist.");
                return false;
            }

            if (item == null)
            {
                Console.WriteLine("Error: The selected menu item does not exist.");
                return false;
            }

            if (quantity <= 0)
            {
                Console.WriteLine("Error: Quantity must be at least 1.");
                return false;
            }

            try
            {
                OrderItemInfo orderItem = new OrderItemInfo(item, quantity, options);
                order.AddItem(orderItem);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return false;
            }
        }

        public bool CheckoutOrder(OrderInfo order, string cardNumber)
        {
            if (order == null)
            {
                Console.WriteLine("Error: Cannot checkout a null order.");
                return false;
            }

            if (cardNumber == "")
            {
                Console.WriteLine("Error: Card number is required for checkout.");
                return false;
            }

            try
            {
                PaymentInfo payment = new PaymentInfo(order, cardNumber);
                payment.ProcessPayment();
                order.SetStatusToPaid();
                order.Customer.AddOrderToHistory();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return false;
            }
        }

        // --- RETRIEVAL METHODS ---

        public List<OrderInfo> GetAllActiveOrders()
        {
            return activeOrders;
        }

        public List<CustomerInfo> GetAllCustomers()
        {
            return customers;
        }

        // --- CSV SAVING METHODS ---

        public bool SaveCustomersToCSV(string filePath)
        {
            if (filePath == "")
            {
                Console.WriteLine("Error: File path cannot be empty.");
                return false;
            }

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

                System.IO.File.WriteAllLines(filePath, lines);
                Console.WriteLine("Successfully saved " + customers.Count + " customers.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while saving customers: " + e.Message);
                return false;
            }
        }

        // --- CSV LOADING METHODS ---

        public bool LoadCustomersFromCSV(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine("Error: Customer CSV file not found at " + filePath);
                return false;
            }

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
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
                            parts[1],
                            parts[2],
                            parts[3],
                            parts[4],
                            address,
                            historyCount,
                            parts[11]
                        );

                        customers.Add(loadedCustomer);
                    }
                    index++;
                }

                Console.WriteLine("Successfully loaded " + customers.Count + " customers.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while loading customers: " + e.Message);
                return false;
            }
        }
    }
}