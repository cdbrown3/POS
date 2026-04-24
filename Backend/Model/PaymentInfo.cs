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
        private string PaymentID;         // P00001 format
        private OrderInfo Order;          // order being paid for
        private string CardNumber;        // card number entered
        private double AmountPaid;        // amount paid
        private string PaymentStatus;     // pending, paid, failed

        // constructors

        public PaymentInfo(
            OrderInfo Order,
            string CardNumber
        ) {
            SetOrder(Order);
            SetCardNumber(CardNumber);

            // payment starts as pending
            this.AmountPaid = 0;
            this.PaymentStatus = "Pending";

            // generate UNIQUE Payment ID
            Count++;
            this.PaymentID = "P" + Count.ToString("D5");
        }

        // getters

        public string GetPaymentID() {
            return PaymentID;
        }

        public OrderInfo GetOrder() {
            return Order;
        }

        public string GetCardNumber() {
            return CardNumber;
        }

        public double GetAmountPaid() {
            return AmountPaid;
        }

        public string GetPaymentStatus() {
            return PaymentStatus;
        }

        // setters w/validation

        public void SetOrder(OrderInfo value) {
            if (value == null) {
                throw new ArgumentException("Order cannot be null!");
            }

            Order = value;
        }

        public void SetCardNumber(string value) {
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

            CardNumber = value;
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
            AmountPaid = Order.GetTotal();
            SetStatusToPaid();
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "Payment ID: " + PaymentID + "\n";
            output += "Order ID: " + Order.GetOrderID() + "\n";
            output += "Amount Paid: $" + AmountPaid + "\n";
            output += "Payment Status: " + PaymentStatus + "\n";

            return output;
        }

        // ToCSV

        public string ToCSV() {
            string output = "";

            output += PaymentID + ",";
            output += Order.GetOrderID() + ",";
            output += CardNumber + ",";
            output += AmountPaid + ",";
            output += PaymentStatus;

            return output;
        }
    }
}