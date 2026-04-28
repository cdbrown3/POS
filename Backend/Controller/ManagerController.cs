using System;
using System.Collections.Generic;
using Backend.Model;

namespace Backend.Controller
{
    public class ManagerController
    {

        private List<EmployeeInfo> employees;
        private List<MenuItemInfo> menuItems;

        public ManagerController()
        {
            this.employees = new List<EmployeeInfo>();
            this.menuItems = new List<MenuItemInfo>();
        }

        // === CORE HIRING & MENU METHODS ===

        // GUI Link: Triggered by a "Hire New Staff" button on the Manager Dashboard.
        // Form takes basic info, plus sets their system login (Username/PIN) and wage.
        public bool HireEmployee(string first, string last, string phone, string email, AddressInfo address, string position, string username, string pin, double hourlyRate)
        {
            if (first == "")
            {
                Console.WriteLine("Error: Missing first name for employee.");
                return false;
            }

            if (last == "")
            {
                Console.WriteLine("Error: Missing last name for employee.");
                return false;
            }

            if (address == null)
            {
                Console.WriteLine("Error: Missing address for employee.");
                return false;
            }

            try
            {
                // MODEL LINK: Calls EmployeeInfo constructor. Triggers the setter validations in the model 
                // (for example, ensuring the PIN is exactly 4 digits & hourly rate isn't negative).
                EmployeeInfo newEmployee = new EmployeeInfo(first, last, phone, email, address, position, username, pin, hourlyRate);
                employees.Add(newEmployee);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return false;
            }
        }

        // GUI Link: Triggered by an "Add to Menu" button inside the Kitchen/Menu Management settings screen.
        public bool CreateMenuItem(string name, string category, double price, List<string> options)
        {
            if (name == "")
            {
                Console.WriteLine("Error: Menu item name cannot be empty.");
                return false;
            }

            if (category == "")
            {
                Console.WriteLine("Error: Menu item category cannot be empty.");
                return false;
            }

            if (price < 0)
            {
                Console.WriteLine("Error: Menu item price cannot be negative.");
                return false;
            }

            try
            {
                // MODEL LINK: Calls the MenuItemInfo constructor. Automatically sets IsAvailable to true
                // and generates a unique ItemID (e.g., M00001).
                MenuItemInfo newItem = new MenuItemInfo(name, category, price, options);
                menuItems.Add(newItem);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                return false;
            }
        }

        // GUI Link: Crucial for the initial Login Screen! When a user types their username and hits "Enter",
        // the GUI calls this method to find the matching employee record to verify their PIN to let them in (if valid).
        public EmployeeInfo FindEmployeeByUsername(string targetUsername)
        {
            if (targetUsername == "")
            {
                Console.WriteLine("Error: Username search term is empty.");
                return null; // Tells the GUI the user doesn't exist
            }

            EmployeeInfo foundEmployee = null;
            bool isFound = false;
            int index = 0;

            // Loops through the entire staff list until the username matches.
            // Uses boolean instead of a 'break' statement.
            while (index < employees.Count && isFound == false)
            {
                // MODEL LINK: Accesses the Username property getter in the EmployeeInfo model
                if (employees[index].Username == targetUsername)
                {
                    foundEmployee = employees[index];
                    isFound = true; // Flips the flag to exit the loop
                }
                index++;
            }

            return foundEmployee; // Returns the full employee object back to the GUI for the next step (PIN validation)
        }

        // === RETRIEVAL METHODS ===

        // GUI Link: Used to populate ListViews/DataGrids on the Manager Dashboard.
        public List<EmployeeInfo> GetAllEmployees()
        {
            return employees;
        }

        public List<MenuItemInfo> GetAllMenuItems()
        {
            return menuItems;
        }

        // === CSV SAVING METHODS ===

        // GUI Link: Triggered by a background autosave timer or manual "Save All Data" button.
        public bool SaveEmployeesToCSV(string filePath)
        {
            if (filePath == "")
            {
                Console.WriteLine("Error: File path cannot be empty.");
                return false;
            }

            try
            {
                List<string> lines = new List<string>();
                lines.Add("UserID,FirstName,LastName,Phone,Email,Street,City,State,Zip,EmployeeID,Position,HourlyRate,IsActive");

                int index = 0;
                while (index < employees.Count)
                {
                    // MODEL LINK: Calls the EmployeeInfo ToCSV() method.
                    lines.Add(employees[index].ToCSV());
                    index++;
                }

                System.IO.File.WriteAllLines(filePath, lines);
                Console.WriteLine("Successfully saved " + employees.Count + " employees.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while saving employees: " + e.Message);
                return false;
            }
        }

        // GUI Link: Saving menu changes after a manager edits prices or adds new items.
        public bool SaveMenuToCSV(string filePath)
        {
            if (filePath == "")
            {
                Console.WriteLine("Error: File path cannot be empty.");
                return false;
            }

            try
            {
                List<string> lines = new List<string>();
                lines.Add("ItemID,Name,Category,Price,IsAvailable,Options");

                int index = 0;
                while (index < menuItems.Count)
                {
                    // MODEL LINK: Calls the MenuItemInfo ToCSV() method. Notice how it formats the 
                    // List<string> Options by putting a '|' character between them.
                    lines.Add(menuItems[index].ToCSV());
                    index++;
                }

                System.IO.File.WriteAllLines(filePath, lines);
                Console.WriteLine("Successfully saved " + menuItems.Count + " menu items.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while saving menu: " + e.Message);
                return false;
            }
        }

        // === CSV LOADING METHODS ===

        // GUI Link: Called during application startup to load the staff database into memory.
        public bool LoadEmployeesFromCSV(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine("Error: Employee CSV file not found at " + filePath);
                return false;
            }

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                int index = 1;

                while (index < lines.Length)
                {
                    string[] parts = lines[index].Split(',');

                    if (parts.Length >= 13)
                    {
                        // MODEL LINK: Rebuilding the AddressInfo object
                        AddressInfo address = new AddressInfo(parts[5], parts[6], parts[7], parts[8]);

                        double hourlyRate = 0;
                        double.TryParse(parts[11], out hourlyRate);

                        // As a workaround since username/password aren't in the CSV output currently, 
                        // we build a temporary one to satisfy the model constructor requirements.
                        string loadedUsername = parts[1].ToLower() + parts[2].ToLower();
                        string tempPassword = "0000";

                        // MODEL LINK: Rebuilding the EmployeeInfo object
                        EmployeeInfo loadedEmployee = new EmployeeInfo(
                            parts[1], parts[2], parts[3], parts[4],
                            address, parts[10], loadedUsername,
                            tempPassword, hourlyRate
                        );

                        // MODEL LINK: Explicitly sets the Active status property
                        bool isActive = true;
                        bool.TryParse(parts[12], out isActive);
                        loadedEmployee.IsActive = isActive;

                        employees.Add(loadedEmployee);
                    }
                    index++;
                }

                Console.WriteLine("Successfully loaded " + employees.Count + " employees.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while loading employees: " + e.Message);
                return false;
            }
        }

        // GUI Link: Called during application startup to load the restaurant's menu into memory.
        public bool LoadMenuFromCSV(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine("Error: Menu CSV file not found at " + filePath);
                return false;
            }

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                int index = 1;

                while (index < lines.Length)
                {
                    string[] parts = lines[index].Split(',');

                    if (parts.Length >= 5)
                    {
                        double price = 0;
                        double.TryParse(parts[3], out price);

                        // MODEL LINK: Rebuilding the options list. Needs to split the string again 
                        // using the '|' character we used when saving the CSV.
                        List<string> options = new List<string>();
                        if (parts.Length == 6 && parts[5] != "")
                        {
                            string[] optionArray = parts[5].Split('|');
                            int optIndex = 0;

                            while (optIndex < optionArray.Length)
                            {
                                if (optionArray[optIndex] != "")
                                {
                                    options.Add(optionArray[optIndex]);
                                }
                                optIndex++;
                            }
                        }

                        // MODEL LINK: Rebuilding the MenuItemInfo object
                        MenuItemInfo loadedItem = new MenuItemInfo(
                            parts[1], parts[2], price, options
                        );

                        // MODEL LINK: Explicitly sets the IsAvailable property
                        bool isAvailable = true;
                        bool.TryParse(parts[4], out isAvailable);
                        loadedItem.IsAvailable = isAvailable;

                        menuItems.Add(loadedItem);
                    }
                    index++;
                }

                Console.WriteLine("Successfully loaded " + menuItems.Count + " menu items.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught while loading menu: " + e.Message);
                return false;
            }
        }
    }
}