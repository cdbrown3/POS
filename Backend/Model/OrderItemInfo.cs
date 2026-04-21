using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class OrderItemInfo : IExportable {
        // variables

        // static counter for UNIQUE Order Item IDs
        private static int Count = 0;

        // order item fields
        private string OrderItemID;                 // I00001 format
        private MenuItemInfo MenuItem;              // item being ordered
        private int Quantity;                       // how many of this item
        private List<string> SelectedOptions;       // chosen options for this item
        private double LineTotal;                   // total for this one order item

        // constructors

        public OrderItemInfo(
            MenuItemInfo MenuItem,
            int Quantity,
            List<string> SelectedOptions
        ) {
            SetMenuItem(MenuItem);
            SetQuantity(Quantity);

            // if null, create empty list
            this.SelectedOptions = SelectedOptions ?? new List<string>();

            // calculate line total
            CalculateLineTotal();

            // generate UNIQUE Order Item ID
            Count++;
            this.OrderItemID = "I" + Count.ToString("D5");
        }

        // getters

        public string GetOrderItemID() {
            return OrderItemID;
        }

        public MenuItemInfo GetMenuItem() {
            return MenuItem;
        }

        public int GetQuantity() {
            return Quantity;
        }

        public List<string> GetSelectedOptions() {
            return SelectedOptions;
        }

        public double GetLineTotal() {
            return LineTotal;
        }

        // setters w/validation

        public void SetMenuItem(MenuItemInfo value) {
            if (value == null) {
                throw new ArgumentException("Menu item cannot be null!");
            }

            MenuItem = value;
            CalculateLineTotal();
        }

        public void SetQuantity(int value) {
            if (value <= 0) {
                throw new ArgumentException("Quantity must be greater than 0!");
            }

            Quantity = value;
            CalculateLineTotal();
        }

        public void SetSelectedOptions(List<string> value) {
            SelectedOptions = value ?? new List<string>();
        }

        // helpers

        public void AddSelectedOption(string option) {
            if (!string.IsNullOrEmpty(option)) {
                SelectedOptions.Add(option);
            }
        }

        public void RemoveSelectedOption(string option) {
            SelectedOptions.Remove(option);
        }

        public void CalculateLineTotal() {
            // only calculate if MenuItem exists
            if (MenuItem != null) {
                LineTotal = MenuItem.GetPrice() * Quantity;
            }
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "Order Item ID: " + OrderItemID + "\n";
            output += "Menu Item: " + MenuItem.GetName() + "\n";
            output += "Quantity: " + Quantity + "\n";
            output += "Line Total: $" + LineTotal + "\n";

            output += "Selected Options: ";

            foreach (string option in SelectedOptions) {
                output += option + " ";
            }

            output += "\n";

            return output;
        }

        // ToCSV - storage

        public string ToCSV() {
            string output = "";

            output += OrderItemID + ",";
            output += MenuItem.GetItemID() + ",";
            output += Quantity + ",";
            output += LineTotal + ",";

            foreach (string option in SelectedOptions) {
                output += option + "|";
            }

            return output;
        }
    }
}