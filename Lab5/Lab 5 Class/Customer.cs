using System;

namespace Lab5.Lab_5_Class
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;

        public Customer() { }

        public Customer(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Email = email;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string GetDisplayText() => firstName + " " + lastName + " " + email;
    }
}
