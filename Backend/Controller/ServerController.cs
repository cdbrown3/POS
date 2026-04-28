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
    }
}