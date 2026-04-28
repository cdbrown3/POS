using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class OrderItemInfo : IExportable {
        // variables

        // static counter for UNIQUE Order Item ID
        private static int Count = 0;

        // order item fields
        public string OrderItemID { get; private set; }                 // I00001 format

        private MenuItemInfo menuItem;              // item being ordered
        private int quantity;                       // how many of this item

        public MenuItemInfo MenuItem
        {
            get { return menuItem; }
            set
            {
                if (value == null) {
                    throw new ArgumentException("Menu item cannot be null!");
                }

                menuItem = value;
                CalculateLineTotal();
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0) {
                    throw new ArgumentException("Quantity must be greater than 0!");
                }

                quantity = value;
                CalculateLineTotal();
            }
        }

        public List<string> SelectedOptions { get; set; }       // chosen options for this item
        public double LineTotal { get; private set; }           // total for this one order item

        // constructors

        public OrderItemInfo(
            MenuItemInfo MenuItem,
            int Quantity,
            List<string> SelectedOptions
        ) {
            this.MenuItem = MenuItem;
            this.Quantity = Quantity;

            // if null -> create empty list
            this.SelectedOptions = SelectedOptions ?? new List<string>();

            // calculate line total
            CalculateLineTotal();

            // generate UNIQUE Order Item ID
            Count++;
            this.OrderItemID = "I" + Count.ToString("D5");
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

        private void CalculateLineTotal() {
            // only calculate if MenuItem exists
            if (MenuItem != null) {
                LineTotal = MenuItem.Price * Quantity;
            }
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "Order Item ID: " + OrderItemID + "\n";
            output += "Menu Item: " + MenuItem.Name + "\n";
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
            output += MenuItem.ItemID + ",";
            output += Quantity + ",";
            output += LineTotal + ",";

            foreach (string option in SelectedOptions) {
                output += option + "|";
            }

            return output;
        }
    }
}