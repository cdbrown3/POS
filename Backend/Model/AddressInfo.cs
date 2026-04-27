using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Backend.Model
{
    public class AddressInfo : IExportable
    {
        // variables:

        private string street;
        private string city;
        private string stateAbbreviation;
        private string zipCode;

        public string Street
        {
            get { return street; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Street cannot be empty!");

                bool hasNumber = false;

                foreach (char c in value)
                { // must have a #
                    if (char.IsDigit(c))
                    {
                        hasNumber = true;
                    }
                }

                if (!hasNumber)
                    throw new ArgumentException("Street must contain a number!");

                street = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("City cannot be empty!");

                foreach (char c in value)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    { // only letters and spaces
                        throw new ArgumentException("City can only contain letters and spaces");
                    }
                }

                city = value;
            }
        }

        public string StateAbbreviation
        {
            get { return stateAbbreviation; }
            set
            {
                foreach (var state in States)
                {
                    if (state.Abbrev.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        stateAbbreviation = state.Abbrev;
                        return;
                    }
                }

                throw new ArgumentException("Invalid state abbreviation");
            }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Zip cannot be empty!");

                if (value.Length != 5)
                    throw new ArgumentException("Zip must be 5 digits!");

                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                        throw new ArgumentException("Zip must be numbers only!");
                }

                zipCode = value;
            }
        }

        // state list from CSV

        private static List<(string Name, string Abbrev)> States = LoadStates("states.csv"); // loaded once

        private static List<(string, string)> LoadStates(string filePath)
        { // return list of pairs
            List<(string, string)> results = new List<(string, string)>(); // creates an empty list to store state and abbrevation

            if (!File.Exists(filePath))
            {
                throw new Exception("states.csv not found");
            }

            string[] lines = File.ReadAllLines(filePath); // read all lines in the file

            for (int i = 0; i < lines.Length; i++) // skip header and then go through each line
            {
                string[] parts = lines[i].Split(','); // split the line wherever there is a comma

                if (parts.Length == 2)
                { // only continue if the line has two parts
                    string name = parts[0].Trim(); // removes the space = trim
                    string abbrev = parts[1].Trim();

                    results.Add((name, abbrev));
                }
            }

            return results;
        }

        // constructors

        public AddressInfo(string Street, string City, string StateAbbreviation, string ZipCode)
        {
            this.Street = Street;
            this.City = City;
            this.StateAbbreviation = StateAbbreviation;
            this.ZipCode = ZipCode;
        }

        // ToString

        public override string ToString()
        {
            return Street + "\n" + City + ", " + StateAbbreviation + " " + ZipCode;
        }

        // ToCSV - storage

        public string ToCSV()
        {
            return Street + "," + City + "," + StateAbbreviation + "," + ZipCode;
        }
    }
}