using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class CustomerInfo : UserInfo {

        // vairables:

        // static counter used to generate UNIQUE IDs
        private static int Count = 0;

        // customer specific fields
        private string CustomerID;          // C00001 format
        private int OrderHistoryCount;      // number of past orders
        private string Notes;               // extra notes for customer

        // constructors
        // calls base constructor for UserInfo fields

        public CustomerInfo(
            string First,
            string Last,
            string Phone,
            string Email,
            string Address,
            int OrderHistoryCount,
            string Notes
        ) : base(First, Last, Phone, Email, Address) {
            // using setters for validation
            SetOrderHistoryCount(OrderHistoryCount);
            SetNotes(Notes);

            // generate UNIQUE Employee ID
            Count++;
            this.CustomerID = "C" + Count.ToString("D5");
        }

        // getters

        public string GetCustomerID() {
            return CustomerID;
        }

        public int GetOrderHistoryCount() {
            return OrderHistoryCount;
        }

        public string GetNotes() {
            return Notes;
        }

        // setters w/ validation

        public void SetOrderHistoryCount(int value) {
            if (value < 0) {
                throw new ArgumentException("Order history count cannot be negative!");
            }

            OrderHistoryCount = value;
        }

        public void SetNotes(string value) {
            // if null -> store as empty string instead
            Notes = value ?? "";
        }

        // helper
        public void AddOrderToHistory() { // increase order history count when customer places an order
            OrderHistoryCount++;
        }

        // ToString

        public override string ToString() {
            string output = base.ToString();

            output += "Customer ID: " + CustomerID + "\n";
            output += "Order History Count: " + OrderHistoryCount + "\n";
            output += "Notes: " + Notes + "\n";

            return output;
        }

        // CSV - storage

        public string ToCSV() {
            string output = "";

            // base class data (UserInfo)
            output += GetUserID() + ",";
            output += GetFirstName() + ",";
            output += GetLastName() + ",";
            output += GetPhoneNumber() + ",";
            output += GetEmail() + ",";
            output += GetAddress() + ",";

            // Customer specific data
            output += CustomerID + ",";
            output += OrderHistoryCount + ",";
            output += Notes;

            return output;
        }
    }
}