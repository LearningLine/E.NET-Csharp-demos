using System;

namespace Properties
{
    public class Customer
    {
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _age = 31;
        }

        public Customer()
        {
            
        }

        


        private int _age = 18;
        public string FirstName { get; set; } = "";
        public string LastName { get; } = "No Last name";

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("value");
                _age = value;
                
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}