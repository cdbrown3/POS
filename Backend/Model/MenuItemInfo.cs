using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class MenuItemInfo : IExportable {

        // variables:

        private static int Count = 0;

        public string ItemID { get; private set; }

        private string name;
        private string category;
        private double price;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Item name cannot be empty!");
                }

                name = value;
            }
        }

        public string Category
        {
            get { return category; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Category cannot be empty!");
                }

                category = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) {
                    throw new ArgumentException("Price cannot be negative!");
                }

                price = value;
            }
        }

        public bool IsAvailable { get; set; }

        // list of options
        public List<string> Options { get; set; }

        // constructors

        public MenuItemInfo(
            string Name,
            string Category,
            double Price,
            List<string> Options
        ) {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;

            // If null -> create empty list
            this.Options = Options ?? new List<string>();

            // default value = assume it is in stock
            this.IsAvailable = true;

            Count++;
            this.ItemID = "M" + Count.ToString("D5"); // identify each menu item
        }

        // helpers

        public void AddOption(string option) {
            if (!string.IsNullOrEmpty(option)) {
                Options.Add(option);
            }
        }

        public void RemoveOption(string option) {
            Options.Remove(option);
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "Item ID: " + ItemID + "\n";
            output += "Name: " + Name + "\n";
            output += "Category: " + Category + "\n";
            output += "Price: $" + Price + "\n";
            output += "Available: " + IsAvailable + "\n";

            output += "Options: ";

            foreach (string opt in Options) {
                output += opt + " ";
            }

            output += "\n";

            return output;
        }

        // CSV - storage

        public string ToCSV() {
            string output = "";

            output += ItemID + ",";
            output += Name + ",";
            output += Category + ",";
            output += Price + ",";
            output += IsAvailable + ",";

            // convert list to string
            foreach (string opt in Options) {
                output += opt + "|"; // use | to separate options
            }

            return output;
        }
    }
}