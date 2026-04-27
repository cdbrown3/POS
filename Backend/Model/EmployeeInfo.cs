using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class EmployeeInfo : UserInfo {

        // variables:

        // static counter used to generate UNIQUE IDs
        private static int Count = 0;

        // employee specific fields
        public string EmployeeID { get; private set; }   // E00001 format

        private string position;
        private string username;
        private string password;     // senstive
        private double hourlyRate; // double = $12.75
        public bool IsActive { get; set; }  // bool = true or false

        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Position cannot be empty!");
                }

                position = value;
            }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Username cannot be empty!");
                }

                username = value;
            }
        }

        public string Password
        {
            private get { return password; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("PIN cannot be empty!");
                }

                if (value.Length != 4) {
                    throw new ArgumentException("PIN must be exactly 4 digits!");
                }

                // check that all characters are digits - How to only have a password be 4 digits in VSCode in Setters
                foreach (char c in value) { // go through each value in the strong one time
                    if (!char.IsDigit(c)) { // if char is a number
                        throw new ArgumentException("PIN must contain only numbers!");
                    }
                }

                password = value;
            }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (value < 0) {
                    throw new ArgumentException("Hourly rate cannot be negative!");
                }

                hourlyRate = value;
            }
        }

        // constructors
        // calls base constructor for UserInfo fields

        public EmployeeInfo(
            string First,
            string Last,
            string Phone,
            string Email,
            AddressInfo Address,
            string Position,
            string Username,
            string Password, // string = if leading 0
            double HourlyRate // double = $12.75
        ) : base(First, Last, Phone, Email, Address) { // base to avoid duplication since they are a user first
            // calls the constructors in UserInfo
            // Use setters for validation
            this.Username = Username;
            this.Password = Password;
            this.Position = Position;
            this.HourlyRate = HourlyRate;

            // default value - new employee will start active
            this.IsActive = true;

            // generate UNIQUE Employee ID
            Count++;
            this.EmployeeID = "E" + Count.ToString("D5");
        }

        // login validation:
        // DO NOT expose password directly

        public bool ValidateLogin(string user, string pass) {
            return (user == Username && pass == Password);
        }

        // ToString

        public override string ToString() {
            string output = base.ToString();

            output += "Employee ID: " + EmployeeID + "\n";
            output += "Position: " + Position + "\n";
            output += "Hourly Rate: " + HourlyRate + "\n";
            output += "Active: " + IsActive + "\n";

            return output;
        }

        // CSV - Storage

        public override string ToCSV() {
            string output = "";

            // base class data (UserInfo)
            output += UserID + ",";
            output += FirstName + ",";
            output += LastName + ",";
            output += PhoneNumber + ",";
            output += Email + ",";
            output += Address.ToCSV() + ",";

            // Employee specific data
            output += EmployeeID + ",";
            output += Position + ",";
            output += HourlyRate + ",";
            output += IsActive;

            return output;
        }
    }
}