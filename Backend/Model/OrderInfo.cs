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
        public string OrderID { get; private set; }                   // O00001 format

        private CustomerInfo customer;
        private EmployeeInfo employee;
        private string status;

        public CustomerInfo Customer
        {
            get { return customer; }
            set
            {
                if (value == null) {
                    throw new ArgumentException("Customer cannot be null!");
                }
                customer = value;
            }
        }

        public EmployeeInfo Employee
        {
            get { return employee; }
            set
            {
                if (value == null) {
                    throw new ArgumentException("Employee cannot be null!");
                }
                employee = value;
            }
        }

        public List<OrderItemInfo> Items { get; private set; }         // items in the order

        public double Subtotal { get; private set; }                  // total before tax
        public double Tax { get; private set; }                       // tax amount
        public double Total { get; private set; }                     // final total after tax

        public string Status
        {
            get { return status; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Status cannot be empty!");
                }
                status = value;
            }
        }

        // constructors
        // call setters for validation
        // tax and total are calculated automatically

        public OrderInfo(
            CustomerInfo Customer,
            EmployeeInfo Employee,
            string Status
        ) {
            this.Customer = Customer;
            this.Employee = Employee;
            this.Status = Status;

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
        private void CalculateSubtotal() {
            Subtotal = 0;

            foreach (OrderItemInfo item in Items) {
                Subtotal += item.LineTotal;
            }
        }

        // calculate tax as 10% of subtotal
        private void CalculateTax() {
            Tax = Subtotal * 0.10;
        }

        // calculate final total
        private void CalculateTotal() {
            Total = Subtotal + Tax;
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
                output += item.MenuItem.Name + " ";
            }

            output += "\n";

            return output;
        }

        // ToCSV

        public string ToCSV() {
            string output = "";

            output += OrderID + ",";
            output += Customer.CustomerID + ",";
            output += Employee.EmployeeID + ",";
            output += Status + ",";
            output += Subtotal + ",";
            output += Tax + ",";
            output += Total + ",";

            // add all item IDs separated by |
            foreach (OrderItemInfo item in Items) {
                output += item.OrderItemID + "|";
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