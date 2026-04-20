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
        private string EmployeeID;   // E00001 format
        private string Position;
        private string Username;
        private string Password;     // senstive
        private double HourlyRate; // double = $12.75
        private bool IsActive;  // bool = true or false

        // constructors
        // calls base constructor for UserInfo fields

        public EmployeeInfo(
            string First,
            string Last,
            string Phone,
            string Email,
            string Address,
            string Position,
            string Username,
            string Password, // string = if leading 0
            double HourlyRate // double = $12.75
        ) : base(First, Last, Phone, Email, Address) { // base to avoid duplication since they are a user first
            // calls the constructors in UserInfo
            // Use setters for validation
            SetUsername(Username);
            SetPassword(Password);
            SetPosition(Position);
            SetHourlyRate(HourlyRate);

            // default value - new employee will start active
            this.IsActive = true;

            // generate UNIQUE Employee ID
            Count++;
            this.EmployeeID = "E" + Count.ToString("D5");
        }

        // getters

        public string GetEmployeeID() {
            return EmployeeID;
        }

        public string GetPosition() {
            return Position;
        }

        public string GetUsername() {
            return Username;
        }

        public double GetHourlyRate() {
            return HourlyRate;
        }

        public bool GetIsActive() {
            return IsActive;
        }

    // setters w/validation
        public void SetUsername(string value) {
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException("Username cannot be empty!");
            }

            Username = value;
        }
        public void SetPassword(string value) {
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

            Password = value;
        }
        public void SetPosition(string value) {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Position cannot be empty!");
                }

                Position = value;
            }

        public void SetHourlyRate(double value) {
            if (value < 0) {
                throw new ArgumentException("Hourly rate cannot be negative!");
            }

            HourlyRate = value;
        }

        public void SetActive(bool value) {
            IsActive = value;
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

        public string ToCSV() {
            string output = "";

            // base class data (UserInfo)
            output += GetUserID() + ",";
            output += GetFirstName() + ",";
            output += GetLastName() + ",";
            output += GetPhoneNumber() + ",";
            output += GetEmail() + ",";
            output += GetAddress() + ",";

            // Employee specific data
            output += EmployeeID + ",";
            output += Position + ",";
            output += HourlyRate + ",";
            output += IsActive;

            return output;
        }
    }
}
