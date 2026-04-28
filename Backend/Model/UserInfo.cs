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
        public string UserID { get; private set; }

        // basic user information
        private string firstName;
        private string lastName;
        private string phoneNumber; // string b/c of '-' or '()'
        private string email;
        private AddressInfo address;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("First Name cannot be empty!");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Last Name cannot be empty!");
                }
                lastName = value;
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Phone Number cannot be empty!");
                }
                phoneNumber = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Email cannot be empty!");
                }

                if (!value.Contains("@")) {
                    throw new ArgumentException("Invalid Email Entered!");
                }

                email = value;
            }
        }

        public AddressInfo Address
        {
            get { return address; }
            set
            {
                if (value == null) {
                    throw new ArgumentException("Address cannot be null!");
                }
                address = value;
            }
        }

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
            this.UserID = "U" + Count.ToString("D5"); // U00001 format
        }

        // helper - avoid repetition

        // returns full name (for GUI)
        public string GetFullName() {
            return FirstName + " " + LastName;
        }

        // ToString

        public override string ToString() {
            string output = "";

            output += "User ID: " + UserID + "\n";
            output += "Name: " + GetFullName() + "\n";
            output += "Phone: " + PhoneNumber + "\n";
            output += "Email: " + Email + "\n";
            output += "Address: " + Address.ToString() + "\n";

            return output;
        }

        // CSV - storage

        public virtual string ToCSV() {
            string output = "";

            output += UserID + ",";
            output += FirstName + ",";
            output += LastName + ",";
            output += PhoneNumber + ",";
            output += Email + ",";
            output += Address.ToCSV();

            return output;
        }
    }
}