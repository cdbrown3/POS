using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class PaymentInfo : IExportable {
        // variables

        // static counter for UNIQUE Payment IDs
        private static int Count = 0;

        // payment specific fields
        public string PaymentID { get; private set; }         // P00001 format

        private OrderInfo order;
        private string cardNumber;
        private string paymentStatus;

        public OrderInfo Order
        {
            get { return order; }
            set
            {
                if (value == null) {
                    throw new ArgumentException("Order cannot be null!");
                }
                order = value;
            }
        }

        public string CardNumber
        {
            private get { return cardNumber; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Card number cannot be empty!");
                }

                // card number must be exactly 16 digits
                if (value.Length != 16) {
                    throw new ArgumentException("Card number must be exactly 16 digits!");
                }

                // check that all characters are digits
                foreach (char c in value) {
                    if (!char.IsDigit(c)) {
                        throw new ArgumentException("Card number must contain only numbers!");
                    }
                }

                cardNumber = value;
            }
        }

        public double AmountPaid { get; private set; }        // amount paid

        public string PaymentStatus
        {
            get { return paymentStatus; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Payment status cannot be empty!");
                }
                paymentStatus = value;
            }
        }

        // constructors

        public PaymentInfo(
            OrderInfo Order,
            string CardNumber
        ) {
            this.Order = Order;
            this.CardNumber = CardNumber;

            // payment starts as pending
            this.AmountPaid = 0;
            this.PaymentStatus = "Pending";

            // generate UNIQUE Payment ID
            Count++;
            this.PaymentID = "P" + Count.ToString("D5");
        }

        // status for payment

        public void SetStatusToPending() {
            PaymentStatus = "Pending";
        }

        public void SetStatusToPaid() {
            PaymentStatus = "Paid";
        }

        public void SetStatusToFailed() {
            PaymentStatus = "Failed";
        }

        // helpers

        // process payment for the full order total
        public void ProcessPayment() {
            AmountPaid = Order.Total;
            SetStatusToPaid();
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "Payment ID: " + PaymentID + "\n";
            output += "Order ID: " + Order.OrderID + "\n";
            output += "Amount Paid: $" + AmountPaid + "\n";
            output += "Payment Status: " + PaymentStatus + "\n";

            return output;
        }

        // ToCSV

        public string ToCSV() {
            string output = "";

            output += PaymentID + ",";
            output += Order.OrderID + ",";
            output += CardNumber + ",";
            output += AmountPaid + ",";
            output += PaymentStatus;

            return output;
        }
    }
}