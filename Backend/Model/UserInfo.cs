using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public class UserInfo : IExportable {  // public so other classes can inherit and controller
    
        // variables:

        // static counter used to generate UNIQUE IDs
        private static int Count = 0;

        // unique User ID (ex: U00001) has 'U' so string not int | stores for one specific user
        private string userID;

        // basic user information
        private string FirstName;
        private string LastName;
        private string PhoneNumber; // string b/c of '-' or '()'
        private string Email;
        private AddressInfo Address;

        // constructors
        // minimum required information to create a user
        // First Name, Last Name, Phone, Email, Address

        public UserInfo(string first, string last, string phone, string email, AddressInfo address)
        // easier to test and avoid complication
        {
            // TODO: Add validation if needed

            this.FirstName = first;
            this.LastName = last;
            this.PhoneNumber = phone;
            this.Email = email;
            this.Address = address;

            // generate ID
            Count++; // add 1 to the shared user counter
            this.userID = "U" + Count.ToString("D5"); // U00001 format
        }

        // getters

        public string GetUserID() {
            return userID;
        }

        public string GetFirstName() {
            return FirstName;
        }

        public string GetLastName() {
            return LastName;
        }

        public string GetPhoneNumber() {
            return PhoneNumber;
        }

        public string GetEmail() {
            return Email;
        }

        public AddressInfo GetAddress() {
            return Address;
        }

        // setters

        public void SetFirstName(string value) {
        if (string.IsNullOrEmpty(value)) {
            throw new ArgumentException("First Name cannot be empty!");
        }

        FirstName = value;
        }

        public void SetLastName(string value) {
        if (string.IsNullOrEmpty(value)) {
            throw new ArgumentException("Last Name cannot be empty!");
        }

        LastName = value;
        }

        public void SetPhoneNumber(string value) {
        if (string.IsNullOrEmpty(value)) {
            throw new ArgumentException("Phone Number cannot be empty!");
        }

        PhoneNumber = value;
        }

        public void SetEmail(string value) {
        if (string.IsNullOrEmpty(value)) {
            throw new ArgumentException("Email cannot be empty!");
        }

        if (!value.Contains("@")) {
            throw new ArgumentException("Invalid Email Entered!");
        }

        Email = value;
        }

        public void SetAddress(AddressInfo value) {
            if (value == null) {
                throw new ArgumentException("Address cannot be null!");
            }

            Address = value;
        }

        // helper - avoid repetition

        // returns full name (for GUI)
        public string GetFullName() {
            return FirstName + " " + LastName;
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "User ID: " + userID + "\n";
            output += "Name: " + GetFullName() + "\n";
            output += "Phone: " + PhoneNumber + "\n";
            output += "Email: " + Email + "\n";
            output += "Address: " + Address.ToString() + "\n";

            return output;
        }

        // CSV - storage

        public virtual string ToCSV() {
            string output = "";

            output += userID + ",";
            output += FirstName + ",";
            output += LastName + ",";
            output += PhoneNumber + ",";
            output += Email + ",";
            output += Address.ToCSV();

            return output;
        }
    }
}
