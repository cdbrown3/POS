using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class MenuItemInfo : IExportable {

        // variables:

        private static int Count = 0;

        private string ItemID;
        private string Name;
        private string Category;
        private double Price;
        private bool IsAvailable;

        // list of options
        private List<string> Options;

        // constructors

        public MenuItemInfo(
            string Name,
            string Category,
            double Price,
            List<string> Options
        ) {
            SetName(Name);
            SetCategory(Category);
            SetPrice(Price);

            // If null -> create empty list
            this.Options = Options ?? new List<string>();
            
            // default value = assume it is in stock
            this.IsAvailable = true;

            Count++;
            this.ItemID = "M" + Count.ToString("D5"); // identify each menu item
        }

        // getters

        public string GetItemID() {
            return ItemID;
        }

        public string GetName() {
            return Name;
        }

        public string GetCategory() {
            return Category;
        }

        public double GetPrice() {
            return Price;
        }

        public bool GetIsAvailable() {
            return IsAvailable;
        }

        public List<string> GetOptions() {
            return Options;
        }

        // setters w/validation

        public void SetName(string value) {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException("Item name cannot be empty!");
            }

            Name = value;
        }

        public void SetCategory(string value) {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException("Category cannot be empty!");
            }

            Category = value;
        }

        public void SetPrice(double value) {
            if (value < 0) {
                throw new ArgumentException("Price cannot be negative!");
            }

            Price = value;
        }

        public void SetAvailable(bool value) {
            IsAvailable = value;
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