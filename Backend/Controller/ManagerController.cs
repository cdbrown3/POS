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
    }
}