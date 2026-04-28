using System;
using System.Collections.Generic;
using Backend.Model; // Imports the Model folder so the Controller can see the data structures

namespace Backend.Controller
{
    public class ServerController
    {
        // --- DATA STORAGE ---
        // These lists act as the temporary "database" while the application is running.
        // GUI Link: These lists are what you will use to populate UI elements like DataGrids, ListViews, or ComboBoxes.
        private List<OrderInfo> activeOrders;
        private List<CustomerInfo> customers;

        public ServerController()
        {
            this.activeOrders = new List<OrderInfo>();
            this.customers = new List<CustomerInfo>();
        }

        // --- CORE CREATION & ORDER METHODS ---

        // GUI Link: Triggered by a "Save" or "Submit" button on a "New Customer Registration" form.
        // Takes all the text boxes (first name, last name, etc.) as parameters.
        public bool CreateCustomer(string first, string last, string phone, string email, AddressInfo address, int historyCount, string notes)
        {
            // Expanded if-statement validations preventing empty inputs before hitting the Model
            if (first == "")
            {
                Console.WriteLine("Error: First name was not provided for the customer.");
                return false; // Tells the GUI that creation failed
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
                // MODEL LINK: Calls the CustomerInfo constructor. This automatically links back 
                // to the UserInfo base constructor and generates a unique CustomerID.
                CustomerInfo newCustomer = new CustomerInfo(first, last, phone, email, address, historyCount, notes);

                // Adds the newly created model to the Controller's running list
                customers.Add(newCustomer);
                return true; // Tells the GUI that creation succeeded (e.g., to close the form)
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return false;
            }
        }

        // GUI Link: Triggered by a "Start Order" button on the main POS screen after the 
        // server selects a specific Customer from a dropdown list.
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
                // MODEL LINK: Calls the OrderInfo constructor. Sets the status to "New" and 
                // generates a unique OrderID (e.g., O00001).
                OrderInfo newOrder = new OrderInfo(customer, server, "New");
                activeOrders.Add(newOrder);

                // Returns the actual order object back to the GUI so the GUI knows which 
                // order to start adding items to.
                return newOrder;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return null;
            }
        }

        // GUI Link: Triggered when a user clicks a specific food item button on the menu screen.
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
                // MODEL LINK: 1. Creates a new OrderItemInfo object using the menu item
                OrderItemInfo orderItem = new OrderItemInfo(item, quantity, options);

                // MODEL LINK: 2. Uses the AddItem() method inside the OrderInfo model. 
                // This method automatically recalculates the Subtotal, Tax, and Total inside the model!
                order.AddItem(orderItem);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return false;
            }
        }

        // GUI Link: Triggered by a "Process Payment" or "Swipe Card" button on the checkout screen.
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
                // MODEL LINK: 1. Creates a new PaymentInfo object and links it to the specific order.
                PaymentInfo payment = new PaymentInfo(order, cardNumber);

                // MODEL LINK: 2. Calls ProcessPayment() which sets AmountPaid = Order.Total
                payment.ProcessPayment();

                // MODEL LINK: 3. Updates the order status from "New" to "Paid"
                order.SetStatusToPaid();

                // MODEL LINK: 4. Increments the customer's loyalty/history count
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

        // GUI Link: Used when opening a "View All Orders" or "Customer Database" window to populate the tables.
        public List<OrderInfo> GetAllActiveOrders()
        {
            return activeOrders;
        }

        public List<CustomerInfo> GetAllCustomers()
        {
            return customers;
        }

        // --- CSV SAVING METHODS ---

        // GUI Link: Triggered by a manual "Backup Data" button in settings, or automatically when the app closes.
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
                    // MODEL LINK: Calls the overridden ToCSV() method inside CustomerInfo.cs.
                    // That method also reaches into the base UserInfo class and AddressInfo class to grab all the strings.
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

        // GUI Link: Triggered automatically during the application startup/loading screen before the user sees the main menu.
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
                int index = 1; // Skips the header row

                while (index < lines.Length)
                {
                    string[] parts = lines[index].Split(',');

                    if (parts.Length == 12)
                    {
                        // MODEL LINK: Reconstructs the AddressInfo object first because CustomerInfo requires it
                        AddressInfo address = new AddressInfo(parts[5], parts[6], parts[7], parts[8]);

                        int historyCount = 0;
                        int.TryParse(parts[10], out historyCount);

                        // MODEL LINK: Reconstructs the CustomerInfo object using the parsed data
                        CustomerInfo loadedCustomer = new CustomerInfo(
                            parts[1], parts[2], parts[3], parts[4],
                            address, historyCount, parts[11]
                        );

                        customers.Add(loadedCustomer); // Adds the loaded model back into the running list
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