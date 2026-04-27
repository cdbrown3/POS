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
        public string CustomerID { get; private set; }          // C00001 format

        private int orderHistoryCount;      // number of past orders
        private string notes;               // extra notes for customer

        public int OrderHistoryCount
        {
            get { return orderHistoryCount; }
            set
            {
                if (value < 0) {
                    throw new ArgumentException("Order history count cannot be negative!");
                }
                orderHistoryCount = value;
            }
        }

        public string Notes
        {
            get { return notes; }
            set
            {
                // if null -> store as empty string instead
                notes = value ?? "";
            }
        }

        // constructors
        // calls base constructor for UserInfo fields

        public CustomerInfo(
            string First,
            string Last,
            string Phone,
            string Email,
            AddressInfo Address,
            int OrderHistoryCount,
            string Notes
        ) : base(First, Last, Phone, Email, Address) {
            // using setters for validation
            this.OrderHistoryCount = OrderHistoryCount;
            this.Notes = Notes;

            // generate UNIQUE Employee ID
            Count++;
            this.CustomerID = "C" + Count.ToString("D5");
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

        public override string ToCSV() {
            string output = "";

            // base class data (UserInfo)
            output += UserID + ",";
            output += FirstName + ",";
            output += LastName + ",";
            output += PhoneNumber + ",";
            output += Email + ",";
            output += Address.ToCSV() + ",";

            // Customer specific data
            output += CustomerID + ",";
            output += OrderHistoryCount + ",";
            output += Notes;

            return output;
        }
    }
}