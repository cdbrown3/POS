using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class OrderInfo : IExportable {
        // variables:

        // static counter used to generate UNIQUE IDs
        private static int Count = 0;

        // order specific fields
        private string OrderID;                   // O00001 format
        private CustomerInfo Customer;            // customer who placed the order
        private EmployeeInfo Employee;            // employee handling the order
        private List<OrderItemInfo> Items;         // items in the order
        private double Subtotal;                  // total before tax
        private double Tax;                       // tax amount
        private double Total;                     // final total after tax
        private string Status;                    // new, paid, cancelled, etc.

        // constructors
        // call setters for validation
        // tax and total are calculated automatically

        public OrderInfo(
            CustomerInfo Customer,
            EmployeeInfo Employee,
            string Status
        ) {
            SetCustomer(Customer);
            SetEmployee(Employee);
            SetStatus(Status);

            // start with an empty list of items
            this.Items = new List<OrderItemInfo>();

            // default totals
            this.Subtotal = 0;
            this.Tax = 0;
            this.Total = 0;

            // generate UNIQUE Order ID
            Count++;
            this.OrderID = "O" + Count.ToString("D5");
        }

        // getters
        public string GetOrderID() {
            return OrderID;
        }

        public CustomerInfo GetCustomer() {
            return Customer;
        }

        public EmployeeInfo GetEmployee() {
            return Employee;
        }

        public List<OrderItemInfo> GetItems() {
            return Items;
        }

        public double GetSubtotal() {
            return Subtotal;
        }

        public double GetTax() {
            return Tax;
        }

        public double GetTotal() {
            return Total;
        }

        public string GetStatus() {
            return Status;
        }

        // setters w/validation

        public void SetCustomer(CustomerInfo value) {
            if (value == null) {
                throw new ArgumentException("Customer cannot be null!");
            }

            Customer = value;
        }

        public void SetEmployee(EmployeeInfo value) {
            if (value == null) {
                throw new ArgumentException("Employee cannot be null!");
            }

            Employee = value;
        }

        public void SetStatus(string value) {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException("Status cannot be empty!");
            }

            Status = value;
        }

        public void SetStatusToNew() {
            Status = "New";
        }

        public void SetStatusToPreparing() {
            Status = "Preparing";
        }

        public void SetStatusToReady() {
            Status = "Ready";
        }

        public void SetStatusToPaid() {
            Status = "Paid";
        }

        public void SetStatusToCancelled() {
            Status = "Cancelled";
        }

        // helpers

        // add one menu item to the order
        public void AddItem(OrderItemInfo item) {
            if (item == null) {
                throw new ArgumentException("Item cannot be null!");
            }

            Items.Add(item);

            // recalculate totals after adding item
            CalculateSubtotal();
            CalculateTax();
            CalculateTotal();
        }

        // remove one menu item from the order
        public void RemoveItem(OrderItemInfo item) {
            if (item == null) {
                throw new ArgumentException("Item cannot be null!");
            }

            Items.Remove(item);

            // recalculate totals after removing item
            CalculateSubtotal();
            CalculateTax();
            CalculateTotal();
        }

        // calculate subtotal by adding up all item prices
        public void CalculateSubtotal() {
            Subtotal = 0;

            foreach (OrderItemInfo item in Items) {
                Subtotal += item.GetLineTotal();
            }
        }

        // calculate tax as 10% of subtotal
        public void CalculateTax() {
            Tax = Subtotal * 0.10;
        }

        // calculate final total
        public void CalculateTotal() {
            Total = Subtotal + Tax;
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "Order ID: " + OrderID + "\n";
            output += "Customer: " + Customer.GetFullName() + "\n";
            output += "Employee: " + Employee.GetFullName() + "\n";
            output += "Status: " + Status + "\n";
            output += "Subtotal: $" + Subtotal + "\n";
            output += "Tax: $" + Tax + "\n";
            output += "Total: $" + Total + "\n";

            output += "Items: ";

            foreach (OrderItemInfo item in Items) {
                output += item.GetMenuItem().GetName() + " ";
            }

            output += "\n";

            return output;
        }

        // ToCSV

        public string ToCSV() {
            string output = "";

            output += OrderID + ",";
            output += Customer.GetCustomerID() + ",";
            output += Employee.GetEmployeeID() + ",";
            output += Status + ",";
            output += Subtotal + ",";
            output += Tax + ",";
            output += Total + ",";

            // add all item IDs separated by |
            foreach (OrderItemInfo item in Items) {
                output += item.GetOrderItemID() + "|";
            }

            return output;
        }

        public String OrderNumber 
        {
            get
            {
                return this.OrderID;
            }
        }

        public String OrderItems
        {
            get
            {
                String output = "";
                foreach (OrderItemInfo item in Items)
                {
                    foreach (string indItem in item.GetSelectedOptions())
                    output += indItem+ System.Environment.NewLine;
                }
                return output;
            }
        }
    }
}