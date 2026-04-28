using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
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

        public bool HireEmployee(string first, string last, string phone, string email, AddressInfo address, string position, string username, string pin, double hourlyRate)
        {
            bool isSuccessful = false;

            if (first == "")
            {
                Console.WriteLine("Error: Missing first name for employee.");
            }
            else if (last == "")
            {
                Console.WriteLine("Error: Missing last name for employee.");
            }
            else if (address == null)
            {
                Console.WriteLine("Error: Missing address for employee.");
            }
            else
            {
                try
                {
                    EmployeeInfo newEmployee = new EmployeeInfo(first, last, phone, email, address, position, username, pin, hourlyRate);
                    employees.Add(newEmployee);
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                }
            }

            return isSuccessful;
        }

        public bool CreateMenuItem(string name, string category, double price, List<string> options)
        {
            bool isSuccessful = false;

            if (name == "")
            {
                Console.WriteLine("Error: Menu item name cannot be empty.");
            }
            else if (category == "")
            {
                Console.WriteLine("Error: Menu item category cannot be empty.");
            }
            else if (price < 0)
            {
                Console.WriteLine("Error: Menu item price cannot be negative.");
            }
            else
            {
                try
                {
                    MenuItemInfo newItem = new MenuItemInfo(name, category, price, options);
                    menuItems.Add(newItem);
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                }
            }

            return isSuccessful;
        }

        public EmployeeInfo FindEmployeeByUsername(string targetUsername)
        {
            EmployeeInfo foundEmployee = null;

            if (targetUsername == "")
            {
                Console.WriteLine("Error: Username search term is empty.");
            }
            else
            {
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
            }

            return foundEmployee;
        }

        // === RETRIEVAL METHODS ===

        public List<EmployeeInfo> GetAllEmployees()
        {
            return employees;
        }

        public List<MenuItemInfo> GetAllMenuItems()
        {
            return menuItems;
        }

        // === SAVING METHODS (CSV & XML) ===

        public bool SaveEmployees(string filePath, string format)
        {
            bool isSuccessful = false;

            if (filePath == "")
            {
                Console.WriteLine("Error: File path cannot be empty.");
            }
            else if (format.ToUpper() == "CSV")
            {
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

                    File.WriteAllLines(filePath, lines);
                    Console.WriteLine("Successfully saved " + employees.Count + " employees to CSV.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while saving employees to CSV: " + e.Message);
                }
            }
            else if (format.ToUpper() == "XML")
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                        writer.WriteLine("<Employees>");

                        int index = 0;
                        while (index < employees.Count)
                        {
                            writer.WriteLine("  <Employee>");
                            writer.WriteLine("    <UserID>" + employees[index].UserID + "</UserID>");
                            writer.WriteLine("    <FirstName>" + employees[index].FirstName + "</FirstName>");
                            writer.WriteLine("    <LastName>" + employees[index].LastName + "</LastName>");
                            writer.WriteLine("    <Phone>" + employees[index].PhoneNumber + "</Phone>");
                            writer.WriteLine("    <Email>" + employees[index].Email + "</Email>");
                            writer.WriteLine("    <Street>" + employees[index].Address.Street + "</Street>");
                            writer.WriteLine("    <City>" + employees[index].Address.City + "</City>");
                            writer.WriteLine("    <State>" + employees[index].Address.StateAbbreviation + "</State>");
                            writer.WriteLine("    <Zip>" + employees[index].Address.ZipCode + "</Zip>");
                            writer.WriteLine("    <EmployeeID>" + employees[index].EmployeeID + "</EmployeeID>");
                            writer.WriteLine("    <Position>" + employees[index].Position + "</Position>");
                            writer.WriteLine("    <HourlyRate>" + employees[index].HourlyRate + "</HourlyRate>");
                            writer.WriteLine("    <IsActive>" + employees[index].IsActive + "</IsActive>");
                            writer.WriteLine("  </Employee>");
                            index++;
                        }
                        writer.WriteLine("</Employees>");
                    }
                    Console.WriteLine("Successfully saved " + employees.Count + " employees to XML.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while saving employees to XML: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported format. Use 'CSV' or 'XML'.");
            }

            return isSuccessful;
        }

        public bool SaveMenu(string filePath, string format)
        {
            bool isSuccessful = false;

            if (filePath == "")
            {
                Console.WriteLine("Error: File path cannot be empty.");
            }
            else if (format.ToUpper() == "CSV")
            {
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

                    File.WriteAllLines(filePath, lines);
                    Console.WriteLine("Successfully saved " + menuItems.Count + " menu items to CSV.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while saving menu to CSV: " + e.Message);
                }
            }
            else if (format.ToUpper() == "XML")
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                        writer.WriteLine("<MenuItems>");

                        int index = 0;
                        while (index < menuItems.Count)
                        {
                            writer.WriteLine("  <MenuItem>");
                            writer.WriteLine("    <ItemID>" + menuItems[index].ItemID + "</ItemID>");
                            writer.WriteLine("    <Name>" + menuItems[index].Name + "</Name>");
                            writer.WriteLine("    <Category>" + menuItems[index].Category + "</Category>");
                            writer.WriteLine("    <Price>" + menuItems[index].Price + "</Price>");
                            writer.WriteLine("    <IsAvailable>" + menuItems[index].IsAvailable + "</IsAvailable>");

                            writer.WriteLine("    <Options>");
                            int optIndex = 0;
                            while (optIndex < menuItems[index].Options.Count)
                            {
                                writer.WriteLine("      <Option>" + menuItems[index].Options[optIndex] + "</Option>");
                                optIndex++;
                            }
                            writer.WriteLine("    </Options>");

                            writer.WriteLine("  </MenuItem>");
                            index++;
                        }
                        writer.WriteLine("</MenuItems>");
                    }
                    Console.WriteLine("Successfully saved " + menuItems.Count + " menu items to XML.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while saving menu to XML: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported format. Use 'CSV' or 'XML'.");
            }

            return isSuccessful;
        }

        // === LOADING METHODS (CSV & XML) ===

        public bool LoadEmployees(string filePath, string format)
        {
            bool isSuccessful = false;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: Employee file not found at " + filePath);
            }
            else if (format.ToUpper() == "CSV")
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
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
                                parts[1], parts[2], parts[3], parts[4],
                                address, parts[10], loadedUsername,
                                tempPassword, hourlyRate
                            );

                            bool isActive = true;
                            bool.TryParse(parts[12], out isActive);
                            loadedEmployee.IsActive = isActive;

                            employees.Add(loadedEmployee);
                        }
                        index++;
                    }

                    Console.WriteLine("Successfully loaded " + employees.Count + " employees from CSV.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while loading employees from CSV: " + e.Message);
                }
            }
            else if (format.ToUpper() == "XML")
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);
                    XmlNodeList nodes = doc.SelectNodes("/Employees/Employee");

                    int index = 0;
                    while (index < nodes.Count)
                    {
                        XmlNode node = nodes[index];
                        AddressInfo address = new AddressInfo(
                            node["Street"]?.InnerText,
                            node["City"]?.InnerText,
                            node["State"]?.InnerText,
                            node["Zip"]?.InnerText
                        );

                        double hourlyRate = 0;
                        double.TryParse(node["HourlyRate"]?.InnerText, out hourlyRate);

                        string loadedUsername = node["FirstName"]?.InnerText.ToLower() + node["LastName"]?.InnerText.ToLower();
                        string tempPassword = "0000";

                        EmployeeInfo loadedEmployee = new EmployeeInfo(
                            node["FirstName"]?.InnerText,
                            node["LastName"]?.InnerText,
                            node["Phone"]?.InnerText,
                            node["Email"]?.InnerText,
                            address,
                            node["Position"]?.InnerText,
                            loadedUsername,
                            tempPassword,
                            hourlyRate
                        );

                        bool isActive = true;
                        bool.TryParse(node["IsActive"]?.InnerText, out isActive);
                        loadedEmployee.IsActive = isActive;

                        employees.Add(loadedEmployee);
                        index++;
                    }

                    Console.WriteLine("Successfully loaded " + employees.Count + " employees from XML.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while loading employees from XML: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported format. Use 'CSV' or 'XML'.");
            }

            return isSuccessful;
        }

        public bool LoadMenu(string filePath, string format)
        {
            bool isSuccessful = false;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: Menu file not found at " + filePath);
            }
            else if (format.ToUpper() == "CSV")
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
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
                                parts[1], parts[2], price, options
                            );

                            bool isAvailable = true;
                            bool.TryParse(parts[4], out isAvailable);
                            loadedItem.IsAvailable = isAvailable;

                            menuItems.Add(loadedItem);
                        }
                        index++;
                    }

                    Console.WriteLine("Successfully loaded " + menuItems.Count + " menu items from CSV.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while loading menu from CSV: " + e.Message);
                }
            }
            else if (format.ToUpper() == "XML")
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);
                    XmlNodeList nodes = doc.SelectNodes("/MenuItems/MenuItem");

                    int index = 0;
                    while (index < nodes.Count)
                    {
                        XmlNode node = nodes[index];

                        double price = 0;
                        double.TryParse(node["Price"]?.InnerText, out price);

                        List<string> options = new List<string>();
                        XmlNodeList optionNodes = node.SelectNodes("Options/Option");
                        int optIndex = 0;
                        while (optIndex < optionNodes.Count)
                        {
                            options.Add(optionNodes[optIndex].InnerText);
                            optIndex++;
                        }

                        MenuItemInfo loadedItem = new MenuItemInfo(
                            node["Name"]?.InnerText,
                            node["Category"]?.InnerText,
                            price,
                            options
                        );

                        bool isAvailable = true;
                        bool.TryParse(node["IsAvailable"]?.InnerText, out isAvailable);
                        loadedItem.IsAvailable = isAvailable;

                        menuItems.Add(loadedItem);
                        index++;
                    }

                    Console.WriteLine("Successfully loaded " + menuItems.Count + " menu items from XML.");
                    isSuccessful = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught while loading menu from XML: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported format. Use 'CSV' or 'XML'.");
            }

            return isSuccessful;
        }
    }
}