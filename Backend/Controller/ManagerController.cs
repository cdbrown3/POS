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

        // --- CORE HIRING & MENU METHODS ---

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

        public EmployeeInfo FindEmployeeByUsername(string targetUsername)
        {
            if (targetUsername == "")
            {
                Console.WriteLine("Error: Username search term is empty.");
                return null;
            }

            EmployeeInfo foundEmployee = null;
            bool isFound = false;
            int index = 0;

            while (index < employees.Count && isFound == false)
            {
                if (employees[index].Username == targetUsername)
                {
                    foundEmployee = employees[index];
                    isFound = true;
                }
                index++;
            }

            return foundEmployee;
        }

        // --- RETRIEVAL METHODS ---

        public List<EmployeeInfo> GetAllEmployees()
        {
            return employees;
        }

        public List<MenuItemInfo> GetAllMenuItems()
        {
            return menuItems;
        }

        // --- CSV SAVING METHODS ---

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

        // --- CSV LOADING METHODS ---

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
                        AddressInfo address = new AddressInfo(parts[5], parts[6], parts[7], parts[8]);

                        double hourlyRate = 0;
                        double.TryParse(parts[11], out hourlyRate);

                        string loadedUsername = parts[1].ToLower() + parts[2].ToLower();
                        string tempPassword = "0000";

                        EmployeeInfo loadedEmployee = new EmployeeInfo(
                            parts[1],
                            parts[2],
                            parts[3],
                            parts[4],
                            address,
                            parts[10],
                            loadedUsername,
                            tempPassword,
                            hourlyRate
                        );

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

                        MenuItemInfo loadedItem = new MenuItemInfo(
                            parts[1],
                            parts[2],
                            price,
                            options
                        );

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